using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiraSharp {
    public partial class Main : Form {
        KiraSerial serial;

        public bool connected {
            get { return icnct; }
            set {
                if (value) {
                    Text = "\"" + serial.devname + "\" on " + serial.serialport;
                    cnctbtn.Text = "Disconnect";
                    stat.Text = "Connection on " +
                        serial.serialport + "@" + serial.serialrate + "bd, " + 
                        serial.timeouts + "ms";

                    icnct = true;

                    srvinit();
                }
                else {
                    Text = "Kira#";
                    cnctbtn.Text = "Connect";
                    stat.Text = "No connection established!";

                    icnct = false;
                }
            }
        }

        private void Srv_degchange(int servo, int loc, int time) {
            Logger.Write("Moving servo " + servo.ToString() + "to " + loc.ToString());

            serial.Setservo(servo, loc, time);
            serial.Run();
        }

        bool icnct = false;


        public Main() {
            InitializeComponent();

            connected = false;
        }

        private void srvinit() {
            string[] servos = serial.Getservos();

            foreach (string sv in servos) {
                string svnm = sv.Split(':')[0];
                int hmpos = int.Parse(sv.Split(':')[1]);

                Servo srv = new Servo(svnm, int.Parse(svnm), hmpos);
                srv.degchange += Srv_degchange;
                servopanel.Controls.Add(srv);

                serial.Setservo(int.Parse(svnm), hmpos, 500);
            }
        }

        private void logwrtbtn_Click(object sender, EventArgs e) {
            Logger.Write("this is a sample log entry");
            MessageBox.Show("wrote log entry");
        }

        private void rdlogbtn_Click(object sender, EventArgs e) {
            List<LogEntry> entries = Logger.Read();

            foreach (LogEntry entry in entries) {
                if (entry.Logtype != LogEntry.Type.None) {
                    debugbox.AppendText("Entry Type: " + entry.Logtype.ToString() + "\r\n");
                    debugbox.AppendText(entry.Time + "\r\n");
                    debugbox.AppendText(entry.Text + "\r\n\r\n"); 
                }
            }
        }

        private void cnctbtn_Click(object sender, EventArgs e) {
            if (serial == null) {
                serial = new Connect().ShowDlg();
                if (serial != null) {
                    connected = true;
                } 
            }
            else {
                serial.Disconnect();
                serial = null;
                connected = false;
            }
        }

        private void clrlogbtn_Click(object sender, EventArgs e) {
            Logger.Clear();
            debugbox.Clear();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e) {
            Logger.Clear();
        }
    }
}

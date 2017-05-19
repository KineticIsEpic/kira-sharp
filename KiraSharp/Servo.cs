using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiraSharp {
    public delegate void servoevthdlr(int servo, int loc, int time);

    /// <summary>
    /// Servo control box
    /// </summary>
    public partial class Servo : UserControl {
        public event servoevthdlr degchange;
        public event servoevthdlr tmchange;
        public event servoevthdlr resetclk;

        Timer autotime = new Timer();

        public bool isauto = false;

        public int servonumber = 0;
        public int location = 90;
        public int mvtime = 1000;

        private bool changed = false;

        public Servo() {
            InitializeComponent();

            autotime.Tick += Autotime_Tick;
            autotime.Interval = 50;
            autotime.Enabled = true;
        }

        public Servo(string name, int servoindex, int defloc) {
            InitializeComponent();

            autotime.Tick += Autotime_Tick;
            autotime.Interval = 55;
            autotime.Enabled = true;

            title.Text = name;
            location = defloc;
            servonumber = servoindex;

            posbar.Value = defloc;
        }

        public Servo(int servoindex) {
            InitializeComponent();

            autotime.Tick += Autotime_Tick;
            autotime.Interval = 50;
            autotime.Enabled = true;

            title.Text = servoindex.ToString();
            servonumber = servoindex;
        }

        public void setText(string text) {
            title.Text = text;
        }

        private void Autotime_Tick(object sender, EventArgs e) {
            if (isauto && changed) {
                try { degchange.Invoke(servonumber, posbar.Value, 50); }
                catch (Exception) { }

                changed = false;
            }
        }

        private void autobtn_Click(object sender, EventArgs e) {
            isauto = !isauto;
            if (isauto) autobtn.ForeColor = Color.Green;
            else autobtn.ForeColor = Color.Black;
        }

        private void posbar_Scroll(object sender, EventArgs e) {
            if (isauto) changed = true;
        }

        private void resetbtn_Click(object sender, EventArgs e) {
            try { resetclk.Invoke(servonumber, location, 50); }
            catch (Exception) { }
        }
    }
}

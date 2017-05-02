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
    public partial class Connect : Form {
        public Connect() {
            InitializeComponent();
        }

        public KiraSerial ShowDlg() {
            listBox1.Items.Clear();
            
            foreach (string port in System.IO.Ports.SerialPort.GetPortNames()) {
                listBox1.Items.Add(port);
            }

            DialogResult dr = ShowDialog();
            if (dr == DialogResult.OK) return new KiraSerial((string)listBox1.SelectedItem, 38400);
            else return null;
        }

        private void button1_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (listBox1.SelectedItem == null) button1.Enabled = false;
            else button1.Enabled = true;
        }
    }
}

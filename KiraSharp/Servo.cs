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

        public bool isauto = false;

        public int servonumber = 0;
        public int location = 90;
        public int mvtime = 1000;

        public Servo() {
            InitializeComponent();
        }

        public Servo(string name, int servoindex, int defloc) {
            InitializeComponent();

            title.Text = name;
            location = defloc;
            servonumber = servoindex;

            posbar.Value = defloc;
        }

        public Servo(int servoindex) {
            InitializeComponent();

            title.Text = servoindex.ToString();
            servonumber = servoindex;
        }

        public void setText(string text) {
            title.Text = text;
        }

        private void autobtn_Click(object sender, EventArgs e) {
            isauto = !isauto;
            if (isauto) autobtn.ForeColor = Color.Green;
            else autobtn.ForeColor = Color.Black;
        }

        private void posbar_Scroll(object sender, EventArgs e) {
            if (isauto) {
                try { degchange.Invoke(servonumber, posbar.Value, spdbar.Value); }
                catch (Exception) { }
            }
        }
    }
}

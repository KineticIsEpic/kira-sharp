namespace KiraSharp {
    partial class Servo {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.posbar = new System.Windows.Forms.TrackBar();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resetbtn = new System.Windows.Forms.Button();
            this.autobtn = new System.Windows.Forms.Button();
            this.spdbtn = new System.Windows.Forms.Button();
            this.spdbar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.posbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdbar)).BeginInit();
            this.SuspendLayout();
            // 
            // posbar
            // 
            this.posbar.Location = new System.Drawing.Point(2, 59);
            this.posbar.Maximum = 180;
            this.posbar.Name = "posbar";
            this.posbar.Size = new System.Drawing.Size(193, 45);
            this.posbar.TabIndex = 0;
            this.posbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.posbar.Value = 90;
            this.posbar.Scroll += new System.EventHandler(this.posbar_Scroll);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(8, 6);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(42, 15);
            this.title.TabIndex = 1;
            this.title.Text = "Servo1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(144, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "0deg";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // resetbtn
            // 
            this.resetbtn.Location = new System.Drawing.Point(10, 29);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(27, 22);
            this.resetbtn.TabIndex = 3;
            this.resetbtn.Text = "R";
            this.resetbtn.UseVisualStyleBackColor = true;
            // 
            // autobtn
            // 
            this.autobtn.Location = new System.Drawing.Point(40, 29);
            this.autobtn.Name = "autobtn";
            this.autobtn.Size = new System.Drawing.Size(27, 22);
            this.autobtn.TabIndex = 4;
            this.autobtn.Text = "A";
            this.autobtn.UseVisualStyleBackColor = true;
            this.autobtn.Click += new System.EventHandler(this.autobtn_Click);
            // 
            // spdbtn
            // 
            this.spdbtn.Location = new System.Drawing.Point(162, 29);
            this.spdbtn.Name = "spdbtn";
            this.spdbtn.Size = new System.Drawing.Size(27, 22);
            this.spdbtn.TabIndex = 5;
            this.spdbtn.Text = "M";
            this.spdbtn.UseVisualStyleBackColor = true;
            // 
            // spdbar
            // 
            this.spdbar.Location = new System.Drawing.Point(73, 30);
            this.spdbar.Maximum = 2000;
            this.spdbar.Minimum = 1;
            this.spdbar.Name = "spdbar";
            this.spdbar.Size = new System.Drawing.Size(83, 45);
            this.spdbar.TabIndex = 6;
            this.spdbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.spdbar.Value = 1000;
            // 
            // Servo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.spdbtn);
            this.Controls.Add(this.autobtn);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.posbar);
            this.Controls.Add(this.spdbar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Servo";
            this.Size = new System.Drawing.Size(199, 85);
            ((System.ComponentModel.ISupportInitialize)(this.posbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spdbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TrackBar posbar;
        public System.Windows.Forms.Button resetbtn;
        public System.Windows.Forms.Button autobtn;
        public System.Windows.Forms.Button spdbtn;
        public System.Windows.Forms.TrackBar spdbar;
    }
}

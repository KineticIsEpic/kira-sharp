namespace KiraSharp {
    partial class Main {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.servostab = new System.Windows.Forms.TabPage();
            this.servopanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cnctbtn = new System.Windows.Forms.Button();
            this.debugtab = new System.Windows.Forms.TabPage();
            this.logwrtbtn = new System.Windows.Forms.Button();
            this.rdlogbtn = new System.Windows.Forms.Button();
            this.stat = new System.Windows.Forms.Label();
            this.debugbox = new System.Windows.Forms.TextBox();
            this.clrlogbtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.servostab.SuspendLayout();
            this.debugtab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.servostab);
            this.tabControl1.Controls.Add(this.debugtab);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(6, 9);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(735, 462);
            this.tabControl1.TabIndex = 0;
            // 
            // servostab
            // 
            this.servostab.BackColor = System.Drawing.SystemColors.Control;
            this.servostab.Controls.Add(this.servopanel);
            this.servostab.Location = new System.Drawing.Point(4, 36);
            this.servostab.Name = "servostab";
            this.servostab.Padding = new System.Windows.Forms.Padding(3);
            this.servostab.Size = new System.Drawing.Size(727, 422);
            this.servostab.TabIndex = 0;
            this.servostab.Text = "Servos";
            // 
            // servopanel
            // 
            this.servopanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.servopanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.servopanel.Location = new System.Drawing.Point(0, 0);
            this.servopanel.Name = "servopanel";
            this.servopanel.Size = new System.Drawing.Size(727, 420);
            this.servopanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(652, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "KIRA";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(712, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "#";
            // 
            // cnctbtn
            // 
            this.cnctbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cnctbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(56)))));
            this.cnctbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.cnctbtn.FlatAppearance.BorderSize = 0;
            this.cnctbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.cnctbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.cnctbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cnctbtn.ForeColor = System.Drawing.Color.White;
            this.cnctbtn.Location = new System.Drawing.Point(553, 5);
            this.cnctbtn.Name = "cnctbtn";
            this.cnctbtn.Size = new System.Drawing.Size(89, 23);
            this.cnctbtn.TabIndex = 2;
            this.cnctbtn.Text = "Connect";
            this.cnctbtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cnctbtn.UseVisualStyleBackColor = false;
            this.cnctbtn.Click += new System.EventHandler(this.cnctbtn_Click);
            // 
            // debugtab
            // 
            this.debugtab.BackColor = System.Drawing.SystemColors.Control;
            this.debugtab.Controls.Add(this.clrlogbtn);
            this.debugtab.Controls.Add(this.debugbox);
            this.debugtab.Controls.Add(this.rdlogbtn);
            this.debugtab.Controls.Add(this.logwrtbtn);
            this.debugtab.Location = new System.Drawing.Point(4, 36);
            this.debugtab.Name = "debugtab";
            this.debugtab.Padding = new System.Windows.Forms.Padding(3);
            this.debugtab.Size = new System.Drawing.Size(727, 422);
            this.debugtab.TabIndex = 1;
            this.debugtab.Text = "Debug";
            // 
            // logwrtbtn
            // 
            this.logwrtbtn.Location = new System.Drawing.Point(6, 6);
            this.logwrtbtn.Name = "logwrtbtn";
            this.logwrtbtn.Size = new System.Drawing.Size(137, 23);
            this.logwrtbtn.TabIndex = 0;
            this.logwrtbtn.Text = "write log entry";
            this.logwrtbtn.UseVisualStyleBackColor = true;
            this.logwrtbtn.Click += new System.EventHandler(this.logwrtbtn_Click);
            // 
            // rdlogbtn
            // 
            this.rdlogbtn.Location = new System.Drawing.Point(6, 35);
            this.rdlogbtn.Name = "rdlogbtn";
            this.rdlogbtn.Size = new System.Drawing.Size(137, 23);
            this.rdlogbtn.TabIndex = 1;
            this.rdlogbtn.Text = "read log";
            this.rdlogbtn.UseVisualStyleBackColor = true;
            this.rdlogbtn.Click += new System.EventHandler(this.rdlogbtn_Click);
            // 
            // stat
            // 
            this.stat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stat.ForeColor = System.Drawing.Color.White;
            this.stat.Location = new System.Drawing.Point(252, 5);
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(290, 23);
            this.stat.TabIndex = 2;
            this.stat.Text = "No connection established!";
            this.stat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // debugbox
            // 
            this.debugbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.debugbox.Font = new System.Drawing.Font("Courier New", 11F);
            this.debugbox.Location = new System.Drawing.Point(149, 3);
            this.debugbox.Multiline = true;
            this.debugbox.Name = "debugbox";
            this.debugbox.ReadOnly = true;
            this.debugbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.debugbox.Size = new System.Drawing.Size(575, 416);
            this.debugbox.TabIndex = 2;
            // 
            // clrlogbtn
            // 
            this.clrlogbtn.Location = new System.Drawing.Point(6, 64);
            this.clrlogbtn.Name = "clrlogbtn";
            this.clrlogbtn.Size = new System.Drawing.Size(137, 23);
            this.clrlogbtn.TabIndex = 3;
            this.clrlogbtn.Text = "clear log";
            this.clrlogbtn.UseVisualStyleBackColor = true;
            this.clrlogbtn.Click += new System.EventHandler(this.clrlogbtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.stat);
            this.Controls.Add(this.cnctbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "Main";
            this.Text = "Project Kira on COM1";
            this.tabControl1.ResumeLayout(false);
            this.servostab.ResumeLayout(false);
            this.debugtab.ResumeLayout(false);
            this.debugtab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage servostab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cnctbtn;
        private System.Windows.Forms.FlowLayoutPanel servopanel;
        private System.Windows.Forms.TabPage debugtab;
        private System.Windows.Forms.Button rdlogbtn;
        private System.Windows.Forms.Button logwrtbtn;
        private System.Windows.Forms.Label stat;
        private System.Windows.Forms.TextBox debugbox;
        private System.Windows.Forms.Button clrlogbtn;
    }
}
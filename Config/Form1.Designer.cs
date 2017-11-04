namespace Configure
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Host = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HostIp = new System.Windows.Forms.TextBox();
            this.cDegree = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(84, 17);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(100, 20);
            this.Host.TabIndex = 1;
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(84, 43);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(100, 20);
            this.Port.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Team Name";
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(84, 69);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(100, 20);
            this.tName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Host IP Address";
            // 
            // HostIp
            // 
            this.HostIp.Location = new System.Drawing.Point(292, 16);
            this.HostIp.Name = "HostIp";
            this.HostIp.Size = new System.Drawing.Size(100, 20);
            this.HostIp.TabIndex = 1;
            // 
            // cDegree
            // 
            this.cDegree.Location = new System.Drawing.Point(292, 42);
            this.cDegree.Name = "cDegree";
            this.cDegree.Size = new System.Drawing.Size(100, 20);
            this.cDegree.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Circle Degree";
            // 
            // gTime
            // 
            this.gTime.Location = new System.Drawing.Point(292, 68);
            this.gTime.Name = "gTime";
            this.gTime.Size = new System.Drawing.Size(100, 20);
            this.gTime.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Game Time";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancell";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 145);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.cDegree);
            this.Controls.Add(this.HostIp);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Configure Settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Host;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HostIp;
        private System.Windows.Forms.TextBox cDegree;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


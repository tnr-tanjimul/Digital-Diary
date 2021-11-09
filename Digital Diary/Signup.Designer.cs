namespace Digital_Diary
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSignup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textConfPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnSignup);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textPassword);
            this.panel1.Controls.Add(this.textConfPassword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textUsername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 507);
            this.panel1.TabIndex = 1;
            // 
            // btnSignup
            // 
            this.btnSignup.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.Location = new System.Drawing.Point(172, 387);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(83, 28);
            this.btnSignup.TabIndex = 2;
            this.btnSignup.Text = "Signup";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.label2.Location = new System.Drawing.Point(99, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(203)))), ((int)(((byte)(212)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.label3.Location = new System.Drawing.Point(26, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "My Diary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.label4.Location = new System.Drawing.Point(99, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(99, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // textUsername
            // 
            this.textUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.textUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textUsername.HintForeColor = System.Drawing.Color.Empty;
            this.textUsername.HintText = "Username";
            this.textUsername.isPassword = false;
            this.textUsername.LineFocusedColor = System.Drawing.Color.Purple;
            this.textUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.textUsername.LineMouseHoverColor = System.Drawing.Color.Black;
            this.textUsername.LineThickness = 3;
            this.textUsername.Location = new System.Drawing.Point(121, 242);
            this.textUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(197, 25);
            this.textUsername.TabIndex = 0;
            this.textUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.textPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textPassword.HintForeColor = System.Drawing.Color.Empty;
            this.textPassword.HintText = "Password";
            this.textPassword.isPassword = true;
            this.textPassword.LineFocusedColor = System.Drawing.Color.Purple;
            this.textPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.textPassword.LineMouseHoverColor = System.Drawing.Color.Black;
            this.textPassword.LineThickness = 3;
            this.textPassword.Location = new System.Drawing.Point(121, 294);
            this.textPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(197, 25);
            this.textPassword.TabIndex = 0;
            this.textPassword.Text = "Username";
            this.textPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textConfPassword
            // 
            this.textConfPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(220)))), ((int)(((byte)(228)))));
            this.textConfPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textConfPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textConfPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textConfPassword.HintForeColor = System.Drawing.Color.Empty;
            this.textConfPassword.HintText = "Password";
            this.textConfPassword.isPassword = true;
            this.textConfPassword.LineFocusedColor = System.Drawing.Color.Purple;
            this.textConfPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.textConfPassword.LineMouseHoverColor = System.Drawing.Color.Black;
            this.textConfPassword.LineThickness = 3;
            this.textConfPassword.Location = new System.Drawing.Point(121, 346);
            this.textConfPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textConfPassword.Name = "textConfPassword";
            this.textConfPassword.Size = new System.Drawing.Size(197, 25);
            this.textConfPassword.TabIndex = 0;
            this.textConfPassword.Text = "Username";
            this.textConfPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 507);
            this.Controls.Add(this.panel1);
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Signup_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textUsername;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textConfPassword;
    }
}
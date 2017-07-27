namespace Editer_v3
{
    partial class frLog
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
            this.lbname = new System.Windows.Forms.Label();
            this.lbpass = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbname.Location = new System.Drawing.Point(31, 36);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(35, 13);
            this.lbname.TabIndex = 0;
            this.lbname.Text = "Name";
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbpass.Location = new System.Drawing.Point(31, 91);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(53, 13);
            this.lbpass.TabIndex = 1;
            this.lbpass.Text = "Password";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(103, 36);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(325, 20);
            this.txtname.TabIndex = 2;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(103, 88);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(325, 20);
            this.txtpass.TabIndex = 3;
            this.txtpass.Visible = false;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            // 
            // frLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Editer_v3.Properties.Resources.nen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(487, 156);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lbpass);
            this.Controls.Add(this.lbname);
            this.Name = "frLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbpass;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpass;

    }
}
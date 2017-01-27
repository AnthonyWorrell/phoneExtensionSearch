namespace Extension_Look_Up
{
    partial class passwordCheckerForm
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
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(85, 27);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(178, 20);
            this.txt_password.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password:";
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(109, 56);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(75, 23);
            this.btn_enter.TabIndex = 2;
            this.btn_enter.Text = "Ok";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // passwordCheckerForm
            // 
            this.AcceptButton = this.btn_enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 86);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Name = "passwordCheckerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Password";
            this.Load += new System.EventHandler(this.passwordCheckerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_enter;
    }
}
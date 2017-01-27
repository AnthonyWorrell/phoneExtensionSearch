namespace Extension_Look_Up
{
    partial class extUpdateForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_connected = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ext = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_position = new System.Windows.Forms.TextBox();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_connected);
            this.groupBox1.Location = new System.Drawing.Point(12, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 49);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Status";
            // 
            // lbl_connected
            // 
            this.lbl_connected.AutoSize = true;
            this.lbl_connected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_connected.Location = new System.Drawing.Point(8, 20);
            this.lbl_connected.Name = "lbl_connected";
            this.lbl_connected.Size = new System.Drawing.Size(110, 16);
            this.lbl_connected.TabIndex = 0;
            this.lbl_connected.Text = "Not Connected";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Controls.Add(this.txt_ext);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(91, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search by Extension";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_update);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_location);
            this.groupBox3.Controls.Add(this.txt_position);
            this.groupBox3.Controls.Add(this.txt_name);
            this.groupBox3.Location = new System.Drawing.Point(23, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 106);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Extension";
            // 
            // txt_ext
            // 
            this.txt_ext.Location = new System.Drawing.Point(65, 40);
            this.txt_ext.Name = "txt_ext";
            this.txt_ext.Size = new System.Drawing.Size(100, 20);
            this.txt_ext.TabIndex = 1;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(7, 44);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 0;
            // 
            // txt_position
            // 
            this.txt_position.Location = new System.Drawing.Point(113, 44);
            this.txt_position.Name = "txt_position";
            this.txt_position.Size = new System.Drawing.Size(100, 20);
            this.txt_position.TabIndex = 1;
            // 
            // txt_location
            // 
            this.txt_location.Location = new System.Drawing.Point(219, 44);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(100, 20);
            this.txt_location.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Location";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(79, 67);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(125, 77);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // extUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 344);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "extUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Extensions";
            this.Load += new System.EventHandler(this.extUpdateForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_connected;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_ext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.TextBox txt_position;
        private System.Windows.Forms.TextBox txt_name;
    }
}
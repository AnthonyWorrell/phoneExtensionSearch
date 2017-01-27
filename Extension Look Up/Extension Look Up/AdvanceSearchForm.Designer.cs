namespace Extension_Look_Up
{
    partial class AdvanceSearchForm
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
            this.btn_searchPosition = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Position = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_searchLocation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ext = new System.Windows.Forms.TextBox();
            this.cmb_results = new System.Windows.Forms.ComboBox();
            this.lbl_ext = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_connected);
            this.groupBox1.Location = new System.Drawing.Point(12, 447);
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
            this.groupBox2.Controls.Add(this.btn_searchPosition);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_Position);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 122);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Position Search";
            // 
            // btn_searchPosition
            // 
            this.btn_searchPosition.Location = new System.Drawing.Point(74, 75);
            this.btn_searchPosition.Name = "btn_searchPosition";
            this.btn_searchPosition.Size = new System.Drawing.Size(75, 23);
            this.btn_searchPosition.TabIndex = 7;
            this.btn_searchPosition.Text = "Search";
            this.btn_searchPosition.UseVisualStyleBackColor = true;
            this.btn_searchPosition.Click += new System.EventHandler(this.btn_searchPosition_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee Position";
            // 
            // txt_Position
            // 
            this.txt_Position.Location = new System.Drawing.Point(130, 29);
            this.txt_Position.Name = "txt_Position";
            this.txt_Position.Size = new System.Drawing.Size(100, 20);
            this.txt_Position.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_searchLocation);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_location);
            this.groupBox3.Location = new System.Drawing.Point(12, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 122);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Location Search";
            // 
            // btn_searchLocation
            // 
            this.btn_searchLocation.Location = new System.Drawing.Point(74, 75);
            this.btn_searchLocation.Name = "btn_searchLocation";
            this.btn_searchLocation.Size = new System.Drawing.Size(75, 23);
            this.btn_searchLocation.TabIndex = 7;
            this.btn_searchLocation.Text = "Search";
            this.btn_searchLocation.UseVisualStyleBackColor = true;
            this.btn_searchLocation.Click += new System.EventHandler(this.btn_searchLocation_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee Location";
            // 
            // txt_location
            // 
            this.txt_location.Location = new System.Drawing.Point(130, 29);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(100, 20);
            this.txt_location.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txt_ext);
            this.groupBox4.Controls.Add(this.cmb_results);
            this.groupBox4.Controls.Add(this.lbl_ext);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox4.Location = new System.Drawing.Point(12, 293);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 136);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Results";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Employee Name";
            // 
            // txt_ext
            // 
            this.txt_ext.Location = new System.Drawing.Point(123, 75);
            this.txt_ext.Name = "txt_ext";
            this.txt_ext.ReadOnly = true;
            this.txt_ext.Size = new System.Drawing.Size(100, 20);
            this.txt_ext.TabIndex = 9;
            // 
            // cmb_results
            // 
            this.cmb_results.FormattingEnabled = true;
            this.cmb_results.Location = new System.Drawing.Point(113, 33);
            this.cmb_results.Name = "cmb_results";
            this.cmb_results.Size = new System.Drawing.Size(121, 21);
            this.cmb_results.TabIndex = 10;
            this.cmb_results.Text = "click arrow for results";
            this.cmb_results.SelectedIndexChanged += new System.EventHandler(this.cmb_results_SelectedIndexChanged);
            // 
            // lbl_ext
            // 
            this.lbl_ext.AutoSize = true;
            this.lbl_ext.Location = new System.Drawing.Point(46, 82);
            this.lbl_ext.Name = "lbl_ext";
            this.lbl_ext.Size = new System.Drawing.Size(25, 13);
            this.lbl_ext.TabIndex = 5;
            this.lbl_ext.Text = "Ext.";
            // 
            // AdvanceSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(296, 513);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdvanceSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advance Search Form";
            this.Load += new System.EventHandler(this.AdvanceSearchForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_connected;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_searchPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Position;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_searchLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ext;
        private System.Windows.Forms.ComboBox cmb_results;
        private System.Windows.Forms.Label lbl_ext;
    }
}
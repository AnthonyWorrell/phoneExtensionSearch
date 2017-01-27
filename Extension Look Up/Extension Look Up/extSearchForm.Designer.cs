namespace Extension_Look_Up
{
    partial class ext_lookup_form
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
            this.txt_ext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ext = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_results = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_advSearch = new System.Windows.Forms.Button();
            this.btn_updateList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_connected);
            this.groupBox1.Location = new System.Drawing.Point(12, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 49);
            this.groupBox1.TabIndex = 0;
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
            // txt_ext
            // 
            this.txt_ext.Location = new System.Drawing.Point(123, 75);
            this.txt_ext.Name = "txt_ext";
            this.txt_ext.ReadOnly = true;
            this.txt_ext.Size = new System.Drawing.Size(100, 20);
            this.txt_ext.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee Name";
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
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(130, 29);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(74, 75);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 7;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_Name);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 122);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt_ext);
            this.groupBox3.Controls.Add(this.cmb_results);
            this.groupBox3.Controls.Add(this.lbl_ext);
            this.groupBox3.Location = new System.Drawing.Point(12, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 136);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Results";
            // 
            // btn_advSearch
            // 
            this.btn_advSearch.Location = new System.Drawing.Point(75, 292);
            this.btn_advSearch.Name = "btn_advSearch";
            this.btn_advSearch.Size = new System.Drawing.Size(108, 23);
            this.btn_advSearch.TabIndex = 12;
            this.btn_advSearch.Text = "Advance Search";
            this.btn_advSearch.UseVisualStyleBackColor = true;
            this.btn_advSearch.Click += new System.EventHandler(this.btn_advSearch_Click);
            // 
            // btn_updateList
            // 
            this.btn_updateList.Location = new System.Drawing.Point(65, 322);
            this.btn_updateList.Name = "btn_updateList";
            this.btn_updateList.Size = new System.Drawing.Size(126, 23);
            this.btn_updateList.TabIndex = 13;
            this.btn_updateList.Text = "Update Extension List";
            this.btn_updateList.UseVisualStyleBackColor = true;
            this.btn_updateList.Click += new System.EventHandler(this.btn_updateList_Click);
            // 
            // ext_lookup_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 412);
            this.Controls.Add(this.btn_updateList);
            this.Controls.Add(this.btn_advSearch);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ext_lookup_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phone Extension Search";
            this.Load += new System.EventHandler(this.ext_lookup_form_Load);
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
        private System.Windows.Forms.TextBox txt_ext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ext;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_results;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_advSearch;
        private System.Windows.Forms.Button btn_updateList;
    }
}


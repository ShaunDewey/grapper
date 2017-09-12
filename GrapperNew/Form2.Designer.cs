namespace GrapperNew
{
    partial class Form2
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
            this.basicInstructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutGrapperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.searchFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.Dir_picker_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.directory_textBox = new System.Windows.Forms.TextBox();
            this.directory_groupBox = new System.Windows.Forms.GroupBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchListTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.directoryTextBox = new System.Windows.Forms.TextBox();
            this.searchDirectoryButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.emailBodyRichTextBox = new System.Windows.Forms.RichTextBox();
            this.emailComboBox = new System.Windows.Forms.ComboBox();
            this.firstMatchCheckBox = new System.Windows.Forms.CheckBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.searchDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dateGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.directory_groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.dateGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // basicInstructionsToolStripMenuItem
            // 
            this.basicInstructionsToolStripMenuItem.Name = "basicInstructionsToolStripMenuItem";
            this.basicInstructionsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.basicInstructionsToolStripMenuItem.Text = "Basic Instructions";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicInstructionsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutGrapperToolStripMenuItem
            // 
            this.aboutGrapperToolStripMenuItem.Name = "aboutGrapperToolStripMenuItem";
            this.aboutGrapperToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutGrapperToolStripMenuItem.Text = "About Grapper";
            this.aboutGrapperToolStripMenuItem.Click += new System.EventHandler(this.aboutGrapperToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutGrapperToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 650);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1126, 23);
            this.progressBar1.TabIndex = 21;
            // 
            // searchFolderBrowserDialog
            // 
            this.searchFolderBrowserDialog.ShowNewFolderButton = false;
            // 
            // Dir_picker_button
            // 
            this.Dir_picker_button.Location = new System.Drawing.Point(6, 15);
            this.Dir_picker_button.Name = "Dir_picker_button";
            this.Dir_picker_button.Size = new System.Drawing.Size(110, 24);
            this.Dir_picker_button.TabIndex = 1;
            this.Dir_picker_button.Text = "Select Search Path";
            this.Dir_picker_button.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.search_textBox);
            this.groupBox2.Location = new System.Drawing.Point(-249, -158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 342);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter Search Terms";
            // 
            // search_textBox
            // 
            this.search_textBox.Location = new System.Drawing.Point(10, 19);
            this.search_textBox.Multiline = true;
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.search_textBox.Size = new System.Drawing.Size(204, 317);
            this.search_textBox.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1153, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // directory_textBox
            // 
            this.directory_textBox.Location = new System.Drawing.Point(122, 19);
            this.directory_textBox.Name = "directory_textBox";
            this.directory_textBox.Size = new System.Drawing.Size(434, 20);
            this.directory_textBox.TabIndex = 0;
            // 
            // directory_groupBox
            // 
            this.directory_groupBox.Controls.Add(this.directory_textBox);
            this.directory_groupBox.Controls.Add(this.Dir_picker_button);
            this.directory_groupBox.Location = new System.Drawing.Point(-20, -158);
            this.directory_groupBox.Name = "directory_groupBox";
            this.directory_groupBox.Size = new System.Drawing.Size(564, 49);
            this.directory_groupBox.TabIndex = 18;
            this.directory_groupBox.TabStop = false;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork_1);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchListTextBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 211);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Search Terms";
            // 
            // searchListTextBox
            // 
            this.searchListTextBox.Location = new System.Drawing.Point(10, 19);
            this.searchListTextBox.Multiline = true;
            this.searchListTextBox.Name = "searchListTextBox";
            this.searchListTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.searchListTextBox.Size = new System.Drawing.Size(343, 186);
            this.searchListTextBox.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.directoryTextBox);
            this.groupBox3.Controls.Add(this.searchDirectoryButton);
            this.groupBox3.Location = new System.Drawing.Point(380, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(564, 49);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // directoryTextBox
            // 
            this.directoryTextBox.Location = new System.Drawing.Point(122, 19);
            this.directoryTextBox.Name = "directoryTextBox";
            this.directoryTextBox.Size = new System.Drawing.Size(434, 20);
            this.directoryTextBox.TabIndex = 0;
            // 
            // searchDirectoryButton
            // 
            this.searchDirectoryButton.Location = new System.Drawing.Point(6, 15);
            this.searchDirectoryButton.Name = "searchDirectoryButton";
            this.searchDirectoryButton.Size = new System.Drawing.Size(110, 24);
            this.searchDirectoryButton.TabIndex = 1;
            this.searchDirectoryButton.Text = "Select Search Path";
            this.searchDirectoryButton.UseVisualStyleBackColor = true;
            this.searchDirectoryButton.Click += new System.EventHandler(this.searchDirectoryButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.emailBodyRichTextBox);
            this.groupBox4.Controls.Add(this.emailComboBox);
            this.groupBox4.Location = new System.Drawing.Point(380, 91);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(564, 147);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select Email";
            // 
            // emailBodyRichTextBox
            // 
            this.emailBodyRichTextBox.Location = new System.Drawing.Point(9, 46);
            this.emailBodyRichTextBox.Name = "emailBodyRichTextBox";
            this.emailBodyRichTextBox.Size = new System.Drawing.Size(547, 95);
            this.emailBodyRichTextBox.TabIndex = 14;
            this.emailBodyRichTextBox.Text = "...write message";
            // 
            // emailComboBox
            // 
            this.emailComboBox.AllowDrop = true;
            this.emailComboBox.DisplayMember = "[email removed]";
            this.emailComboBox.FormattingEnabled = true;
            this.emailComboBox.Items.AddRange(new object[] {
            "[email removed]"});
            this.emailComboBox.Location = new System.Drawing.Point(9, 19);
            this.emailComboBox.Name = "emailComboBox";
            this.emailComboBox.Size = new System.Drawing.Size(376, 21);
            this.emailComboBox.TabIndex = 13;
            this.emailComboBox.Text = "none";
            // 
            // firstMatchCheckBox
            // 
            this.firstMatchCheckBox.AutoSize = true;
            this.firstMatchCheckBox.Checked = true;
            this.firstMatchCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.firstMatchCheckBox.Location = new System.Drawing.Point(961, 114);
            this.firstMatchCheckBox.Name = "firstMatchCheckBox";
            this.firstMatchCheckBox.Size = new System.Drawing.Size(119, 17);
            this.firstMatchCheckBox.TabIndex = 29;
            this.firstMatchCheckBox.Text = "Find only first match";
            this.firstMatchCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(987, 170);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 31;
            this.searchBtn.Text = "Start Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.logTextBox);
            this.groupBox5.Location = new System.Drawing.Point(15, 244);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1126, 400);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search Log";
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(9, 19);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logTextBox.Size = new System.Drawing.Size(1111, 375);
            this.logTextBox.TabIndex = 0;
            // 
            // searchDatePicker
            // 
            this.searchDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.searchDatePicker.Location = new System.Drawing.Point(26, 22);
            this.searchDatePicker.Name = "searchDatePicker";
            this.searchDatePicker.Size = new System.Drawing.Size(93, 20);
            this.searchDatePicker.TabIndex = 33;
            // 
            // dateGroupBox
            // 
            this.dateGroupBox.Controls.Add(this.searchDatePicker);
            this.dateGroupBox.Location = new System.Drawing.Point(961, 27);
            this.dateGroupBox.Name = "dateGroupBox";
            this.dateGroupBox.Size = new System.Drawing.Size(143, 51);
            this.dateGroupBox.TabIndex = 34;
            this.dateGroupBox.TabStop = false;
            this.dateGroupBox.Text = "Search After This Date";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 683);
            this.Controls.Add(this.dateGroupBox);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.firstMatchCheckBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.directory_groupBox);
            this.Name = "Form2";
            this.Text = "Grapper";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.directory_groupBox.ResumeLayout(false);
            this.directory_groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.dateGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem basicInstructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutGrapperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog searchFolderBrowserDialog;
        private System.Windows.Forms.Button Dir_picker_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox directory_textBox;
        private System.Windows.Forms.GroupBox directory_groupBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox searchListTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox directoryTextBox;
        private System.Windows.Forms.Button searchDirectoryButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox emailBodyRichTextBox;
        private System.Windows.Forms.ComboBox emailComboBox;
        private System.Windows.Forms.CheckBox firstMatchCheckBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.DateTimePicker searchDatePicker;
        private System.Windows.Forms.GroupBox dateGroupBox;
    }
}


namespace CRUDEFExample
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
            this.tabCRUD = new System.Windows.Forms.TabControl();
            this.createTab = new System.Windows.Forms.TabPage();
            this.numericIDCreate = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textFullNameCreate = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.readTab = new System.Windows.Forms.TabPage();
            this.numericIDReadTo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.checkIDRead = new System.Windows.Forms.CheckBox();
            this.numericIDReadFrom = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textFullNameRead = new System.Windows.Forms.TextBox();
            this.readButton = new System.Windows.Forms.Button();
            this.updateTab = new System.Windows.Forms.TabPage();
            this.numericIDUpdateFrom = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textFullNameUpdate = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteTab = new System.Windows.Forms.TabPage();
            this.employeesList = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabCRUD.SuspendLayout();
            this.createTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericIDCreate)).BeginInit();
            this.readTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericIDReadTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIDReadFrom)).BeginInit();
            this.updateTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericIDUpdateFrom)).BeginInit();
            this.deleteTab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCRUD
            // 
            this.tabCRUD.Controls.Add(this.createTab);
            this.tabCRUD.Controls.Add(this.readTab);
            this.tabCRUD.Controls.Add(this.updateTab);
            this.tabCRUD.Controls.Add(this.deleteTab);
            this.tabCRUD.Location = new System.Drawing.Point(12, 31);
            this.tabCRUD.Name = "tabCRUD";
            this.tabCRUD.SelectedIndex = 0;
            this.tabCRUD.Size = new System.Drawing.Size(497, 228);
            this.tabCRUD.TabIndex = 0;
            this.tabCRUD.SelectedIndexChanged += new System.EventHandler(this.tabCRUD_SelectedIndexChanged);
            // 
            // createTab
            // 
            this.createTab.Controls.Add(this.numericIDCreate);
            this.createTab.Controls.Add(this.label1);
            this.createTab.Controls.Add(this.label12);
            this.createTab.Controls.Add(this.textFullNameCreate);
            this.createTab.Controls.Add(this.createButton);
            this.createTab.Location = new System.Drawing.Point(4, 22);
            this.createTab.Name = "createTab";
            this.createTab.Padding = new System.Windows.Forms.Padding(3);
            this.createTab.Size = new System.Drawing.Size(489, 202);
            this.createTab.TabIndex = 0;
            this.createTab.Text = "Create";
            this.createTab.UseVisualStyleBackColor = true;
            // 
            // numericIDCreate
            // 
            this.numericIDCreate.Location = new System.Drawing.Point(72, 10);
            this.numericIDCreate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericIDCreate.Name = "numericIDCreate";
            this.numericIDCreate.Size = new System.Drawing.Size(40, 20);
            this.numericIDCreate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Full Name";
            // 
            // textFullNameCreate
            // 
            this.textFullNameCreate.Location = new System.Drawing.Point(72, 36);
            this.textFullNameCreate.Name = "textFullNameCreate";
            this.textFullNameCreate.Size = new System.Drawing.Size(411, 20);
            this.textFullNameCreate.TabIndex = 2;
            this.textFullNameCreate.TextChanged += new System.EventHandler(this.textFullNameCreate_TextChanged);
            // 
            // createButton
            // 
            this.createButton.Enabled = false;
            this.createButton.Location = new System.Drawing.Point(383, 62);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(100, 23);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // readTab
            // 
            this.readTab.Controls.Add(this.numericIDReadTo);
            this.readTab.Controls.Add(this.label2);
            this.readTab.Controls.Add(this.checkIDRead);
            this.readTab.Controls.Add(this.numericIDReadFrom);
            this.readTab.Controls.Add(this.label5);
            this.readTab.Controls.Add(this.label4);
            this.readTab.Controls.Add(this.textFullNameRead);
            this.readTab.Controls.Add(this.readButton);
            this.readTab.Location = new System.Drawing.Point(4, 22);
            this.readTab.Name = "readTab";
            this.readTab.Padding = new System.Windows.Forms.Padding(3);
            this.readTab.Size = new System.Drawing.Size(489, 202);
            this.readTab.TabIndex = 1;
            this.readTab.Text = "Read";
            this.readTab.UseVisualStyleBackColor = true;
            // 
            // numericIDReadTo
            // 
            this.numericIDReadTo.Location = new System.Drawing.Point(140, 10);
            this.numericIDReadTo.Name = "numericIDReadTo";
            this.numericIDReadTo.Size = new System.Drawing.Size(40, 20);
            this.numericIDReadTo.TabIndex = 3;
            this.numericIDReadTo.ValueChanged += new System.EventHandler(this.numericIDReadTo_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "to";
            // 
            // checkIDRead
            // 
            this.checkIDRead.AutoSize = true;
            this.checkIDRead.Location = new System.Drawing.Point(186, 11);
            this.checkIDRead.Name = "checkIDRead";
            this.checkIDRead.Size = new System.Drawing.Size(105, 17);
            this.checkIDRead.TabIndex = 4;
            this.checkIDRead.Text = "Use ID in search";
            this.checkIDRead.UseVisualStyleBackColor = true;
            this.checkIDRead.CheckedChanged += new System.EventHandler(this.checkIDRead_CheckedChanged);
            // 
            // numericIDReadFrom
            // 
            this.numericIDReadFrom.Location = new System.Drawing.Point(72, 10);
            this.numericIDReadFrom.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericIDReadFrom.Name = "numericIDReadFrom";
            this.numericIDReadFrom.Size = new System.Drawing.Size(40, 20);
            this.numericIDReadFrom.TabIndex = 2;
            this.numericIDReadFrom.ValueChanged += new System.EventHandler(this.numericIDReadFrom_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Full Name";
            // 
            // textFullNameRead
            // 
            this.textFullNameRead.Location = new System.Drawing.Point(72, 36);
            this.textFullNameRead.Name = "textFullNameRead";
            this.textFullNameRead.Size = new System.Drawing.Size(411, 20);
            this.textFullNameRead.TabIndex = 5;
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(383, 62);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(100, 23);
            this.readButton.TabIndex = 6;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // updateTab
            // 
            this.updateTab.Controls.Add(this.numericIDUpdateFrom);
            this.updateTab.Controls.Add(this.label6);
            this.updateTab.Controls.Add(this.label8);
            this.updateTab.Controls.Add(this.textFullNameUpdate);
            this.updateTab.Controls.Add(this.updateButton);
            this.updateTab.Location = new System.Drawing.Point(4, 22);
            this.updateTab.Name = "updateTab";
            this.updateTab.Padding = new System.Windows.Forms.Padding(3);
            this.updateTab.Size = new System.Drawing.Size(489, 202);
            this.updateTab.TabIndex = 2;
            this.updateTab.Text = "Update";
            this.updateTab.UseVisualStyleBackColor = true;
            // 
            // numericIDUpdateFrom
            // 
            this.numericIDUpdateFrom.Location = new System.Drawing.Point(72, 10);
            this.numericIDUpdateFrom.Name = "numericIDUpdateFrom";
            this.numericIDUpdateFrom.Size = new System.Drawing.Size(40, 20);
            this.numericIDUpdateFrom.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "New Name";
            // 
            // textFullNameUpdate
            // 
            this.textFullNameUpdate.Location = new System.Drawing.Point(72, 36);
            this.textFullNameUpdate.Name = "textFullNameUpdate";
            this.textFullNameUpdate.Size = new System.Drawing.Size(411, 20);
            this.textFullNameUpdate.TabIndex = 3;
            this.textFullNameUpdate.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(383, 62);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 23);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // deleteTab
            // 
            this.deleteTab.Controls.Add(this.employeesList);
            this.deleteTab.Controls.Add(this.label9);
            this.deleteTab.Controls.Add(this.deleteButton);
            this.deleteTab.Location = new System.Drawing.Point(4, 22);
            this.deleteTab.Name = "deleteTab";
            this.deleteTab.Padding = new System.Windows.Forms.Padding(3);
            this.deleteTab.Size = new System.Drawing.Size(489, 202);
            this.deleteTab.TabIndex = 3;
            this.deleteTab.Text = "Delete";
            this.deleteTab.UseVisualStyleBackColor = true;
            // 
            // employeesList
            // 
            this.employeesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeesList.FormattingEnabled = true;
            this.employeesList.Location = new System.Drawing.Point(72, 8);
            this.employeesList.Name = "employeesList";
            this.employeesList.Size = new System.Drawing.Size(305, 21);
            this.employeesList.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "ID";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(383, 7);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // textOutput
            // 
            this.textOutput.Location = new System.Drawing.Point(12, 265);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.ReadOnly = true;
            this.textOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textOutput.Size = new System.Drawing.Size(497, 169);
            this.textOutput.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveLogToolStripMenuItem,
            this.clearLogToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveLogToolStripMenuItem
            // 
            this.saveLogToolStripMenuItem.Name = "saveLogToolStripMenuItem";
            this.saveLogToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveLogToolStripMenuItem.Text = "Save log";
            this.saveLogToolStripMenuItem.Click += new System.EventHandler(this.saveLogToolStripMenuItem_Click);
            // 
            // clearLogToolStripMenuItem
            // 
            this.clearLogToolStripMenuItem.Name = "clearLogToolStripMenuItem";
            this.clearLogToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.clearLogToolStripMenuItem.Text = "Clear log";
            this.clearLogToolStripMenuItem.Click += new System.EventHandler(this.clearLogToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Form1
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 446);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.tabCRUD);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CRUD operations via EF DEMO";
            this.tabCRUD.ResumeLayout(false);
            this.createTab.ResumeLayout(false);
            this.createTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericIDCreate)).EndInit();
            this.readTab.ResumeLayout(false);
            this.readTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericIDReadTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIDReadFrom)).EndInit();
            this.updateTab.ResumeLayout(false);
            this.updateTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericIDUpdateFrom)).EndInit();
            this.deleteTab.ResumeLayout(false);
            this.deleteTab.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCRUD;
        private System.Windows.Forms.TabPage createTab;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TabPage readTab;
        private System.Windows.Forms.TabPage updateTab;
        private System.Windows.Forms.TabPage deleteTab;
        private System.Windows.Forms.NumericUpDown numericIDReadFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textFullNameRead;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.CheckBox checkIDRead;
        private System.Windows.Forms.NumericUpDown numericIDUpdateFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textFullNameUpdate;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.NumericUpDown numericIDCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textFullNameCreate;
        private System.Windows.Forms.NumericUpDown numericIDReadTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ComboBox employeesList;
    }
}


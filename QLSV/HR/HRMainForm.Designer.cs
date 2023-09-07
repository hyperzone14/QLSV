namespace QLSV
{
    partial class HRMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HRMainForm));
            this.labelXuyetThang = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelRefresh = new System.Windows.Forms.Label();
            this.labelEditInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLogout = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editContactButton = new System.Windows.Forms.Button();
            this.addContactButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.selectContactButton = new System.Windows.Forms.Button();
            this.txtRemoveContact = new System.Windows.Forms.TextBox();
            this.labelRemoveContact = new System.Windows.Forms.Label();
            this.removeContactButton = new System.Windows.Forms.Button();
            this.showFullListButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.removeGroupButton = new System.Windows.Forms.Button();
            this.comboBoxGroupNameRemove = new System.Windows.Forms.ComboBox();
            this.panelEditGroup = new System.Windows.Forms.Panel();
            this.labelSelectGroup = new System.Windows.Forms.Label();
            this.editGroupButton = new System.Windows.Forms.Button();
            this.comboBoxGroupNameEdit = new System.Windows.Forms.ComboBox();
            this.txtBoxNewGroupName = new System.Windows.Forms.TextBox();
            this.labelNewName = new System.Windows.Forms.Label();
            this.panelAddGroup = new System.Windows.Forms.Panel();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.txtBoxAddGroupName = new System.Windows.Forms.TextBox();
            this.labelEnterGroupName = new System.Windows.Forms.Label();
            this.labelTittleGroup = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelEditGroup.SuspendLayout();
            this.panelAddGroup.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelXuyetThang
            // 
            this.labelXuyetThang.AutoSize = true;
            this.labelXuyetThang.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXuyetThang.ForeColor = System.Drawing.Color.White;
            this.labelXuyetThang.Location = new System.Drawing.Point(218, 50);
            this.labelXuyetThang.Name = "labelXuyetThang";
            this.labelXuyetThang.Size = new System.Drawing.Size(15, 20);
            this.labelXuyetThang.TabIndex = 4;
            this.labelXuyetThang.Text = "|";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.White;
            this.labelWelcome.Location = new System.Drawing.Point(90, 7);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(295, 32);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "Welcome Back Full Name";
            // 
            // labelRefresh
            // 
            this.labelRefresh.AutoSize = true;
            this.labelRefresh.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRefresh.ForeColor = System.Drawing.Color.White;
            this.labelRefresh.Location = new System.Drawing.Point(239, 50);
            this.labelRefresh.Name = "labelRefresh";
            this.labelRefresh.Size = new System.Drawing.Size(67, 22);
            this.labelRefresh.TabIndex = 3;
            this.labelRefresh.Text = "Refresh";
            this.labelRefresh.Click += new System.EventHandler(this.labelRefresh_Click);
            // 
            // labelEditInfo
            // 
            this.labelEditInfo.AutoSize = true;
            this.labelEditInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelEditInfo.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditInfo.ForeColor = System.Drawing.Color.White;
            this.labelEditInfo.Location = new System.Drawing.Point(89, 49);
            this.labelEditInfo.Name = "labelEditInfo";
            this.labelEditInfo.Size = new System.Drawing.Size(106, 22);
            this.labelEditInfo.TabIndex = 2;
            this.labelEditInfo.Text = "Edit My Info";
            this.labelEditInfo.Click += new System.EventHandler(this.labelEditInfo_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelLogout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelXuyetThang);
            this.panel1.Controls.Add(this.labelRefresh);
            this.panel1.Controls.Add(this.labelEditInfo);
            this.panel1.Controls.Add(this.labelWelcome);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 87);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(319, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "|";
            // 
            // labelLogout
            // 
            this.labelLogout.AutoSize = true;
            this.labelLogout.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogout.ForeColor = System.Drawing.Color.White;
            this.labelLogout.Location = new System.Drawing.Point(340, 51);
            this.labelLogout.Name = "labelLogout";
            this.labelLogout.Size = new System.Drawing.Size(64, 22);
            this.labelLogout.TabIndex = 5;
            this.labelLogout.Text = "Log out";
            this.labelLogout.Click += new System.EventHandler(this.labelLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Contact";
            // 
            // editContactButton
            // 
            this.editContactButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editContactButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.editContactButton.Location = new System.Drawing.Point(204, 49);
            this.editContactButton.Name = "editContactButton";
            this.editContactButton.Size = new System.Drawing.Size(208, 38);
            this.editContactButton.TabIndex = 12;
            this.editContactButton.Text = "Edit";
            this.editContactButton.UseVisualStyleBackColor = true;
            this.editContactButton.Click += new System.EventHandler(this.editContactButton_Click);
            // 
            // addContactButton
            // 
            this.addContactButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addContactButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.addContactButton.Location = new System.Drawing.Point(10, 49);
            this.addContactButton.Name = "addContactButton";
            this.addContactButton.Size = new System.Drawing.Size(188, 38);
            this.addContactButton.TabIndex = 11;
            this.addContactButton.Text = "Add";
            this.addContactButton.UseVisualStyleBackColor = true;
            this.addContactButton.Click += new System.EventHandler(this.addContactButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.selectContactButton);
            this.panel2.Controls.Add(this.txtRemoveContact);
            this.panel2.Controls.Add(this.labelRemoveContact);
            this.panel2.Controls.Add(this.removeContactButton);
            this.panel2.Location = new System.Drawing.Point(18, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 110);
            this.panel2.TabIndex = 14;
            // 
            // selectContactButton
            // 
            this.selectContactButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectContactButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.selectContactButton.Location = new System.Drawing.Point(273, 9);
            this.selectContactButton.Name = "selectContactButton";
            this.selectContactButton.Size = new System.Drawing.Size(138, 28);
            this.selectContactButton.TabIndex = 10;
            this.selectContactButton.Text = "Select Contact";
            this.selectContactButton.UseVisualStyleBackColor = true;
            this.selectContactButton.Click += new System.EventHandler(this.selectContactButton_Click);
            // 
            // txtRemoveContact
            // 
            this.txtRemoveContact.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemoveContact.Location = new System.Drawing.Point(163, 10);
            this.txtRemoveContact.Name = "txtRemoveContact";
            this.txtRemoveContact.Size = new System.Drawing.Size(104, 28);
            this.txtRemoveContact.TabIndex = 9;
            // 
            // labelRemoveContact
            // 
            this.labelRemoveContact.AutoSize = true;
            this.labelRemoveContact.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemoveContact.ForeColor = System.Drawing.Color.White;
            this.labelRemoveContact.Location = new System.Drawing.Point(-1, 14);
            this.labelRemoveContact.Name = "labelRemoveContact";
            this.labelRemoveContact.Size = new System.Drawing.Size(158, 24);
            this.labelRemoveContact.TabIndex = 8;
            this.labelRemoveContact.Text = "Enter Contact ID:";
            // 
            // removeContactButton
            // 
            this.removeContactButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeContactButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.removeContactButton.Location = new System.Drawing.Point(7, 52);
            this.removeContactButton.Name = "removeContactButton";
            this.removeContactButton.Size = new System.Drawing.Size(394, 38);
            this.removeContactButton.TabIndex = 6;
            this.removeContactButton.Text = "Remove";
            this.removeContactButton.UseVisualStyleBackColor = true;
            this.removeContactButton.Click += new System.EventHandler(this.removeContactButton_Click);
            // 
            // showFullListButton
            // 
            this.showFullListButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showFullListButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.showFullListButton.Location = new System.Drawing.Point(15, 373);
            this.showFullListButton.Name = "showFullListButton";
            this.showFullListButton.Size = new System.Drawing.Size(415, 38);
            this.showFullListButton.TabIndex = 13;
            this.showFullListButton.Text = "Show Full List";
            this.showFullListButton.UseVisualStyleBackColor = true;
            this.showFullListButton.Click += new System.EventHandler(this.showFullListButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.BlueViolet;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.removeGroupButton);
            this.panel3.Controls.Add(this.comboBoxGroupNameRemove);
            this.panel3.Location = new System.Drawing.Point(440, 389);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 95);
            this.panel3.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Group:";
            // 
            // removeGroupButton
            // 
            this.removeGroupButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeGroupButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.removeGroupButton.Location = new System.Drawing.Point(7, 52);
            this.removeGroupButton.Name = "removeGroupButton";
            this.removeGroupButton.Size = new System.Drawing.Size(318, 38);
            this.removeGroupButton.TabIndex = 6;
            this.removeGroupButton.Text = "Remove";
            this.removeGroupButton.UseVisualStyleBackColor = true;
            this.removeGroupButton.Click += new System.EventHandler(this.removeGroupButton_Click);
            // 
            // comboBoxGroupNameRemove
            // 
            this.comboBoxGroupNameRemove.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGroupNameRemove.FormattingEnabled = true;
            this.comboBoxGroupNameRemove.Location = new System.Drawing.Point(112, 9);
            this.comboBoxGroupNameRemove.Name = "comboBoxGroupNameRemove";
            this.comboBoxGroupNameRemove.Size = new System.Drawing.Size(213, 28);
            this.comboBoxGroupNameRemove.TabIndex = 7;
            // 
            // panelEditGroup
            // 
            this.panelEditGroup.BackColor = System.Drawing.Color.BlueViolet;
            this.panelEditGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEditGroup.Controls.Add(this.labelSelectGroup);
            this.panelEditGroup.Controls.Add(this.editGroupButton);
            this.panelEditGroup.Controls.Add(this.comboBoxGroupNameEdit);
            this.panelEditGroup.Controls.Add(this.txtBoxNewGroupName);
            this.panelEditGroup.Controls.Add(this.labelNewName);
            this.panelEditGroup.Location = new System.Drawing.Point(440, 257);
            this.panelEditGroup.Name = "panelEditGroup";
            this.panelEditGroup.Size = new System.Drawing.Size(356, 127);
            this.panelEditGroup.TabIndex = 17;
            // 
            // labelSelectGroup
            // 
            this.labelSelectGroup.AutoSize = true;
            this.labelSelectGroup.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectGroup.ForeColor = System.Drawing.Color.White;
            this.labelSelectGroup.Location = new System.Drawing.Point(3, 17);
            this.labelSelectGroup.Name = "labelSelectGroup";
            this.labelSelectGroup.Size = new System.Drawing.Size(103, 20);
            this.labelSelectGroup.TabIndex = 8;
            this.labelSelectGroup.Text = "Select Group:";
            // 
            // editGroupButton
            // 
            this.editGroupButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editGroupButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.editGroupButton.Location = new System.Drawing.Point(7, 83);
            this.editGroupButton.Name = "editGroupButton";
            this.editGroupButton.Size = new System.Drawing.Size(318, 38);
            this.editGroupButton.TabIndex = 6;
            this.editGroupButton.Text = "Edit";
            this.editGroupButton.UseVisualStyleBackColor = true;
            this.editGroupButton.Click += new System.EventHandler(this.editGroupButton_Click);
            // 
            // comboBoxGroupNameEdit
            // 
            this.comboBoxGroupNameEdit.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGroupNameEdit.FormattingEnabled = true;
            this.comboBoxGroupNameEdit.Location = new System.Drawing.Point(112, 9);
            this.comboBoxGroupNameEdit.Name = "comboBoxGroupNameEdit";
            this.comboBoxGroupNameEdit.Size = new System.Drawing.Size(213, 28);
            this.comboBoxGroupNameEdit.TabIndex = 7;
            // 
            // txtBoxNewGroupName
            // 
            this.txtBoxNewGroupName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNewGroupName.Location = new System.Drawing.Point(139, 43);
            this.txtBoxNewGroupName.Name = "txtBoxNewGroupName";
            this.txtBoxNewGroupName.Size = new System.Drawing.Size(186, 28);
            this.txtBoxNewGroupName.TabIndex = 5;
            // 
            // labelNewName
            // 
            this.labelNewName.AutoSize = true;
            this.labelNewName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewName.ForeColor = System.Drawing.Color.White;
            this.labelNewName.Location = new System.Drawing.Point(3, 46);
            this.labelNewName.Name = "labelNewName";
            this.labelNewName.Size = new System.Drawing.Size(130, 20);
            this.labelNewName.TabIndex = 4;
            this.labelNewName.Text = "Enter New Name:";
            // 
            // panelAddGroup
            // 
            this.panelAddGroup.BackColor = System.Drawing.Color.BlueViolet;
            this.panelAddGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddGroup.Controls.Add(this.addGroupButton);
            this.panelAddGroup.Controls.Add(this.txtBoxAddGroupName);
            this.panelAddGroup.Controls.Add(this.labelEnterGroupName);
            this.panelAddGroup.Location = new System.Drawing.Point(440, 155);
            this.panelAddGroup.Name = "panelAddGroup";
            this.panelAddGroup.Size = new System.Drawing.Size(356, 96);
            this.panelAddGroup.TabIndex = 16;
            // 
            // addGroupButton
            // 
            this.addGroupButton.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGroupButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.addGroupButton.Location = new System.Drawing.Point(7, 50);
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(318, 38);
            this.addGroupButton.TabIndex = 6;
            this.addGroupButton.Text = "Add";
            this.addGroupButton.UseVisualStyleBackColor = true;
            this.addGroupButton.Click += new System.EventHandler(this.addGroupButton_Click);
            // 
            // txtBoxAddGroupName
            // 
            this.txtBoxAddGroupName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAddGroupName.Location = new System.Drawing.Point(139, 10);
            this.txtBoxAddGroupName.Name = "txtBoxAddGroupName";
            this.txtBoxAddGroupName.Size = new System.Drawing.Size(186, 28);
            this.txtBoxAddGroupName.TabIndex = 5;
            // 
            // labelEnterGroupName
            // 
            this.labelEnterGroupName.AutoSize = true;
            this.labelEnterGroupName.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterGroupName.ForeColor = System.Drawing.Color.White;
            this.labelEnterGroupName.Location = new System.Drawing.Point(3, 13);
            this.labelEnterGroupName.Name = "labelEnterGroupName";
            this.labelEnterGroupName.Size = new System.Drawing.Size(140, 20);
            this.labelEnterGroupName.TabIndex = 4;
            this.labelEnterGroupName.Text = "Enter Group Name:";
            // 
            // labelTittleGroup
            // 
            this.labelTittleGroup.AutoSize = true;
            this.labelTittleGroup.BackColor = System.Drawing.Color.BlueViolet;
            this.labelTittleGroup.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittleGroup.ForeColor = System.Drawing.Color.White;
            this.labelTittleGroup.Location = new System.Drawing.Point(440, 113);
            this.labelTittleGroup.Name = "labelTittleGroup";
            this.labelTittleGroup.Size = new System.Drawing.Size(112, 39);
            this.labelTittleGroup.TabIndex = 15;
            this.labelTittleGroup.Text = "GROUP";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.addContactButton);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.editContactButton);
            this.panel4.Location = new System.Drawing.Point(19, 155);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(416, 96);
            this.panel4.TabIndex = 19;
            // 
            // HRMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelEditGroup);
            this.Controls.Add(this.panelAddGroup);
            this.Controls.Add(this.labelTittleGroup);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.showFullListButton);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "HRMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HRMainForm";
            this.Load += new System.EventHandler(this.HRMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelEditGroup.ResumeLayout(false);
            this.panelEditGroup.PerformLayout();
            this.panelAddGroup.ResumeLayout(false);
            this.panelAddGroup.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelXuyetThang;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelRefresh;
        private System.Windows.Forms.Label labelEditInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editContactButton;
        private System.Windows.Forms.Button addContactButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button selectContactButton;
        private System.Windows.Forms.TextBox txtRemoveContact;
        private System.Windows.Forms.Label labelRemoveContact;
        private System.Windows.Forms.Button removeContactButton;
        private System.Windows.Forms.Button showFullListButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removeGroupButton;
        private System.Windows.Forms.ComboBox comboBoxGroupNameRemove;
        private System.Windows.Forms.Panel panelEditGroup;
        private System.Windows.Forms.Label labelSelectGroup;
        private System.Windows.Forms.Button editGroupButton;
        private System.Windows.Forms.ComboBox comboBoxGroupNameEdit;
        private System.Windows.Forms.TextBox txtBoxNewGroupName;
        private System.Windows.Forms.Label labelNewName;
        private System.Windows.Forms.Panel panelAddGroup;
        private System.Windows.Forms.Button addGroupButton;
        private System.Windows.Forms.TextBox txtBoxAddGroupName;
        private System.Windows.Forms.Label labelEnterGroupName;
        private System.Windows.Forms.Label labelTittleGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelLogout;
        private System.Windows.Forms.Panel panel4;
    }
}
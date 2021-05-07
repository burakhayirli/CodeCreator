namespace CodeCreator
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabClassPage = new System.Windows.Forms.TabPage();
            this.txt_ClassCode = new System.Windows.Forms.TextBox();
            this.tabInsertPage = new System.Windows.Forms.TabPage();
            this.txt_InsertCode = new System.Windows.Forms.TextBox();
            this.tabUpdatePage = new System.Windows.Forms.TabPage();
            this.txt_UpdateCode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TableOrPropertyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ColumnNames = new System.Windows.Forms.TextBox();
            this.btn_CreateCode = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_Database = new System.Windows.Forms.RadioButton();
            this.rb_Manuel = new System.Windows.Forms.RadioButton();
            this.gb_DatabaseAndTableSelection = new System.Windows.Forms.GroupBox();
            this.chkb_UseOrjinalColumnNameOnClass = new System.Windows.Forms.CheckBox();
            this.chkb_UseOrjinalColumnNameOnSQL = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Tables = new System.Windows.Forms.ComboBox();
            this.cb_Databases = new System.Windows.Forms.ComboBox();
            this.gb_DatabaseConnection = new System.Windows.Forms.GroupBox();
            this.txt_DbPassword = new System.Windows.Forms.TextBox();
            this.txt_DbUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.txt_ServerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_About = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabClassPage.SuspendLayout();
            this.tabInsertPage.SuspendLayout();
            this.tabUpdatePage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gb_DatabaseAndTableSelection.SuspendLayout();
            this.gb_DatabaseConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabClassPage);
            this.tabControl1.Controls.Add(this.tabInsertPage);
            this.tabControl1.Controls.Add(this.tabUpdatePage);
            this.tabControl1.Location = new System.Drawing.Point(20, 363);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1047, 319);
            this.tabControl1.TabIndex = 3;
            // 
            // tabClassPage
            // 
            this.tabClassPage.Controls.Add(this.txt_ClassCode);
            this.tabClassPage.Location = new System.Drawing.Point(4, 25);
            this.tabClassPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabClassPage.Name = "tabClassPage";
            this.tabClassPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabClassPage.Size = new System.Drawing.Size(1039, 290);
            this.tabClassPage.TabIndex = 0;
            this.tabClassPage.Text = "Class";
            this.tabClassPage.UseVisualStyleBackColor = true;
            // 
            // txt_ClassCode
            // 
            this.txt_ClassCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ClassCode.Location = new System.Drawing.Point(0, 0);
            this.txt_ClassCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ClassCode.Multiline = true;
            this.txt_ClassCode.Name = "txt_ClassCode";
            this.txt_ClassCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_ClassCode.Size = new System.Drawing.Size(1035, 286);
            this.txt_ClassCode.TabIndex = 1;
            this.txt_ClassCode.WordWrap = false;
            // 
            // tabInsertPage
            // 
            this.tabInsertPage.Controls.Add(this.txt_InsertCode);
            this.tabInsertPage.Location = new System.Drawing.Point(4, 25);
            this.tabInsertPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabInsertPage.Name = "tabInsertPage";
            this.tabInsertPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabInsertPage.Size = new System.Drawing.Size(1039, 290);
            this.tabInsertPage.TabIndex = 1;
            this.tabInsertPage.Text = "Insert";
            this.tabInsertPage.UseVisualStyleBackColor = true;
            // 
            // txt_InsertCode
            // 
            this.txt_InsertCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_InsertCode.Location = new System.Drawing.Point(0, 0);
            this.txt_InsertCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_InsertCode.Multiline = true;
            this.txt_InsertCode.Name = "txt_InsertCode";
            this.txt_InsertCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_InsertCode.Size = new System.Drawing.Size(1031, 238);
            this.txt_InsertCode.TabIndex = 1;
            this.txt_InsertCode.WordWrap = false;
            // 
            // tabUpdatePage
            // 
            this.tabUpdatePage.Controls.Add(this.txt_UpdateCode);
            this.tabUpdatePage.Location = new System.Drawing.Point(4, 25);
            this.tabUpdatePage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabUpdatePage.Name = "tabUpdatePage";
            this.tabUpdatePage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabUpdatePage.Size = new System.Drawing.Size(1039, 290);
            this.tabUpdatePage.TabIndex = 2;
            this.tabUpdatePage.Text = "Update";
            this.tabUpdatePage.UseVisualStyleBackColor = true;
            // 
            // txt_UpdateCode
            // 
            this.txt_UpdateCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_UpdateCode.Location = new System.Drawing.Point(0, 0);
            this.txt_UpdateCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_UpdateCode.Multiline = true;
            this.txt_UpdateCode.Name = "txt_UpdateCode";
            this.txt_UpdateCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_UpdateCode.Size = new System.Drawing.Size(1031, 242);
            this.txt_UpdateCode.TabIndex = 2;
            this.txt_UpdateCode.WordWrap = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_TableOrPropertyName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_ColumnNames);
            this.groupBox1.Controls.Add(this.btn_CreateCode);
            this.groupBox1.Location = new System.Drawing.Point(20, 180);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1047, 176);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sütun - Özellik İsmi Belirle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tablo ve Class Adı : ";
            // 
            // txt_TableOrPropertyName
            // 
            this.txt_TableOrPropertyName.Location = new System.Drawing.Point(157, 28);
            this.txt_TableOrPropertyName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TableOrPropertyName.Name = "txt_TableOrPropertyName";
            this.txt_TableOrPropertyName.Size = new System.Drawing.Size(208, 22);
            this.txt_TableOrPropertyName.TabIndex = 4;
            this.txt_TableOrPropertyName.Text = "TABLE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sütün yada Özellik İsimleri (Ör: Burak,Hayirli)";
            // 
            // txt_ColumnNames
            // 
            this.txt_ColumnNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ColumnNames.Location = new System.Drawing.Point(20, 84);
            this.txt_ColumnNames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ColumnNames.Multiline = true;
            this.txt_ColumnNames.Name = "txt_ColumnNames";
            this.txt_ColumnNames.Size = new System.Drawing.Size(1017, 78);
            this.txt_ColumnNames.TabIndex = 1;
            // 
            // btn_CreateCode
            // 
            this.btn_CreateCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CreateCode.Image = global::CodeCreator.Properties.Resources.edit_property_24;
            this.btn_CreateCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CreateCode.Location = new System.Drawing.Point(889, 20);
            this.btn_CreateCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CreateCode.Name = "btn_CreateCode";
            this.btn_CreateCode.Size = new System.Drawing.Size(149, 47);
            this.btn_CreateCode.TabIndex = 1;
            this.btn_CreateCode.Text = "Kodları Oluştur";
            this.btn_CreateCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CreateCode.UseVisualStyleBackColor = true;
            this.btn_CreateCode.Click += new System.EventHandler(this.btn_CreateCode_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_Database);
            this.groupBox2.Controls.Add(this.rb_Manuel);
            this.groupBox2.Location = new System.Drawing.Point(25, 33);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(296, 91);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yol Seçenekleri";
            // 
            // rb_Database
            // 
            this.rb_Database.AutoSize = true;
            this.rb_Database.Location = new System.Drawing.Point(152, 42);
            this.rb_Database.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_Database.Name = "rb_Database";
            this.rb_Database.Size = new System.Drawing.Size(93, 21);
            this.rb_Database.TabIndex = 0;
            this.rb_Database.Text = "Veritabanı";
            this.rb_Database.UseVisualStyleBackColor = true;
            this.rb_Database.CheckedChanged += new System.EventHandler(this.rb_Database_CheckedChanged);
            // 
            // rb_Manuel
            // 
            this.rb_Manuel.AutoSize = true;
            this.rb_Manuel.Checked = true;
            this.rb_Manuel.Location = new System.Drawing.Point(29, 42);
            this.rb_Manuel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_Manuel.Name = "rb_Manuel";
            this.rb_Manuel.Size = new System.Drawing.Size(75, 21);
            this.rb_Manuel.TabIndex = 0;
            this.rb_Manuel.TabStop = true;
            this.rb_Manuel.Text = "Manuel";
            this.rb_Manuel.UseVisualStyleBackColor = true;
            // 
            // gb_DatabaseAndTableSelection
            // 
            this.gb_DatabaseAndTableSelection.Controls.Add(this.chkb_UseOrjinalColumnNameOnClass);
            this.gb_DatabaseAndTableSelection.Controls.Add(this.chkb_UseOrjinalColumnNameOnSQL);
            this.gb_DatabaseAndTableSelection.Controls.Add(this.label6);
            this.gb_DatabaseAndTableSelection.Controls.Add(this.label5);
            this.gb_DatabaseAndTableSelection.Controls.Add(this.cb_Tables);
            this.gb_DatabaseAndTableSelection.Controls.Add(this.cb_Databases);
            this.gb_DatabaseAndTableSelection.Location = new System.Drawing.Point(339, 33);
            this.gb_DatabaseAndTableSelection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_DatabaseAndTableSelection.Name = "gb_DatabaseAndTableSelection";
            this.gb_DatabaseAndTableSelection.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_DatabaseAndTableSelection.Size = new System.Drawing.Size(673, 139);
            this.gb_DatabaseAndTableSelection.TabIndex = 7;
            this.gb_DatabaseAndTableSelection.TabStop = false;
            this.gb_DatabaseAndTableSelection.Text = "Veritabanı ve Tablo Seçimi";
            this.gb_DatabaseAndTableSelection.Visible = false;
            // 
            // chkb_UseOrjinalColumnNameOnClass
            // 
            this.chkb_UseOrjinalColumnNameOnClass.AutoSize = true;
            this.chkb_UseOrjinalColumnNameOnClass.Checked = true;
            this.chkb_UseOrjinalColumnNameOnClass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkb_UseOrjinalColumnNameOnClass.Location = new System.Drawing.Point(336, 91);
            this.chkb_UseOrjinalColumnNameOnClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkb_UseOrjinalColumnNameOnClass.Name = "chkb_UseOrjinalColumnNameOnClass";
            this.chkb_UseOrjinalColumnNameOnClass.Size = new System.Drawing.Size(307, 21);
            this.chkb_UseOrjinalColumnNameOnClass.TabIndex = 8;
            this.chkb_UseOrjinalColumnNameOnClass.Text = "Class içinde sütun isimlerinin orjinalini kullan";
            this.chkb_UseOrjinalColumnNameOnClass.UseVisualStyleBackColor = true;
            // 
            // chkb_UseOrjinalColumnNameOnSQL
            // 
            this.chkb_UseOrjinalColumnNameOnSQL.AutoSize = true;
            this.chkb_UseOrjinalColumnNameOnSQL.Location = new System.Drawing.Point(336, 63);
            this.chkb_UseOrjinalColumnNameOnSQL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkb_UseOrjinalColumnNameOnSQL.Name = "chkb_UseOrjinalColumnNameOnSQL";
            this.chkb_UseOrjinalColumnNameOnSQL.Size = new System.Drawing.Size(341, 21);
            this.chkb_UseOrjinalColumnNameOnSQL.TabIndex = 7;
            this.chkb_UseOrjinalColumnNameOnSQL.Text = "SQL scriptlerinde sütun isimlerinin orjinalini kullan";
            this.chkb_UseOrjinalColumnNameOnSQL.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tablo :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Veritabanı :";
            // 
            // cb_Tables
            // 
            this.cb_Tables.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Tables.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Tables.FormattingEnabled = true;
            this.cb_Tables.Location = new System.Drawing.Point(413, 18);
            this.cb_Tables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_Tables.Name = "cb_Tables";
            this.cb_Tables.Size = new System.Drawing.Size(251, 24);
            this.cb_Tables.TabIndex = 1;
            this.cb_Tables.SelectedValueChanged += new System.EventHandler(this.cb_Tables_SelectedValueChanged);
            // 
            // cb_Databases
            // 
            this.cb_Databases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Databases.FormattingEnabled = true;
            this.cb_Databases.Location = new System.Drawing.Point(112, 20);
            this.cb_Databases.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_Databases.Name = "cb_Databases";
            this.cb_Databases.Size = new System.Drawing.Size(231, 24);
            this.cb_Databases.TabIndex = 1;
            this.cb_Databases.SelectedValueChanged += new System.EventHandler(this.cb_Databases_SelectedValueChanged);
            // 
            // gb_DatabaseConnection
            // 
            this.gb_DatabaseConnection.Controls.Add(this.txt_DbPassword);
            this.gb_DatabaseConnection.Controls.Add(this.txt_DbUser);
            this.gb_DatabaseConnection.Controls.Add(this.label7);
            this.gb_DatabaseConnection.Controls.Add(this.label4);
            this.gb_DatabaseConnection.Controls.Add(this.btn_Connect);
            this.gb_DatabaseConnection.Controls.Add(this.txt_ServerName);
            this.gb_DatabaseConnection.Controls.Add(this.label3);
            this.gb_DatabaseConnection.Location = new System.Drawing.Point(344, 33);
            this.gb_DatabaseConnection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_DatabaseConnection.Name = "gb_DatabaseConnection";
            this.gb_DatabaseConnection.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_DatabaseConnection.Size = new System.Drawing.Size(660, 132);
            this.gb_DatabaseConnection.TabIndex = 9;
            this.gb_DatabaseConnection.TabStop = false;
            this.gb_DatabaseConnection.Text = "Veritabanı Bağlantısı";
            this.gb_DatabaseConnection.Visible = false;
            // 
            // txt_DbPassword
            // 
            this.txt_DbPassword.Location = new System.Drawing.Point(71, 85);
            this.txt_DbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_DbPassword.Name = "txt_DbPassword";
            this.txt_DbPassword.PasswordChar = '*';
            this.txt_DbPassword.Size = new System.Drawing.Size(132, 22);
            this.txt_DbPassword.TabIndex = 3;
            // 
            // txt_DbUser
            // 
            this.txt_DbUser.Location = new System.Drawing.Point(71, 53);
            this.txt_DbUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_DbUser.Name = "txt_DbUser";
            this.txt_DbUser.Size = new System.Drawing.Size(132, 22);
            this.txt_DbUser.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Parola:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kullanıcı:";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(408, 20);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(100, 28);
            this.btn_Connect.TabIndex = 4;
            this.btn_Connect.Text = "Bağlan";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // txt_ServerName
            // 
            this.txt_ServerName.Location = new System.Drawing.Point(71, 22);
            this.txt_ServerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ServerName.Name = "txt_ServerName";
            this.txt_ServerName.Size = new System.Drawing.Size(328, 22);
            this.txt_ServerName.TabIndex = 1;
            this.txt_ServerName.Text = "BURAK\\SQLEXPRESS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sunucu :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_About
            // 
            this.btn_About.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_About.Image = global::CodeCreator.Properties.Resources.info_2_24;
            this.btn_About.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_About.Location = new System.Drawing.Point(948, 7);
            this.btn_About.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(119, 37);
            this.btn_About.TabIndex = 10;
            this.btn_About.Text = "Hakkında";
            this.btn_About.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_About.UseVisualStyleBackColor = true;
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 697);
            this.Controls.Add(this.btn_About);
            this.Controls.Add(this.gb_DatabaseConnection);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gb_DatabaseAndTableSelection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_Main";
            this.Text = "Code Creator --> Class - Insert - Update";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabClassPage.ResumeLayout(false);
            this.tabClassPage.PerformLayout();
            this.tabInsertPage.ResumeLayout(false);
            this.tabInsertPage.PerformLayout();
            this.tabUpdatePage.ResumeLayout(false);
            this.tabUpdatePage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gb_DatabaseAndTableSelection.ResumeLayout(false);
            this.gb_DatabaseAndTableSelection.PerformLayout();
            this.gb_DatabaseConnection.ResumeLayout(false);
            this.gb_DatabaseConnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateCode;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabClassPage;
        private System.Windows.Forms.TextBox txt_ClassCode;
        private System.Windows.Forms.TabPage tabInsertPage;
        private System.Windows.Forms.TextBox txt_InsertCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ColumnNames;
        private System.Windows.Forms.TabPage tabUpdatePage;
        private System.Windows.Forms.TextBox txt_UpdateCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TableOrPropertyName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_Database;
        private System.Windows.Forms.RadioButton rb_Manuel;
        private System.Windows.Forms.GroupBox gb_DatabaseAndTableSelection;
        private System.Windows.Forms.GroupBox gb_DatabaseConnection;
        private System.Windows.Forms.TextBox txt_ServerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Tables;
        private System.Windows.Forms.ComboBox cb_Databases;
        private System.Windows.Forms.CheckBox chkb_UseOrjinalColumnNameOnSQL;
        private System.Windows.Forms.CheckBox chkb_UseOrjinalColumnNameOnClass;
        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.TextBox txt_DbPassword;
        private System.Windows.Forms.TextBox txt_DbUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
    }
}


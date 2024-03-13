namespace GYM
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            groupBox4 = new GroupBox();
            Btn_LoginCancel = new Button();
            Btn_LoginEnter = new Button();
            Txt_LoginPassword = new TextBox();
            Txt_LoginUser = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            dataGridViewUsers = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            birthDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            userBindingSource = new BindingSource(components);
            label9 = new Label();
            Btn_CancelSearch = new Button();
            Btn_Search = new Button();
            Txt_NameSearch = new TextBox();
            groupBox5 = new GroupBox();
            Btn_SelectEdit = new Button();
            Btn_EditCancel = new Button();
            Btn_DeleteConfirm = new Button();
            Cmb_EditGender = new ComboBox();
            Txt_EditBirth = new MaskedTextBox();
            Txt_EditPhoneNumber = new MaskedTextBox();
            Txt_EditEmail = new TextBox();
            Txt_EditName = new TextBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            Btn_Edit = new Button();
            Txt_EditSearchId = new TextBox();
            label13 = new Label();
            AddBox = new GroupBox();
            Cmb_AddGender = new ComboBox();
            Btn_CancelAdd = new Button();
            Btn_AddMember = new Button();
            Txt_AddEmail = new TextBox();
            label8 = new Label();
            Txt_AddPhone = new MaskedTextBox();
            Txt_AddBirth = new MaskedTextBox();
            Txt_AddName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            namesBindingSource = new BindingSource(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox4.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            groupBox5.SuspendLayout();
            AddBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)namesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1284, 1005);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(1276, 977);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Member";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 40F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(557, 47);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(150, 63);
            label3.TabIndex = 1;
            label3.Text = "GYM";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(Btn_LoginCancel);
            groupBox4.Controls.Add(Btn_LoginEnter);
            groupBox4.Controls.Add(Txt_LoginPassword);
            groupBox4.Controls.Add(Txt_LoginUser);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label1);
            groupBox4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(437, 232);
            groupBox4.Margin = new Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 3, 4, 3);
            groupBox4.Size = new Size(397, 272);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Login";
            // 
            // Btn_LoginCancel
            // 
            Btn_LoginCancel.Location = new Point(133, 208);
            Btn_LoginCancel.Margin = new Padding(4, 3, 4, 3);
            Btn_LoginCancel.Name = "Btn_LoginCancel";
            Btn_LoginCancel.Size = new Size(125, 42);
            Btn_LoginCancel.TabIndex = 5;
            Btn_LoginCancel.Text = "CANCEL";
            Btn_LoginCancel.UseVisualStyleBackColor = true;
            Btn_LoginCancel.Click += Btn_LoginCancel_Click;
            // 
            // Btn_LoginEnter
            // 
            Btn_LoginEnter.Location = new Point(265, 208);
            Btn_LoginEnter.Margin = new Padding(4, 3, 4, 3);
            Btn_LoginEnter.Name = "Btn_LoginEnter";
            Btn_LoginEnter.Size = new Size(125, 42);
            Btn_LoginEnter.TabIndex = 4;
            Btn_LoginEnter.Text = "ENTER";
            Btn_LoginEnter.UseVisualStyleBackColor = true;
            Btn_LoginEnter.Click += Btn_LoginEnter_Click;
            // 
            // Txt_LoginPassword
            // 
            Txt_LoginPassword.Location = new Point(13, 166);
            Txt_LoginPassword.Margin = new Padding(4, 3, 4, 3);
            Txt_LoginPassword.Name = "Txt_LoginPassword";
            Txt_LoginPassword.PasswordChar = '#';
            Txt_LoginPassword.Size = new Size(376, 30);
            Txt_LoginPassword.TabIndex = 3;
            // 
            // Txt_LoginUser
            // 
            Txt_LoginUser.Location = new Point(13, 96);
            Txt_LoginUser.Margin = new Padding(4, 3, 4, 3);
            Txt_LoginUser.Name = "Txt_LoginUser";
            Txt_LoginUser.Size = new Size(376, 30);
            Txt_LoginUser.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 134);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 63);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(groupBox5);
            tabPage2.Controls.Add(AddBox);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.Size = new Size(1276, 977);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Admin";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewUsers);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(Btn_CancelSearch);
            groupBox1.Controls.Add(Btn_Search);
            groupBox1.Controls.Add(Txt_NameSearch);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(4, 354);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1268, 620);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "DISPLAY DATABASE";
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.Anchor = AnchorStyles.None;
            dataGridViewUsers.AutoGenerateColumns = false;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, birthDateDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, Username, Password });
            dataGridViewUsers.DataSource = userBindingSource;
            dataGridViewUsers.Location = new Point(7, 56);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(1258, 584);
            dataGridViewUsers.TabIndex = 34;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 42;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.ReadOnly = true;
            genderDataGridViewTextBoxColumn.Width = 70;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            birthDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            birthDateDataGridViewTextBoxColumn.Width = 81;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            phoneNumberDataGridViewTextBoxColumn.Width = 110;
            // 
            // Username
            // 
            Username.DataPropertyName = "Username";
            Username.HeaderText = "Username";
            Username.Name = "Username";
            // 
            // Password
            // 
            Password.DataPropertyName = "Password";
            Password.HeaderText = "Password";
            Password.Name = "Password";
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Model.User);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(7, 19);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(70, 25);
            label9.TabIndex = 33;
            label9.Text = "Name:";
            label9.TextAlign = ContentAlignment.BottomRight;
            // 
            // Btn_CancelSearch
            // 
            Btn_CancelSearch.Location = new Point(1084, 18);
            Btn_CancelSearch.Margin = new Padding(4, 3, 4, 3);
            Btn_CancelSearch.Name = "Btn_CancelSearch";
            Btn_CancelSearch.Size = new Size(179, 32);
            Btn_CancelSearch.TabIndex = 32;
            Btn_CancelSearch.Text = "CANCEL";
            Btn_CancelSearch.UseVisualStyleBackColor = true;
            Btn_CancelSearch.Click += Btn_CancelSearch_Click;
            // 
            // Btn_Search
            // 
            Btn_Search.Location = new Point(897, 19);
            Btn_Search.Margin = new Padding(4, 3, 4, 3);
            Btn_Search.Name = "Btn_Search";
            Btn_Search.Size = new Size(179, 31);
            Btn_Search.TabIndex = 29;
            Btn_Search.Text = "SEARCH";
            Btn_Search.UseVisualStyleBackColor = true;
            Btn_Search.Click += Btn_Search_Click;
            // 
            // Txt_NameSearch
            // 
            Txt_NameSearch.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_NameSearch.Location = new Point(77, 23);
            Txt_NameSearch.Margin = new Padding(4, 3, 4, 3);
            Txt_NameSearch.MaxLength = 60;
            Txt_NameSearch.Name = "Txt_NameSearch";
            Txt_NameSearch.Size = new Size(507, 23);
            Txt_NameSearch.TabIndex = 28;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(Btn_SelectEdit);
            groupBox5.Controls.Add(Btn_EditCancel);
            groupBox5.Controls.Add(Btn_DeleteConfirm);
            groupBox5.Controls.Add(Cmb_EditGender);
            groupBox5.Controls.Add(Txt_EditBirth);
            groupBox5.Controls.Add(Txt_EditPhoneNumber);
            groupBox5.Controls.Add(Txt_EditEmail);
            groupBox5.Controls.Add(Txt_EditName);
            groupBox5.Controls.Add(label18);
            groupBox5.Controls.Add(label17);
            groupBox5.Controls.Add(label16);
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(Btn_Edit);
            groupBox5.Controls.Add(Txt_EditSearchId);
            groupBox5.Controls.Add(label13);
            groupBox5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.Location = new Point(646, 3);
            groupBox5.Margin = new Padding(4, 3, 4, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 3, 4, 3);
            groupBox5.Size = new Size(626, 320);
            groupBox5.TabIndex = 27;
            groupBox5.TabStop = false;
            groupBox5.Text = "EDIT/DELETE DATA";
            // 
            // Btn_SelectEdit
            // 
            Btn_SelectEdit.Location = new Point(255, 18);
            Btn_SelectEdit.Margin = new Padding(4, 3, 4, 3);
            Btn_SelectEdit.Name = "Btn_SelectEdit";
            Btn_SelectEdit.Size = new Size(114, 27);
            Btn_SelectEdit.TabIndex = 27;
            Btn_SelectEdit.Text = "SELECT";
            Btn_SelectEdit.UseVisualStyleBackColor = true;
            Btn_SelectEdit.Click += Btn_SelectEdit_Click;
            // 
            // Btn_EditCancel
            // 
            Btn_EditCancel.Location = new Point(224, 248);
            Btn_EditCancel.Margin = new Padding(4, 3, 4, 3);
            Btn_EditCancel.Name = "Btn_EditCancel";
            Btn_EditCancel.Size = new Size(114, 45);
            Btn_EditCancel.TabIndex = 26;
            Btn_EditCancel.Text = "CANCEL";
            Btn_EditCancel.UseVisualStyleBackColor = true;
            Btn_EditCancel.Click += Btn_EditCancel_Click;
            // 
            // Btn_DeleteConfirm
            // 
            Btn_DeleteConfirm.Font = new Font("Microsoft Sans Serif", 10F);
            Btn_DeleteConfirm.Location = new Point(468, 248);
            Btn_DeleteConfirm.Margin = new Padding(4, 3, 4, 3);
            Btn_DeleteConfirm.Name = "Btn_DeleteConfirm";
            Btn_DeleteConfirm.Size = new Size(114, 45);
            Btn_DeleteConfirm.TabIndex = 21;
            Btn_DeleteConfirm.Text = "DELETE";
            Btn_DeleteConfirm.UseVisualStyleBackColor = true;
            Btn_DeleteConfirm.Click += Btn_DeleteConfirm_Click;
            // 
            // Cmb_EditGender
            // 
            Cmb_EditGender.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmb_EditGender.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cmb_EditGender.FormattingEnabled = true;
            Cmb_EditGender.Items.AddRange(new object[] { "", "MALE", "FEMALE", "OTHER" });
            Cmb_EditGender.Location = new Point(149, 126);
            Cmb_EditGender.Margin = new Padding(4, 3, 4, 3);
            Cmb_EditGender.Name = "Cmb_EditGender";
            Cmb_EditGender.Size = new Size(97, 24);
            Cmb_EditGender.TabIndex = 20;
            // 
            // Txt_EditBirth
            // 
            Txt_EditBirth.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_EditBirth.Location = new Point(149, 101);
            Txt_EditBirth.Margin = new Padding(4, 3, 4, 3);
            Txt_EditBirth.Mask = "00/00/0000";
            Txt_EditBirth.Name = "Txt_EditBirth";
            Txt_EditBirth.ReadOnly = true;
            Txt_EditBirth.Size = new Size(79, 23);
            Txt_EditBirth.TabIndex = 16;
            Txt_EditBirth.TextAlign = HorizontalAlignment.Center;
            Txt_EditBirth.ValidatingType = typeof(DateTime);
            // 
            // Txt_EditPhoneNumber
            // 
            Txt_EditPhoneNumber.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_EditPhoneNumber.Location = new Point(150, 152);
            Txt_EditPhoneNumber.Margin = new Padding(4, 3, 4, 3);
            Txt_EditPhoneNumber.Mask = "(99) 0000-0000";
            Txt_EditPhoneNumber.Name = "Txt_EditPhoneNumber";
            Txt_EditPhoneNumber.ReadOnly = true;
            Txt_EditPhoneNumber.Size = new Size(97, 23);
            Txt_EditPhoneNumber.TabIndex = 15;
            Txt_EditPhoneNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // Txt_EditEmail
            // 
            Txt_EditEmail.Font = new Font("Microsoft Sans Serif", 10F);
            Txt_EditEmail.Location = new Point(149, 177);
            Txt_EditEmail.Margin = new Padding(4, 3, 4, 3);
            Txt_EditEmail.Name = "Txt_EditEmail";
            Txt_EditEmail.ReadOnly = true;
            Txt_EditEmail.Size = new Size(433, 23);
            Txt_EditEmail.TabIndex = 14;
            // 
            // Txt_EditName
            // 
            Txt_EditName.Font = new Font("Microsoft Sans Serif", 10F);
            Txt_EditName.Location = new Point(149, 76);
            Txt_EditName.Margin = new Padding(4, 3, 4, 3);
            Txt_EditName.Name = "Txt_EditName";
            Txt_EditName.ReadOnly = true;
            Txt_EditName.Size = new Size(433, 23);
            Txt_EditName.TabIndex = 12;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 15F);
            label18.Location = new Point(87, 175);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(66, 25);
            label18.TabIndex = 10;
            label18.Text = "Email:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 15F);
            label17.Location = new Point(4, 150);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(149, 25);
            label17.TabIndex = 9;
            label17.Text = "Phone Number:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 15F);
            label16.Location = new Point(70, 126);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(83, 25);
            label16.TabIndex = 8;
            label16.Text = "Gender:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 15F);
            label15.Location = new Point(29, 101);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(124, 25);
            label15.TabIndex = 7;
            label15.Text = "Date of Birth:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 15F);
            label14.Location = new Point(83, 76);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(70, 25);
            label14.TabIndex = 6;
            label14.Text = "Name:";
            // 
            // Btn_Edit
            // 
            Btn_Edit.Font = new Font("Microsoft Sans Serif", 10F);
            Btn_Edit.Location = new Point(346, 248);
            Btn_Edit.Margin = new Padding(4, 3, 4, 3);
            Btn_Edit.Name = "Btn_Edit";
            Btn_Edit.Size = new Size(114, 45);
            Btn_Edit.TabIndex = 4;
            Btn_Edit.Text = "EDIT";
            Btn_Edit.UseVisualStyleBackColor = true;
            Btn_Edit.Click += Btn_Edit_Click;
            // 
            // Txt_EditSearchId
            // 
            Txt_EditSearchId.Font = new Font("Microsoft Sans Serif", 10F);
            Txt_EditSearchId.Location = new Point(185, 19);
            Txt_EditSearchId.Margin = new Padding(4, 3, 4, 3);
            Txt_EditSearchId.Name = "Txt_EditSearchId";
            Txt_EditSearchId.Size = new Size(62, 23);
            Txt_EditSearchId.TabIndex = 3;
            Txt_EditSearchId.TextAlign = HorizontalAlignment.Center;
            Txt_EditSearchId.KeyUp += Txt_EditSearchId_KeyUp;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 10F);
            label13.Location = new Point(149, 23);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(25, 17);
            label13.TabIndex = 2;
            label13.Text = "ID:";
            // 
            // AddBox
            // 
            AddBox.Controls.Add(Cmb_AddGender);
            AddBox.Controls.Add(Btn_CancelAdd);
            AddBox.Controls.Add(Btn_AddMember);
            AddBox.Controls.Add(Txt_AddEmail);
            AddBox.Controls.Add(label8);
            AddBox.Controls.Add(Txt_AddPhone);
            AddBox.Controls.Add(Txt_AddBirth);
            AddBox.Controls.Add(Txt_AddName);
            AddBox.Controls.Add(label7);
            AddBox.Controls.Add(label6);
            AddBox.Controls.Add(label5);
            AddBox.Controls.Add(label4);
            AddBox.Location = new Point(4, 7);
            AddBox.Margin = new Padding(4, 3, 4, 3);
            AddBox.Name = "AddBox";
            AddBox.Padding = new Padding(4, 3, 4, 3);
            AddBox.Size = new Size(634, 316);
            AddBox.TabIndex = 24;
            AddBox.TabStop = false;
            AddBox.Text = "ADD MEMBER";
            // 
            // Cmb_AddGender
            // 
            Cmb_AddGender.BackColor = Color.White;
            Cmb_AddGender.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmb_AddGender.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cmb_AddGender.FormattingEnabled = true;
            Cmb_AddGender.Items.AddRange(new object[] { "", "MALE", "FEMALE", "OTHER" });
            Cmb_AddGender.Location = new Point(148, 87);
            Cmb_AddGender.Margin = new Padding(4, 3, 4, 3);
            Cmb_AddGender.Name = "Cmb_AddGender";
            Cmb_AddGender.Size = new Size(166, 24);
            Cmb_AddGender.TabIndex = 26;
            // 
            // Btn_CancelAdd
            // 
            Btn_CancelAdd.Location = new Point(305, 244);
            Btn_CancelAdd.Margin = new Padding(4, 3, 4, 3);
            Btn_CancelAdd.Name = "Btn_CancelAdd";
            Btn_CancelAdd.Size = new Size(144, 45);
            Btn_CancelAdd.TabIndex = 23;
            Btn_CancelAdd.Text = "CANCEL";
            Btn_CancelAdd.UseVisualStyleBackColor = true;
            Btn_CancelAdd.Click += Btn_CancelAdd_Click;
            // 
            // Btn_AddMember
            // 
            Btn_AddMember.Location = new Point(456, 244);
            Btn_AddMember.Margin = new Padding(4, 3, 4, 3);
            Btn_AddMember.Name = "Btn_AddMember";
            Btn_AddMember.Size = new Size(144, 45);
            Btn_AddMember.TabIndex = 13;
            Btn_AddMember.Text = "ADD MEMBER";
            Btn_AddMember.UseVisualStyleBackColor = true;
            Btn_AddMember.Click += Btn_AddMember_Click;
            // 
            // Txt_AddEmail
            // 
            Txt_AddEmail.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_AddEmail.Location = new Point(148, 137);
            Txt_AddEmail.Margin = new Padding(4, 3, 4, 3);
            Txt_AddEmail.MaxLength = 50;
            Txt_AddEmail.Name = "Txt_AddEmail";
            Txt_AddEmail.PlaceholderText = "#####@#####.com";
            Txt_AddEmail.Size = new Size(419, 23);
            Txt_AddEmail.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(83, 135);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(66, 25);
            label8.TabIndex = 21;
            label8.Text = "Email:";
            label8.TextAlign = ContentAlignment.BottomRight;
            // 
            // Txt_AddPhone
            // 
            Txt_AddPhone.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_AddPhone.Location = new Point(148, 113);
            Txt_AddPhone.Margin = new Padding(4, 3, 4, 3);
            Txt_AddPhone.Mask = "(99) 0000-0000";
            Txt_AddPhone.Name = "Txt_AddPhone";
            Txt_AddPhone.Size = new Size(96, 23);
            Txt_AddPhone.TabIndex = 20;
            // 
            // Txt_AddBirth
            // 
            Txt_AddBirth.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_AddBirth.Location = new Point(148, 58);
            Txt_AddBirth.Margin = new Padding(4, 3, 4, 3);
            Txt_AddBirth.Mask = "00/00/0000";
            Txt_AddBirth.Name = "Txt_AddBirth";
            Txt_AddBirth.Size = new Size(96, 23);
            Txt_AddBirth.TabIndex = 18;
            Txt_AddBirth.ValidatingType = typeof(DateTime);
            // 
            // Txt_AddName
            // 
            Txt_AddName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txt_AddName.Location = new Point(148, 29);
            Txt_AddName.Margin = new Padding(4, 3, 4, 3);
            Txt_AddName.MaxLength = 60;
            Txt_AddName.Name = "Txt_AddName";
            Txt_AddName.Size = new Size(419, 23);
            Txt_AddName.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(0, 111);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(149, 25);
            label7.TabIndex = 16;
            label7.Text = "Phone Number:";
            label7.TextAlign = ContentAlignment.BottomRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(66, 83);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(83, 25);
            label6.TabIndex = 15;
            label6.Text = "Gender:";
            label6.TextAlign = ContentAlignment.BottomRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 54);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(124, 25);
            label5.TabIndex = 14;
            label5.Text = "Date of Birth:";
            label5.TextAlign = ContentAlignment.BottomRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(79, 26);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 12;
            label4.Text = "Name:";
            label4.TextAlign = ContentAlignment.BottomRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 1005);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            AddBox.ResumeLayout(false);
            AddBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)namesBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox AddBox;
        private System.Windows.Forms.Button Btn_CancelAdd;
        private System.Windows.Forms.Button Btn_AddMember;
        private System.Windows.Forms.TextBox Txt_AddEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox Txt_AddPhone;
        private System.Windows.Forms.MaskedTextBox Txt_AddBirth;
        private System.Windows.Forms.TextBox Txt_AddName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_LoginPassword;
        private System.Windows.Forms.TextBox Txt_LoginUser;
        private System.Windows.Forms.Button Btn_LoginCancel;
        private System.Windows.Forms.Button Btn_LoginEnter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.TextBox Txt_EditSearchId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Txt_EditEmail;
        private System.Windows.Forms.TextBox Txt_EditName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox Txt_EditBirth;
        private System.Windows.Forms.MaskedTextBox Txt_EditPhoneNumber;
        private System.Windows.Forms.ComboBox Cmb_EditGender;
        private System.Windows.Forms.Button Btn_EditCancel;
        private System.Windows.Forms.Button Btn_DeleteConfirm;
        private System.Windows.Forms.BindingSource namesBindingSource;
        private Names names;
        private System.Windows.Forms.Button Btn_SelectEdit;
        private System.Windows.Forms.ComboBox Cmb_AddGender;
        private GroupBox groupBox1;
        private Label label9;
        private Button Btn_CancelSearch;
        private Button Btn_Search;
        private TextBox Txt_NameSearch;
        private DataGridView dataGridViewUsers;
        private BindingSource userBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
    }
}


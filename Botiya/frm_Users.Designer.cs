namespace Botiya
{
    partial class frm_Users
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Users));
            this.btnCancel = new CustomControls.RJControls.RJButton();
            this.BtnOk = new CustomControls.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.txtFName = new CustomControls.RJControls.RJTextBox();
            this.BtnDelete = new CustomControls.RJControls.RJButton();
            this.BtnEdit = new CustomControls.RJControls.RJButton();
            this.BtnAdd = new CustomControls.RJControls.RJButton();
            this.BtnBack = new CustomControls.RJControls.RJButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtLName = new CustomControls.RJControls.RJTextBox();
            this.txtUserName = new CustomControls.RJControls.RJTextBox();
            this.txtPassword = new CustomControls.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnShowHide = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundColor = System.Drawing.Color.White;
            this.btnCancel.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.BorderRadius = 12;
            this.btnCancel.BorderSize = 2;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(13, 390);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCancel.Size = new System.Drawing.Size(140, 42);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.TextColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.White;
            this.BtnOk.BackgroundColor = System.Drawing.Color.White;
            this.BtnOk.BorderColor = System.Drawing.Color.SteelBlue;
            this.BtnOk.BorderRadius = 12;
            this.BtnOk.BorderSize = 2;
            this.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOk.FlatAppearance.BorderSize = 0;
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnOk.Image = ((System.Drawing.Image)(resources.GetObject("BtnOk.Image")));
            this.BtnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOk.Location = new System.Drawing.Point(308, 125);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnOk.Size = new System.Drawing.Size(140, 42);
            this.BtnOk.TabIndex = 8;
            this.BtnOk.Text = "تایید";
            this.BtnOk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOk.TextColor = System.Drawing.Color.SteelBlue;
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Visible = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Chocolate;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(457, 34);
            this.label1.TabIndex = 33;
            this.label1.Text = "کاربران";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dgvUsers.DataSource = this.bsUsers;
            this.dgvUsers.GridColor = System.Drawing.Color.Chocolate;
            this.dgvUsers.Location = new System.Drawing.Point(13, 175);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(436, 209);
            this.dgvUsers.TabIndex = 32;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "fName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "نام";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            this.fNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "lName";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "نام خانوادگی";
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            this.lNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "نام کاربری";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsUsers
            // 
            this.bsUsers.DataSource = typeof(Botiya.tblUser);
            // 
            // txtFName
            // 
            this.txtFName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFName.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtFName.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtFName.BorderRadius = 5;
            this.txtFName.BorderSize = 2;
            this.txtFName.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFName.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtFName.Location = new System.Drawing.Point(13, 59);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFName.Multiline = false;
            this.txtFName.Name = "txtFName";
            this.txtFName.Padding = new System.Windows.Forms.Padding(7);
            this.txtFName.PasswordChar = false;
            this.txtFName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFName.PlaceholderText = "نام";
            this.txtFName.Size = new System.Drawing.Size(158, 35);
            this.txtFName.TabIndex = 0;
            this.txtFName.Texts = "";
            this.txtFName.UnderlinedStyle = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.White;
            this.BtnDelete.BackgroundColor = System.Drawing.Color.White;
            this.BtnDelete.BorderColor = System.Drawing.Color.SteelBlue;
            this.BtnDelete.BorderRadius = 12;
            this.BtnDelete.BorderSize = 2;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDelete.Location = new System.Drawing.Point(158, 390);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnDelete.Size = new System.Drawing.Size(140, 42);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "حذف";
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.TextColor = System.Drawing.Color.SteelBlue;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.White;
            this.BtnEdit.BackgroundColor = System.Drawing.Color.White;
            this.BtnEdit.BorderColor = System.Drawing.Color.SteelBlue;
            this.BtnEdit.BorderRadius = 12;
            this.BtnEdit.BorderSize = 2;
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.FlatAppearance.BorderSize = 0;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEdit.Location = new System.Drawing.Point(12, 390);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnEdit.Size = new System.Drawing.Size(140, 42);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.Text = "ویرایش";
            this.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEdit.TextColor = System.Drawing.Color.SteelBlue;
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.White;
            this.BtnAdd.BackgroundColor = System.Drawing.Color.White;
            this.BtnAdd.BorderColor = System.Drawing.Color.SteelBlue;
            this.BtnAdd.BorderRadius = 12;
            this.BtnAdd.BorderSize = 2;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAdd.Location = new System.Drawing.Point(309, 125);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnAdd.Size = new System.Drawing.Size(140, 42);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "افزودن";
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.TextColor = System.Drawing.Color.SteelBlue;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.White;
            this.BtnBack.BackgroundColor = System.Drawing.Color.White;
            this.BtnBack.BorderColor = System.Drawing.Color.SteelBlue;
            this.BtnBack.BorderRadius = 12;
            this.BtnBack.BorderSize = 2;
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.FlatAppearance.BorderSize = 0;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBack.Location = new System.Drawing.Point(309, 390);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnBack.Size = new System.Drawing.Size(140, 42);
            this.BtnBack.TabIndex = 7;
            this.BtnBack.Text = "بازگشت";
            this.BtnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBack.TextColor = System.Drawing.Color.SteelBlue;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // txtLName
            // 
            this.txtLName.BackColor = System.Drawing.SystemColors.Window;
            this.txtLName.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtLName.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtLName.BorderRadius = 5;
            this.txtLName.BorderSize = 2;
            this.txtLName.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtLName.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtLName.Location = new System.Drawing.Point(179, 59);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLName.Multiline = false;
            this.txtLName.Name = "txtLName";
            this.txtLName.Padding = new System.Windows.Forms.Padding(7);
            this.txtLName.PasswordChar = false;
            this.txtLName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLName.PlaceholderText = "نام خانوادگی";
            this.txtLName.Size = new System.Drawing.Size(269, 35);
            this.txtLName.TabIndex = 1;
            this.txtLName.Texts = "";
            this.txtLName.UnderlinedStyle = true;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.Window;
            this.txtUserName.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtUserName.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtUserName.BorderRadius = 5;
            this.txtUserName.BorderSize = 2;
            this.txtUserName.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtUserName.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtUserName.Location = new System.Drawing.Point(13, 132);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Multiline = false;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Padding = new System.Windows.Forms.Padding(7);
            this.txtUserName.PasswordChar = false;
            this.txtUserName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUserName.PlaceholderText = "نام کاربری";
            this.txtUserName.Size = new System.Drawing.Size(139, 35);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Texts = "";
            this.txtUserName.UnderlinedStyle = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.txtPassword.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtPassword.BorderRadius = 5;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPassword.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtPassword.Location = new System.Drawing.Point(158, 132);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "رمز عبور";
            this.txtPassword.Size = new System.Drawing.Size(140, 35);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "نام";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(178, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "نام خانوادگی";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 41;
            this.label4.Text = "نام کاربری";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(154, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 23);
            this.label5.TabIndex = 42;
            this.label5.Text = "رمز عبور";
            // 
            // btnShowHide
            // 
            this.btnShowHide.BackColor = System.Drawing.Color.Transparent;
            this.btnShowHide.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnShowHide.BorderColor = System.Drawing.Color.Transparent;
            this.btnShowHide.BorderRadius = 12;
            this.btnShowHide.BorderSize = 2;
            this.btnShowHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowHide.FlatAppearance.BorderSize = 0;
            this.btnShowHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowHide.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnShowHide.Image = ((System.Drawing.Image)(resources.GetObject("btnShowHide.Image")));
            this.btnShowHide.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowHide.Location = new System.Drawing.Point(267, 134);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnShowHide.Size = new System.Drawing.Size(36, 25);
            this.btnShowHide.TabIndex = 43;
            this.btnShowHide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowHide.TextColor = System.Drawing.Color.SteelBlue;
            this.btnShowHide.UseVisualStyleBackColor = false;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // frm_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 437);
            this.ControlBox = false;
            this.Controls.Add(this.btnShowHide);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnBack);
            this.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Chocolate;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Users";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton btnCancel;
        private CustomControls.RJControls.RJButton BtnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.BindingSource bsUsers;
        private CustomControls.RJControls.RJTextBox txtFName;
        private CustomControls.RJControls.RJButton BtnDelete;
        private CustomControls.RJControls.RJButton BtnEdit;
        private CustomControls.RJControls.RJButton BtnAdd;
        private CustomControls.RJControls.RJButton BtnBack;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private CustomControls.RJControls.RJTextBox txtPassword;
        private CustomControls.RJControls.RJTextBox txtUserName;
        private CustomControls.RJControls.RJTextBox txtLName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private CustomControls.RJControls.RJButton btnShowHide;
    }
}
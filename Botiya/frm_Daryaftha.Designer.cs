namespace Botiya
{
    partial class frm_Daryaftha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Daryaftha));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDaryafti = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idQarardadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shomareCheckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSarResidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceChekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDaryaftha = new System.Windows.Forms.BindingSource(this.components);
            this.BtnAdd = new CustomControls.RJControls.RJButton();
            this.BtnBack = new CustomControls.RJControls.RJButton();
            this.txtShomareQarardad = new CustomControls.RJControls.RJTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bsBanks = new System.Windows.Forms.BindingSource(this.components);
            this.cmbBank = new CustomControls.RJControls.RJComboBox();
            this.txtPrice = new CustomControls.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtShomareCheck = new CustomControls.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDateSar = new CustomControls.RJControls.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPriceMande = new System.Windows.Forms.Label();
            this.cmbBankAsli = new System.Windows.Forms.ComboBox();
            this.BtnDelete = new CustomControls.RJControls.RJButton();
            this.BtnEdit = new CustomControls.RJControls.RJButton();
            this.BtnOk = new CustomControls.RJControls.RJButton();
            this.btnCancel = new CustomControls.RJControls.RJButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaryafti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDaryaftha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(683, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "ثبت دریافت ها";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDaryafti
            // 
            this.dgvDaryafti.AllowUserToAddRows = false;
            this.dgvDaryafti.AllowUserToDeleteRows = false;
            this.dgvDaryafti.AutoGenerateColumns = false;
            this.dgvDaryafti.BackgroundColor = System.Drawing.Color.White;
            this.dgvDaryafti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaryafti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idQarardadDataGridViewTextBoxColumn,
            this.idBankDataGridViewTextBoxColumn,
            this.shomareCheckDataGridViewTextBoxColumn,
            this.dateSarResidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceChekDataGridViewTextBoxColumn});
            this.dgvDaryafti.DataSource = this.bsDaryaftha;
            this.dgvDaryafti.GridColor = System.Drawing.Color.Chocolate;
            this.dgvDaryafti.Location = new System.Drawing.Point(12, 145);
            this.dgvDaryafti.Name = "dgvDaryafti";
            this.dgvDaryafti.ReadOnly = true;
            this.dgvDaryafti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDaryafti.Size = new System.Drawing.Size(663, 227);
            this.dgvDaryafti.TabIndex = 20;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idQarardadDataGridViewTextBoxColumn
            // 
            this.idQarardadDataGridViewTextBoxColumn.DataPropertyName = "IdQarardad";
            this.idQarardadDataGridViewTextBoxColumn.HeaderText = "IdQarardad";
            this.idQarardadDataGridViewTextBoxColumn.Name = "idQarardadDataGridViewTextBoxColumn";
            this.idQarardadDataGridViewTextBoxColumn.ReadOnly = true;
            this.idQarardadDataGridViewTextBoxColumn.Visible = false;
            // 
            // idBankDataGridViewTextBoxColumn
            // 
            this.idBankDataGridViewTextBoxColumn.DataPropertyName = "IdBank";
            this.idBankDataGridViewTextBoxColumn.HeaderText = "IdBank";
            this.idBankDataGridViewTextBoxColumn.Name = "idBankDataGridViewTextBoxColumn";
            this.idBankDataGridViewTextBoxColumn.ReadOnly = true;
            this.idBankDataGridViewTextBoxColumn.Visible = false;
            // 
            // shomareCheckDataGridViewTextBoxColumn
            // 
            this.shomareCheckDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.shomareCheckDataGridViewTextBoxColumn.DataPropertyName = "ShomareCheck";
            this.shomareCheckDataGridViewTextBoxColumn.HeaderText = "شماره چک";
            this.shomareCheckDataGridViewTextBoxColumn.Name = "shomareCheckDataGridViewTextBoxColumn";
            this.shomareCheckDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateSarResidDataGridViewTextBoxColumn
            // 
            this.dateSarResidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateSarResidDataGridViewTextBoxColumn.DataPropertyName = "DateSarResid";
            this.dateSarResidDataGridViewTextBoxColumn.HeaderText = "تاریخ سررسید";
            this.dateSarResidDataGridViewTextBoxColumn.Name = "dateSarResidDataGridViewTextBoxColumn";
            this.dateSarResidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام بانک";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceChekDataGridViewTextBoxColumn
            // 
            this.priceChekDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceChekDataGridViewTextBoxColumn.DataPropertyName = "PriceChek";
            this.priceChekDataGridViewTextBoxColumn.HeaderText = "مبلغ چک";
            this.priceChekDataGridViewTextBoxColumn.Name = "priceChekDataGridViewTextBoxColumn";
            this.priceChekDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsDaryaftha
            // 
            this.bsDaryaftha.DataSource = typeof(Botiya.ViewDaryaftiBank);
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
            this.BtnAdd.Location = new System.Drawing.Point(535, 86);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnAdd.Size = new System.Drawing.Size(140, 42);
            this.BtnAdd.TabIndex = 23;
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
            this.BtnBack.Location = new System.Drawing.Point(535, 378);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnBack.Size = new System.Drawing.Size(140, 42);
            this.BtnBack.TabIndex = 22;
            this.BtnBack.Text = "بازگشت";
            this.BtnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBack.TextColor = System.Drawing.Color.SteelBlue;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // txtShomareQarardad
            // 
            this.txtShomareQarardad.BackColor = System.Drawing.SystemColors.Window;
            this.txtShomareQarardad.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtShomareQarardad.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtShomareQarardad.BorderRadius = 5;
            this.txtShomareQarardad.BorderSize = 2;
            this.txtShomareQarardad.Enabled = false;
            this.txtShomareQarardad.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtShomareQarardad.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtShomareQarardad.Location = new System.Drawing.Point(107, 46);
            this.txtShomareQarardad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtShomareQarardad.Multiline = false;
            this.txtShomareQarardad.Name = "txtShomareQarardad";
            this.txtShomareQarardad.Padding = new System.Windows.Forms.Padding(7);
            this.txtShomareQarardad.PasswordChar = false;
            this.txtShomareQarardad.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtShomareQarardad.PlaceholderText = "";
            this.txtShomareQarardad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtShomareQarardad.Size = new System.Drawing.Size(92, 35);
            this.txtShomareQarardad.TabIndex = 40;
            this.txtShomareQarardad.Texts = "";
            this.txtShomareQarardad.UnderlinedStyle = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(12, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 23);
            this.label9.TabIndex = 41;
            this.label9.Text = "شماره قرارداد";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(206, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "بانک";
            // 
            // bsBanks
            // 
            this.bsBanks.DataSource = typeof(Botiya.tblBank);
            // 
            // cmbBank
            // 
            this.cmbBank.BackColor = System.Drawing.Color.White;
            this.cmbBank.BorderColor = System.Drawing.Color.SteelBlue;
            this.cmbBank.BorderSize = 2;
            this.cmbBank.DataSource = this.bsBanks;
            this.cmbBank.DisplayMember = "Name";
            this.cmbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbBank.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbBank.ForeColor = System.Drawing.Color.SteelBlue;
            this.cmbBank.IconColor = System.Drawing.Color.SteelBlue;
            this.cmbBank.ListBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbBank.ListTextColor = System.Drawing.Color.SteelBlue;
            this.cmbBank.Location = new System.Drawing.Point(248, 43);
            this.cmbBank.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Padding = new System.Windows.Forms.Padding(2);
            this.cmbBank.Size = new System.Drawing.Size(200, 35);
            this.cmbBank.TabIndex = 44;
            this.cmbBank.Texts = "";
            this.cmbBank.ValueMember = "Id";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrice.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtPrice.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtPrice.BorderRadius = 5;
            this.txtPrice.BorderSize = 2;
            this.txtPrice.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPrice.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtPrice.Location = new System.Drawing.Point(52, 86);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Padding = new System.Windows.Forms.Padding(7);
            this.txtPrice.PasswordChar = false;
            this.txtPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrice.Size = new System.Drawing.Size(127, 35);
            this.txtPrice.TabIndex = 46;
            this.txtPrice.Texts = "0";
            this.txtPrice.UnderlinedStyle = true;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 23);
            this.label3.TabIndex = 47;
            this.label3.Text = "مبلغ";
            // 
            // txtShomareCheck
            // 
            this.txtShomareCheck.BackColor = System.Drawing.SystemColors.Window;
            this.txtShomareCheck.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtShomareCheck.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtShomareCheck.BorderRadius = 5;
            this.txtShomareCheck.BorderSize = 2;
            this.txtShomareCheck.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtShomareCheck.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtShomareCheck.Location = new System.Drawing.Point(260, 86);
            this.txtShomareCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtShomareCheck.Multiline = false;
            this.txtShomareCheck.Name = "txtShomareCheck";
            this.txtShomareCheck.Padding = new System.Windows.Forms.Padding(7);
            this.txtShomareCheck.PasswordChar = false;
            this.txtShomareCheck.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtShomareCheck.PlaceholderText = "";
            this.txtShomareCheck.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtShomareCheck.Size = new System.Drawing.Size(122, 35);
            this.txtShomareCheck.TabIndex = 48;
            this.txtShomareCheck.Texts = "";
            this.txtShomareCheck.UnderlinedStyle = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(186, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 49;
            this.label4.Text = "شماره چک";
            // 
            // txtDateSar
            // 
            this.txtDateSar.BackColor = System.Drawing.SystemColors.Window;
            this.txtDateSar.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtDateSar.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtDateSar.BorderRadius = 5;
            this.txtDateSar.BorderSize = 2;
            this.txtDateSar.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDateSar.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtDateSar.Location = new System.Drawing.Point(550, 39);
            this.txtDateSar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDateSar.Multiline = false;
            this.txtDateSar.Name = "txtDateSar";
            this.txtDateSar.Padding = new System.Windows.Forms.Padding(7);
            this.txtDateSar.PasswordChar = false;
            this.txtDateSar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDateSar.PlaceholderText = "1400/01/01";
            this.txtDateSar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDateSar.Size = new System.Drawing.Size(125, 35);
            this.txtDateSar.TabIndex = 50;
            this.txtDateSar.Texts = "";
            this.txtDateSar.UnderlinedStyle = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(454, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 51;
            this.label5.Text = "تاریخ سررسید";
            // 
            // lblPriceMande
            // 
            this.lblPriceMande.AutoSize = true;
            this.lblPriceMande.BackColor = System.Drawing.Color.Transparent;
            this.lblPriceMande.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPriceMande.Location = new System.Drawing.Point(315, 388);
            this.lblPriceMande.Name = "lblPriceMande";
            this.lblPriceMande.Size = new System.Drawing.Size(90, 23);
            this.lblPriceMande.TabIndex = 52;
            this.lblPriceMande.Text = "مبلغ باقی مانده";
            this.lblPriceMande.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbBankAsli
            // 
            this.cmbBankAsli.DataSource = this.bsBanks;
            this.cmbBankAsli.DisplayMember = "Name";
            this.cmbBankAsli.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbBankAsli.FormattingEnabled = true;
            this.cmbBankAsli.Location = new System.Drawing.Point(369, 43);
            this.cmbBankAsli.Margin = new System.Windows.Forms.Padding(5);
            this.cmbBankAsli.Name = "cmbBankAsli";
            this.cmbBankAsli.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbBankAsli.Size = new System.Drawing.Size(77, 31);
            this.cmbBankAsli.TabIndex = 45;
            this.cmbBankAsli.ValueMember = "Id";
            this.cmbBankAsli.Visible = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.White;
            this.BtnDelete.BackgroundColor = System.Drawing.Color.White;
            this.BtnDelete.BorderColor = System.Drawing.Color.SteelBlue;
            this.BtnDelete.BorderRadius = 12;
            this.BtnDelete.BorderSize = 2;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.Enabled = false;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDelete.Location = new System.Drawing.Point(12, 378);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnDelete.Size = new System.Drawing.Size(140, 42);
            this.BtnDelete.TabIndex = 54;
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
            this.BtnEdit.Enabled = false;
            this.BtnEdit.FlatAppearance.BorderSize = 0;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEdit.Location = new System.Drawing.Point(158, 378);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnEdit.Size = new System.Drawing.Size(140, 42);
            this.BtnEdit.TabIndex = 53;
            this.BtnEdit.Text = "ویرایش";
            this.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEdit.TextColor = System.Drawing.Color.SteelBlue;
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
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
            this.BtnOk.Location = new System.Drawing.Point(535, 86);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnOk.Size = new System.Drawing.Size(140, 42);
            this.BtnOk.TabIndex = 55;
            this.BtnOk.Text = "تایید";
            this.BtnOk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOk.TextColor = System.Drawing.Color.SteelBlue;
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Visible = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(389, 86);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCancel.Size = new System.Drawing.Size(140, 42);
            this.btnCancel.TabIndex = 56;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.TextColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // frm_Daryaftha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 425);
            this.ControlBox = false;
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.lblPriceMande);
            this.Controls.Add(this.txtDateSar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtShomareCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBankAsli);
            this.Controls.Add(this.cmbBank);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtShomareQarardad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.dgvDaryafti);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Daryaftha";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Daryaftha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaryafti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDaryaftha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDaryafti;
        private CustomControls.RJControls.RJButton BtnAdd;
        private CustomControls.RJControls.RJButton BtnBack;
        private System.Windows.Forms.BindingSource bsDaryaftha;
        private CustomControls.RJControls.RJTextBox txtShomareQarardad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bsBanks;
        private CustomControls.RJControls.RJComboBox cmbBank;
        private CustomControls.RJControls.RJTextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox txtShomareCheck;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RJTextBox txtDateSar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPriceMande;
        private System.Windows.Forms.ComboBox cmbBankAsli;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idQarardadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shomareCheckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSarResidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceChekDataGridViewTextBoxColumn;
        private CustomControls.RJControls.RJButton BtnDelete;
        private CustomControls.RJControls.RJButton BtnEdit;
        private CustomControls.RJControls.RJButton BtnOk;
        private CustomControls.RJControls.RJButton btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
namespace Botiya
{
    partial class frm_ProductInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ProductInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbVahedAsli = new System.Windows.Forms.ComboBox();
            this.txtPriceKol2 = new CustomControls.RJControls.RJTextBox();
            this.txtPriceKol1 = new CustomControls.RJControls.RJTextBox();
            this.txtPriceDastmozd2 = new CustomControls.RJControls.RJTextBox();
            this.txtPrice2 = new CustomControls.RJControls.RJTextBox();
            this.txtPriceDastmozd1 = new CustomControls.RJControls.RJTextBox();
            this.cmbVahed = new CustomControls.RJControls.RJComboBox();
            this.txtPriceKala1 = new CustomControls.RJControls.RJTextBox();
            this.txtNameKala = new CustomControls.RJControls.RJTextBox();
            this.txtCodeKala = new CustomControls.RJControls.RJTextBox();
            this.BtnBack = new CustomControls.RJControls.RJButton();
            this.BtnSave = new CustomControls.RJControls.RJButton();
            this.bsVaheds = new System.Windows.Forms.BindingSource(this.components);
            this.bsProducts = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVaheds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(580, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "جزئیات محصول";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(33, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "قیمت کالا1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(6, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "قیمت دستمزد1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(33, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "قیمت کالا2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(6, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "قیمت دستمزد2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(282, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "قیمت کل 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(282, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "قیمت کل 2";
            // 
            // cmbVahedAsli
            // 
            this.cmbVahedAsli.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProducts, "Vahed", true));
            this.cmbVahedAsli.DataSource = this.bsVaheds;
            this.cmbVahedAsli.DisplayMember = "Name";
            this.cmbVahedAsli.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbVahedAsli.FormattingEnabled = true;
            this.cmbVahedAsli.Location = new System.Drawing.Point(280, 101);
            this.cmbVahedAsli.Margin = new System.Windows.Forms.Padding(5);
            this.cmbVahedAsli.Name = "cmbVahedAsli";
            this.cmbVahedAsli.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbVahedAsli.Size = new System.Drawing.Size(250, 31);
            this.cmbVahedAsli.TabIndex = 26;
            this.cmbVahedAsli.ValueMember = "Id";
            this.cmbVahedAsli.Visible = false;
            // 
            // txtPriceKol2
            // 
            this.txtPriceKol2.BackColor = System.Drawing.SystemColors.Window;
            this.txtPriceKol2.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtPriceKol2.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtPriceKol2.BorderRadius = 5;
            this.txtPriceKol2.BorderSize = 2;
            this.txtPriceKol2.Enabled = false;
            this.txtPriceKol2.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPriceKol2.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtPriceKol2.Location = new System.Drawing.Point(362, 284);
            this.txtPriceKol2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPriceKol2.Multiline = false;
            this.txtPriceKol2.Name = "txtPriceKol2";
            this.txtPriceKol2.Padding = new System.Windows.Forms.Padding(7);
            this.txtPriceKol2.PasswordChar = false;
            this.txtPriceKol2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPriceKol2.PlaceholderText = "قیمت کل 2:";
            this.txtPriceKol2.Size = new System.Drawing.Size(169, 35);
            this.txtPriceKol2.TabIndex = 19;
            this.txtPriceKol2.Texts = "";
            this.txtPriceKol2.UnderlinedStyle = true;
            // 
            // txtPriceKol1
            // 
            this.txtPriceKol1.BackColor = System.Drawing.SystemColors.Window;
            this.txtPriceKol1.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtPriceKol1.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtPriceKol1.BorderRadius = 5;
            this.txtPriceKol1.BorderSize = 2;
            this.txtPriceKol1.Enabled = false;
            this.txtPriceKol1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPriceKol1.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtPriceKol1.Location = new System.Drawing.Point(361, 182);
            this.txtPriceKol1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPriceKol1.Multiline = false;
            this.txtPriceKol1.Name = "txtPriceKol1";
            this.txtPriceKol1.Padding = new System.Windows.Forms.Padding(7);
            this.txtPriceKol1.PasswordChar = false;
            this.txtPriceKol1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPriceKol1.PlaceholderText = "قیمت کل 1:";
            this.txtPriceKol1.Size = new System.Drawing.Size(169, 35);
            this.txtPriceKol1.TabIndex = 18;
            this.txtPriceKol1.Texts = "";
            this.txtPriceKol1.UnderlinedStyle = true;
            // 
            // txtPriceDastmozd2
            // 
            this.txtPriceDastmozd2.BackColor = System.Drawing.SystemColors.Window;
            this.txtPriceDastmozd2.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtPriceDastmozd2.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtPriceDastmozd2.BorderRadius = 5;
            this.txtPriceDastmozd2.BorderSize = 2;
            this.txtPriceDastmozd2.DataBindings.Add(new System.Windows.Forms.Binding("Texts", this.bsProducts, "PriceDastMozd2", true));
            this.txtPriceDastmozd2.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPriceDastmozd2.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtPriceDastmozd2.Location = new System.Drawing.Point(111, 317);
            this.txtPriceDastmozd2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPriceDastmozd2.Multiline = false;
            this.txtPriceDastmozd2.Name = "txtPriceDastmozd2";
            this.txtPriceDastmozd2.Padding = new System.Windows.Forms.Padding(7);
            this.txtPriceDastmozd2.PasswordChar = false;
            this.txtPriceDastmozd2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPriceDastmozd2.PlaceholderText = "قیمت دستمزد2";
            this.txtPriceDastmozd2.Size = new System.Drawing.Size(170, 35);
            this.txtPriceDastmozd2.TabIndex = 6;
            this.txtPriceDastmozd2.Texts = "";
            this.txtPriceDastmozd2.UnderlinedStyle = true;
            this.txtPriceDastmozd2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceDastmozd2_KeyPress);
            this.txtPriceDastmozd2.Leave += new System.EventHandler(this.txtPriceKala1_Leave);
            // 
            // txtPrice2
            // 
            this.txtPrice2.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrice2.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtPrice2.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtPrice2.BorderRadius = 5;
            this.txtPrice2.BorderSize = 2;
            this.txtPrice2.DataBindings.Add(new System.Windows.Forms.Binding("Texts", this.bsProducts, "PricKala2", true));
            this.txtPrice2.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPrice2.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtPrice2.Location = new System.Drawing.Point(111, 272);
            this.txtPrice2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice2.Multiline = false;
            this.txtPrice2.Name = "txtPrice2";
            this.txtPrice2.Padding = new System.Windows.Forms.Padding(7);
            this.txtPrice2.PasswordChar = false;
            this.txtPrice2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrice2.PlaceholderText = "قیمت 2";
            this.txtPrice2.Size = new System.Drawing.Size(170, 35);
            this.txtPrice2.TabIndex = 5;
            this.txtPrice2.Texts = "";
            this.txtPrice2.UnderlinedStyle = true;
            this.txtPrice2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice2_KeyPress);
            this.txtPrice2.Leave += new System.EventHandler(this.txtPriceKala1_Leave);
            // 
            // txtPriceDastmozd1
            // 
            this.txtPriceDastmozd1.BackColor = System.Drawing.SystemColors.Window;
            this.txtPriceDastmozd1.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtPriceDastmozd1.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtPriceDastmozd1.BorderRadius = 5;
            this.txtPriceDastmozd1.BorderSize = 2;
            this.txtPriceDastmozd1.DataBindings.Add(new System.Windows.Forms.Binding("Texts", this.bsProducts, "PriceDastMozd1", true));
            this.txtPriceDastmozd1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPriceDastmozd1.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtPriceDastmozd1.Location = new System.Drawing.Point(111, 215);
            this.txtPriceDastmozd1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPriceDastmozd1.Multiline = false;
            this.txtPriceDastmozd1.Name = "txtPriceDastmozd1";
            this.txtPriceDastmozd1.Padding = new System.Windows.Forms.Padding(7);
            this.txtPriceDastmozd1.PasswordChar = false;
            this.txtPriceDastmozd1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPriceDastmozd1.PlaceholderText = "قیمت دستمزد1";
            this.txtPriceDastmozd1.Size = new System.Drawing.Size(168, 35);
            this.txtPriceDastmozd1.TabIndex = 4;
            this.txtPriceDastmozd1.Texts = "";
            this.txtPriceDastmozd1.UnderlinedStyle = true;
            this.txtPriceDastmozd1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceDastmozd1_KeyPress);
            this.txtPriceDastmozd1.Leave += new System.EventHandler(this.txtPriceKala1_Leave);
            // 
            // cmbVahed
            // 
            this.cmbVahed.BackColor = System.Drawing.Color.White;
            this.cmbVahed.BorderColor = System.Drawing.Color.SteelBlue;
            this.cmbVahed.BorderSize = 2;
            this.cmbVahed.DataSource = this.bsVaheds;
            this.cmbVahed.DisplayMember = "Name";
            this.cmbVahed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbVahed.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbVahed.ForeColor = System.Drawing.Color.SteelBlue;
            this.cmbVahed.IconColor = System.Drawing.Color.SteelBlue;
            this.cmbVahed.ListBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbVahed.ListTextColor = System.Drawing.Color.SteelBlue;
            this.cmbVahed.Location = new System.Drawing.Point(281, 51);
            this.cmbVahed.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbVahed.Name = "cmbVahed";
            this.cmbVahed.Padding = new System.Windows.Forms.Padding(2);
            this.cmbVahed.Size = new System.Drawing.Size(250, 42);
            this.cmbVahed.TabIndex = 1;
            this.cmbVahed.Texts = "";
            this.cmbVahed.ValueMember = "Id";
            // 
            // txtPriceKala1
            // 
            this.txtPriceKala1.BackColor = System.Drawing.SystemColors.Window;
            this.txtPriceKala1.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtPriceKala1.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtPriceKala1.BorderRadius = 5;
            this.txtPriceKala1.BorderSize = 2;
            this.txtPriceKala1.DataBindings.Add(new System.Windows.Forms.Binding("Texts", this.bsProducts, "PriceKala1", true));
            this.txtPriceKala1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPriceKala1.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtPriceKala1.Location = new System.Drawing.Point(111, 170);
            this.txtPriceKala1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPriceKala1.Multiline = false;
            this.txtPriceKala1.Name = "txtPriceKala1";
            this.txtPriceKala1.Padding = new System.Windows.Forms.Padding(7);
            this.txtPriceKala1.PasswordChar = false;
            this.txtPriceKala1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPriceKala1.PlaceholderText = "قیمت 1";
            this.txtPriceKala1.Size = new System.Drawing.Size(169, 35);
            this.txtPriceKala1.TabIndex = 3;
            this.txtPriceKala1.Texts = "";
            this.txtPriceKala1.UnderlinedStyle = true;
            this.txtPriceKala1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceKala1_KeyPress);
            this.txtPriceKala1.Leave += new System.EventHandler(this.txtPriceKala1_Leave);
            // 
            // txtNameKala
            // 
            this.txtNameKala.BackColor = System.Drawing.SystemColors.Window;
            this.txtNameKala.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtNameKala.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtNameKala.BorderRadius = 5;
            this.txtNameKala.BorderSize = 2;
            this.txtNameKala.DataBindings.Add(new System.Windows.Forms.Binding("Texts", this.bsProducts, "Name", true));
            this.txtNameKala.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNameKala.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtNameKala.Location = new System.Drawing.Point(13, 108);
            this.txtNameKala.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNameKala.Multiline = false;
            this.txtNameKala.Name = "txtNameKala";
            this.txtNameKala.Padding = new System.Windows.Forms.Padding(7);
            this.txtNameKala.PasswordChar = false;
            this.txtNameKala.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNameKala.PlaceholderText = "نام کالا";
            this.txtNameKala.Size = new System.Drawing.Size(518, 35);
            this.txtNameKala.TabIndex = 2;
            this.txtNameKala.Texts = "";
            this.txtNameKala.UnderlinedStyle = true;
            // 
            // txtCodeKala
            // 
            this.txtCodeKala.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodeKala.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtCodeKala.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtCodeKala.BorderRadius = 5;
            this.txtCodeKala.BorderSize = 2;
            this.txtCodeKala.DataBindings.Add(new System.Windows.Forms.Binding("Texts", this.bsProducts, "CodeId", true));
            this.txtCodeKala.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCodeKala.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtCodeKala.Location = new System.Drawing.Point(13, 51);
            this.txtCodeKala.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodeKala.Multiline = false;
            this.txtCodeKala.Name = "txtCodeKala";
            this.txtCodeKala.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodeKala.PasswordChar = false;
            this.txtCodeKala.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodeKala.PlaceholderText = "کدکالا";
            this.txtCodeKala.Size = new System.Drawing.Size(250, 35);
            this.txtCodeKala.TabIndex = 0;
            this.txtCodeKala.Texts = "";
            this.txtCodeKala.UnderlinedStyle = true;
            this.txtCodeKala.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeKala_KeyPress);
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
            this.BtnBack.Location = new System.Drawing.Point(428, 371);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnBack.Size = new System.Drawing.Size(140, 42);
            this.BtnBack.TabIndex = 8;
            this.BtnBack.Text = "بازگشت";
            this.BtnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBack.TextColor = System.Drawing.Color.SteelBlue;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.White;
            this.BtnSave.BackgroundColor = System.Drawing.Color.White;
            this.BtnSave.BorderColor = System.Drawing.Color.SteelBlue;
            this.BtnSave.BorderRadius = 12;
            this.BtnSave.BorderSize = 2;
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.Location = new System.Drawing.Point(12, 371);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnSave.Size = new System.Drawing.Size(140, 42);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "ذخیره";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.TextColor = System.Drawing.Color.SteelBlue;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // bsVaheds
            // 
            this.bsVaheds.DataSource = typeof(Botiya.Vahed);
            // 
            // bsProducts
            // 
            this.bsProducts.DataSource = typeof(Botiya.Product);
            // 
            // frm_ProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 425);
            this.ControlBox = false;
            this.Controls.Add(this.cmbVahedAsli);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPriceKol2);
            this.Controls.Add(this.txtPriceKol1);
            this.Controls.Add(this.txtPriceDastmozd2);
            this.Controls.Add(this.txtPrice2);
            this.Controls.Add(this.txtPriceDastmozd1);
            this.Controls.Add(this.cmbVahed);
            this.Controls.Add(this.txtPriceKala1);
            this.Controls.Add(this.txtNameKala);
            this.Controls.Add(this.txtCodeKala);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_ProductInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_ProductInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVaheds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox txtCodeKala;
        private CustomControls.RJControls.RJButton BtnBack;
        private CustomControls.RJControls.RJButton BtnSave;
        private CustomControls.RJControls.RJTextBox txtNameKala;
        private CustomControls.RJControls.RJTextBox txtPriceKala1;
        private CustomControls.RJControls.RJComboBox cmbVahed;
        private CustomControls.RJControls.RJTextBox txtPriceDastmozd1;
        private CustomControls.RJControls.RJTextBox txtPrice2;
        private CustomControls.RJControls.RJTextBox txtPriceDastmozd2;
        private CustomControls.RJControls.RJTextBox txtPriceKol1;
        private CustomControls.RJControls.RJTextBox txtPriceKol2;
        private System.Windows.Forms.BindingSource bsVaheds;
        private System.Windows.Forms.BindingSource bsProducts;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbVahedAsli;
    }
}
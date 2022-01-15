namespace Botiya
{
    partial class frm_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Settings));
            this.txtAddress = new CustomControls.RJControls.RJTextBox();
            this.bsSetting = new System.Windows.Forms.BindingSource(this.components);
            this.txtCodePosti = new CustomControls.RJControls.RJTextBox();
            this.txtCodeMelliNamayande = new CustomControls.RJControls.RJTextBox();
            this.txtNameNamayande = new CustomControls.RJControls.RJTextBox();
            this.txtSematNamayande = new CustomControls.RJControls.RJTextBox();
            this.txtFamilyNamayande = new CustomControls.RJControls.RJTextBox();
            this.txtCodeEqtesadi = new CustomControls.RJControls.RJTextBox();
            this.txtShomareSabt = new CustomControls.RJControls.RJTextBox();
            this.txtNameSherkat = new CustomControls.RJControls.RJTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaliyat = new CustomControls.RJControls.RJTextBox();
            this.BtnBack = new CustomControls.RJControls.RJButton();
            this.BtnSave = new CustomControls.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtAddress.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtAddress.BorderRadius = 5;
            this.txtAddress.BorderSize = 2;
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Texts", this.bsSetting, "Address", true));
            this.txtAddress.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtAddress.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtAddress.Location = new System.Drawing.Point(90, 279);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new System.Windows.Forms.Padding(7);
            this.txtAddress.PasswordChar = false;
            this.txtAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.Size = new System.Drawing.Size(436, 99);
            this.txtAddress.TabIndex = 8;
            this.txtAddress.Texts = "";
            this.txtAddress.UnderlinedStyle = true;
            // 
            // bsSetting
            // 
            this.bsSetting.DataSource = typeof(Botiya.tblSetting);
            // 
            // txtCodePosti
            // 
            this.txtCodePosti.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodePosti.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtCodePosti.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtCodePosti.BorderRadius = 5;
            this.txtCodePosti.BorderSize = 2;
            this.txtCodePosti.DataBindings.Add(new System.Windows.Forms.Binding("Texts", this.bsSetting, "CodePosti", true));
            this.txtCodePosti.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCodePosti.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtCodePosti.Location = new System.Drawing.Point(90, 235);
            this.txtCodePosti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodePosti.Multiline = false;
            this.txtCodePosti.Name = "txtCodePosti";
            this.txtCodePosti.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodePosti.PasswordChar = false;
            this.txtCodePosti.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodePosti.PlaceholderText = "";
            this.txtCodePosti.Size = new System.Drawing.Size(111, 35);
            this.txtCodePosti.TabIndex = 7;
            this.txtCodePosti.Texts = "";
            this.txtCodePosti.UnderlinedStyle = true;
            this.txtCodePosti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodePosti_KeyPress);
            // 
            // txtCodeMelliNamayande
            // 
            this.txtCodeMelliNamayande.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodeMelliNamayande.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtCodeMelliNamayande.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtCodeMelliNamayande.BorderRadius = 5;
            this.txtCodeMelliNamayande.BorderSize = 2;
            this.txtCodeMelliNamayande.DataBindings.Add(new System.Windows.Forms.Binding("Texts", this.bsSetting, "CodeMelliNamayande", true));
            this.txtCodeMelliNamayande.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCodeMelliNamayande.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtCodeMelliNamayande.Location = new System.Drawing.Point(107, 185);
            this.txtCodeMelliNamayande.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodeMelliNamayande.Multiline = false;
            this.txtCodeMelliNamayande.Name = "txtCodeMelliNamayande";
            this.txtCodeMelliNamayande.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodeMelliNamayande.PasswordChar = false;
            this.txtCodeMelliNamayande.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodeMelliNamayande.PlaceholderText = "";
            this.txtCodeMelliNamayande.Size = new System.Drawing.Size(111, 35);
            this.txtCodeMelliNamayande.TabIndex = 5;
            this.txtCodeMelliNamayande.Texts = "";
            this.txtCodeMelliNamayande.UnderlinedStyle = true;
            this.txtCodeMelliNamayande.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeMelliNamayande_KeyPress);
            // 
            // txtNameNamayande
            // 
            this.txtNameNamayande.BackColor = System.Drawing.SystemColors.Window;
            this.txtNameNamayande.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtNameNamayande.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtNameNamayande.BorderRadius = 5;
            this.txtNameNamayande.BorderSize = 2;
            this.txtNameNamayande.DataBindings.Add(new System.Windows.Forms.Binding("Texts", this.bsSetting, "NameNamayande", true));
            this.txtNameNamayande.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNameNamayande.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtNameNamayande.Location = new System.Drawing.Point(128, 140);
            this.txtNameNamayande.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNameNamayande.Multiline = false;
            this.txtNameNamayande.Name = "txtNameNamayande";
            this.txtNameNamayande.Padding = new System.Windows.Forms.Padding(7);
            this.txtNameNamayande.PasswordChar = false;
            this.txtNameNamayande.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNameNamayande.PlaceholderText = "";
            this.txtNameNamayande.Size = new System.Drawing.Size(111, 35);
            this.txtNameNamayande.TabIndex = 3;
            this.txtNameNamayande.Texts = "";
            this.txtNameNamayande.UnderlinedStyle = true;
            // 
            // txtSematNamayande
            // 
            this.txtSematNamayande.BackColor = System.Drawing.SystemColors.Window;
            this.txtSematNamayande.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtSematNamayande.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtSematNamayande.BorderRadius = 5;
            this.txtSematNamayande.BorderSize = 2;
            this.txtSematNamayande.DataBindings.Add(new System.Windows.Forms.Binding("Texts", this.bsSetting, "SematNamayande", true));
            this.txtSematNamayande.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSematNamayande.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtSematNamayande.Location = new System.Drawing.Point(338, 189);
            this.txtSematNamayande.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSematNamayande.Multiline = false;
            this.txtSematNamayande.Name = "txtSematNamayande";
            this.txtSematNamayande.Padding = new System.Windows.Forms.Padding(7);
            this.txtSematNamayande.PasswordChar = false;
            this.txtSematNamayande.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSematNamayande.PlaceholderText = "";
            this.txtSematNamayande.Size = new System.Drawing.Size(186, 35);
            this.txtSematNamayande.TabIndex = 6;
            this.txtSematNamayande.Texts = "";
            this.txtSematNamayande.UnderlinedStyle = true;
            // 
            // txtFamilyNamayande
            // 
            this.txtFamilyNamayande.BackColor = System.Drawing.SystemColors.Window;
            this.txtFamilyNamayande.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtFamilyNamayande.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtFamilyNamayande.BorderRadius = 5;
            this.txtFamilyNamayande.BorderSize = 2;
            this.txtFamilyNamayande.DataBindings.Add(new System.Windows.Forms.Binding("Texts", this.bsSetting, "FamilyNamyande", true));
            this.txtFamilyNamayande.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFamilyNamayande.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtFamilyNamayande.Location = new System.Drawing.Point(373, 144);
            this.txtFamilyNamayande.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFamilyNamayande.Multiline = false;
            this.txtFamilyNamayande.Name = "txtFamilyNamayande";
            this.txtFamilyNamayande.Padding = new System.Windows.Forms.Padding(7);
            this.txtFamilyNamayande.PasswordChar = false;
            this.txtFamilyNamayande.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFamilyNamayande.PlaceholderText = "";
            this.txtFamilyNamayande.Size = new System.Drawing.Size(153, 35);
            this.txtFamilyNamayande.TabIndex = 4;
            this.txtFamilyNamayande.Texts = "";
            this.txtFamilyNamayande.UnderlinedStyle = true;
            // 
            // txtCodeEqtesadi
            // 
            this.txtCodeEqtesadi.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodeEqtesadi.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtCodeEqtesadi.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtCodeEqtesadi.BorderRadius = 5;
            this.txtCodeEqtesadi.BorderSize = 2;
            this.txtCodeEqtesadi.DataBindings.Add(new System.Windows.Forms.Binding("Texts", this.bsSetting, "CodeEqtesadi", true));
            this.txtCodeEqtesadi.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCodeEqtesadi.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtCodeEqtesadi.Location = new System.Drawing.Point(373, 99);
            this.txtCodeEqtesadi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodeEqtesadi.Multiline = false;
            this.txtCodeEqtesadi.Name = "txtCodeEqtesadi";
            this.txtCodeEqtesadi.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodeEqtesadi.PasswordChar = false;
            this.txtCodeEqtesadi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodeEqtesadi.PlaceholderText = "";
            this.txtCodeEqtesadi.Size = new System.Drawing.Size(153, 35);
            this.txtCodeEqtesadi.TabIndex = 2;
            this.txtCodeEqtesadi.Texts = "";
            this.txtCodeEqtesadi.UnderlinedStyle = true;
            // 
            // txtShomareSabt
            // 
            this.txtShomareSabt.BackColor = System.Drawing.SystemColors.Window;
            this.txtShomareSabt.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtShomareSabt.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtShomareSabt.BorderRadius = 5;
            this.txtShomareSabt.BorderSize = 2;
            this.txtShomareSabt.DataBindings.Add(new System.Windows.Forms.Binding("Texts", this.bsSetting, "ShomareSabt", true));
            this.txtShomareSabt.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtShomareSabt.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtShomareSabt.Location = new System.Drawing.Point(130, 95);
            this.txtShomareSabt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtShomareSabt.Multiline = false;
            this.txtShomareSabt.Name = "txtShomareSabt";
            this.txtShomareSabt.Padding = new System.Windows.Forms.Padding(7);
            this.txtShomareSabt.PasswordChar = false;
            this.txtShomareSabt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtShomareSabt.PlaceholderText = "";
            this.txtShomareSabt.Size = new System.Drawing.Size(153, 35);
            this.txtShomareSabt.TabIndex = 1;
            this.txtShomareSabt.Texts = "";
            this.txtShomareSabt.UnderlinedStyle = true;
            // 
            // txtNameSherkat
            // 
            this.txtNameSherkat.BackColor = System.Drawing.SystemColors.Window;
            this.txtNameSherkat.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtNameSherkat.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtNameSherkat.BorderRadius = 5;
            this.txtNameSherkat.BorderSize = 2;
            this.txtNameSherkat.DataBindings.Add(new System.Windows.Forms.Binding("Texts", this.bsSetting, "Name", true));
            this.txtNameSherkat.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNameSherkat.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtNameSherkat.Location = new System.Drawing.Point(90, 54);
            this.txtNameSherkat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNameSherkat.Multiline = false;
            this.txtNameSherkat.Name = "txtNameSherkat";
            this.txtNameSherkat.Padding = new System.Windows.Forms.Padding(7);
            this.txtNameSherkat.PasswordChar = false;
            this.txtNameSherkat.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNameSherkat.PlaceholderText = "";
            this.txtNameSherkat.Size = new System.Drawing.Size(436, 35);
            this.txtNameSherkat.TabIndex = 0;
            this.txtNameSherkat.Texts = "";
            this.txtNameSherkat.UnderlinedStyle = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(12, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 23);
            this.label11.TabIndex = 54;
            this.label11.Text = "درصد مالیات بر ارزش افزوده";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(248, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 23);
            this.label10.TabIndex = 53;
            this.label10.Text = "سمت نماینده";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(14, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 23);
            this.label9.TabIndex = 52;
            this.label9.Text = "کدملی نماینده";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(248, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 23);
            this.label8.TabIndex = 51;
            this.label8.Text = "نام خانوادگی نماینده";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(14, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 23);
            this.label7.TabIndex = 50;
            this.label7.Text = "نام نماینده شرکت";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(290, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 49;
            this.label6.Text = "کد اقتصادی";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(14, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 23);
            this.label5.TabIndex = 48;
            this.label5.Text = "کد پستی";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(14, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 23);
            this.label4.TabIndex = 47;
            this.label4.Text = "آدرس";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(14, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 46;
            this.label3.Text = "شماره ثبت شرکت";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(14, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 45;
            this.label2.Text = "نام شرکت";
            // 
            // txtMaliyat
            // 
            this.txtMaliyat.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaliyat.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtMaliyat.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtMaliyat.BorderRadius = 5;
            this.txtMaliyat.BorderSize = 2;
            this.txtMaliyat.DataBindings.Add(new System.Windows.Forms.Binding("Texts", this.bsSetting, "Maliyat", true));
            this.txtMaliyat.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtMaliyat.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtMaliyat.Location = new System.Drawing.Point(189, 388);
            this.txtMaliyat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaliyat.Multiline = false;
            this.txtMaliyat.Name = "txtMaliyat";
            this.txtMaliyat.Padding = new System.Windows.Forms.Padding(7);
            this.txtMaliyat.PasswordChar = false;
            this.txtMaliyat.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaliyat.PlaceholderText = "فقط عدد وارد کنید";
            this.txtMaliyat.Size = new System.Drawing.Size(118, 35);
            this.txtMaliyat.TabIndex = 9;
            this.txtMaliyat.Texts = "";
            this.txtMaliyat.UnderlinedStyle = true;
            this.txtMaliyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaliyat_KeyPress);
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
            this.BtnBack.Location = new System.Drawing.Point(386, 442);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnBack.Size = new System.Drawing.Size(140, 42);
            this.BtnBack.TabIndex = 11;
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
            this.BtnSave.Location = new System.Drawing.Point(18, 442);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnSave.Size = new System.Drawing.Size(140, 42);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "ذخیره";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.TextColor = System.Drawing.Color.SteelBlue;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
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
            this.label1.Size = new System.Drawing.Size(547, 34);
            this.label1.TabIndex = 41;
            this.label1.Text = "تعیین مالیات بر ارزش افزوده";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 496);
            this.ControlBox = false;
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCodePosti);
            this.Controls.Add(this.txtCodeMelliNamayande);
            this.Controls.Add(this.txtNameNamayande);
            this.Controls.Add(this.txtSematNamayande);
            this.Controls.Add(this.txtFamilyNamayande);
            this.Controls.Add(this.txtCodeEqtesadi);
            this.Controls.Add(this.txtShomareSabt);
            this.Controls.Add(this.txtNameSherkat);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaliyat);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Settings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsSetting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJTextBox txtAddress;
        private CustomControls.RJControls.RJTextBox txtCodePosti;
        private CustomControls.RJControls.RJTextBox txtCodeMelliNamayande;
        private CustomControls.RJControls.RJTextBox txtNameNamayande;
        private CustomControls.RJControls.RJTextBox txtSematNamayande;
        private CustomControls.RJControls.RJTextBox txtFamilyNamayande;
        private CustomControls.RJControls.RJTextBox txtCodeEqtesadi;
        private CustomControls.RJControls.RJTextBox txtShomareSabt;
        private CustomControls.RJControls.RJTextBox txtNameSherkat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJTextBox txtMaliyat;
        private CustomControls.RJControls.RJButton BtnBack;
        private CustomControls.RJControls.RJButton BtnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsSetting;
    }
}
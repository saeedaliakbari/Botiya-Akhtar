namespace Botiya
{
    partial class frm_PersonInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PersonInfo));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBack = new CustomControls.RJControls.RJButton();
            this.BtnSave = new CustomControls.RJControls.RJButton();
            this.txtSherkatName = new CustomControls.RJControls.RJTextBox();
            this.bsPerson = new System.Windows.Forms.BindingSource(this.components);
            this.TgbHoghoghi = new CustomControls.RJControls.RJToggleButton();
            this.txtFatherName = new CustomControls.RJControls.RJTextBox();
            this.txtfName = new CustomControls.RJControls.RJTextBox();
            this.txtMobile = new CustomControls.RJControls.RJTextBox();
            this.txtLName = new CustomControls.RJControls.RJTextBox();
            this.txtPhone = new CustomControls.RJControls.RJTextBox();
            this.txtCodeMelli = new CustomControls.RJControls.RJTextBox();
            this.txtAddress = new CustomControls.RJControls.RJTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "حقوقی";
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
            this.label1.Size = new System.Drawing.Size(672, 34);
            this.label1.TabIndex = 29;
            this.label1.Text = "مشتریان";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.BtnBack.Location = new System.Drawing.Point(506, 349);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnBack.Size = new System.Drawing.Size(140, 42);
            this.BtnBack.TabIndex = 10;
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
            this.BtnSave.Location = new System.Drawing.Point(32, 349);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnSave.Size = new System.Drawing.Size(140, 42);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "ذخیره";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.TextColor = System.Drawing.Color.SteelBlue;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtSherkatName
            // 
            this.txtSherkatName.BackColor = System.Drawing.SystemColors.Window;
            this.txtSherkatName.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtSherkatName.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtSherkatName.BorderRadius = 5;
            this.txtSherkatName.BorderSize = 2;
            this.txtSherkatName.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSherkatName.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtSherkatName.Location = new System.Drawing.Point(365, 65);
            this.txtSherkatName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSherkatName.Multiline = false;
            this.txtSherkatName.Name = "txtSherkatName";
            this.txtSherkatName.Padding = new System.Windows.Forms.Padding(7);
            this.txtSherkatName.PasswordChar = false;
            this.txtSherkatName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSherkatName.PlaceholderText = "نام شرکت";
            this.txtSherkatName.Size = new System.Drawing.Size(281, 35);
            this.txtSherkatName.TabIndex = 8;
            this.txtSherkatName.Texts = "";
            this.txtSherkatName.UnderlinedStyle = true;
            // 
            // bsPerson
            // 
            this.bsPerson.DataSource = typeof(Botiya.Person);
            // 
            // TgbHoghoghi
            // 
            this.TgbHoghoghi.AutoSize = true;
            this.TgbHoghoghi.Location = new System.Drawing.Point(81, 65);
            this.TgbHoghoghi.MinimumSize = new System.Drawing.Size(45, 22);
            this.TgbHoghoghi.Name = "TgbHoghoghi";
            this.TgbHoghoghi.OffBackColor = System.Drawing.Color.Gray;
            this.TgbHoghoghi.OffToggleColor = System.Drawing.Color.White;
            this.TgbHoghoghi.OnBackColor = System.Drawing.Color.SteelBlue;
            this.TgbHoghoghi.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.TgbHoghoghi.Size = new System.Drawing.Size(45, 22);
            this.TgbHoghoghi.TabIndex = 7;
            this.TgbHoghoghi.UseVisualStyleBackColor = true;
            // 
            // txtFatherName
            // 
            this.txtFatherName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFatherName.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtFatherName.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtFatherName.BorderRadius = 5;
            this.txtFatherName.BorderSize = 2;
            this.txtFatherName.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFatherName.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtFatherName.Location = new System.Drawing.Point(32, 150);
            this.txtFatherName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFatherName.Multiline = false;
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Padding = new System.Windows.Forms.Padding(7);
            this.txtFatherName.PasswordChar = false;
            this.txtFatherName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFatherName.PlaceholderText = "نام پدر";
            this.txtFatherName.Size = new System.Drawing.Size(281, 35);
            this.txtFatherName.TabIndex = 2;
            this.txtFatherName.Texts = "";
            this.txtFatherName.UnderlinedStyle = true;
            // 
            // txtfName
            // 
            this.txtfName.BackColor = System.Drawing.SystemColors.Window;
            this.txtfName.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtfName.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtfName.BorderRadius = 5;
            this.txtfName.BorderSize = 2;
            this.txtfName.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtfName.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtfName.Location = new System.Drawing.Point(32, 105);
            this.txtfName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtfName.Multiline = false;
            this.txtfName.Name = "txtfName";
            this.txtfName.Padding = new System.Windows.Forms.Padding(7);
            this.txtfName.PasswordChar = false;
            this.txtfName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtfName.PlaceholderText = "نام";
            this.txtfName.Size = new System.Drawing.Size(281, 35);
            this.txtfName.TabIndex = 0;
            this.txtfName.Texts = "";
            this.txtfName.UnderlinedStyle = true;
            // 
            // txtMobile
            // 
            this.txtMobile.BackColor = System.Drawing.SystemColors.Window;
            this.txtMobile.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtMobile.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtMobile.BorderRadius = 5;
            this.txtMobile.BorderSize = 2;
            this.txtMobile.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtMobile.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtMobile.Location = new System.Drawing.Point(365, 204);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMobile.Multiline = false;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Padding = new System.Windows.Forms.Padding(7);
            this.txtMobile.PasswordChar = false;
            this.txtMobile.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMobile.PlaceholderText = "شماره همراه";
            this.txtMobile.Size = new System.Drawing.Size(281, 35);
            this.txtMobile.TabIndex = 5;
            this.txtMobile.Texts = "";
            this.txtMobile.UnderlinedStyle = true;
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
            this.txtLName.Location = new System.Drawing.Point(365, 105);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLName.Multiline = false;
            this.txtLName.Name = "txtLName";
            this.txtLName.Padding = new System.Windows.Forms.Padding(7);
            this.txtLName.PasswordChar = false;
            this.txtLName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLName.PlaceholderText = "نام خانوادگی";
            this.txtLName.Size = new System.Drawing.Size(281, 35);
            this.txtLName.TabIndex = 1;
            this.txtLName.Texts = "";
            this.txtLName.UnderlinedStyle = true;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhone.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtPhone.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtPhone.BorderRadius = 5;
            this.txtPhone.BorderSize = 2;
            this.txtPhone.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPhone.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtPhone.Location = new System.Drawing.Point(32, 204);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(7);
            this.txtPhone.PasswordChar = false;
            this.txtPhone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPhone.PlaceholderText = "شماره تماس";
            this.txtPhone.Size = new System.Drawing.Size(281, 35);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.Texts = "";
            this.txtPhone.UnderlinedStyle = true;
            // 
            // txtCodeMelli
            // 
            this.txtCodeMelli.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodeMelli.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtCodeMelli.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtCodeMelli.BorderRadius = 5;
            this.txtCodeMelli.BorderSize = 2;
            this.txtCodeMelli.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCodeMelli.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtCodeMelli.Location = new System.Drawing.Point(365, 150);
            this.txtCodeMelli.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodeMelli.Multiline = false;
            this.txtCodeMelli.Name = "txtCodeMelli";
            this.txtCodeMelli.Padding = new System.Windows.Forms.Padding(7);
            this.txtCodeMelli.PasswordChar = false;
            this.txtCodeMelli.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCodeMelli.PlaceholderText = "کدملی";
            this.txtCodeMelli.Size = new System.Drawing.Size(281, 35);
            this.txtCodeMelli.TabIndex = 3;
            this.txtCodeMelli.Texts = "";
            this.txtCodeMelli.UnderlinedStyle = true;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtAddress.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtAddress.BorderRadius = 5;
            this.txtAddress.BorderSize = 2;
            this.txtAddress.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtAddress.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtAddress.Location = new System.Drawing.Point(32, 260);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new System.Windows.Forms.Padding(7);
            this.txtAddress.PasswordChar = false;
            this.txtAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAddress.PlaceholderText = "آدرس";
            this.txtAddress.Size = new System.Drawing.Size(614, 70);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.Texts = "";
            this.txtAddress.UnderlinedStyle = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_PersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 409);
            this.ControlBox = false;
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.txtSherkatName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TgbHoghoghi);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtfName);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCodeMelli);
            this.Controls.Add(this.txtAddress);
            this.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_PersonInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_PersonInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJToggleButton TgbHoghoghi;
        private CustomControls.RJControls.RJTextBox txtFatherName;
        private CustomControls.RJControls.RJTextBox txtfName;
        private CustomControls.RJControls.RJTextBox txtMobile;
        private CustomControls.RJControls.RJTextBox txtLName;
        private CustomControls.RJControls.RJTextBox txtPhone;
        private CustomControls.RJControls.RJTextBox txtCodeMelli;
        private CustomControls.RJControls.RJTextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox txtSherkatName;
        private CustomControls.RJControls.RJButton BtnBack;
        private CustomControls.RJControls.RJButton BtnSave;
        private System.Windows.Forms.BindingSource bsPerson;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
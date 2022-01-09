namespace Botiya
{
    partial class frm_Qarardadha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Qarardadha));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvQarardad = new System.Windows.Forms.DataGridView();
            this.bsViewQarardadPerson = new System.Windows.Forms.BindingSource(this.components);
            this.BtnBack = new CustomControls.RJControls.RJButton();
            this.BtnDelete = new CustomControls.RJControls.RJButton();
            this.BtnEdit = new CustomControls.RJControls.RJButton();
            this.BtnAdd = new CustomControls.RJControls.RJButton();
            this.btnPrint = new CustomControls.RJControls.RJButton();
            this.txtSearchFamily = new CustomControls.RJControls.RJTextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeMelliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sherkatNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceHamlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idQarardadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mozoQarardadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modatQarardadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shomareEnsheabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEnsheabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doreTazminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modatRafeNaghzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceJarimeTakhirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQarardad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsViewQarardadPerson)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(998, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "قراردادها";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvQarardad
            // 
            this.dgvQarardad.AllowUserToAddRows = false;
            this.dgvQarardad.AllowUserToDeleteRows = false;
            this.dgvQarardad.AutoGenerateColumns = false;
            this.dgvQarardad.BackgroundColor = System.Drawing.Color.White;
            this.dgvQarardad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQarardad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idPersonDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.codeMelliDataGridViewTextBoxColumn,
            this.sherkatNameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.priceHamlDataGridViewTextBoxColumn,
            this.idQarardadDataGridViewTextBoxColumn,
            this.mozoQarardadDataGridViewTextBoxColumn,
            this.modatQarardadDataGridViewTextBoxColumn,
            this.shomareEnsheabDataGridViewTextBoxColumn,
            this.dateEnsheabDataGridViewTextBoxColumn,
            this.doreTazminDataGridViewTextBoxColumn,
            this.modatRafeNaghzDataGridViewTextBoxColumn,
            this.priceJarimeTakhirDataGridViewTextBoxColumn});
            this.dgvQarardad.DataSource = this.bsViewQarardadPerson;
            this.dgvQarardad.GridColor = System.Drawing.Color.Chocolate;
            this.dgvQarardad.Location = new System.Drawing.Point(12, 50);
            this.dgvQarardad.Name = "dgvQarardad";
            this.dgvQarardad.ReadOnly = true;
            this.dgvQarardad.Size = new System.Drawing.Size(974, 528);
            this.dgvQarardad.TabIndex = 19;
            // 
            // bsViewQarardadPerson
            // 
            this.bsViewQarardadPerson.DataSource = typeof(Botiya.ViewQarardadPerson);
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
            this.BtnBack.Location = new System.Drawing.Point(846, 584);
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
            this.BtnDelete.Location = new System.Drawing.Point(304, 584);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnDelete.Size = new System.Drawing.Size(140, 42);
            this.BtnDelete.TabIndex = 21;
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
            this.BtnEdit.Location = new System.Drawing.Point(158, 584);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnEdit.Size = new System.Drawing.Size(140, 42);
            this.BtnEdit.TabIndex = 20;
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
            this.BtnAdd.Location = new System.Drawing.Point(12, 584);
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
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.BackgroundColor = System.Drawing.Color.White;
            this.btnPrint.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnPrint.BorderRadius = 12;
            this.btnPrint.BorderSize = 2;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(700, 584);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnPrint.Size = new System.Drawing.Size(140, 42);
            this.btnPrint.TabIndex = 24;
            this.btnPrint.Text = "پرینت";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.TextColor = System.Drawing.Color.SteelBlue;
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // txtSearchFamily
            // 
            this.txtSearchFamily.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchFamily.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtSearchFamily.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtSearchFamily.BorderRadius = 5;
            this.txtSearchFamily.BorderSize = 2;
            this.txtSearchFamily.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearchFamily.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtSearchFamily.Location = new System.Drawing.Point(451, 589);
            this.txtSearchFamily.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchFamily.Multiline = false;
            this.txtSearchFamily.Name = "txtSearchFamily";
            this.txtSearchFamily.Padding = new System.Windows.Forms.Padding(7);
            this.txtSearchFamily.PasswordChar = false;
            this.txtSearchFamily.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearchFamily.PlaceholderText = "جستجو براساس نام خانوادگی یا نام شرکت";
            this.txtSearchFamily.Size = new System.Drawing.Size(242, 35);
            this.txtSearchFamily.TabIndex = 25;
            this.txtSearchFamily.Texts = "";
            this.txtSearchFamily.UnderlinedStyle = true;
            this.txtSearchFamily._TextChanged += new System.EventHandler(this.txtSearchFamily__TextChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idPersonDataGridViewTextBoxColumn
            // 
            this.idPersonDataGridViewTextBoxColumn.DataPropertyName = "IdPerson";
            this.idPersonDataGridViewTextBoxColumn.HeaderText = "IdPerson";
            this.idPersonDataGridViewTextBoxColumn.Name = "idPersonDataGridViewTextBoxColumn";
            this.idPersonDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPersonDataGridViewTextBoxColumn.Visible = false;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "FName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "نام";
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            this.fNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "LName";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "نام خانوادگی";
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            this.lNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // codeMelliDataGridViewTextBoxColumn
            // 
            this.codeMelliDataGridViewTextBoxColumn.DataPropertyName = "CodeMelli";
            this.codeMelliDataGridViewTextBoxColumn.HeaderText = "کدملی";
            this.codeMelliDataGridViewTextBoxColumn.Name = "codeMelliDataGridViewTextBoxColumn";
            this.codeMelliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sherkatNameDataGridViewTextBoxColumn
            // 
            this.sherkatNameDataGridViewTextBoxColumn.DataPropertyName = "SherkatName";
            this.sherkatNameDataGridViewTextBoxColumn.HeaderText = "نام شرکت";
            this.sherkatNameDataGridViewTextBoxColumn.Name = "sherkatNameDataGridViewTextBoxColumn";
            this.sherkatNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sherkatNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "تاریخ قرارداد";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceHamlDataGridViewTextBoxColumn
            // 
            this.priceHamlDataGridViewTextBoxColumn.DataPropertyName = "PriceHaml";
            this.priceHamlDataGridViewTextBoxColumn.HeaderText = "کرایه حمل";
            this.priceHamlDataGridViewTextBoxColumn.Name = "priceHamlDataGridViewTextBoxColumn";
            this.priceHamlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idQarardadDataGridViewTextBoxColumn
            // 
            this.idQarardadDataGridViewTextBoxColumn.DataPropertyName = "IdQarardad";
            this.idQarardadDataGridViewTextBoxColumn.HeaderText = "شماره قرارداد";
            this.idQarardadDataGridViewTextBoxColumn.Name = "idQarardadDataGridViewTextBoxColumn";
            this.idQarardadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mozoQarardadDataGridViewTextBoxColumn
            // 
            this.mozoQarardadDataGridViewTextBoxColumn.DataPropertyName = "MozoQarardad";
            this.mozoQarardadDataGridViewTextBoxColumn.HeaderText = "موضوع قرارداد";
            this.mozoQarardadDataGridViewTextBoxColumn.Name = "mozoQarardadDataGridViewTextBoxColumn";
            this.mozoQarardadDataGridViewTextBoxColumn.ReadOnly = true;
            this.mozoQarardadDataGridViewTextBoxColumn.Width = 200;
            // 
            // modatQarardadDataGridViewTextBoxColumn
            // 
            this.modatQarardadDataGridViewTextBoxColumn.DataPropertyName = "ModatQarardad";
            this.modatQarardadDataGridViewTextBoxColumn.HeaderText = "مدت قرارداد";
            this.modatQarardadDataGridViewTextBoxColumn.Name = "modatQarardadDataGridViewTextBoxColumn";
            this.modatQarardadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shomareEnsheabDataGridViewTextBoxColumn
            // 
            this.shomareEnsheabDataGridViewTextBoxColumn.DataPropertyName = "ShomareEnsheab";
            this.shomareEnsheabDataGridViewTextBoxColumn.HeaderText = "شماره انشعاب";
            this.shomareEnsheabDataGridViewTextBoxColumn.Name = "shomareEnsheabDataGridViewTextBoxColumn";
            this.shomareEnsheabDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateEnsheabDataGridViewTextBoxColumn
            // 
            this.dateEnsheabDataGridViewTextBoxColumn.DataPropertyName = "DateEnsheab";
            this.dateEnsheabDataGridViewTextBoxColumn.HeaderText = "تاریخ انشعاب";
            this.dateEnsheabDataGridViewTextBoxColumn.Name = "dateEnsheabDataGridViewTextBoxColumn";
            this.dateEnsheabDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doreTazminDataGridViewTextBoxColumn
            // 
            this.doreTazminDataGridViewTextBoxColumn.DataPropertyName = "DoreTazmin";
            this.doreTazminDataGridViewTextBoxColumn.HeaderText = "دوره تضمین";
            this.doreTazminDataGridViewTextBoxColumn.Name = "doreTazminDataGridViewTextBoxColumn";
            this.doreTazminDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modatRafeNaghzDataGridViewTextBoxColumn
            // 
            this.modatRafeNaghzDataGridViewTextBoxColumn.DataPropertyName = "ModatRafeNaghz";
            this.modatRafeNaghzDataGridViewTextBoxColumn.HeaderText = "مدت رفع نقض";
            this.modatRafeNaghzDataGridViewTextBoxColumn.Name = "modatRafeNaghzDataGridViewTextBoxColumn";
            this.modatRafeNaghzDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceJarimeTakhirDataGridViewTextBoxColumn
            // 
            this.priceJarimeTakhirDataGridViewTextBoxColumn.DataPropertyName = "PriceJarimeTakhir";
            this.priceJarimeTakhirDataGridViewTextBoxColumn.HeaderText = "هزینه جریمه تاخیر";
            this.priceJarimeTakhirDataGridViewTextBoxColumn.Name = "priceJarimeTakhirDataGridViewTextBoxColumn";
            this.priceJarimeTakhirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_Qarardadha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(998, 638);
            this.ControlBox = false;
            this.Controls.Add(this.txtSearchFamily);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.dgvQarardad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Qarardadha";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Qarardadha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQarardad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsViewQarardadPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsViewQarardadPerson;
        private System.Windows.Forms.DataGridView dgvQarardad;
        private CustomControls.RJControls.RJButton BtnBack;
        private CustomControls.RJControls.RJButton BtnDelete;
        private CustomControls.RJControls.RJButton BtnEdit;
        private CustomControls.RJControls.RJButton BtnAdd;
        private CustomControls.RJControls.RJButton btnPrint;
        private CustomControls.RJControls.RJTextBox txtSearchFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeMelliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sherkatNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceHamlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idQarardadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mozoQarardadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modatQarardadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shomareEnsheabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEnsheabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doreTazminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modatRafeNaghzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceJarimeTakhirDataGridViewTextBoxColumn;
    }
}
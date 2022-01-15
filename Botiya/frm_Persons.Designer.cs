namespace Botiya
{
    partial class frm_Persons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Persons));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPesons = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeMelliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoqoqiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sherkatNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPersons = new System.Windows.Forms.BindingSource(this.components);
            this.BtnDelete = new CustomControls.RJControls.RJButton();
            this.BtnEdit = new CustomControls.RJControls.RJButton();
            this.BtnAdd = new CustomControls.RJControls.RJButton();
            this.BtnBack = new CustomControls.RJControls.RJButton();
            this.txtSearchFamily = new CustomControls.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPersons)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(1000, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "مشتریان";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPesons
            // 
            this.dgvPesons.AllowUserToAddRows = false;
            this.dgvPesons.AllowUserToDeleteRows = false;
            this.dgvPesons.AutoGenerateColumns = false;
            this.dgvPesons.BackgroundColor = System.Drawing.Color.White;
            this.dgvPesons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.fatherNameDataGridViewTextBoxColumn,
            this.codeMelliDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.hoqoqiDataGridViewTextBoxColumn,
            this.sherkatNameDataGridViewTextBoxColumn});
            this.dgvPesons.DataSource = this.bsPersons;
            this.dgvPesons.GridColor = System.Drawing.Color.Chocolate;
            this.dgvPesons.Location = new System.Drawing.Point(12, 47);
            this.dgvPesons.MultiSelect = false;
            this.dgvPesons.Name = "dgvPesons";
            this.dgvPesons.ReadOnly = true;
            this.dgvPesons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesons.Size = new System.Drawing.Size(980, 530);
            this.dgvPesons.TabIndex = 1;
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
            // 
            // fatherNameDataGridViewTextBoxColumn
            // 
            this.fatherNameDataGridViewTextBoxColumn.DataPropertyName = "FatherName";
            this.fatherNameDataGridViewTextBoxColumn.HeaderText = "نام پدر";
            this.fatherNameDataGridViewTextBoxColumn.Name = "fatherNameDataGridViewTextBoxColumn";
            this.fatherNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeMelliDataGridViewTextBoxColumn
            // 
            this.codeMelliDataGridViewTextBoxColumn.DataPropertyName = "CodeMelli";
            this.codeMelliDataGridViewTextBoxColumn.HeaderText = "کد ملی";
            this.codeMelliDataGridViewTextBoxColumn.Name = "codeMelliDataGridViewTextBoxColumn";
            this.codeMelliDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeMelliDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "تلفن";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "موبایل";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            this.mobileDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "آدرس";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 200;
            // 
            // hoqoqiDataGridViewTextBoxColumn
            // 
            this.hoqoqiDataGridViewTextBoxColumn.DataPropertyName = "Hoqoqi";
            this.hoqoqiDataGridViewTextBoxColumn.HeaderText = "حقوقی";
            this.hoqoqiDataGridViewTextBoxColumn.Name = "hoqoqiDataGridViewTextBoxColumn";
            this.hoqoqiDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoqoqiDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hoqoqiDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // sherkatNameDataGridViewTextBoxColumn
            // 
            this.sherkatNameDataGridViewTextBoxColumn.DataPropertyName = "SherkatName";
            this.sherkatNameDataGridViewTextBoxColumn.HeaderText = "نام شرکت";
            this.sherkatNameDataGridViewTextBoxColumn.Name = "sherkatNameDataGridViewTextBoxColumn";
            this.sherkatNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sherkatNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // bsPersons
            // 
            this.bsPersons.DataSource = typeof(Botiya.Person);
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
            this.BtnDelete.Location = new System.Drawing.Point(304, 583);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnDelete.Size = new System.Drawing.Size(140, 42);
            this.BtnDelete.TabIndex = 2;
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
            this.BtnEdit.Location = new System.Drawing.Point(158, 583);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnEdit.Size = new System.Drawing.Size(140, 42);
            this.BtnEdit.TabIndex = 1;
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
            this.BtnAdd.Location = new System.Drawing.Point(12, 583);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnAdd.Size = new System.Drawing.Size(140, 42);
            this.BtnAdd.TabIndex = 0;
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
            this.BtnBack.Location = new System.Drawing.Point(852, 583);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnBack.Size = new System.Drawing.Size(140, 42);
            this.BtnBack.TabIndex = 4;
            this.BtnBack.Text = "بازگشت";
            this.BtnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBack.TextColor = System.Drawing.Color.SteelBlue;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
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
            this.txtSearchFamily.Location = new System.Drawing.Point(451, 585);
            this.txtSearchFamily.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchFamily.Multiline = false;
            this.txtSearchFamily.Name = "txtSearchFamily";
            this.txtSearchFamily.Padding = new System.Windows.Forms.Padding(7);
            this.txtSearchFamily.PasswordChar = false;
            this.txtSearchFamily.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearchFamily.PlaceholderText = "جستجو نام خانوادگی";
            this.txtSearchFamily.Size = new System.Drawing.Size(262, 35);
            this.txtSearchFamily.TabIndex = 3;
            this.txtSearchFamily.Texts = "";
            this.txtSearchFamily.UnderlinedStyle = true;
            this.txtSearchFamily._TextChanged += new System.EventHandler(this.txtSearchFamily__TextChanged);
            // 
            // frm_Persons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 633);
            this.ControlBox = false;
            this.Controls.Add(this.txtSearchFamily);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.dgvPesons);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Persons";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Persons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPersons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPesons;
        private CustomControls.RJControls.RJButton BtnDelete;
        private CustomControls.RJControls.RJButton BtnEdit;
        private CustomControls.RJControls.RJButton BtnAdd;
        private CustomControls.RJControls.RJButton BtnBack;
        private System.Windows.Forms.BindingSource bsPersons;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeMelliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hoqoqiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sherkatNameDataGridViewTextBoxColumn;
        private CustomControls.RJControls.RJTextBox txtSearchFamily;
    }
}
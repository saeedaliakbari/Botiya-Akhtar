namespace Botiya
{
    partial class frm_Qarardad_SelectPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Qarardad_SelectPerson));
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.bsPerson = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.rdbName = new System.Windows.Forms.RadioButton();
            this.rdbCodeMelli = new System.Windows.Forms.RadioButton();
            this.txtSerachCodeMelli = new CustomControls.RJControls.RJTextBox();
            this.txtSearchName = new CustomControls.RJControls.RJTextBox();
            this.BtnOk = new CustomControls.RJControls.RJButton();
            this.btnCancel = new CustomControls.RJControls.RJButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPerson
            // 
            this.dgvPerson.AllowUserToAddRows = false;
            this.dgvPerson.AllowUserToDeleteRows = false;
            this.dgvPerson.AutoGenerateColumns = false;
            this.dgvPerson.BackgroundColor = System.Drawing.Color.White;
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvPerson.DataSource = this.bsPerson;
            this.dgvPerson.GridColor = System.Drawing.Color.Chocolate;
            this.dgvPerson.Location = new System.Drawing.Point(12, 82);
            this.dgvPerson.MultiSelect = false;
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.ReadOnly = true;
            this.dgvPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerson.Size = new System.Drawing.Size(774, 396);
            this.dgvPerson.TabIndex = 15;
            // 
            // bsPerson
            // 
            this.bsPerson.DataSource = typeof(Botiya.Person);
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
            this.label1.Size = new System.Drawing.Size(798, 34);
            this.label1.TabIndex = 17;
            this.label1.Text = "انتخاب مشتری";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbName
            // 
            this.rdbName.AutoSize = true;
            this.rdbName.Checked = true;
            this.rdbName.Location = new System.Drawing.Point(19, 51);
            this.rdbName.Name = "rdbName";
            this.rdbName.Size = new System.Drawing.Size(14, 13);
            this.rdbName.TabIndex = 19;
            this.rdbName.TabStop = true;
            this.rdbName.UseVisualStyleBackColor = true;
            this.rdbName.CheckedChanged += new System.EventHandler(this.rdbName_CheckedChanged);
            // 
            // rdbCodeMelli
            // 
            this.rdbCodeMelli.AutoSize = true;
            this.rdbCodeMelli.Location = new System.Drawing.Point(317, 51);
            this.rdbCodeMelli.Name = "rdbCodeMelli";
            this.rdbCodeMelli.Size = new System.Drawing.Size(14, 13);
            this.rdbCodeMelli.TabIndex = 20;
            this.rdbCodeMelli.UseVisualStyleBackColor = true;
            this.rdbCodeMelli.CheckedChanged += new System.EventHandler(this.rdbCodeMelli_CheckedChanged);
            // 
            // txtSerachCodeMelli
            // 
            this.txtSerachCodeMelli.BackColor = System.Drawing.SystemColors.Window;
            this.txtSerachCodeMelli.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtSerachCodeMelli.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtSerachCodeMelli.BorderRadius = 5;
            this.txtSerachCodeMelli.BorderSize = 2;
            this.txtSerachCodeMelli.Enabled = false;
            this.txtSerachCodeMelli.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSerachCodeMelli.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtSerachCodeMelli.Location = new System.Drawing.Point(338, 39);
            this.txtSerachCodeMelli.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSerachCodeMelli.Multiline = false;
            this.txtSerachCodeMelli.Name = "txtSerachCodeMelli";
            this.txtSerachCodeMelli.Padding = new System.Windows.Forms.Padding(7);
            this.txtSerachCodeMelli.PasswordChar = false;
            this.txtSerachCodeMelli.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSerachCodeMelli.PlaceholderText = "جستجو براساس کدملی";
            this.txtSerachCodeMelli.Size = new System.Drawing.Size(137, 35);
            this.txtSerachCodeMelli.TabIndex = 18;
            this.txtSerachCodeMelli.Texts = "";
            this.txtSerachCodeMelli.UnderlinedStyle = true;
            this.txtSerachCodeMelli._TextChanged += new System.EventHandler(this.txtSerachCodeMelli__TextChanged);
            this.txtSerachCodeMelli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerachCodeMelli_KeyPress);
            // 
            // txtSearchName
            // 
            this.txtSearchName.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchName.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtSearchName.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtSearchName.BorderRadius = 5;
            this.txtSearchName.BorderSize = 2;
            this.txtSearchName.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearchName.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtSearchName.Location = new System.Drawing.Point(40, 39);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchName.Multiline = false;
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Padding = new System.Windows.Forms.Padding(7);
            this.txtSearchName.PasswordChar = false;
            this.txtSearchName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearchName.PlaceholderText = "جستجو براساس نام خانوادگی";
            this.txtSearchName.Size = new System.Drawing.Size(250, 35);
            this.txtSearchName.TabIndex = 16;
            this.txtSearchName.Texts = "";
            this.txtSearchName.UnderlinedStyle = true;
            this.txtSearchName._TextChanged += new System.EventHandler(this.txtSearchName__TextChanged);
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
            this.BtnOk.Location = new System.Drawing.Point(12, 484);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnOk.Size = new System.Drawing.Size(140, 42);
            this.BtnOk.TabIndex = 14;
            this.BtnOk.Text = "انتخاب";
            this.BtnOk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOk.TextColor = System.Drawing.Color.SteelBlue;
            this.BtnOk.UseVisualStyleBackColor = false;
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
            this.btnCancel.Location = new System.Drawing.Point(646, 484);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCancel.Size = new System.Drawing.Size(140, 42);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.TextColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.codeMelliDataGridViewTextBoxColumn.HeaderText = "کدملی";
            this.codeMelliDataGridViewTextBoxColumn.Name = "codeMelliDataGridViewTextBoxColumn";
            this.codeMelliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "تلفن";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "موبایل";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "آدرس";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
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
            // 
            // frm_Qarardad_SelectPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 538);
            this.ControlBox = false;
            this.Controls.Add(this.rdbCodeMelli);
            this.Controls.Add(this.rdbName);
            this.Controls.Add(this.txtSerachCodeMelli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.dgvPerson);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Qarardad_SelectPerson";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Qarardad_SelectPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton BtnOk;
        private CustomControls.RJControls.RJButton btnCancel;
        private System.Windows.Forms.DataGridView dgvPerson;
        private CustomControls.RJControls.RJTextBox txtSearchName;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox txtSerachCodeMelli;
        private System.Windows.Forms.BindingSource bsPerson;
        private System.Windows.Forms.RadioButton rdbName;
        private System.Windows.Forms.RadioButton rdbCodeMelli;
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
    }
}
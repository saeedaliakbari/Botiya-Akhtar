namespace Botiya
{
    partial class frm_Vaheds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Vaheds));
            this.BtnDelete = new CustomControls.RJControls.RJButton();
            this.BtnEdit = new CustomControls.RJControls.RJButton();
            this.BtnAdd = new CustomControls.RJControls.RJButton();
            this.BtnBack = new CustomControls.RJControls.RJButton();
            this.txtVahedName = new CustomControls.RJControls.RJTextBox();
            this.bsVaheds = new System.Windows.Forms.BindingSource(this.components);
            this.dgvVaheds = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnOk = new CustomControls.RJControls.RJButton();
            this.btnCancel = new CustomControls.RJControls.RJButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsVaheds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaheds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.BtnDelete.Location = new System.Drawing.Point(158, 382);
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
            this.BtnEdit.FlatAppearance.BorderSize = 0;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEdit.Location = new System.Drawing.Point(12, 382);
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
            this.BtnAdd.Location = new System.Drawing.Point(309, 44);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnAdd.Size = new System.Drawing.Size(140, 42);
            this.BtnAdd.TabIndex = 19;
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
            this.BtnBack.Location = new System.Drawing.Point(309, 382);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnBack.Size = new System.Drawing.Size(140, 42);
            this.BtnBack.TabIndex = 18;
            this.BtnBack.Text = "بازگشت";
            this.BtnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBack.TextColor = System.Drawing.Color.SteelBlue;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // txtVahedName
            // 
            this.txtVahedName.BackColor = System.Drawing.SystemColors.Window;
            this.txtVahedName.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtVahedName.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtVahedName.BorderRadius = 5;
            this.txtVahedName.BorderSize = 2;
            this.txtVahedName.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtVahedName.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtVahedName.Location = new System.Drawing.Point(13, 51);
            this.txtVahedName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVahedName.Multiline = false;
            this.txtVahedName.Name = "txtVahedName";
            this.txtVahedName.Padding = new System.Windows.Forms.Padding(7);
            this.txtVahedName.PasswordChar = false;
            this.txtVahedName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtVahedName.PlaceholderText = "نام";
            this.txtVahedName.Size = new System.Drawing.Size(285, 35);
            this.txtVahedName.TabIndex = 22;
            this.txtVahedName.Texts = "";
            this.txtVahedName.UnderlinedStyle = true;
            // 
            // bsVaheds
            // 
            this.bsVaheds.DataSource = typeof(Botiya.Vahed);
            // 
            // dgvVaheds
            // 
            this.dgvVaheds.AllowUserToAddRows = false;
            this.dgvVaheds.AllowUserToDeleteRows = false;
            this.dgvVaheds.AutoGenerateColumns = false;
            this.dgvVaheds.BackgroundColor = System.Drawing.Color.White;
            this.dgvVaheds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaheds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dgvVaheds.DataSource = this.bsVaheds;
            this.dgvVaheds.Location = new System.Drawing.Point(13, 94);
            this.dgvVaheds.Name = "dgvVaheds";
            this.dgvVaheds.ReadOnly = true;
            this.dgvVaheds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVaheds.Size = new System.Drawing.Size(436, 282);
            this.dgvVaheds.TabIndex = 23;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام واحد";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.label1.Size = new System.Drawing.Size(461, 34);
            this.label1.TabIndex = 24;
            this.label1.Text = "واحد";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.BtnOk.Location = new System.Drawing.Point(309, 44);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnOk.Size = new System.Drawing.Size(140, 42);
            this.BtnOk.TabIndex = 25;
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
            this.btnCancel.Location = new System.Drawing.Point(12, 382);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCancel.Size = new System.Drawing.Size(140, 42);
            this.btnCancel.TabIndex = 26;
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
            // 
            // frm_Vaheds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(461, 441);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVaheds);
            this.Controls.Add(this.txtVahedName);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnBack);
            this.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Vaheds";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Vaheds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsVaheds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaheds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.RJControls.RJButton BtnDelete;
        private CustomControls.RJControls.RJButton BtnEdit;
        private CustomControls.RJControls.RJButton BtnAdd;
        private CustomControls.RJControls.RJButton BtnBack;
        private CustomControls.RJControls.RJTextBox txtVahedName;
        private System.Windows.Forms.BindingSource bsVaheds;
        private System.Windows.Forms.DataGridView dgvVaheds;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton BtnOk;
        private CustomControls.RJControls.RJButton btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
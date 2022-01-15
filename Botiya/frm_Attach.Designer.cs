namespace Botiya
{
    partial class frm_Attach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Attach));
            this.bsFile = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picAttach = new System.Windows.Forms.PictureBox();
            this.bsFileById = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAttach = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idQarardadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnViewPic = new CustomControls.RJControls.RJButton();
            this.BtnOk = new CustomControls.RJControls.RJButton();
            this.btnCancel = new CustomControls.RJControls.RJButton();
            this.BtnDelete = new CustomControls.RJControls.RJButton();
            this.BtnEdit = new CustomControls.RJControls.RJButton();
            this.btnSelect = new CustomControls.RJControls.RJButton();
            this.txtComment = new CustomControls.RJControls.RJTextBox();
            this.txtShomareQarardad = new CustomControls.RJControls.RJTextBox();
            this.BtnAdd = new CustomControls.RJControls.RJButton();
            this.BtnBack = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.bsFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAttach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFileById)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bsFile
            // 
            this.bsFile.DataSource = typeof(Botiya.tblFileAttach);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(10, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 23);
            this.label9.TabIndex = 41;
            this.label9.Text = "شماره قرارداد";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(10, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "توضیحات";
            // 
            // picAttach
            // 
            this.picAttach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAttach.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bsFileById, "Image", true));
            this.picAttach.Location = new System.Drawing.Point(486, 41);
            this.picAttach.Name = "picAttach";
            this.picAttach.Size = new System.Drawing.Size(317, 409);
            this.picAttach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAttach.TabIndex = 45;
            this.picAttach.TabStop = false;
            // 
            // bsFileById
            // 
            this.bsFileById.DataSource = typeof(Botiya.tblFileAttach);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Chocolate;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(815, 34);
            this.label2.TabIndex = 46;
            this.label2.Text = "ثبت ضمیمه";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvAttach
            // 
            this.dgvAttach.AllowUserToAddRows = false;
            this.dgvAttach.AllowUserToDeleteRows = false;
            this.dgvAttach.AutoGenerateColumns = false;
            this.dgvAttach.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idQarardadDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.imageDataGridViewTextBoxColumn});
            this.dgvAttach.DataSource = this.bsFile;
            this.dgvAttach.GridColor = System.Drawing.Color.Chocolate;
            this.dgvAttach.Location = new System.Drawing.Point(12, 253);
            this.dgvAttach.MultiSelect = false;
            this.dgvAttach.Name = "dgvAttach";
            this.dgvAttach.ReadOnly = true;
            this.dgvAttach.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvAttach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttach.Size = new System.Drawing.Size(469, 197);
            this.dgvAttach.TabIndex = 49;
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
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "توضیحات فایل ضمیمه";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "Image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "Image";
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            this.imageDataGridViewTextBoxColumn.ReadOnly = true;
            this.imageDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.imageDataGridViewTextBoxColumn.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // btnViewPic
            // 
            this.btnViewPic.BackColor = System.Drawing.Color.White;
            this.btnViewPic.BackgroundColor = System.Drawing.Color.White;
            this.btnViewPic.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnViewPic.BorderRadius = 12;
            this.btnViewPic.BorderSize = 2;
            this.btnViewPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewPic.FlatAppearance.BorderSize = 0;
            this.btnViewPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPic.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnViewPic.Image = ((System.Drawing.Image)(resources.GetObject("btnViewPic.Image")));
            this.btnViewPic.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewPic.Location = new System.Drawing.Point(304, 456);
            this.btnViewPic.Name = "btnViewPic";
            this.btnViewPic.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnViewPic.Size = new System.Drawing.Size(140, 42);
            this.btnViewPic.TabIndex = 8;
            this.btnViewPic.Text = "نمایش عکس";
            this.btnViewPic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewPic.TextColor = System.Drawing.Color.SteelBlue;
            this.btnViewPic.UseVisualStyleBackColor = false;
            this.btnViewPic.Click += new System.EventHandler(this.btnViewPic_Click);
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
            this.BtnOk.Location = new System.Drawing.Point(341, 205);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnOk.Size = new System.Drawing.Size(140, 42);
            this.BtnOk.TabIndex = 5;
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
            this.btnCancel.Location = new System.Drawing.Point(195, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCancel.Size = new System.Drawing.Size(140, 42);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.TextColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.BtnDelete.Location = new System.Drawing.Point(158, 456);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnDelete.Size = new System.Drawing.Size(140, 42);
            this.BtnDelete.TabIndex = 7;
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
            this.BtnEdit.Location = new System.Drawing.Point(12, 456);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnEdit.Size = new System.Drawing.Size(140, 42);
            this.BtnEdit.TabIndex = 4;
            this.BtnEdit.Text = "ویرایش";
            this.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEdit.TextColor = System.Drawing.Color.SteelBlue;
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.White;
            this.btnSelect.BackgroundColor = System.Drawing.Color.White;
            this.btnSelect.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnSelect.BorderRadius = 12;
            this.btnSelect.BorderSize = 2;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.Location = new System.Drawing.Point(340, 45);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSelect.Size = new System.Drawing.Size(140, 42);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "انتخاب عکس";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.TextColor = System.Drawing.Color.SteelBlue;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.SystemColors.Window;
            this.txtComment.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtComment.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtComment.BorderRadius = 5;
            this.txtComment.BorderSize = 2;
            this.txtComment.DataBindings.Add(new System.Windows.Forms.Binding("Texts", this.bsFileById, "Comment", true));
            this.txtComment.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtComment.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtComment.Location = new System.Drawing.Point(78, 102);
            this.txtComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Padding = new System.Windows.Forms.Padding(7);
            this.txtComment.PasswordChar = false;
            this.txtComment.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtComment.PlaceholderText = "";
            this.txtComment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtComment.Size = new System.Drawing.Size(403, 79);
            this.txtComment.TabIndex = 1;
            this.txtComment.Texts = "";
            this.txtComment.UnderlinedStyle = true;
            // 
            // txtShomareQarardad
            // 
            this.txtShomareQarardad.BackColor = System.Drawing.SystemColors.Window;
            this.txtShomareQarardad.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtShomareQarardad.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtShomareQarardad.BorderRadius = 5;
            this.txtShomareQarardad.BorderSize = 2;
            this.txtShomareQarardad.DataBindings.Add(new System.Windows.Forms.Binding("Texts", this.bsFileById, "IdQarardad", true));
            this.txtShomareQarardad.Enabled = false;
            this.txtShomareQarardad.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtShomareQarardad.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtShomareQarardad.Location = new System.Drawing.Point(105, 57);
            this.txtShomareQarardad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtShomareQarardad.Multiline = false;
            this.txtShomareQarardad.Name = "txtShomareQarardad";
            this.txtShomareQarardad.Padding = new System.Windows.Forms.Padding(7);
            this.txtShomareQarardad.PasswordChar = false;
            this.txtShomareQarardad.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtShomareQarardad.PlaceholderText = "";
            this.txtShomareQarardad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtShomareQarardad.Size = new System.Drawing.Size(92, 35);
            this.txtShomareQarardad.TabIndex = 0;
            this.txtShomareQarardad.Texts = "";
            this.txtShomareQarardad.UnderlinedStyle = true;
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
            this.BtnAdd.Location = new System.Drawing.Point(340, 205);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnAdd.Size = new System.Drawing.Size(140, 42);
            this.BtnAdd.TabIndex = 3;
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
            this.BtnBack.Location = new System.Drawing.Point(663, 456);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnBack.Size = new System.Drawing.Size(140, 42);
            this.BtnBack.TabIndex = 9;
            this.BtnBack.Text = "بازگشت";
            this.BtnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBack.TextColor = System.Drawing.Color.SteelBlue;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // frm_Attach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(815, 510);
            this.ControlBox = false;
            this.Controls.Add(this.btnViewPic);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvAttach);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picAttach);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtShomareQarardad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnBack);
            this.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Attach";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Attach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAttach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFileById)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton BtnAdd;
        private CustomControls.RJControls.RJButton BtnBack;
        private CustomControls.RJControls.RJTextBox txtShomareQarardad;
        private System.Windows.Forms.Label label9;
        private CustomControls.RJControls.RJTextBox txtComment;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton btnSelect;
        private System.Windows.Forms.PictureBox picAttach;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJButton BtnDelete;
        private CustomControls.RJControls.RJButton BtnEdit;
        private System.Windows.Forms.DataGridView dgvAttach;
        private System.Windows.Forms.BindingSource bsFile;
        private System.Windows.Forms.BindingSource bsFileById;
        private CustomControls.RJControls.RJButton BtnOk;
        private CustomControls.RJControls.RJButton btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idQarardadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private CustomControls.RJControls.RJButton btnViewPic;
    }
}
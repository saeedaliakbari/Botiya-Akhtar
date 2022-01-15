namespace Botiya
{
    partial class frm_Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Products));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vahedNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceKala1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDastMozd1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricKala2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDastMozd2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vahedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsViewProductVahed = new System.Windows.Forms.BindingSource(this.components);
            this.bsProducts = new System.Windows.Forms.BindingSource(this.components);
            this.txtSerachKala = new CustomControls.RJControls.RJTextBox();
            this.BtnDelete = new CustomControls.RJControls.RJButton();
            this.BtnEdit = new CustomControls.RJControls.RJButton();
            this.BtnAdd = new CustomControls.RJControls.RJButton();
            this.BtnBack = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsViewProductVahed)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(994, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "محصولات";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.vahedNameDataGridViewTextBoxColumn,
            this.priceKala1DataGridViewTextBoxColumn,
            this.priceDastMozd1DataGridViewTextBoxColumn,
            this.pricKala2DataGridViewTextBoxColumn,
            this.priceDastMozd2DataGridViewTextBoxColumn,
            this.vahedDataGridViewTextBoxColumn});
            this.dgvProducts.DataSource = this.bsViewProductVahed;
            this.dgvProducts.GridColor = System.Drawing.Color.Chocolate;
            this.dgvProducts.Location = new System.Drawing.Point(12, 55);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(974, 511);
            this.dgvProducts.TabIndex = 18;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeIdDataGridViewTextBoxColumn
            // 
            this.codeIdDataGridViewTextBoxColumn.DataPropertyName = "CodeId";
            this.codeIdDataGridViewTextBoxColumn.HeaderText = "کدمحصول";
            this.codeIdDataGridViewTextBoxColumn.Name = "codeIdDataGridViewTextBoxColumn";
            this.codeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام محصول";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 331;
            // 
            // vahedNameDataGridViewTextBoxColumn
            // 
            this.vahedNameDataGridViewTextBoxColumn.DataPropertyName = "VahedName";
            this.vahedNameDataGridViewTextBoxColumn.HeaderText = "واحد";
            this.vahedNameDataGridViewTextBoxColumn.Name = "vahedNameDataGridViewTextBoxColumn";
            this.vahedNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceKala1DataGridViewTextBoxColumn
            // 
            this.priceKala1DataGridViewTextBoxColumn.DataPropertyName = "PriceKala1";
            this.priceKala1DataGridViewTextBoxColumn.HeaderText = "قیمت محصول1";
            this.priceKala1DataGridViewTextBoxColumn.Name = "priceKala1DataGridViewTextBoxColumn";
            this.priceKala1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDastMozd1DataGridViewTextBoxColumn
            // 
            this.priceDastMozd1DataGridViewTextBoxColumn.DataPropertyName = "PriceDastMozd1";
            this.priceDastMozd1DataGridViewTextBoxColumn.HeaderText = "قیمت دستمزد 1";
            this.priceDastMozd1DataGridViewTextBoxColumn.Name = "priceDastMozd1DataGridViewTextBoxColumn";
            this.priceDastMozd1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pricKala2DataGridViewTextBoxColumn
            // 
            this.pricKala2DataGridViewTextBoxColumn.DataPropertyName = "PricKala2";
            this.pricKala2DataGridViewTextBoxColumn.HeaderText = "قیمت محصول 2";
            this.pricKala2DataGridViewTextBoxColumn.Name = "pricKala2DataGridViewTextBoxColumn";
            this.pricKala2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDastMozd2DataGridViewTextBoxColumn
            // 
            this.priceDastMozd2DataGridViewTextBoxColumn.DataPropertyName = "PriceDastMozd2";
            this.priceDastMozd2DataGridViewTextBoxColumn.HeaderText = "قیمت دستمزد 2";
            this.priceDastMozd2DataGridViewTextBoxColumn.Name = "priceDastMozd2DataGridViewTextBoxColumn";
            this.priceDastMozd2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vahedDataGridViewTextBoxColumn
            // 
            this.vahedDataGridViewTextBoxColumn.DataPropertyName = "Vahed";
            this.vahedDataGridViewTextBoxColumn.HeaderText = "Vahed";
            this.vahedDataGridViewTextBoxColumn.Name = "vahedDataGridViewTextBoxColumn";
            this.vahedDataGridViewTextBoxColumn.ReadOnly = true;
            this.vahedDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsViewProductVahed
            // 
            this.bsViewProductVahed.DataSource = typeof(Botiya.ViewProductsVahed);
            // 
            // bsProducts
            // 
            this.bsProducts.DataSource = typeof(Botiya.Product);
            // 
            // txtSerachKala
            // 
            this.txtSerachKala.BackColor = System.Drawing.SystemColors.Window;
            this.txtSerachKala.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtSerachKala.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtSerachKala.BorderRadius = 5;
            this.txtSerachKala.BorderSize = 2;
            this.txtSerachKala.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSerachKala.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtSerachKala.Location = new System.Drawing.Point(460, 589);
            this.txtSerachKala.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSerachKala.Multiline = false;
            this.txtSerachKala.Name = "txtSerachKala";
            this.txtSerachKala.Padding = new System.Windows.Forms.Padding(7);
            this.txtSerachKala.PasswordChar = false;
            this.txtSerachKala.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSerachKala.PlaceholderText = "جستجو نام محصول";
            this.txtSerachKala.Size = new System.Drawing.Size(250, 35);
            this.txtSerachKala.TabIndex = 3;
            this.txtSerachKala.Texts = "";
            this.txtSerachKala.UnderlinedStyle = true;
            this.txtSerachKala._TextChanged += new System.EventHandler(this.txtSerachKala__TextChanged);
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
            this.BtnDelete.Location = new System.Drawing.Point(304, 584);
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
            this.BtnEdit.Location = new System.Drawing.Point(158, 584);
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
            this.BtnAdd.Location = new System.Drawing.Point(12, 584);
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
            this.BtnBack.Location = new System.Drawing.Point(846, 584);
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
            // frm_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 634);
            this.ControlBox = false;
            this.Controls.Add(this.txtSerachKala);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Products";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsViewProductVahed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton BtnDelete;
        private CustomControls.RJControls.RJButton BtnEdit;
        private CustomControls.RJControls.RJButton BtnAdd;
        private CustomControls.RJControls.RJButton BtnBack;
        private System.Windows.Forms.BindingSource bsProducts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private CustomControls.RJControls.RJTextBox txtSerachKala;
        private System.Windows.Forms.BindingSource bsViewProductVahed;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vahedNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceKala1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDastMozd1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricKala2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDastMozd2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vahedDataGridViewTextBoxColumn;
    }
}
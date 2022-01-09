namespace Botiya
{
    partial class frm_Qarardad_SelectProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Qarardad_SelectProduct));
            this.txtSerachCodeKala = new CustomControls.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSerachNameKala = new CustomControls.RJControls.RJTextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vahedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceKala1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDastMozd1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricKala2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDastMozd2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vahedNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsViewProduct = new System.Windows.Forms.BindingSource(this.components);
            this.BtnOk = new CustomControls.RJControls.RJButton();
            this.btnCancel = new CustomControls.RJControls.RJButton();
            this.rdbName = new System.Windows.Forms.RadioButton();
            this.rdbCode = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSerachCodeKala
            // 
            this.txtSerachCodeKala.BackColor = System.Drawing.SystemColors.Window;
            this.txtSerachCodeKala.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtSerachCodeKala.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtSerachCodeKala.BorderRadius = 5;
            this.txtSerachCodeKala.BorderSize = 2;
            this.txtSerachCodeKala.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSerachCodeKala.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtSerachCodeKala.Location = new System.Drawing.Point(311, 45);
            this.txtSerachCodeKala.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSerachCodeKala.Multiline = false;
            this.txtSerachCodeKala.Name = "txtSerachCodeKala";
            this.txtSerachCodeKala.Padding = new System.Windows.Forms.Padding(7);
            this.txtSerachCodeKala.PasswordChar = false;
            this.txtSerachCodeKala.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSerachCodeKala.PlaceholderText = "جستجو براساس کدکالا";
            this.txtSerachCodeKala.Size = new System.Drawing.Size(137, 35);
            this.txtSerachCodeKala.TabIndex = 24;
            this.txtSerachCodeKala.Texts = "";
            this.txtSerachCodeKala.UnderlinedStyle = true;
            this.txtSerachCodeKala._TextChanged += new System.EventHandler(this.txtSerachCodeKala__TextChanged);
            this.txtSerachCodeKala.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSerachCodeKala_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Chocolate;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(798, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "انتخاب محصول";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSerachNameKala
            // 
            this.txtSerachNameKala.BackColor = System.Drawing.SystemColors.Window;
            this.txtSerachNameKala.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtSerachNameKala.BorderFocusColor = System.Drawing.Color.Chocolate;
            this.txtSerachNameKala.BorderRadius = 5;
            this.txtSerachNameKala.BorderSize = 2;
            this.txtSerachNameKala.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSerachNameKala.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtSerachNameKala.Location = new System.Drawing.Point(33, 45);
            this.txtSerachNameKala.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSerachNameKala.Multiline = false;
            this.txtSerachNameKala.Name = "txtSerachNameKala";
            this.txtSerachNameKala.Padding = new System.Windows.Forms.Padding(7);
            this.txtSerachNameKala.PasswordChar = false;
            this.txtSerachNameKala.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSerachNameKala.PlaceholderText = "جستجو براساس نام کالا";
            this.txtSerachNameKala.Size = new System.Drawing.Size(250, 35);
            this.txtSerachNameKala.TabIndex = 22;
            this.txtSerachNameKala.Texts = "";
            this.txtSerachNameKala.UnderlinedStyle = true;
            this.txtSerachNameKala._TextChanged += new System.EventHandler(this.txtSerachNameKala__TextChanged);
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
            this.vahedDataGridViewTextBoxColumn,
            this.priceKala1DataGridViewTextBoxColumn,
            this.priceDastMozd1DataGridViewTextBoxColumn,
            this.pricKala2DataGridViewTextBoxColumn,
            this.priceDastMozd2DataGridViewTextBoxColumn,
            this.vahedNameDataGridViewTextBoxColumn});
            this.dgvProducts.DataSource = this.bsViewProduct;
            this.dgvProducts.Location = new System.Drawing.Point(12, 88);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(774, 396);
            this.dgvProducts.TabIndex = 21;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeIdDataGridViewTextBoxColumn
            // 
            this.codeIdDataGridViewTextBoxColumn.DataPropertyName = "CodeId";
            this.codeIdDataGridViewTextBoxColumn.HeaderText = "CodeId";
            this.codeIdDataGridViewTextBoxColumn.Name = "codeIdDataGridViewTextBoxColumn";
            this.codeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vahedDataGridViewTextBoxColumn
            // 
            this.vahedDataGridViewTextBoxColumn.DataPropertyName = "Vahed";
            this.vahedDataGridViewTextBoxColumn.HeaderText = "Vahed";
            this.vahedDataGridViewTextBoxColumn.Name = "vahedDataGridViewTextBoxColumn";
            this.vahedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceKala1DataGridViewTextBoxColumn
            // 
            this.priceKala1DataGridViewTextBoxColumn.DataPropertyName = "PriceKala1";
            this.priceKala1DataGridViewTextBoxColumn.HeaderText = "PriceKala1";
            this.priceKala1DataGridViewTextBoxColumn.Name = "priceKala1DataGridViewTextBoxColumn";
            this.priceKala1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDastMozd1DataGridViewTextBoxColumn
            // 
            this.priceDastMozd1DataGridViewTextBoxColumn.DataPropertyName = "PriceDastMozd1";
            this.priceDastMozd1DataGridViewTextBoxColumn.HeaderText = "PriceDastMozd1";
            this.priceDastMozd1DataGridViewTextBoxColumn.Name = "priceDastMozd1DataGridViewTextBoxColumn";
            this.priceDastMozd1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pricKala2DataGridViewTextBoxColumn
            // 
            this.pricKala2DataGridViewTextBoxColumn.DataPropertyName = "PricKala2";
            this.pricKala2DataGridViewTextBoxColumn.HeaderText = "PricKala2";
            this.pricKala2DataGridViewTextBoxColumn.Name = "pricKala2DataGridViewTextBoxColumn";
            this.pricKala2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDastMozd2DataGridViewTextBoxColumn
            // 
            this.priceDastMozd2DataGridViewTextBoxColumn.DataPropertyName = "PriceDastMozd2";
            this.priceDastMozd2DataGridViewTextBoxColumn.HeaderText = "PriceDastMozd2";
            this.priceDastMozd2DataGridViewTextBoxColumn.Name = "priceDastMozd2DataGridViewTextBoxColumn";
            this.priceDastMozd2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vahedNameDataGridViewTextBoxColumn
            // 
            this.vahedNameDataGridViewTextBoxColumn.DataPropertyName = "VahedName";
            this.vahedNameDataGridViewTextBoxColumn.HeaderText = "VahedName";
            this.vahedNameDataGridViewTextBoxColumn.Name = "vahedNameDataGridViewTextBoxColumn";
            this.vahedNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsViewProduct
            // 
            this.bsViewProduct.DataSource = typeof(Botiya.ViewProductsVahed);
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
            this.BtnOk.Location = new System.Drawing.Point(12, 490);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnOk.Size = new System.Drawing.Size(140, 42);
            this.BtnOk.TabIndex = 20;
            this.BtnOk.Text = "تایید";
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
            this.btnCancel.Location = new System.Drawing.Point(646, 490);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCancel.Size = new System.Drawing.Size(140, 42);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.TextColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rdbName
            // 
            this.rdbName.AutoSize = true;
            this.rdbName.Checked = true;
            this.rdbName.Location = new System.Drawing.Point(12, 55);
            this.rdbName.Name = "rdbName";
            this.rdbName.Size = new System.Drawing.Size(14, 13);
            this.rdbName.TabIndex = 25;
            this.rdbName.TabStop = true;
            this.rdbName.UseVisualStyleBackColor = true;
            this.rdbName.CheckedChanged += new System.EventHandler(this.rdbName_CheckedChanged);
            // 
            // rdbCode
            // 
            this.rdbCode.AutoSize = true;
            this.rdbCode.Location = new System.Drawing.Point(290, 55);
            this.rdbCode.Name = "rdbCode";
            this.rdbCode.Size = new System.Drawing.Size(14, 13);
            this.rdbCode.TabIndex = 26;
            this.rdbCode.UseVisualStyleBackColor = true;
            this.rdbCode.CheckedChanged += new System.EventHandler(this.rdbCode_CheckedChanged);
            // 
            // frm_Qarardad_SelectProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 538);
            this.ControlBox = false;
            this.Controls.Add(this.rdbCode);
            this.Controls.Add(this.rdbName);
            this.Controls.Add(this.txtSerachCodeKala);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSerachNameKala);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Qarardad_SelectProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Qarardad_SelectProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsViewProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJTextBox txtSerachCodeKala;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox txtSerachNameKala;
        private System.Windows.Forms.DataGridView dgvProducts;
        private CustomControls.RJControls.RJButton BtnOk;
        private CustomControls.RJControls.RJButton btnCancel;
        private System.Windows.Forms.BindingSource bsViewProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vahedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceKala1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDastMozd1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricKala2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDastMozd2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vahedNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton rdbName;
        private System.Windows.Forms.RadioButton rdbCode;
    }
}
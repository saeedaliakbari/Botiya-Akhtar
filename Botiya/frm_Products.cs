using BehComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Botiya
{
    public partial class frm_Products : Form
    {
        BotiyaDataContext db = new BotiyaDataContext();
        public frm_Products()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frm_ProductInfo.editMode = false;
                frm_ProductInfo.frm_Products = this;
                new frm_ProductInfo().ShowDialog();
            }
            catch
            {

                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFarsi.Show("آیا محصول  با مشخصات زیر حذف گردد؟" + "\n" + " کد: " + dgvProducts.CurrentRow.Cells[1].Value + " \n نام کالا: " + dgvProducts.CurrentRow.Cells[2].Value, "حذف", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Delete, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    int? resultProduct = null;
                    db.CheckDeleteProduct((int)dgvProducts.CurrentRow.Cells[0].Value, ref resultProduct);
                    if (resultProduct is null)
                    {
                        db.DeleteProducts((int)dgvProducts.CurrentRow.Cells[0].Value);
                        UpdateDb();
                    }
                    else
                    {
                        MessageBoxFarsi.Show("محصول انتخاب شده در فاکتور قرارداد استفاده شده است و امکان حذف آن وجود ندارد", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1, true, false);
                    }



                   
                }
            }
            catch
            {

                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
        public void UpdateDb()
        {
            try
            {
                bsViewProductVahed.DataSource = db.FillViewProductVahed();
                if (dgvProducts.Rows.Count == 0)
                {
                    BtnDelete.Enabled = false;
                    BtnEdit.Enabled = false;
                }
                else
                {
                    BtnDelete.Enabled = true;
                    BtnEdit.Enabled = true;

                }
            }
            catch
            {

                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }

        }

        private void frm_Products_Load(object sender, EventArgs e)
        {
            UpdateDb();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                frm_ProductInfo.editMode = true;
                frm_ProductInfo.frm_Products = this;
                frm_ProductInfo.idProduct = (int)dgvProducts.CurrentRow.Cells[0].Value;
                new frm_ProductInfo().ShowDialog();
            }
            catch
            {

                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void txtSerachKala__TextChanged(object sender, EventArgs e)
        {
            try
            {
                bsViewProductVahed.DataSource = db.FillViewPrdouctByName(txtSerachKala.Texts);
                if (dgvProducts.Rows.Count == 0)
                {
                    BtnDelete.Enabled = false;
                    BtnEdit.Enabled = false;
                }
                else
                {
                    BtnDelete.Enabled = true;
                    BtnEdit.Enabled = true;

                }
            }
            catch
            {

                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

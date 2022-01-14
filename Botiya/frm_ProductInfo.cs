using BehComponents;
using CustomControls.RJControls;
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
    public partial class frm_ProductInfo : Form
    {
        BotiyaDataContext db = new BotiyaDataContext();
        public static bool editMode = false;
        public static int idProduct = -1;
        public static frm_Products frm_Products = null;
        string? codeId = "";
        string? name = "";
        string? CodeIdForCheck = string.Empty;
        int? vahed= 0;
        double? priceKala1= 0;
        double? priceDastmozd1 = 0;
        double? priceKala2 = 0;
        double? priceDastmozd2 = 0;
        public frm_ProductInfo()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                db.GetProductsByCodeId(txtCodeKala.Texts,ref CodeIdForCheck);
                if (txtCodeKala.Texts == String.Empty)
                {
                errorProvider1.Clear();
                errorProvider1.SetError(txtCodeKala, "ورود مقدار الزامی است");
                }
                else if (txtNameKala.Texts == String.Empty)
                {
                errorProvider1.Clear();
                errorProvider1.SetError(txtNameKala, "ورود مقدار الزامی است");
                }
                else if (CodeIdForCheck != null && codeId!=txtCodeKala.Texts)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtCodeKala, "کد کالا تکراری است");
                }
                else
                {
                    //MessageBox.Show("SelectedValue :"+cmbVahedAsli.SelectedValue + " > " + cmbVahedAsli.SelectedText);
                    errorProvider1.Clear();
                    if (editMode)
                    {
                        db.UpdateProduct(idProduct, txtCodeKala.Texts, txtNameKala.Texts,Convert.ToInt32(cmbVahedAsli.SelectedValue), Convert.ToDouble(txtPriceKala1.Texts), Convert.ToDouble(txtPriceDastmozd1.Texts), Convert.ToDouble(txtPrice2.Texts), Convert.ToDouble(txtPriceDastmozd2.Texts));
                        MessageBoxFarsi.Show("کالا ویرایش شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                        this.Close();
                    }
                    else
                    {
                        db.InsertProducts(txtCodeKala.Texts, txtNameKala.Texts, Convert.ToInt32(cmbVahedAsli.SelectedValue), Convert.ToDouble(txtPriceKala1.Texts), Convert.ToDouble(txtPriceDastmozd1.Texts), Convert.ToDouble(txtPrice2.Texts), Convert.ToDouble(txtPriceDastmozd2.Texts)); 
                        MessageBoxFarsi.Show("کالا جدید افزوده شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                        clear();
                    }
                    frm_Products.UpdateDb();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1, true, false);
            }
        }

        private void frm_ProductInfo_Load(object sender, EventArgs e)
        {
            bsVaheds.DataSource = db.FillVaheds();
            cmbVahedAsli.SelectedIndex = 3;
            if (editMode)
            {
                bsProducts.DataSource = db.FillProductById(idProduct);
                db.GetProducts(idProduct, ref codeId, ref name, ref vahed, ref priceKala1, ref priceDastmozd1, ref priceKala2, ref priceDastmozd2);
                cmbVahedAsli.SelectedValue = (int)vahed;
                CalculatePriceKol();
            }
            else
            {
                clear();

            }
        }
        public void clear()
        {
            cmbVahed.SelectedIndex =1;
            txtCodeKala.Texts = String.Empty;
            txtNameKala.Texts = String.Empty;
            txtPriceKala1.Texts = "0";
            txtPrice2.Texts = "0";
            txtPriceDastmozd1.Texts = "0";
            txtPriceDastmozd2.Texts = "0";
            txtPriceKol1.Texts = "0";
            txtPriceKol2.Texts = "0";
            txtCodeKala.Focus();
            CodeIdForCheck = string.Empty;
        }
        public void CalculatePriceKol()
        {
            txtPriceKol1.Texts = (Convert.ToDouble(txtPriceKala1.Texts) + Convert.ToDouble(txtPriceDastmozd1.Texts)).ToString("0,0");
            txtPriceKol2.Texts = (Convert.ToDouble(txtPrice2.Texts) + Convert.ToDouble(txtPriceDastmozd2.Texts)).ToString("0,0");
        }

        private void txtPriceKala1_Leave(object sender, EventArgs e)
        {
            CalculatePriceKol();
        }

        private void txtPriceKala1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumeric(sender, e);
        }
        private void OnlyNumeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as RJTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPriceDastmozd1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumeric(sender, e);
        }

        private void txtPrice2_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumeric(sender, e);
        }

        private void txtPriceDastmozd2_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumeric(sender, e);
        }

        private void txtCodeKala_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumeric(sender, e);
        }
    }
}

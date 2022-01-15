using BehComponents;
using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Botiya
{
    public partial class frm_AddQarardad : Form
    {
        PersianCalendar pc = new PersianCalendar();
        BotiyaDataContext db = new BotiyaDataContext();
        public static frm_Qarardadha frm_Qarardadha= null;

        public static int idPerson = -1;
        public static int idProduct = -1;
        public static string dateString = string.Empty;
        public static int? idQarardad = -1;

        string? fName = "";
        string? lName = "";
        string? fatherName = "";
        string? codeMelli = "";
        string? phone = "";
        string? mobile = "";
        string? address = "";
        string? sherkatName = "";
        int? hoqoqi = 0;

        int? idKala = -1;
        string? codeIdKala = "";
        string? nameKala = "";
        int? vahedKala = 0;
        double? priceKala1 = 0;
        double? priceDastmozd1 = 0;
        double? priceKala2 = 0;
        double? priceDastmozd2 = 0;

        double? priceVahedKala = 0;
        double? priceKolKala = 0;
        double? tedadKala = 0;

        int idFactor = -1;

        int? refIdFactor = -1;
        public frm_AddQarardad()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            new frm_Qarardad_SelectPerson().ShowDialog();
            this.Close();
        }


        private void frm_AddQarardad_Load(object sender, EventArgs e)
        {
            if (idQarardad == -1)
            {
                db.InsertQarardad(ref idQarardad);
                db.InsertEvent(frm_Main.userName, "افزودن قرارداد به شماره " + idQarardad,frm_Login.strtoday+" "+ DateTime.Now.ToString("HH:mm"));
            }
            else
            {
                //bsViewFacotrProduct.DataSource = db.FillViewFatcorProduct(idQarardad);
                bsQarardadPerson.DataSource = db.FillViewQarardadPersonById(idQarardad);
                
                UpdateDb();
            }
            if (dateString== string.Empty)
            {
                dateString= pc.GetYear(DateTime.Now).ToString("0000") + "/" + pc.GetMonth(DateTime.Now).ToString("00") + "/" + pc.GetDayOfMonth(DateTime.Now).ToString("00");
            }
            txtDate.Texts = dateString;
            if (idPerson != -1)
            {
                db.GetPerson(idPerson, ref fName, ref lName, ref fatherName, ref codeMelli, ref phone, ref mobile, ref address, ref hoqoqi, ref sherkatName);
                txtName.Texts = fName + " " + lName;
            }
            if (idProduct != -1)
            {
                db.GetProducts(idProduct, ref codeIdKala, ref nameKala, ref vahedKala, ref priceKala1, ref priceDastmozd1, ref priceKala2, ref priceDastmozd2);
                txtNameKala.Texts = nameKala;
                txtCodeKala.Texts = codeIdKala;
                txtPriceVahed.Texts = (priceKala1 + priceDastmozd1).ToString();
                GetFacotrByIdKala();
            }
           
        }
        private void UpdateDb()
        {
            bsViewFacotrProduct.DataSource = db.FillViewFatcorProduct(idQarardad);
            calculatePrice();
            if (dgvFactor.Rows.Count == 0)
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
        private void txtNameKala_Click(object sender, EventArgs e)
        {
            new frm_Qarardad_SelectProduct().ShowDialog();
            this.Close();
        }

        private void txtPriceVahed_Leave(object sender, EventArgs e)
        {
            try
            {
                txtPriceKol.Texts = (Convert.ToDouble(txtPriceVahed.Texts) * float.Parse(txtTedad.Texts)).ToString();
            }
            catch
            {
                txtPriceVahed.Texts = "0";
                txtTedad.Texts = "0";
            }

        }

        private void txtTedad_Leave(object sender, EventArgs e)
        {
            try
            {
                txtPriceKol.Texts = (double.Parse(txtPriceVahed.Texts) * float.Parse(txtTedad.Texts)).ToString();
            }
            catch
            {
                txtPriceVahed.Texts = "0";
                txtTedad.Texts = "0";
            }
        }

        private void txtDate_Leave(object sender, EventArgs e)
        {
            dateString = txtDate.Texts;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("idProduct> " + idProduct + " idQarardad>" + idQarardad);
                if (idProduct != -1)
                {
                    db.InsertFactor(idQarardad, idProduct, Double.Parse(txtTedad.Texts), Convert.ToDouble(txtPriceVahed.Texts), Convert.ToDouble(txtPriceKol.Texts));
                    db.InsertEvent(frm_Main.userName, "افزودن محصول" + idProduct + "به فاکتور به قرارداد" + idQarardad, frm_Login.strtoday + " " + DateTime.Now.ToString("HH:mm"));
                    idProduct = -1;
                    txtNameKala.Texts = "";
                    txtCodeKala.Texts = "";
                    txtTedad.Texts = "0";
                    txtPriceVahed.Texts = "0";
                    txtPriceKol.Texts = "0";
                    UpdateDb();
                }
                else
                {
                    MessageBoxFarsi.Show("محصول را بدرستی انتخاب کنید.", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string? ShomareQarardad = null;
                db.CheckShomareQarardad(txtShomareQarardad.Texts, ref ShomareQarardad);
                if (ShomareQarardad == null)
                {
                    db.UpdateQarardad(idQarardad, idPerson, txtDate.Texts, Convert.ToDouble(txtPriceHaml.Texts), txtShomareQarardad.Texts, txtMozoQarardad.Texts, txtModatQarardad.Texts, txtShomareEnsheab.Texts, txtDateEnsheab.Texts, txtDoreTazmin.Texts, txtModatRafeNaghz.Texts, Convert.ToDouble(txtPriceJarime.Texts), Convert.ToDouble(txtPaye.Texts), Convert.ToDouble(txtPricePishnahadi.Texts), Convert.ToDouble(txtZaribPeyman.Texts), Convert.ToDouble(txtTakhfif.Texts), Convert.ToDouble(txtMaliyat.Texts), Convert.ToDouble(txtPriceNahayi.Texts));
                    db.InsertEvent(frm_Main.userName, "بروز رسانی قرارداد به شماره " + txtShomareQarardad.Texts + "و آیدی "+idQarardad, frm_Login.strtoday + " " + DateTime.Now.ToString("HH:mm"));
                    frm_Qarardadha.UpdateDb();
                    MessageBoxFarsi.Show("قرارداد ثبت شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                }
                else
                {
                    MessageBoxFarsi.Show("شماره قرارداد تکراری است و امکان ثبت قرارداد با شماره یکسان وجود ندارد", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);

                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);

            }
        }

        private void txtPriceJarime_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPriceHaml_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumeric(sender, e);
        }

        private void txtCodeKala_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumeric(sender, e);
        }

        private void txtTedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumeric(sender, e);
        }

        private void txtPriceVahed_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumeric(sender, e);
        }

        private void txtCodeKala_Leave(object sender, EventArgs e)
        {
            try
            {
                db.GetProductsByCodeId(txtCodeKala.Texts, ref codeIdKala);
                if (codeIdKala != null)
                {
                    db.GetProductByCode(ref idKala, txtCodeKala.Texts, ref nameKala, ref vahedKala, ref priceKala1, ref priceDastmozd1, ref priceKala2, ref priceDastmozd2);
                    idProduct = int.Parse(idKala.ToString());
                    txtNameKala.Texts = nameKala;
                    txtPriceVahed.Texts = (priceKala1+priceDastmozd1).ToString();
                    GetFacotrByIdKala();
                }
                else
                {
                    MessageBoxFarsi.Show("کد کالا وارد شده اشتباه است", "عملیات نا موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                }

        }
            catch 
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
}
        private void GetFacotrByIdKala()
        {
            try
            {
                db.GetFactorByIdKala(ref refIdFactor, idQarardad, idProduct, ref codeIdKala, ref nameKala, ref tedadKala, ref priceVahedKala, ref priceKolKala);
                if (refIdFactor != null)
                {
                    idFactor = Convert.ToInt32(refIdFactor);
                    txtCodeKala.Texts = codeIdKala;
                    txtNameKala.Texts = nameKala;
                    txtTedad.Texts = tedadKala.ToString();
                    txtPriceVahed.Texts = priceVahedKala.ToString();
                    txtPriceKol.Texts = priceKolKala.ToString();
                    BtnEdit.Enabled = false;
                    BtnDelete.Enabled = false;
                    btnAdd.Visible = false;
                    btnCancel.Visible = true;
                    BtnOk.Visible = true;
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                idFactor = int.Parse(dgvFactor.CurrentRow.Cells[0].Value.ToString());
                db.GetFactorById(idFactor,ref idKala, ref codeIdKala, ref nameKala, ref tedadKala, ref priceVahedKala, ref priceKolKala);
                idProduct = int.Parse(idKala.ToString());
                txtCodeKala.Texts = codeIdKala;
                txtNameKala.Texts = nameKala;
                txtTedad.Texts = tedadKala.ToString();
                txtPriceVahed.Texts = priceVahedKala.ToString();
                txtPriceKol.Texts = priceKolKala.ToString();
                BtnEdit.Enabled = false;
                BtnDelete.Enabled = false;
                btnAdd.Visible = false;
                btnCancel.Visible = true;
                BtnOk.Visible = true;
            }
            catch 
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            idProduct = -1;
            txtCodeKala.Texts = String.Empty;
            txtNameKala.Texts = String.Empty;
            txtTedad.Texts = String.Empty;
            txtPriceVahed.Texts = String.Empty;
            txtPriceKol.Texts = String.Empty;
            btnCancel.Visible = false;
            BtnOk.Visible = false;
            btnAdd.Visible = true;
            UpdateDb();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (idProduct != -1)
                {
                    db.UpdateFactor(idFactor, idProduct, Double.Parse(txtTedad.Texts), Convert.ToDouble(txtPriceVahed.Texts), Convert.ToDouble(txtPriceKol.Texts));
                    db.InsertEvent(frm_Main.userName, "اضافه کردن محصول " + idProduct + " به فاکتور به قرارداد" + idProduct, frm_Login.strtoday + " " + DateTime.Now.ToString("HH:mm"));
                    idProduct = -1;
                    txtNameKala.Texts = "";
                    txtCodeKala.Texts = "";
                    txtTedad.Texts = "0";
                    txtPriceVahed.Texts = "0";
                    txtPriceKol.Texts = "0";
                    btnCancel.Visible = false;
                    BtnOk.Visible = false;
                    btnAdd.Visible = true;
                    UpdateDb();
                }
                else
                {
                    MessageBoxFarsi.Show("محصول را بدرستی انتخاب کنید.", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
                }
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
                if (MessageBoxFarsi.Show("آیا محصول  با مشخصات زیر حذف گردد؟" + "\n" + " کد محصول: " + dgvFactor.CurrentRow.Cells[3].Value + " \n نام محصول: " + dgvFactor.CurrentRow.Cells[4].Value , "حذف", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Delete, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    db.DeleteFactor((int)dgvFactor.CurrentRow.Cells[0].Value);
                    db.InsertEvent(frm_Main.userName, "+حذف محصول " + dgvFactor.CurrentRow.Cells[3].Value + " از قرارداد " + idQarardad, frm_Login.strtoday + " " + DateTime.Now.ToString("HH:mm"));
                    UpdateDb();
                }
            }
            catch 
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void calculatePrice()
        {
            double pricePishnahadi = 0;
            double priceMaliyat = 0;
            double? sumFactor= 0;
            double? zaribMaliyat = 0;
            try
            {
                db.GetSumFactor(idQarardad, ref sumFactor);// get sum factor
                db.GetZaribMaliyat(ref zaribMaliyat);//get zarib maliyat
                pricePishnahadi = double.Parse(txtPriceHaml.Texts) - double.Parse(txtTakhfif.Texts) + double.Parse(sumFactor.ToString());
                priceMaliyat = Math.Round(double.Parse(zaribMaliyat.ToString()) * pricePishnahadi / 100);
                txtZaribPeyman.Texts = Math.Round(pricePishnahadi / double.Parse(txtPaye.Texts),2).ToString();
                txtPricePishnahadi.Texts = pricePishnahadi.ToString();
                txtMaliyat.Texts = priceMaliyat.ToString();
                txtPriceNahayi.Texts = (pricePishnahadi + priceMaliyat).ToString();
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
            
        }

        private void txtPriceHaml_Leave(object sender, EventArgs e)
        {
            calculatePrice();
        }

        private void txtPaye_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumeric(sender, e);
        }

        private void txtTakhfif_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumeric(sender, e);
        }

        private void txtPaye_Leave(object sender, EventArgs e)
        {
            calculatePrice();
        }

        private void txtTakhfif_Leave(object sender, EventArgs e)
        {
            calculatePrice();
        }
    }
}

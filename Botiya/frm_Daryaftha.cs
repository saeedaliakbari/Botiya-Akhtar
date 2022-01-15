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
    public partial class frm_Daryaftha : Form
    {
        PersianCalendar pc = new PersianCalendar();
        public static int idQarardad = -1;
        private int idDaryafti = -1;
        public static string ShomareQarardad = string.Empty;
        double? priceKol = 0;
        double? priceDaryafti = 0;
        double? sumDaryafti = 0;
        BotiyaDataContext db = new BotiyaDataContext();
        public frm_Daryaftha()
        {
            InitializeComponent();
        }

        private void frm_Daryaftha_Load(object sender, EventArgs e)
        {
            try
            {
                txtShomareQarardad.Texts = ShomareQarardad;
                updateDb();
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

        private void updateDb()
        {
            bsBanks.DataSource = db.FillBank();
            cmbBank.SelectedIndex = 1;
            bsDaryaftha.DataSource = db.FillViewDaryafti(idQarardad);
            txtDateSar.Texts= pc.GetYear(DateTime.Now).ToString("0000") + "/" + pc.GetMonth(DateTime.Now).ToString("00") + "/" + pc.GetDayOfMonth(DateTime.Now).ToString("00");
            db.GetPriceQarardad(idQarardad, ref priceKol);
            db.GetSumDaryafti(idQarardad, ref sumDaryafti);
            lblPriceMande.Text = "مبلغ باقی مانده :" + ((double)priceKol - (double)sumDaryafti).ToString("#,#");
            if (dgvDaryafti.Rows.Count == 0)
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPrice.Texts == string.Empty)
                {
                    errorProvider1.SetError(txtPrice, "مقدار را وارد نمایید");
                }
                else
                {
                    db.InsertDaryaft(idQarardad, (int)cmbBankAsli.SelectedValue, txtDateSar.Texts, txtShomareCheck.Texts, Convert.ToDouble(txtPrice.Texts));
                    db.InsertEvent(frm_Main.userName, "ثبت دریافت برای قرارداد ایدی" + idQarardad, frm_Login.strtoday + " " + DateTime.Now.ToString("HH:mm"));
                    updateDb();
                    MessageBoxFarsi.Show("دریافتی جدید ثبت شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                }
            }
            catch
            {

                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                idQarardad =(int)dgvDaryafti.CurrentRow.Cells[1].Value;
                idDaryafti=(int)dgvDaryafti.CurrentRow.Cells[0].Value;
                txtShomareQarardad.Texts = ShomareQarardad;
                txtDateSar.Texts = dgvDaryafti.CurrentRow.Cells[4].Value.ToString();
                txtPrice.Texts = dgvDaryafti.CurrentRow.Cells[6].Value.ToString();
                txtShomareCheck.Texts = dgvDaryafti.CurrentRow.Cells[3].Value.ToString();
                cmbBank.SelectedIndex = 1;
                cmbBankAsli.SelectedValue = (int)dgvDaryafti.CurrentRow.Cells[2].Value;
                BtnEdit.Enabled = false;
                BtnDelete.Enabled = false;
                BtnAdd.Visible = false;
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
            txtDateSar.Texts = pc.GetYear(DateTime.Now).ToString("0000") + "/" + pc.GetMonth(DateTime.Now).ToString("00") + "/" + pc.GetDayOfMonth(DateTime.Now).ToString("00");
            cmbBank.SelectedIndex= 1;
            txtShomareCheck.Texts = string.Empty;
            txtPrice.Texts = "0";
            BtnEdit.Enabled = true;
            BtnDelete.Enabled = true;
            BtnAdd.Visible = true;
            btnCancel.Visible = false;
            BtnOk.Visible = false;

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPrice.Texts == string.Empty)
                {
                    errorProvider1.SetError(txtPrice, "مقدار را وارد نمایید");
                }
                else
                {
                    db.UpdateDaryaft(idDaryafti, (int)cmbBankAsli.SelectedValue, txtDateSar.Texts, txtShomareCheck.Texts, Convert.ToDouble(txtPrice.Texts));
                    db.InsertEvent(frm_Main.userName, "بروزرسانی دریافت برای قرارداد ایدی" + idQarardad, frm_Login.strtoday + " " + DateTime.Now.ToString("HH:mm"));
                    updateDb();
                    MessageBoxFarsi.Show("دریافتی بروزرسانی شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                    txtDateSar.Texts = pc.GetYear(DateTime.Now).ToString("0000") + "/" + pc.GetMonth(DateTime.Now).ToString("00") + "/" + pc.GetDayOfMonth(DateTime.Now).ToString("00");
                    cmbBank.SelectedIndex = 1;
                    txtShomareCheck.Texts = string.Empty;
                    txtPrice.Texts = "0";
                    BtnEdit.Enabled = true;
                    BtnDelete.Enabled = true;
                    BtnAdd.Visible = true;
                    btnCancel.Visible = false;
                    BtnOk.Visible = false;
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
                if (MessageBoxFarsi.Show("آیا  دریافتی  با مشخصات زیر حذف گردد؟" + "\n" + " شماره چک: " + dgvDaryafti.CurrentRow.Cells[3].Value + " \n مبلغ: " + dgvDaryafti.CurrentRow.Cells[6].Value + " \n تاریخ سررسید: " + dgvDaryafti.CurrentRow.Cells[4].Value, "حذف", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Delete, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    db.DeleteDaryafti((int)dgvDaryafti.CurrentRow.Cells[0].Value);
                    db.InsertEvent(frm_Main.userName, "حذف دریافت برای قرارداد ایدی" + dgvDaryafti.CurrentRow.Cells[0].Value, frm_Login.strtoday + " " + DateTime.Now.ToString("HH:mm"));
                    updateDb();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}

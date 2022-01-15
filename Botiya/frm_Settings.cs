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
    public partial class frm_Settings : Form
    {
        BotiyaDataContext db = new BotiyaDataContext();
        public frm_Settings()
        {
            InitializeComponent();
        }

        private void frm_Settings_Load(object sender, EventArgs e)
        {
            try
            {
                bsSetting.DataSource = db.FilltblSetting();
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                db.UpdatetblSetting(txtNameSherkat.Texts, txtShomareSabt.Texts, txtCodeEqtesadi.Texts, txtNameNamayande.Texts, txtFamilyNamayande.Texts, txtCodeMelliNamayande.Texts, txtSematNamayande.Texts, txtCodePosti.Texts, txtAddress.Texts, Convert.ToDouble(txtMaliyat.Texts));
                db.InsertEvent(frm_Main.userName, "بروزرسانی تنظیمات  ", frm_Login.strtoday + " " + DateTime.Now.ToString("HH:mm"));
                MessageBoxFarsi.Show("تنظیمات بروزرسانی شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void txtCodeMelliNamayande_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumeric(sender, e);
        }

        private void txtCodePosti_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumeric(sender, e);
        }

        private void txtMaliyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumeric(sender, e);
        }
    }
}

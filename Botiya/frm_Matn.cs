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
    public partial class frm_Matn : Form
    {
        BotiyaDataContext db = new BotiyaDataContext();
        public frm_Matn()
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
                db.UpdateMatnQarardad(txtMade1.Texts, txtMade2.Texts, txtMade3.Texts, txtMade4.Texts, txtMade5.Texts, txtMade6.Texts, txtMade7.Texts, txtMade8.Texts, txtMade9.Texts, txtMade10.Texts, txtMade11.Texts, txtMade12.Texts, txtMade13.Texts, txtMade14.Texts, txtMade15.Texts);
                db.InsertEvent(frm_Main.userName, "بروز رسانی متن قر ارداد ", frm_Login.strtoday + " " + DateTime.Now.ToString("HH:mm"));
                MessageBoxFarsi.Show("متن قرارداد ثبت شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void frm_Matn_Load(object sender, EventArgs e)
        {
            try
            {
                bsMatnQarardad.DataSource = db.FillMatnQarardad();
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}

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
    public partial class frm_Qarardadha : Form
    {
        BotiyaDataContext db = new BotiyaDataContext();
        public frm_Qarardadha()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            frm_AddQarardad.idPerson = -1;
            frm_AddQarardad.idProduct = -1;
            frm_AddQarardad.idQarardad = -1;
            frm_AddQarardad.frm_Qarardadha = this;
            frm_AddQarardad.dateString = string.Empty;
            new frm_AddQarardad().ShowDialog();
        }

        private void frm_Qarardadha_Load(object sender, EventArgs e)
        {
            try
            {
                UpdateDb();
            }
            catch
            {

                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
        public void UpdateDb()
        {
                bsViewQarardadPerson.DataSource = db.FillViewQarardadPerson();
                if (dgvQarardad.Rows.Count == 0)
                {
                btnPrint.Enabled = false;
                    BtnDelete.Enabled = false;
                    BtnEdit.Enabled = false;
                }
                else
                {
                btnPrint.Enabled = true;
                    BtnDelete.Enabled = true;
                    BtnEdit.Enabled = true;

                }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                frm_AddQarardad.frm_Qarardadha = this;
                frm_AddQarardad.idQarardad = (int)dgvQarardad.CurrentRow.Cells[0].Value;
                frm_AddQarardad.idPerson = (int)dgvQarardad.CurrentRow.Cells[1].Value;
                new frm_AddQarardad().ShowDialog();
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
                if (MessageBoxFarsi.Show("آیا قرارداد  با مشخصات زیر حذف گردد؟" + "\n" + " شماره قرارداد: " + dgvQarardad.CurrentRow.Cells[8].Value + "\n" + " نام و نام خانوادگی مشتری: " + dgvQarardad.CurrentRow.Cells[2].Value + " " + dgvQarardad.CurrentRow.Cells[3].Value, "حذف", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Delete, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    db.DeleteQarardad((int)dgvQarardad.CurrentRow.Cells[0].Value);
                    UpdateDb();
                }
            }
            catch
            {

                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void txtSearchFamily__TextChanged(object sender, EventArgs e)
        {
            try
            {
                bsViewQarardadPerson.DataSource = db.FillViewQarardadPersonByName(txtSearchFamily.Texts);
                if (dgvQarardad.Rows.Count == 0)
                {
                    btnPrint.Enabled = false;
                    BtnDelete.Enabled = false;
                    BtnEdit.Enabled = false;
                }
                else
                {
                    btnPrint.Enabled = true;
                    BtnDelete.Enabled = true;
                    BtnEdit.Enabled = true;

                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}

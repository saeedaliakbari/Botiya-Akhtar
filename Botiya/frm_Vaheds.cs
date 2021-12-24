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
    public partial class frm_Vaheds : Form
    {
        BotiyaDataContext db = new BotiyaDataContext();
        private int idVahed = -1;
        public frm_Vaheds()
        {
            InitializeComponent();
        }

        private void frm_Vaheds_Load(object sender, EventArgs e)
        {
            try
            {
                bsVaheds.DataSource = db.FillVaheds();
                CheckDgv();
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtVahedName.Texts == String.Empty)
                {
                    errorProvider1.SetError(txtVahedName, "ورود مقدار الزامی است");
                }
                else
                {
                    errorProvider1.Clear();
                    db.InsertVahed(txtVahedName.Texts);
                    MessageBoxFarsi.Show("واحد جدید افزوده شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                    txtVahedName.Texts = String.Empty;
                    bsVaheds.DataSource = db.FillVaheds();
                    CheckDgv();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1, true, false);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            txtVahedName.Texts = dgvVaheds.CurrentRow.Cells[1].Value.ToString();
            idVahed = (int)dgvVaheds.CurrentRow.Cells[0].Value;
            ManageEditMode(true);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtVahedName.Texts = String.Empty;
            ManageEditMode(false);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtVahedName.Texts == String.Empty)
                {
                    errorProvider1.SetError(txtVahedName, "ورود مقدار الزامی است");
                }
                else
                {
                    errorProvider1.Clear();
                    db.UpdateVahed(idVahed, txtVahedName.Texts);
                    MessageBoxFarsi.Show("واحد ویرایش شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                    txtVahedName.Texts = String.Empty;
                    bsVaheds.DataSource = db.FillVaheds();
                    ManageEditMode(false);
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1, true, false);
            }
        }
        private void ManageEditMode(bool edit)
        {
            BtnDelete.Enabled = !edit;
            BtnBack.Enabled = !edit;
            BtnAdd.Visible = !edit;
            BtnEdit.Visible = !edit;
            btnCancel.Visible = edit;
            BtnOk.Visible = edit;
        }
        private void CheckDgv()
        {
            if (dgvVaheds.Rows.Count == 0)
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFarsi.Show("آیا واحد "+ dgvVaheds.CurrentRow.Cells[1].Value + "  حذف گردد؟" , "حذف", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Delete, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    db.DeleteVahed((int)dgvVaheds.CurrentRow.Cells[0].Value);
                    bsVaheds.DataSource = db.FillVaheds();
                    CheckDgv();
                }
            }
            catch
            {

                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}

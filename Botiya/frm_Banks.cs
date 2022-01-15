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
    public partial class frm_Banks : Form
    {
        BotiyaDataContext db = new BotiyaDataContext();
        string? nameBankCheck = string.Empty;
        private int idBank = -1;
        public frm_Banks()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                nameBankCheck = string.Empty;
                db.GetBankByName(txtName.Texts, ref nameBankCheck);
                if (txtName.Texts == String.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtName, "ورود مقدار الزامی است");
                }
                else if (nameBankCheck != string.Empty && txtName.Texts!=(string)dgvBanks.CurrentRow.Cells[1].Value)
                {
                    nameBankCheck = String.Empty;
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtName, "مثدار تکراری است");
                }
                else
                {
                    errorProvider1.Clear();
                    db.UpdateVahed(idBank, txtName.Texts);
                    db.InsertEvent(frm_Main.userName, "بروز کردن بانک "+txtName.Texts, frm_Main.strtoday + " " + DateTime.Now.ToString("HH:mm"));
                    MessageBoxFarsi.Show("بانک ویرایش شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                    txtName.Texts = String.Empty;
                    nameBankCheck = String.Empty;
                    bsBank.DataSource = db.FillBank();
                    ManageEditMode(false);
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1, true, false);
            }
        }

        private void frm_Banks_Load(object sender, EventArgs e)
        {
            try
            {
                bsBank.DataSource = db.FillBank();
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
                db.GetBankByName(txtName.Texts, ref nameBankCheck);
                if (txtName.Texts == String.Empty)
                {
                    errorProvider1.SetError(txtName, "ورود مقدار الزامی است");
                }
                else if (nameBankCheck != null)
                {
                    nameBankCheck = String.Empty;
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtName, "مثدار تکراری است");

                }
                else
                {
                    errorProvider1.Clear();
                    db.InsertBank(txtName.Texts);
                    db.InsertEvent(frm_Main.userName, "اضافه کردن بانک " + txtName.Texts, frm_Main.strtoday + " " + DateTime.Now.ToString("HH:mm"));
                    MessageBoxFarsi.Show("بانک جدید افزوده شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                    txtName.Texts = String.Empty;
                    nameBankCheck = String.Empty;
                    bsBank.DataSource = db.FillBank();
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
            txtName.Texts = dgvBanks.CurrentRow.Cells[1].Value.ToString();
            idBank = (int)dgvBanks.CurrentRow.Cells[0].Value;
            ManageEditMode(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtName.Texts = String.Empty;
            ManageEditMode(false);
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
            if (dgvBanks.Rows.Count == 0)
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
                if (MessageBoxFarsi.Show("آیا بانک " + dgvBanks.CurrentRow.Cells[1].Value + "  حذف گردد؟", "حذف", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Delete, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    db.DeleteBank((int)dgvBanks.CurrentRow.Cells[0].Value);
                    db.InsertEvent(frm_Main.userName, "حذف کردن بانک " + dgvBanks.CurrentRow.Cells[1].Value, frm_Main.strtoday + " " + DateTime.Now.ToString("HH:mm"));
                    bsBank.DataSource = db.FillBank();
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

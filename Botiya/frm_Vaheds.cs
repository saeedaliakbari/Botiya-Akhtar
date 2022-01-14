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
        string? nameVahedCheck = string.Empty;
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
                db.GetVahedByName(txtVahedName.Texts, ref nameVahedCheck);
                if (txtVahedName.Texts == String.Empty)
                {
                    errorProvider1.SetError(txtVahedName, "ورود مقدار الزامی است");
                }
                else if (nameVahedCheck!= null)
                {
                    nameVahedCheck = String.Empty;
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtVahedName, "مثدار تکراری است");
                    
                }
                else
                {
                    errorProvider1.Clear();
                    db.InsertVahed(txtVahedName.Texts);
                    MessageBoxFarsi.Show("واحد جدید افزوده شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                    txtVahedName.Texts = String.Empty;
                    nameVahedCheck = String.Empty;
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
                db.GetVahedByName(txtVahedName.Texts, ref nameVahedCheck);
                if (txtVahedName.Texts == String.Empty)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtVahedName, "ورود مقدار الزامی است");
                }
                else if (nameVahedCheck != string.Empty && txtVahedName.Texts!=(string)dgvVaheds.CurrentRow.Cells[1].Value)
                {
                    nameVahedCheck = String.Empty;
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtVahedName, "مثدار تکراری است");
                }
                else
                {
                    errorProvider1.Clear();
                    db.UpdateVahed(idVahed, txtVahedName.Texts);
                    MessageBoxFarsi.Show("واحد ویرایش شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                    txtVahedName.Texts = String.Empty;
                        nameVahedCheck = String.Empty;
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
                    int? resultVahed = null;
                    db.CheckDeleteVahed((int)dgvVaheds.CurrentRow.Cells[0].Value, ref resultVahed);
                    if (resultVahed is null)
                    {
                        db.DeleteVahed((int)dgvVaheds.CurrentRow.Cells[0].Value);
                        bsVaheds.DataSource = db.FillVaheds();
                        CheckDgv();
                    }
                    else
                    {
                        MessageBoxFarsi.Show("واحد انتخاب شده در محصولات استفاده شده است و امکان حذف آن وجود ندارد", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1, true, false);
                    }
                }
            }
            catch
            {

                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}

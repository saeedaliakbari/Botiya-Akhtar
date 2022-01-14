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
    public partial class frm_Users : Form
    {
        BotiyaDataContext db = new BotiyaDataContext();
        private int idUser = -1;
        public frm_Users()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string? usernameCheck = null;
                db.GetVahedByName(txtUserName.Texts, ref usernameCheck);
                if (txtFName.Texts == String.Empty)
                {
                    errorProvider1.SetError(txtFName, "ورود مقدار الزامی است");
                }else if (txtLName.Texts == String.Empty)
                {
                    errorProvider1.SetError(txtLName, "ورود مقدار الزامی است");
                }else if (txtUserName.Texts == String.Empty)
                {
                    errorProvider1.SetError(txtUserName, "ورود مقدار الزامی است");
                }
                else if (txtPassword.Texts == String.Empty)
                {
                    errorProvider1.SetError(txtPassword, "ورود مقدار الزامی است");
                }
                else if (usernameCheck != null && txtUserName.Texts != (string)dgvUsers.CurrentRow.Cells[3].Value)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtUserName, "مثدار تکراری است");
                }
                else
                {
                    errorProvider1.Clear();
                    db.InsertUsers(txtFName.Texts,txtLName.Texts,txtUserName.Texts,txtPassword.Texts);
                    MessageBoxFarsi.Show("کاربر جدید افزوده شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                    txtFName.Texts = String.Empty;
                    txtLName.Texts = String.Empty;
                    txtPassword.Texts= String.Empty;
                    txtUserName.Texts= String.Empty;
                    CheckDgv();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1, true, false);
            }
        }
        private void CheckDgv()
        {
            bsUsers.DataSource = db.FillUsers();
            if (dgvUsers.Rows.Count < 2)
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
        private void ManageEditMode(bool edit)
        {
            BtnDelete.Enabled = !edit;
            BtnBack.Enabled = !edit;
            BtnAdd.Visible = !edit;
            BtnEdit.Visible = !edit;
            btnCancel.Visible = edit;
            BtnOk.Visible = edit;
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFarsi.Show("آیا کاربر " + dgvUsers.CurrentRow.Cells[3].Value + "  حذف گردد؟", "حذف", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Delete, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    db.DeleteUser((int)dgvUsers.CurrentRow.Cells[0].Value);
                    CheckDgv();
                }
            }
            catch
            {

                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void frm_Users_Load(object sender, EventArgs e)
        {
            try
            {
                bsUsers.DataSource = db.FillUsers();
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            txtFName.Texts = dgvUsers.CurrentRow.Cells[1].Value.ToString();
            txtLName.Texts = dgvUsers.CurrentRow.Cells[2].Value.ToString();
            txtUserName.Texts = dgvUsers.CurrentRow.Cells[3].Value.ToString();
            txtPassword.Texts = string.Empty;
            idUser = (int)dgvUsers.CurrentRow.Cells[0].Value;
            ManageEditMode(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtFName.Texts = String.Empty;
            txtLName.Texts = String.Empty;
            txtUserName.Texts = String.Empty;
            txtPassword.Texts = String.Empty;
            ManageEditMode(false);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                string? usernameCheck = null;
                db.GetVahedByName(txtUserName.Texts, ref usernameCheck);
                if (txtFName.Texts == String.Empty)
                {
                    errorProvider1.SetError(txtFName, "ورود مقدار الزامی است");
                }
                else if (txtLName.Texts == String.Empty)
                {
                    errorProvider1.SetError(txtLName, "ورود مقدار الزامی است");
                }
                else if (txtUserName.Texts == String.Empty)
                {
                    errorProvider1.SetError(txtUserName, "ورود مقدار الزامی است");
                }
                else if (txtPassword.Texts == String.Empty)
                {
                    errorProvider1.SetError(txtPassword, "ورود مقدار الزامی است");
                }
                else if (usernameCheck != null && txtUserName.Texts != (string)dgvUsers.CurrentRow.Cells[3].Value)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtUserName, "مثدار تکراری است");
                }
                else
                {
                    errorProvider1.Clear();
                    db.UpdateUsers((int)dgvUsers.CurrentRow.Cells[0].Value,txtFName.Texts, txtLName.Texts, txtUserName.Texts, txtPassword.Texts);
                    MessageBoxFarsi.Show("کاربر ویرایش افزوده شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                    txtFName.Texts = String.Empty;
                    txtLName.Texts = String.Empty;
                    txtPassword.Texts = String.Empty;
                    txtUserName.Texts = String.Empty;
                    CheckDgv();
                    ManageEditMode(false);
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1, true, false);
            }
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = !txtPassword.PasswordChar;
        }
    }
}

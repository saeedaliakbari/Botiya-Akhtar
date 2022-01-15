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
    public partial class frm_Login : Form
    {
        BotiyaDataContext db = new BotiyaDataContext();
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = !txtPassword.PasswordChar;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Texts==string.Empty)
            {
                errorProvider1.SetError(txtUserName,"مقدار الزامی می باشد");
            }else if (txtPassword.Texts == string.Empty) {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPassword,"مقدار الزامی می باشد");
            }else
            {
                errorProvider1.Clear();
                int? idUser = null;
                try
                {
                    db.CheckUserPass(txtUserName.Texts, txtPassword.Texts, ref idUser);
                    if (idUser == null)
                    {
                        errorProvider1.SetError(txtUserName, "نام کاربری یا رمزعبور اشتباه است");
                        db.InsertEvent(txtUserName.Texts, "اشتباه در وارد کردن رمز عبور یا نام کاربری",DateTime.Now.ToString());
                        txtUserName.Focus();
                    }
                    else
                    {
                        db.InsertEvent(txtUserName.Texts, "ورود موفقیت آمیز", DateTime.Now.ToString());
                        frm_Main.idUser = (int)idUser;
                        new frm_Main().ShowDialog();
                    }
                }
                catch
                {
                    MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1, true, false);
                }
            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(DateTime.Now.ToString());
            //MessageBox.Show(DateTime.Now.ToString("HH:mm"));
        }
    }
}

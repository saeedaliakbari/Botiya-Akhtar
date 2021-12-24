using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BehComponents;

namespace Botiya
{
    public partial class frm_PersonInfo : Form
    {
        BotiyaDataContext db = new BotiyaDataContext();
        public static bool editMode = false;
        public static int idPerson = -1;
        public static frm_Persons frmPerson = null;
        string? fName = "";
        string? lName = "";
        string? fatherName = "";
        string? codeMelli = "";
        string? phone = "";
        string? mobile = "";
        string? address = "";
        string? sherkatName = "";
        int? hoqoqi = 0;
        public frm_PersonInfo()
        {
            InitializeComponent();
        }
        public void clear()
        {
            TgbHoghoghi.Checked = false;
            txtAddress.Texts = String.Empty;
            txtCodeMelli.Texts = String.Empty;
            txtFatherName.Texts = String.Empty;
            txtfName.Texts = String.Empty;
            txtLName.Texts = String.Empty;
            txtMobile.Texts = String.Empty;
            txtPhone.Texts = String.Empty;
            txtSherkatName.Texts = String.Empty;
            txtfName.Focus();
        }

        private void frm_PersonInfo_Load(object sender, EventArgs e)
        {
            if (editMode)
            {
                bsPerson.DataSource = db.FillPersonsById(idPerson);
                db.GetPerson(idPerson, ref fName, ref lName, ref fatherName, ref codeMelli, ref phone, ref mobile, ref address, ref hoqoqi, ref sherkatName);
                txtfName.Texts = fName;
                txtLName.Texts = lName;
                txtFatherName.Texts = fatherName;
                txtCodeMelli.Texts = codeMelli;
                txtPhone.Texts = phone;
                txtMobile.Texts = mobile;
                txtAddress.Texts = address;
                txtSherkatName.Texts = sherkatName;
                if (hoqoqi == 1) TgbHoghoghi.Checked = true;
                else TgbHoghoghi.Checked = false;
            }
            else
            {
                clear();

            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLName.Texts == String.Empty)
                {
                    errorProvider1.SetError(txtLName, "ورود مقدار الزامی است");
                }else if (TgbHoghoghi.Checked && txtSherkatName.Texts==String.Empty)
                {
                    errorProvider1.SetError(txtSherkatName, "ورود مقدار الزامی است");
                }
                else
                {
                    errorProvider1.Clear();
                    if (editMode)
                    {
                        db.UpdatePerson(idPerson, txtfName.Texts, txtLName.Texts, txtFatherName.Texts, txtCodeMelli.Texts, txtPhone.Texts, txtMobile.Texts, txtAddress.Texts, TgbHoghoghi.Checked ? 1 : 0, txtSherkatName.Texts);
                        MessageBoxFarsi.Show("مشتری ویرایش شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                        this.Close();
                    }
                    else
                    {
                        db.InsertPersons(txtfName.Texts, txtLName.Texts, txtFatherName.Texts, txtCodeMelli.Texts, txtPhone.Texts, txtMobile.Texts, txtAddress.Texts, TgbHoghoghi.Checked ? 1 : 0, txtSherkatName.Texts);
                        MessageBoxFarsi.Show("مشتری جدید افزوده شد", "عملیات موفق", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                        clear();
                    }
                    frmPerson.UpdateDb();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1, true, false);
            }
           
            
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}

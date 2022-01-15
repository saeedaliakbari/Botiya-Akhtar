using BehComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Botiya
{
    public partial class frm_Attach : Form
    {
        BotiyaDataContext db = new BotiyaDataContext();
        public static int idQararad = -1;
        public static string ShomareQarardad="";
        public int idFile = -1;
        public frm_Attach()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter="(*.jpg;*.jepg;*.bmp)| *.jpg; *.jpeg; *.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picAttach.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private byte[] ImageToByteArray(Image imgIn)
        {
            using(MemoryStream ms=new MemoryStream())
            {
                imgIn.Save(ms, imgIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (picAttach.Image == null) {
                errorProvider1.SetError(btnSelect, "انتخاب عکس اجباری می باشد");
                
            }
            else
            {
                errorProvider1.Clear();
                byte[] fileByte = ImageToByteArray(picAttach.Image);
                Binary fileBinary = new Binary(fileByte);
                try
                {
                    db.InsertFile(idQararad, txtComment.Texts, fileBinary);
                    db.InsertEvent(frm_Main.userName, "اضافه کردن فایل ضمیمه به قرارداد" +idQararad+"با توضیحات "+ txtComment.Texts, frm_Main.strtoday + " " + DateTime.Now.ToString("HH:mm"));
                    txtComment.Texts = string.Empty;
                    picAttach.Image = null;
                    updateDb();
                }
                catch
                {

                    MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
                }
            }
        }

        private void frm_Attach_Load(object sender, EventArgs e)
        {
            try
            {
                txtShomareQarardad.Texts = ShomareQarardad.ToString();
                updateDb();
            }
            catch
            {

                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
        private void updateDb()
        {
            bsFile.DataSource = db.FillAttach(idQararad);
            if (dgvAttach.Rows.Count == 0)
            {
                btnViewPic.Enabled = false;
                BtnDelete.Enabled = false;
                BtnEdit.Enabled = false;
            }
            else
            {
                btnViewPic.Enabled = true;
                BtnDelete.Enabled = true;
                BtnEdit.Enabled = true;

            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFarsi.Show("آیا فایل ضمیمه  با مشخصات زیر حذف گردد؟" + "\n" + " توضیحات: " + dgvAttach.CurrentRow.Cells[2].Value , "حذف", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Delete, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    db.DeleteFile((int)dgvAttach.CurrentRow.Cells[0].Value);
                    db.InsertEvent(frm_Main.userName, "حذف کردن فایل ضمیمه به قرارداد" + idQararad + "با توضیحات " + dgvAttach.CurrentRow.Cells[2].Value, frm_Main.strtoday + " " + DateTime.Now.ToString("HH:mm"));
                    updateDb();
                }
            }
            catch
            {

                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using(MemoryStream ms=new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                idFile = (int)dgvAttach.CurrentRow.Cells[0].Value;
                bsFileById.DataSource = db.FillAttachById(idFile);
                idQararad = (int)dgvAttach.CurrentRow.Cells[1].Value;
                byte[] photo_aray;
                picAttach.Image = null;
                if (dgvAttach.CurrentRow.Cells[3].Value != System.DBNull.Value)
                {
                    photo_aray = ((Binary)dgvAttach.CurrentRow.Cells[3].Value).ToArray();
                    MemoryStream ms = new MemoryStream(photo_aray);
                    picAttach.Image = Image.FromStream(ms);
                }
                dgvAttach.Enabled = false;
                BtnOk.Visible = true;
                btnCancel.Visible = true;
                BtnAdd.Visible = false;
                BtnEdit.Visible = false;
                BtnDelete.Visible = false;
                btnViewPic.Visible = false;
            }
            catch
            {

                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgvAttach.Enabled = true;
            BtnOk.Visible = false;
            btnCancel.Visible = false;
            BtnAdd.Visible = true;
            BtnEdit.Visible = true;
            BtnDelete.Visible = true;
            btnViewPic.Visible = true;
            picAttach.Image = null;
            txtComment.Texts = string.Empty;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (picAttach.Image == null)
            {
                errorProvider1.SetError(btnSelect, "انتخاب عکس اجباری می باشد");

            }
            else
            {
                byte[] fileByte = ImageToByteArray(picAttach.Image);
                Binary fileBinary = new Binary(fileByte);
                try
                {
                    db.UpdateFile(idFile, idQararad, txtComment.Texts, fileBinary);
                    db.InsertEvent(frm_Main.userName, "بروز کردن فایل ضمیمه به قرارداد" + idQararad + "با توضیحات " + txtComment.Texts, frm_Main.strtoday + " " + DateTime.Now.ToString("HH:mm"));
                    txtComment.Texts = string.Empty;
                    picAttach.Image = null;
                    updateDb();
                    dgvAttach.Enabled = true;
                    BtnOk.Visible = false;
                    btnCancel.Visible = false;
                    BtnAdd.Visible = true;
                    BtnEdit.Visible = true;
                    BtnDelete.Visible = true;
                    btnViewPic.Visible = true;
                    txtComment.Texts = string.Empty;
                    picAttach.Image = null;
                }
                catch
                {

                    MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
                }
            }
            
        }
        
        private void btnViewPic_Click(object sender, EventArgs e)
        {
            byte[] photo_aray;
            picAttach.Image = null;
            if (dgvAttach.CurrentRow.Cells[3].Value != System.DBNull.Value)
            {
                photo_aray = ((Binary)dgvAttach.CurrentRow.Cells[3].Value).ToArray();
                MemoryStream ms = new MemoryStream(photo_aray);
                picAttach.Image= Image.FromStream(ms);
            }
        }  
    }
}

using BehComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Botiya
{
    public partial class frm_Main : Form
    {
        BotiyaDataContext db = new BotiyaDataContext();
        PersianCalendar pc = new PersianCalendar();
        public static string strtoday = "";
        public static int idUser = -1;
        public static string userName = null;
        public frm_Main()
        {
            InitializeComponent();
        }
        //#FF4682B4
        //#d2691e
        private void تعریفToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            تعریفToolStripMenuItem.ForeColor = Color.Chocolate;
        }

        private void تعریفToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            تعریفToolStripMenuItem.ForeColor = Color.White;
        }

        private void عملیاتToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            عملیاتToolStripMenuItem.ForeColor = Color.White;

        }

        private void عملیاتToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            عملیاتToolStripMenuItem.ForeColor = Color.Chocolate;

        }

        private void تنظیماتToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            تنظیماتToolStripMenuItem.ForeColor = Color.White;

        }

        private void تنظیماتToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            تنظیماتToolStripMenuItem.ForeColor = Color.Chocolate;

        }

        private void پشتیبانیToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void پشتیبانیToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            پشتیبانیToolStripMenuItem.ForeColor = Color.White;

        }

        private void پشتیبانیToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            پشتیبانیToolStripMenuItem.ForeColor = Color.Chocolate;
        }

        private void کارفرماToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_Persons().ShowDialog();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBoxFarsi.Show("از خروج مطمئنید؟", "خروج از برنامه", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Stop, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                Application.Exit();
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            strtoday = pc.GetYear(DateTime.Now).ToString("0000") + "/" + pc.GetMonth(DateTime.Now).ToString("00") + "/" + pc.GetDayOfMonth(DateTime.Now).ToString("00");
            try
            {
                bsUser.DataSource = db.FillUsersById(idUser);
                userName = lblUsername.Text;
                MessageBox.Show(userName);
                lblMain.Text = "تاریخ امروز: " + strtoday;
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1, true, false);
            }

        }

        private void واحدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_Vaheds().ShowDialog();
        }

        private void محصولاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_Products().ShowDialog();
        }

        private void ایجادقراردادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_AddQarardad.idPerson = -1;
            //frm_AddQarardad.idProduct = -1;
            //frm_AddQarardad.idQarardad = -1;
            //frm_AddQarardad.dateString = string.Empty;
            //new frm_AddQarardad().ShowDialog();
            new frm_Qarardadha().ShowDialog();
        }

        private void متنقراردادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_Matn().ShowDialog();
        }

        private void نرخارزشافزودهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_Settings().ShowDialog();
        }

        private void بانکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_Banks().ShowDialog();
        }

        private void ذخیرهسازیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            string str_filename = string.Empty;
            sfd.FileName = "backup_BeratAj_" + strtoday.Replace("/", "_");
            sfd.Filter = @"backup files(*.bak)|*.bak|all files(*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.OverwritePrompt = true;
            sfd.Title = "***ذخیره سازی پشتیبان***";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                str_filename = sfd.FileName;
                backup(str_filename);
            }
        }
        private void backup(string str_filename)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                db.ExecuteCommand(@"BACKUP DATABASE " + db.Mapping.DatabaseName + " to DISK='" + str_filename + "'");
                this.Cursor = Cursors.Default;
                db.InsertEvent(userName, "پشتیبان گیری به تاریخ" + strtoday, strtoday + " " + DateTime.Now.ToString("HH:mm"));
                MessageBox.Show("عملیات ذخیره سازی موفقیت آمیز بود");
            }
            catch (Exception ex)
            {
                MessageBox.Show("عملیات ذخیره سازی موفقیت آمیز نبود |" + ex.Message);
            }
        }

        private void بازیابیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog sfd = new OpenFileDialog();
            string str_filename = string.Empty;

            sfd.Filter = @"backup files(*.bak)|*.bak|all files(*.*)|*.*";
            sfd.FilterIndex = 1;

            sfd.Title = "***بازیابی پشتیبان***";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                str_filename = sfd.FileName;
                restore(str_filename);


            }
        }
        private void restore(string str_filename)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;
                db.ExecuteCommand(@"ALTER DATABASE " + db.Mapping.DatabaseName + "  SET SINGLE_USER with ROLLBACK IMMEDIATE "
               + " USE MASTER " +
               "  RESTORE DATABASE " + db.Mapping.DatabaseName + " from DISK='" + str_filename + "' with REPLACE");
                this.Cursor = Cursors.Default;
                db.InsertEvent(userName, "بازیابی فایل " + str_filename, strtoday + " " + DateTime.Now.ToString("HH:mm"));
                MessageBox.Show("عملیات بازیابی پشتیبان موفقیت آمیز بود");
            }
            catch (Exception ex)
            {
                MessageBox.Show("عملیات بازیابی پشتیبان موفقیت آمیز نبود|" + ex.Message);
            }
        }

        private void کاربرانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frm_Users().ShowDialog();
        }
    }
}

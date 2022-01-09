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
    public partial class frm_Main : Form
    {
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
            Application.Exit();
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            
           
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
    }
}

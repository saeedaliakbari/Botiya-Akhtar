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
    public partial class frm_Qarardad_SelectProduct : Form
    {
        BotiyaDataContext db = new BotiyaDataContext();
        public frm_Qarardad_SelectProduct()
        {
            InitializeComponent();
        }

        private void rdbName_CheckedChanged(object sender, EventArgs e)
        {
            txtSerachNameKala.Enabled = true;
            txtSerachCodeKala.Enabled = false;
            load();
        }

        private void rdbCode_CheckedChanged(object sender, EventArgs e)
        {
            txtSerachNameKala.Enabled = false;
            txtSerachCodeKala.Enabled = true;
            load();
        }
        private void load()
        {
            try
            {
                txtSerachNameKala.Texts = String.Empty;
                txtSerachCodeKala.Texts = String.Empty;
                bsViewProduct.DataSource = db.FillViewProductVahed();
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1, true, false);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            new frm_AddQarardad().ShowDialog();
        }

        private void txtSerachNameKala__TextChanged(object sender, EventArgs e)
        {
            try
            {
                bsViewProduct.DataSource = db.FillViewPrdouctByName(txtSerachNameKala.Texts);
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1, true, false);
            }
        }

        private void txtSerachCodeKala__TextChanged(object sender, EventArgs e)
        {
            try
            {
                bsViewProduct.DataSource = db.FillViewPrdouctByCode(txtSerachNameKala.Texts);
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1, true, false);
            }
        }

        private void frm_Qarardad_SelectProduct_Load(object sender, EventArgs e)
        {
            load();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            frm_AddQarardad.idProduct = (int)dgvProducts.CurrentRow.Cells[0].Value;
            new frm_AddQarardad().ShowDialog();
            this.Close();
        }

        private void txtSerachCodeKala_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
    }
}

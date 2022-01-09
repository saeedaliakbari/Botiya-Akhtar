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
    public partial class frm_Qarardad_SelectPerson : Form
    {
        BotiyaDataContext db = new BotiyaDataContext();
        public frm_Qarardad_SelectPerson()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            new frm_AddQarardad().ShowDialog();
        }

        private void rdbCodeMelli_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchName.Enabled = false;
            txtSerachCodeMelli.Enabled = true;
            load();
        }

        private void rdbName_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchName.Enabled = true;
            txtSerachCodeMelli.Enabled = false;
            load();
        }

        private void txtSearchName__TextChanged(object sender, EventArgs e)
        {
            try
            {
                bsPerson.DataSource = db.FillPersonByLname(txtSearchName.Texts);
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1, true, false);
            }
        }

        private void txtSerachCodeMelli__TextChanged(object sender, EventArgs e)
        {
            try
            {
                bsPerson.DataSource = db.FillPersonByCodeMelli(txtSerachCodeMelli.Texts);
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1, true, false);
            }
        }

        private void frm_Qarardad_SelectPerson_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            try
            {
                txtSerachCodeMelli.Texts = String.Empty;
                txtSearchName.Texts = String.Empty;
                bsPerson.DataSource = db.FillPersons();
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1, true, false);
            }
        }


        private void BtnOk_Click(object sender, EventArgs e)
        {
            frm_AddQarardad.idPerson = (int)dgvPerson.CurrentRow.Cells[0].Value;
            new frm_AddQarardad().ShowDialog();
            this.Close();
            

        }

        private void txtSerachCodeMelli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
    }
}

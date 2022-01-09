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
    public partial class frm_Persons : Form
    {
        BotiyaDataContext db = new BotiyaDataContext();
        public frm_Persons()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frm_PersonInfo.editMode = false;
                frm_PersonInfo.frmPerson = this;
                new frm_PersonInfo().ShowDialog();
            }
            catch
            {

                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }



        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                frm_PersonInfo.editMode = true;
                frm_PersonInfo.frmPerson = this;
                frm_PersonInfo.idPerson = (int)dgvPesons.CurrentRow.Cells[0].Value;
                new frm_PersonInfo().ShowDialog();
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

        private void frm_Persons_Load(object sender, EventArgs e)
        {
            try
            {
                UpdateDb();
            }
            catch
            {

                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFarsi.Show("آیا مشتری  با مشخصات زیر حذف گردد؟" + "\n" + " " + dgvPesons.CurrentRow.Cells[1].Value + " " + dgvPesons.CurrentRow.Cells[2].Value + " نام پدر : " + dgvPesons.CurrentRow.Cells[3].Value, "حذف", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Delete, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    db.DeletePerson((int)dgvPesons.CurrentRow.Cells[0].Value);
                    UpdateDb();
                }
            }
            catch
            {

                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
        public void UpdateDb()
        {
            bsPersons.DataSource = db.FillPersons();
            if (dgvPesons.Rows.Count == 0)
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

        private void txtSearchFamily__TextChanged(object sender, EventArgs e)
        {
            try
            {
                bsPersons.DataSource = db.FillPersonByLname(txtSearchFamily.Texts);
                if (dgvPesons.Rows.Count == 0)
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
            catch
            {

                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}

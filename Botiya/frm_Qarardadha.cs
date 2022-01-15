using BehComponents;
using JntNum2Text;
using Stimulsoft.Report;
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
    public partial class frm_Qarardadha : Form
    {
        BotiyaDataContext db = new BotiyaDataContext();
        public frm_Qarardadha()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            frm_AddQarardad.idPerson = -1;
            frm_AddQarardad.idProduct = -1;
            frm_AddQarardad.idQarardad = -1;
            frm_AddQarardad.frm_Qarardadha = this;
            frm_AddQarardad.dateString = string.Empty;
            new frm_AddQarardad().ShowDialog();
        }

        private void frm_Qarardadha_Load(object sender, EventArgs e)
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
        public void UpdateDb()
        {
                bsViewQarardadPerson.DataSource = db.FillViewQarardadPerson();
                if (dgvQarardad.Rows.Count == 0)
                {
                btnPrint.Enabled = false;
                    BtnDelete.Enabled = false;
                    BtnEdit.Enabled = false;
                }
                else
                {
                btnPrint.Enabled = true;
                    BtnDelete.Enabled = true;
                    BtnEdit.Enabled = true;

                }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                frm_AddQarardad.frm_Qarardadha = this;
                frm_AddQarardad.idQarardad = (int)dgvQarardad.CurrentRow.Cells[0].Value;
                frm_AddQarardad.idPerson = (int)dgvQarardad.CurrentRow.Cells[1].Value;
                new frm_AddQarardad().ShowDialog();
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
                if (MessageBoxFarsi.Show("آیا قرارداد  با مشخصات زیر حذف گردد؟" + "\n" + " شماره قرارداد: " + dgvQarardad.CurrentRow.Cells[8].Value + "\n" + " نام و نام خانوادگی مشتری: " + dgvQarardad.CurrentRow.Cells[2].Value + " " + dgvQarardad.CurrentRow.Cells[3].Value, "حذف", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Delete, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    db.DeleteQarardad((int)dgvQarardad.CurrentRow.Cells[0].Value);
                    db.InsertEvent(frm_Main.userName, "حذف قرارداد با شماره " + dgvQarardad.CurrentRow.Cells[8].Value, frm_Main.strtoday + " " + DateTime.Now.ToString("HH:mm"));
                    UpdateDb();
                }
            }
            catch
            {

                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void txtSearchFamily__TextChanged(object sender, EventArgs e)
        {
            try
            {
                bsViewQarardadPerson.DataSource = db.FillViewQarardadPersonByName(txtSearchFamily.Texts);
                if (dgvQarardad.Rows.Count == 0)
                {
                    btnPrint.Enabled = false;
                    BtnDelete.Enabled = false;
                    BtnEdit.Enabled = false;
                }
                else
                {
                    btnPrint.Enabled = true;
                    BtnDelete.Enabled = true;
                    BtnEdit.Enabled = true;

                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با پایگاه داده قطع است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            StiReport Report = new StiReport();

            Report.Load("rpt_Qarardad.mrt");
            Report.Compile();
           
            Report["IdQarardad"] = (int)dgvQarardad.CurrentRow.Cells[0].Value;
            Report["MadeFive"] = SetMadeFive(); 
            Report.ShowWithRibbonGUI();

        }

        private string SetMadeFive()
        {
            string outStr= string.Empty;
            bsDaryaftha.DataSource = db.FillViewDaryafti((int)dgvQarardad.CurrentRow.Cells[0].Value);
            for (int i = 0; i < dgvDaryafti.RowCount; i++)
            {
                //MessageBox.Show("قسط" + (i + 1) + " به مبلغ " + dgvDaryafti.Rows[i].Cells[5].Value + "  طی چک شماره " + dgvDaryafti.Rows[i].Cells[4].Value + " بانک " + dgvDaryafti.Rows[i].Cells[6].Value + " به تاریخ سررسید " + dgvDaryafti.Rows[i].Cells[3].Value);
                outStr +="ب5-"+(i+1)+"-قسط " + Num2Text.ToFarsi(i + 1) + " به مبلغ " + dgvDaryafti.Rows[i].Cells[5].Value + "  طی چک شماره " + dgvDaryafti.Rows[i].Cells[4].Value + " بانک " + dgvDaryafti.Rows[i].Cells[6].Value + " به تاریخ سررسید " + dgvDaryafti.Rows[i].Cells[3].Value + "\n";
        }
            return outStr;
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            frm_Attach.idQararad = (int)dgvQarardad.CurrentRow.Cells[0].Value;
            frm_Attach.ShomareQarardad = (string)dgvQarardad.CurrentRow.Cells[7].Value;
            new frm_Attach().ShowDialog();
        }

        private void btnDaryafty_Click(object sender, EventArgs e)
        {
            frm_Daryaftha.idQarardad = (int)dgvQarardad.CurrentRow.Cells[0].Value;
            frm_Daryaftha.ShomareQarardad = (string)dgvQarardad.CurrentRow.Cells[7].Value;
            new frm_Daryaftha().ShowDialog();
        }

        private void btnPrintFactor_Click(object sender, EventArgs e)
        {
            StiReport Report = new StiReport();

            Report.Load("rpt_Factor.mrt");
            Report.Compile();

            Report["IdQarardad"] = (int)dgvQarardad.CurrentRow.Cells[0].Value;
            Report.ShowWithRibbonGUI();
        }
    }
}

namespace Botiya
{
    partial class frm_MessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MessageBox));
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.BtnBack = new CustomControls.RJControls.RJButton();
            this.BtnOk = new CustomControls.RJControls.RJButton();
            this.btnCancel = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Chocolate;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHeader.Size = new System.Drawing.Size(474, 39);
            this.lblHeader.TabIndex = 30;
            this.lblHeader.Text = "پیغام";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(12, 53);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(450, 203);
            this.lblMessage.TabIndex = 31;
            this.lblMessage.Text = "متن پیغام";
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.White;
            this.BtnBack.BackgroundColor = System.Drawing.Color.White;
            this.BtnBack.BorderColor = System.Drawing.Color.SteelBlue;
            this.BtnBack.BorderRadius = 12;
            this.BtnBack.BorderSize = 2;
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.FlatAppearance.BorderSize = 0;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.BtnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBack.Location = new System.Drawing.Point(167, 260);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnBack.Size = new System.Drawing.Size(140, 42);
            this.BtnBack.TabIndex = 32;
            this.BtnBack.Text = "بازگشت";
            this.BtnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBack.TextColor = System.Drawing.Color.SteelBlue;
            this.BtnBack.UseVisualStyleBackColor = false;
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.White;
            this.BtnOk.BackgroundColor = System.Drawing.Color.White;
            this.BtnOk.BorderColor = System.Drawing.Color.SteelBlue;
            this.BtnOk.BorderRadius = 12;
            this.BtnOk.BorderSize = 2;
            this.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOk.FlatAppearance.BorderSize = 0;
            this.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOk.ForeColor = System.Drawing.Color.SteelBlue;
            this.BtnOk.Image = ((System.Drawing.Image)(resources.GetObject("BtnOk.Image")));
            this.BtnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOk.Location = new System.Drawing.Point(66, 260);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnOk.Size = new System.Drawing.Size(140, 42);
            this.BtnOk.TabIndex = 34;
            this.BtnOk.Text = "تایید";
            this.BtnOk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOk.TextColor = System.Drawing.Color.SteelBlue;
            this.BtnOk.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundColor = System.Drawing.Color.White;
            this.btnCancel.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.BorderRadius = 12;
            this.btnCancel.BorderSize = 2;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(257, 259);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnCancel.Size = new System.Drawing.Size(140, 42);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.TextColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frm_MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(474, 314);
            this.ControlBox = false;
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_MessageBox";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private CustomControls.RJControls.RJButton BtnBack;
        public System.Windows.Forms.Label lblMessage;
        private CustomControls.RJControls.RJButton BtnOk;
        private CustomControls.RJControls.RJButton btnCancel;
    }
}
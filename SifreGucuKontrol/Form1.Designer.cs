
namespace SifreGucuKontrol
{
    partial class Form1
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
            this.txtSifreGirisi = new System.Windows.Forms.TextBox();
            this.lblsifreGücü = new System.Windows.Forms.Label();
            this.lblrenk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSifreGirisi
            // 
            this.txtSifreGirisi.Location = new System.Drawing.Point(150, 99);
            this.txtSifreGirisi.Name = "txtSifreGirisi";
            this.txtSifreGirisi.Size = new System.Drawing.Size(166, 20);
            this.txtSifreGirisi.TabIndex = 0;
            this.txtSifreGirisi.TextChanged += new System.EventHandler(this.txtSifreGirisi_TextChanged);
            // 
            // lblsifreGücü
            // 
            this.lblsifreGücü.AutoSize = true;
            this.lblsifreGücü.Location = new System.Drawing.Point(147, 134);
            this.lblsifreGücü.Name = "lblsifreGücü";
            this.lblsifreGücü.Size = new System.Drawing.Size(60, 13);
            this.lblsifreGücü.TabIndex = 3;
            this.lblsifreGücü.Text = "Şifre Gücü:";
            // 
            // lblrenk
            // 
            this.lblrenk.AutoSize = true;
            this.lblrenk.Location = new System.Drawing.Point(278, 134);
            this.lblrenk.Name = "lblrenk";
            this.lblrenk.Size = new System.Drawing.Size(38, 13);
            this.lblrenk.TabIndex = 4;
            this.lblrenk.Text = "Düşük";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 249);
            this.Controls.Add(this.lblrenk);
            this.Controls.Add(this.lblsifreGücü);
            this.Controls.Add(this.txtSifreGirisi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSifreGirisi;
        private System.Windows.Forms.Label lblsifreGücü;
        private System.Windows.Forms.Label lblrenk;
    }
}


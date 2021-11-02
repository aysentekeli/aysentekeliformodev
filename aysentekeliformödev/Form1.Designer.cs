
namespace aysentekeliformödev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btntimer = new System.Windows.Forms.Timer(this.components);
            this.oyunTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblpuan = new System.Windows.Forms.Label();
            this.lblsüre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btntimer
            // 
            this.btntimer.Interval = 1000;
            this.btntimer.Tick += new System.EventHandler(this.btntimer_Tick);
            // 
            // oyunTimer
            // 
            this.oyunTimer.Interval = 1000;
            this.oyunTimer.Tick += new System.EventHandler(this.oyunTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblsüre);
            this.panel1.Controls.Add(this.lblpuan);
            this.panel1.Location = new System.Drawing.Point(648, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 136);
            this.panel1.TabIndex = 0;
            // 
            // lblpuan
            // 
            this.lblpuan.AutoSize = true;
            this.lblpuan.Location = new System.Drawing.Point(3, 14);
            this.lblpuan.Name = "lblpuan";
            this.lblpuan.Size = new System.Drawing.Size(67, 20);
            this.lblpuan.TabIndex = 0;
            this.lblpuan.Text = "Puanınız:";

            // 
            // lblsüre
            // 
            this.lblsüre.AutoSize = true;
            this.lblsüre.Location = new System.Drawing.Point(4, 38);
            this.lblsüre.Name = "lblsüre";
            this.lblsüre.Size = new System.Drawing.Size(82, 20);
            this.lblsüre.TabIndex = 1;
            this.lblsüre.Text = "Kalan Süre:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Form1_ClientSizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer btntimer;
        private System.Windows.Forms.Timer oyunTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblpuan;
        private System.Windows.Forms.Label lblsüre;
    }
}


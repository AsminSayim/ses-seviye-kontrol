namespace ses_seviye_kontrol
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
            this.lblSesSeviyesi = new System.Windows.Forms.Label();
            this.lblSesSeviye = new System.Windows.Forms.Label();
            this.tBarSes = new System.Windows.Forms.TrackBar();
            this.lblSesDeger = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tBarSes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSesSeviyesi
            // 
            this.lblSesSeviyesi.AutoSize = true;
            this.lblSesSeviyesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSesSeviyesi.Location = new System.Drawing.Point(12, 39);
            this.lblSesSeviyesi.Name = "lblSesSeviyesi";
            this.lblSesSeviyesi.Size = new System.Drawing.Size(110, 20);
            this.lblSesSeviyesi.TabIndex = 0;
            this.lblSesSeviyesi.Text = "Ses Seviyesi";
            // 
            // lblSesSeviye
            // 
            this.lblSesSeviye.AutoSize = true;
            this.lblSesSeviye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSesSeviye.Location = new System.Drawing.Point(124, 146);
            this.lblSesSeviye.Name = "lblSesSeviye";
            this.lblSesSeviye.Size = new System.Drawing.Size(115, 20);
            this.lblSesSeviye.TabIndex = 1;
            this.lblSesSeviye.Text = "Ses Seviyesi:";
            // 
            // tBarSes
            // 
            this.tBarSes.Location = new System.Drawing.Point(137, 29);
            this.tBarSes.Maximum = 100;
            this.tBarSes.Name = "tBarSes";
            this.tBarSes.Size = new System.Drawing.Size(542, 45);
            this.tBarSes.TabIndex = 2;
            this.tBarSes.Scroll += new System.EventHandler(this.tBarSes_Scroll);
            // 
            // lblSesDeger
            // 
            this.lblSesDeger.AutoSize = true;
            this.lblSesDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSesDeger.Location = new System.Drawing.Point(685, 39);
            this.lblSesDeger.Name = "lblSesDeger";
            this.lblSesDeger.Size = new System.Drawing.Size(61, 20);
            this.lblSesDeger.TabIndex = 3;
            this.lblSesDeger.Text = "Seviye";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 244);
            this.Controls.Add(this.lblSesDeger);
            this.Controls.Add(this.tBarSes);
            this.Controls.Add(this.lblSesSeviye);
            this.Controls.Add(this.lblSesSeviyesi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBarSes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSesSeviyesi;
        private System.Windows.Forms.Label lblSesSeviye;
        private System.Windows.Forms.TrackBar tBarSes;
        private System.Windows.Forms.Label lblSesDeger;
    }
}


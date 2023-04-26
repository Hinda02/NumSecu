namespace tpNumSS
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
            this.TxtNumSS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerifier = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtNumSS
            // 
            this.TxtNumSS.Location = new System.Drawing.Point(99, 65);
            this.TxtNumSS.MaxLength = 15;
            this.TxtNumSS.Name = "TxtNumSS";
            this.TxtNumSS.Size = new System.Drawing.Size(215, 22);
            this.TxtNumSS.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Analyse d\'un numéro de sécurité sociale";
            // 
            // btnVerifier
            // 
            this.btnVerifier.BackColor = System.Drawing.Color.PaleGreen;
            this.btnVerifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnVerifier.Location = new System.Drawing.Point(25, 111);
            this.btnVerifier.Name = "btnVerifier";
            this.btnVerifier.Size = new System.Drawing.Size(108, 39);
            this.btnVerifier.TabIndex = 2;
            this.btnVerifier.Text = "Verifier";
            this.btnVerifier.UseVisualStyleBackColor = false;
            this.btnVerifier.Click += new System.EventHandler(this.btnVerifier_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEffacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEffacer.Location = new System.Drawing.Point(155, 111);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(103, 39);
            this.btnEffacer.TabIndex = 3;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = false;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.LightCoral;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnQuitter.Location = new System.Drawing.Point(278, 111);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(97, 39);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.btnQuitter);
            this.panel1.Controls.Add(this.btnEffacer);
            this.panel1.Controls.Add(this.btnVerifier);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtNumSS);
            this.panel1.Location = new System.Drawing.Point(26, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 185);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 245);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNumSS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerifier;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Panel panel1;
    }
}


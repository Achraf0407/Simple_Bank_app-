
namespace App_Banque
{
    partial class AddCompte
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LabelTaux = new System.Windows.Forms.Label();
            this.textBoxTaux = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(165, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(97, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Solde :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(127, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 26);
            this.textBox1.TabIndex = 7;
            // 
            // LabelTaux
            // 
            this.LabelTaux.AutoSize = true;
            this.LabelTaux.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LabelTaux.Location = new System.Drawing.Point(97, 254);
            this.LabelTaux.Name = "LabelTaux";
            this.LabelTaux.Size = new System.Drawing.Size(55, 20);
            this.LabelTaux.TabIndex = 17;
            this.LabelTaux.Text = "Taux :";
            // 
            // textBoxTaux
            // 
            this.textBoxTaux.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxTaux.Location = new System.Drawing.Point(126, 285);
            this.textBoxTaux.Name = "textBoxTaux";
            this.textBoxTaux.Size = new System.Drawing.Size(209, 24);
            this.textBoxTaux.TabIndex = 18;
            // 
            // AddCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(473, 558);
            this.Controls.Add(this.textBoxTaux);
            this.Controls.Add(this.LabelTaux);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "AddCompte";
            this.Text = "Add Compte Epargne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LabelTaux;
        private System.Windows.Forms.TextBox textBoxTaux;
    }
}
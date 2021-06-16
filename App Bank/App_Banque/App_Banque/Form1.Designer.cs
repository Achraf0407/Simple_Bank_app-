
namespace App_Banque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionComptesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompteEpargneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.CompteCourantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.comptePayantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionClientsToolStripMenuItem,
            this.gestionComptesToolStripMenuItem,
            this.serviceToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // gestionClientsToolStripMenuItem
            // 
            this.gestionClientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.gestionClientsToolStripMenuItem.Name = "gestionClientsToolStripMenuItem";
            this.gestionClientsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gestionClientsToolStripMenuItem.Text = "Gestion Clients";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteToolStripMenuItem.Text = "Show Clients";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // gestionComptesToolStripMenuItem
            // 
            this.gestionComptesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CompteEpargneToolStripMenuItem,
            this.CompteCourantToolStripMenuItem,
            this.comptePayantToolStripMenuItem});
            this.gestionComptesToolStripMenuItem.Name = "gestionComptesToolStripMenuItem";
            this.gestionComptesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gestionComptesToolStripMenuItem.Text = "Gestion Comptes";
            // 
            // CompteEpargneToolStripMenuItem
            // 
            this.CompteEpargneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem2});
            this.CompteEpargneToolStripMenuItem.Name = "CompteEpargneToolStripMenuItem";
            this.CompteEpargneToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.CompteEpargneToolStripMenuItem.Text = "Compte Epargne";
            // 
            // addToolStripMenuItem2
            // 
            this.addToolStripMenuItem2.Name = "addToolStripMenuItem2";
            this.addToolStripMenuItem2.Size = new System.Drawing.Size(120, 26);
            this.addToolStripMenuItem2.Text = "Add";
            this.addToolStripMenuItem2.Click += new System.EventHandler(this.addToolStripMenuItem2_Click);
            // 
            // CompteCourantToolStripMenuItem
            // 
            this.CompteCourantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem3});
            this.CompteCourantToolStripMenuItem.Name = "CompteCourantToolStripMenuItem";
            this.CompteCourantToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.CompteCourantToolStripMenuItem.Text = "Compte Courant";
            // 
            // addToolStripMenuItem3
            // 
            this.addToolStripMenuItem3.Name = "addToolStripMenuItem3";
            this.addToolStripMenuItem3.Size = new System.Drawing.Size(120, 26);
            this.addToolStripMenuItem3.Text = "Add";
            // 
            // comptePayantToolStripMenuItem
            // 
            this.comptePayantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem4});
            this.comptePayantToolStripMenuItem.Name = "comptePayantToolStripMenuItem";
            this.comptePayantToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.comptePayantToolStripMenuItem.Text = "Compte Payant";
            // 
            // addToolStripMenuItem4
            // 
            this.addToolStripMenuItem4.Name = "addToolStripMenuItem4";
            this.addToolStripMenuItem4.Size = new System.Drawing.Size(120, 26);
            this.addToolStripMenuItem4.Text = "Add";
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertisseurToolStripMenuItem});
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.serviceToolStripMenuItem.Text = "Service";
            // 
            // convertisseurToolStripMenuItem
            // 
            this.convertisseurToolStripMenuItem.Name = "convertisseurToolStripMenuItem";
            this.convertisseurToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.convertisseurToolStripMenuItem.Text = "Convertisseur";
            this.convertisseurToolStripMenuItem.Click += new System.EventHandler(this.convertisseurToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App_Banque.Properties.Resources._1e940faf364ba9ac9139e53e9ac57e55;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionComptesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CompteEpargneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CompteCourantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem comptePayantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem4;
    }
}


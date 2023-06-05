namespace STOCKS
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.logo = new System.Windows.Forms.PictureBox();
            this.button_administrateurs = new System.Windows.Forms.Button();
            this.button_fournisseurs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = global::STOCKS.Properties.Resources.STOCK1;
            this.logo.Location = new System.Drawing.Point(0, -1);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(124, 109);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // button_administrateurs
            // 
            this.button_administrateurs.Location = new System.Drawing.Point(243, 238);
            this.button_administrateurs.Name = "button_administrateurs";
            this.button_administrateurs.Size = new System.Drawing.Size(211, 42);
            this.button_administrateurs.TabIndex = 1;
            this.button_administrateurs.Text = "Administrateurs";
            this.button_administrateurs.UseVisualStyleBackColor = true;
            this.button_administrateurs.Click += new System.EventHandler(this.button_administrateurs_Click);
            // 
            // button_fournisseurs
            // 
            this.button_fournisseurs.Location = new System.Drawing.Point(243, 321);
            this.button_fournisseurs.Name = "button_fournisseurs";
            this.button_fournisseurs.Size = new System.Drawing.Size(211, 42);
            this.button_fournisseurs.TabIndex = 2;
            this.button_fournisseurs.Text = "Fournisseurs";
            this.button_fournisseurs.UseVisualStyleBackColor = true;
            this.button_fournisseurs.Click += new System.EventHandler(this.button_fournisseurs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Veuillez cliquer sur la composante à laquelle vous appartenez.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(129)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_fournisseurs);
            this.Controls.Add(this.button_administrateurs);
            this.Controls.Add(this.logo);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button button_administrateurs;
        private System.Windows.Forms.Button button_fournisseurs;
        private System.Windows.Forms.Label label1;
    }
}


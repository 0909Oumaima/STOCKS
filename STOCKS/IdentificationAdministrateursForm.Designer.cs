namespace STOCKS
{
    partial class IdentificationAdministrateursForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.mdpOA = new System.Windows.Forms.Label();
            this.textBox_IDA = new System.Windows.Forms.TextBox();
            this.textBox_mdpA = new System.Windows.Forms.TextBox();
            this.validerA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identification Administrateurs";
            // 
            // mdpOA
            // 
            this.mdpOA.AutoSize = true;
            this.mdpOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdpOA.Location = new System.Drawing.Point(295, 340);
            this.mdpOA.Name = "mdpOA";
            this.mdpOA.Size = new System.Drawing.Size(151, 20);
            this.mdpOA.TabIndex = 2;
            this.mdpOA.Text = "mot de passe oublié";
            // 
            // textBox_IDA
            // 
            this.textBox_IDA.Location = new System.Drawing.Point(273, 151);
            this.textBox_IDA.Name = "textBox_IDA";
            this.textBox_IDA.Size = new System.Drawing.Size(198, 26);
            this.textBox_IDA.TabIndex = 3;
            // 
            // textBox_mdpA
            // 
            this.textBox_mdpA.Location = new System.Drawing.Point(273, 215);
            this.textBox_mdpA.Name = "textBox_mdpA";
            this.textBox_mdpA.Size = new System.Drawing.Size(198, 26);
            this.textBox_mdpA.TabIndex = 4;
            // 
            // validerA
            // 
            this.validerA.Location = new System.Drawing.Point(299, 290);
            this.validerA.Name = "validerA";
            this.validerA.Size = new System.Drawing.Size(145, 30);
            this.validerA.TabIndex = 5;
            this.validerA.Text = "VALIDER";
            this.validerA.UseVisualStyleBackColor = true;
            this.validerA.Click += new System.EventHandler(this.validerA_Click);
            // 
            // IdentificationAdministrateursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.validerA);
            this.Controls.Add(this.textBox_mdpA);
            this.Controls.Add(this.textBox_IDA);
            this.Controls.Add(this.mdpOA);
            this.Controls.Add(this.label1);
            this.Name = "IdentificationAdministrateursForm";
            this.Text = "IdentificationAdministrateursForm";
            this.Load += new System.EventHandler(this.IdentificationAdministrateursForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mdpOA;
        private System.Windows.Forms.TextBox textBox_IDA;
        private System.Windows.Forms.TextBox textBox_mdpA;
        private System.Windows.Forms.Button validerA;
    }
}
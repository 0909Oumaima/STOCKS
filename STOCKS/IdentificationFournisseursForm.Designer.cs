namespace STOCKS
{
    partial class IdentificationFournisseursForm
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
            this.textBox_mdpF = new System.Windows.Forms.TextBox();
            this.textBox_IDF = new System.Windows.Forms.TextBox();
            this.mdpOF = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.validerF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_mdpF
            // 
            this.textBox_mdpF.Location = new System.Drawing.Point(273, 215);
            this.textBox_mdpF.Name = "textBox_mdpF";
            this.textBox_mdpF.Size = new System.Drawing.Size(198, 26);
            this.textBox_mdpF.TabIndex = 8;
            // 
            // textBox_IDF
            // 
            this.textBox_IDF.Location = new System.Drawing.Point(273, 151);
            this.textBox_IDF.Name = "textBox_IDF";
            this.textBox_IDF.Size = new System.Drawing.Size(198, 26);
            this.textBox_IDF.TabIndex = 7;
            // 
            // mdpOF
            // 
            this.mdpOF.AutoSize = true;
            this.mdpOF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdpOF.Location = new System.Drawing.Point(295, 340);
            this.mdpOF.Name = "mdpOF";
            this.mdpOF.Size = new System.Drawing.Size(151, 20);
            this.mdpOF.TabIndex = 6;
            this.mdpOF.Text = "mot de passe oublié";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Identification Fournisseurs";
            // 
            // validerF
            // 
            this.validerF.Location = new System.Drawing.Point(299, 290);
            this.validerF.Name = "validerF";
            this.validerF.Size = new System.Drawing.Size(147, 27);
            this.validerF.TabIndex = 9;
            this.validerF.Text = "VALIDER";
            this.validerF.UseVisualStyleBackColor = true;
            // 
            // IdentificationFournisseursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.validerF);
            this.Controls.Add(this.textBox_mdpF);
            this.Controls.Add(this.textBox_IDF);
            this.Controls.Add(this.mdpOF);
            this.Controls.Add(this.label1);
            this.Name = "IdentificationFournisseursForm";
            this.Text = "IdentificationFournisseursForm";
            this.Load += new System.EventHandler(this.IdentificationFournisseursForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_mdpF;
        private System.Windows.Forms.TextBox textBox_IDF;
        private System.Windows.Forms.Label mdpOF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button validerF;
    }
}
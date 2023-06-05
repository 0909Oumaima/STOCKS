using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STOCKS
{
    public partial class IdentificationFournisseursForm : Form
    {
        public IdentificationFournisseursForm()
        {
            InitializeComponent();
        }

        private void IdentificationFournisseursForm_Load(object sender, EventArgs e)
        {
            textBox_IDF.Text = "Identifiant";
            textBox_mdpF.Text = "Mot de passe";
        }
    }
}

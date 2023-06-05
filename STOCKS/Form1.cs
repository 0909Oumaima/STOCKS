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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_administrateurs_Click(object sender, EventArgs e)
        {
            // Instancier et afficher la forme d'identification des administrateurs
            IdentificationAdministrateursForm identificationAdministrateursForm = new IdentificationAdministrateursForm();
            identificationAdministrateursForm.Show();
        }

        private void button_fournisseurs_Click(object sender, EventArgs e)
        {
            // Instancier et afficher la forme d'identification des fournisseurs
            IdentificationFournisseursForm identificationFournisseursForm = new IdentificationFournisseursForm();
            identificationFournisseursForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

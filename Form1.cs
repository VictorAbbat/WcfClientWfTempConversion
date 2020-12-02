using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfClientWfTempConversion.ReferenceTempConversion;

namespace WcfClientWfTempConversion
{
    public partial class Form1 : Form
    {

        ServiceConversionClient client;

        public Form1(ServiceConversionClient client)
        {
            this.client = client;
            InitializeComponent();
        }

        private void txtValeur_TextChanged(object sender, EventArgs e)
        {
            if (txtValeur.TextLength > 0 && ValidValeur(txtValeur.Text))
            {
                btnConvertir.Enabled = true;
            }
            else
            {
                btnConvertir.Enabled = false;
            }
        }

        // retourne true ou false selon la vérification
        private bool ValidValeur(string valeur)
        {
            Regex myRegex = new Regex("[0-9]");
            return myRegex.IsMatch(valeur); 
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {

            if (txtValeur.Text.Length > 0)
            {
                if (rbtnFahrenheit.Checked)
                {
                    lblResultat.Text = client.ConvertirVersFarh(double.Parse(txtValeur.Text), Environment.UserName, Environment.MachineName).ToString();
                    populate();
                }
                else
                {
                    lblResultat.Text = client.ConvertirVersCelcius(double.Parse(txtValeur.Text), Environment.UserName, Environment.MachineName).ToString();
                    populate();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtValeur;
            //txtValeur.Focus();
            rbtnCelcius.Checked = true;
            btnConvertir.Enabled = false;
            populate();
        }

        // Pour les tests
        private void btnCharger_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void populate()
        {
            var liste = client.GetAll().ToList();
            DataTable source = new DataTable();
            source.Columns.Add("User name", typeof(string));
            source.Columns.Add("Machine name", typeof(string));
            source.Columns.Add("Valeur temp", typeof(double));
            source.Columns.Add("Date appel", typeof(DateTime));

            foreach (Conversion conv in liste)
            {
                source.Rows.Add(conv.userName, conv.machineName, conv.valeur, conv.dateAppel);
            }
            dgvData.DataSource = source;
        }

        private void rbtnCelcius_CheckedChanged(object sender, EventArgs e)
        {
            lblUnite.Text = "C";
        }

        private void rbtnFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            lblUnite.Text = "F";
        }
    }
}

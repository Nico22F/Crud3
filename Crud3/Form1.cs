using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Crud3
{
    public partial class finestra22f : Form
    {   

        public struct prodotto
        {
            public string nome;
            public float prezzo;
        }
        public prodotto[] p = new prodotto[100];
        public int dim;

        public finestra22f()
        {
            InitializeComponent();
            dim = 0;
            lista.Visible = false;
        }


        // funzione per aggiungere i prodotti

        private void salva_Click(object sender, EventArgs e)
        {
            p[dim].nome = text_nome.Text;
            p[dim].prezzo = float.Parse(text_prezzo.Text);
            dim++;
            visualizza(p);
            text_nome.Text = "";
            text_prezzo.Text = "";
            MessageBox.Show("Prodotto Aggiunto!");
        }

        // mostra prodotti

        public void visualizza(prodotto[] pp)
        {
            lista.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                lista.Items.Add(prodString(p[i]));
            }
        }

        // funzione che scrive la stringa
        public string prodString(prodotto p)
        {
            return "Nome:" + p.nome + " prezzo:" + p.prezzo.ToString() + "€";
        }

        private void create_Click(object sender, EventArgs e)
        {
            
        }
    }
}

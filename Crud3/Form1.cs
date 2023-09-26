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
using Microsoft.VisualBasic;
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
            titolo.Visible = false;
            ConfermaModifica.Visible = false;
        }

        public bool conferma_modifica = false;

        // funzione per aggiungere i prodotti

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
            return $"{p.nome}:{p.prezzo}";
        }

        private void create_Click(object sender, EventArgs e)
        {
            p[dim].nome = text_nome.Text;
            p[dim].prezzo = float.Parse(text_prezzo.Text);
            dim++;
            visualizza(p);
            text_nome.Text = "";
            text_prezzo.Text = "";
            MessageBox.Show("Prodotto Aggiunto!");
        }

        private void mostra_Click(object sender, EventArgs e)
        {
            if (lista.Visible == false)
            {
                lista.Visible = true;
                titolo.Visible = true;
            }
            else
            {
                lista.Visible = false;
                titolo.Visible = false;
            }
        }

        private void modifica_Click(object sender, EventArgs e)
        {
            // mostra lista prodotti

            lista.Visible = true;
            conferma_modifica = true;
        }

        // split
        static string[] Split(string stringa)
        {
            string[] array = new string[2];
            string frase = "";
            int p = 0;
            for (int i = 0; i < stringa.Length; i++)
            {
                if (stringa[i] == ':')
                {
                    array[p] = frase; p++; frase = "";
                }
                else
                {
                    frase += stringa[i];
                }
                if (i == stringa.Length - 1)
                {
                    array[p] = frase;
                }
            }
            return array;
        }
        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conferma_modifica == true)
            {
                int scelta = lista.SelectedIndex;
                MessageBox.Show("Procedi con la modifica del prodotto da lei selezionato");
                string oggettomodifca = lista.Items[scelta].ToString();
                string[] modificona = Split(oggettomodifca);
                text_nome.Text = modificona[0];
                text_prezzo.Text = modificona[1];
                ConfermaModifica.Visible = true;
                //public string nomignolo = modificona[0];
             }
    }
        

        private void ConfermaModifica_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dim; i++)
            {
                if (p[i].nome = modificona[0])
                {

                }
            }
        }
    }
}

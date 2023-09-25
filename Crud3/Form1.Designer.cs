namespace Crud3
{
    partial class finestra22f
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_nome = new System.Windows.Forms.Label();
            this.label_prezzo = new System.Windows.Forms.Label();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.text_prezzo = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            this.mostra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(16, 16);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(42, 13);
            this.label_nome.TabIndex = 0;
            this.label_nome.Text = "NOME:";
            // 
            // label_prezzo
            // 
            this.label_prezzo.AutoSize = true;
            this.label_prezzo.Location = new System.Drawing.Point(16, 73);
            this.label_prezzo.Name = "label_prezzo";
            this.label_prezzo.Size = new System.Drawing.Size(54, 13);
            this.label_prezzo.TabIndex = 1;
            this.label_prezzo.Text = "PREZZO:";
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(19, 32);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(172, 20);
            this.text_nome.TabIndex = 2;
            // 
            // text_prezzo
            // 
            this.text_prezzo.Location = new System.Drawing.Point(19, 89);
            this.text_prezzo.Name = "text_prezzo";
            this.text_prezzo.Size = new System.Drawing.Size(172, 20);
            this.text_prezzo.TabIndex = 3;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(19, 139);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(219, 78);
            this.create.TabIndex = 4;
            this.create.Text = "Aggiungi Prodotto";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(347, 32);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(428, 381);
            this.lista.TabIndex = 5;
            // 
            // mostra
            // 
            this.mostra.Location = new System.Drawing.Point(19, 223);
            this.mostra.Name = "mostra";
            this.mostra.Size = new System.Drawing.Size(219, 72);
            this.mostra.TabIndex = 6;
            this.mostra.Text = "Visualizza Prodotti";
            this.mostra.UseVisualStyleBackColor = true;
            // 
            // finestra22f
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mostra);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.create);
            this.Controls.Add(this.text_prezzo);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label_prezzo);
            this.Controls.Add(this.label_nome);
            this.Name = "finestra22f";
            this.Text = "Finestra22F";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.Label label_prezzo;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.TextBox text_prezzo;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button mostra;
    }
}


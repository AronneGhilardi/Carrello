namespace Carrello
{
    partial class Form1
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
            this.ProdottiList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.Svuota = new System.Windows.Forms.Button();
            this.Rimuovi = new System.Windows.Forms.Button();
            this.Aggiungi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProdottiList
            // 
            this.ProdottiList.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ProdottiList.HideSelection = false;
            this.ProdottiList.Location = new System.Drawing.Point(12, 45);
            this.ProdottiList.Name = "ProdottiList";
            this.ProdottiList.Size = new System.Drawing.Size(460, 250);
            this.ProdottiList.TabIndex = 0;
            this.ProdottiList.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRODOTTI";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 365);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(460, 250);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "CARRELLO";
            // 
            // Svuota
            // 
            this.Svuota.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Svuota.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Svuota.Location = new System.Drawing.Point(316, 329);
            this.Svuota.Name = "Svuota";
            this.Svuota.Size = new System.Drawing.Size(75, 30);
            this.Svuota.TabIndex = 4;
            this.Svuota.Text = "SVUOTA";
            this.Svuota.UseVisualStyleBackColor = false;
            // 
            // Rimuovi
            // 
            this.Rimuovi.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Rimuovi.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rimuovi.Location = new System.Drawing.Point(397, 329);
            this.Rimuovi.Name = "Rimuovi";
            this.Rimuovi.Size = new System.Drawing.Size(75, 30);
            this.Rimuovi.TabIndex = 5;
            this.Rimuovi.Text = "RIMUOVI";
            this.Rimuovi.UseVisualStyleBackColor = false;
            // 
            // Aggiungi
            // 
            this.Aggiungi.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Aggiungi.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aggiungi.Location = new System.Drawing.Point(397, 9);
            this.Aggiungi.Name = "Aggiungi";
            this.Aggiungi.Size = new System.Drawing.Size(75, 30);
            this.Aggiungi.TabIndex = 6;
            this.Aggiungi.Text = "AGGIUNGI";
            this.Aggiungi.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(484, 627);
            this.Controls.Add(this.Aggiungi);
            this.Controls.Add(this.Rimuovi);
            this.Controls.Add(this.Svuota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProdottiList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ProdottiList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Svuota;
        private System.Windows.Forms.Button Rimuovi;
        private System.Windows.Forms.Button Aggiungi;
    }
}


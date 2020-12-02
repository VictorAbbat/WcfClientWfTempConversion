namespace WcfClientWfTempConversion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblValeur = new System.Windows.Forms.Label();
            this.txtValeur = new System.Windows.Forms.TextBox();
            this.rbtnCelcius = new System.Windows.Forms.RadioButton();
            this.rbtnFahrenheit = new System.Windows.Forms.RadioButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnCharger = new System.Windows.Forms.Button();
            this.lblResultat = new System.Windows.Forms.Label();
            this.lblEn = new System.Windows.Forms.Label();
            this.lblUnite = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValeur
            // 
            this.lblValeur.AutoSize = true;
            this.lblValeur.Location = new System.Drawing.Point(22, 33);
            this.lblValeur.Name = "lblValeur";
            this.lblValeur.Size = new System.Drawing.Size(131, 13);
            this.lblValeur.TabIndex = 0;
            this.lblValeur.Text = "Saisir la valeur à convertir:";
            // 
            // txtValeur
            // 
            this.txtValeur.Location = new System.Drawing.Point(158, 29);
            this.txtValeur.MaxLength = 5;
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(60, 20);
            this.txtValeur.TabIndex = 1;
            this.txtValeur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValeur.TextChanged += new System.EventHandler(this.txtValeur_TextChanged);
            // 
            // rbtnCelcius
            // 
            this.rbtnCelcius.AutoSize = true;
            this.rbtnCelcius.Location = new System.Drawing.Point(253, 31);
            this.rbtnCelcius.Name = "rbtnCelcius";
            this.rbtnCelcius.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnCelcius.Size = new System.Drawing.Size(59, 17);
            this.rbtnCelcius.TabIndex = 2;
            this.rbtnCelcius.TabStop = true;
            this.rbtnCelcius.Text = "Celcius";
            this.rbtnCelcius.UseVisualStyleBackColor = true;
            this.rbtnCelcius.CheckedChanged += new System.EventHandler(this.rbtnCelcius_CheckedChanged);
            // 
            // rbtnFahrenheit
            // 
            this.rbtnFahrenheit.AutoSize = true;
            this.rbtnFahrenheit.Location = new System.Drawing.Point(325, 31);
            this.rbtnFahrenheit.Name = "rbtnFahrenheit";
            this.rbtnFahrenheit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnFahrenheit.Size = new System.Drawing.Size(75, 17);
            this.rbtnFahrenheit.TabIndex = 3;
            this.rbtnFahrenheit.TabStop = true;
            this.rbtnFahrenheit.Text = "Fahrenheit";
            this.rbtnFahrenheit.UseVisualStyleBackColor = true;
            this.rbtnFahrenheit.CheckedChanged += new System.EventHandler(this.rbtnFahrenheit_CheckedChanged);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(25, 68);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(465, 214);
            this.dgvData.TabIndex = 4;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(25, 303);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(170, 23);
            this.btnConvertir.TabIndex = 5;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnCharger
            // 
            this.btnCharger.Location = new System.Drawing.Point(415, 303);
            this.btnCharger.Name = "btnCharger";
            this.btnCharger.Size = new System.Drawing.Size(75, 23);
            this.btnCharger.TabIndex = 6;
            this.btnCharger.Text = "Charger";
            this.btnCharger.UseVisualStyleBackColor = true;
            this.btnCharger.Click += new System.EventHandler(this.btnCharger_Click);
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Location = new System.Drawing.Point(432, 34);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(0, 13);
            this.lblResultat.TabIndex = 7;
            // 
            // lblEn
            // 
            this.lblEn.AutoSize = true;
            this.lblEn.Location = new System.Drawing.Point(231, 33);
            this.lblEn.Name = "lblEn";
            this.lblEn.Size = new System.Drawing.Size(19, 13);
            this.lblEn.TabIndex = 8;
            this.lblEn.Text = "en";
            // 
            // lblUnite
            // 
            this.lblUnite.AutoSize = true;
            this.lblUnite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnite.Location = new System.Drawing.Point(469, 32);
            this.lblUnite.Name = "lblUnite";
            this.lblUnite.Size = new System.Drawing.Size(17, 17);
            this.lblUnite.TabIndex = 9;
            this.lblUnite.Text = "C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 338);
            this.Controls.Add(this.lblUnite);
            this.Controls.Add(this.lblEn);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.btnCharger);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.rbtnFahrenheit);
            this.Controls.Add(this.rbtnCelcius);
            this.Controls.Add(this.txtValeur);
            this.Controls.Add(this.lblValeur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Convertisseur de température";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValeur;
        private System.Windows.Forms.TextBox txtValeur;
        private System.Windows.Forms.RadioButton rbtnCelcius;
        private System.Windows.Forms.RadioButton rbtnFahrenheit;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnCharger;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Label lblEn;
        private System.Windows.Forms.Label lblUnite;
    }
}


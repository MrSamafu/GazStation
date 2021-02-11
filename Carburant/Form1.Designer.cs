
namespace Carburant
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.labelGeneral = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.ticketSelection1 = new Carburant.TicketSelection();
            this.fuelSelection1 = new Carburant.FuelSelection();
            this.clavierNum1 = new Carburant.ClavierNum();
            this.SuspendLayout();
            // 
            // labelGeneral
            // 
            this.labelGeneral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGeneral.Location = new System.Drawing.Point(12, 9);
            this.labelGeneral.Name = "labelGeneral";
            this.labelGeneral.Size = new System.Drawing.Size(321, 120);
            this.labelGeneral.TabIndex = 1;
            this.labelGeneral.Text = "Insérer votre Carte";
            this.labelGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCode
            // 
            this.labelCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCode.Location = new System.Drawing.Point(124, 129);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(100, 23);
            this.labelCode.TabIndex = 4;
            this.labelCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ticketSelection1
            // 
            this.ticketSelection1.Location = new System.Drawing.Point(12, 164);
            this.ticketSelection1.Name = "ticketSelection1";
            this.ticketSelection1.Size = new System.Drawing.Size(321, 386);
            this.ticketSelection1.TabIndex = 3;
            // 
            // fuelSelection1
            // 
            this.fuelSelection1.Location = new System.Drawing.Point(12, 200);
            this.fuelSelection1.Name = "fuelSelection1";
            this.fuelSelection1.Size = new System.Drawing.Size(321, 386);
            this.fuelSelection1.TabIndex = 2;
            // 
            // clavierNum1
            // 
            this.clavierNum1.Location = new System.Drawing.Point(12, 200);
            this.clavierNum1.Name = "clavierNum1";
            this.clavierNum1.Size = new System.Drawing.Size(321, 386);
            this.clavierNum1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 606);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.ticketSelection1);
            this.Controls.Add(this.fuelSelection1);
            this.Controls.Add(this.labelGeneral);
            this.Controls.Add(this.clavierNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ClavierNum clavierNum1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.Label labelGeneral;
        private FuelSelection fuelSelection1;
        private TicketSelection ticketSelection1;
        public System.Windows.Forms.Label labelCode;
    }
}


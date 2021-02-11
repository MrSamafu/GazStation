
namespace Carburant
{
    partial class TicketSelection
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonWithoutTicket = new System.Windows.Forms.Button();
            this.buttonTicket2 = new System.Windows.Forms.Button();
            this.buttonTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.AccessibleName = "Annuler";
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDelete.Location = new System.Drawing.Point(243, 31);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 75);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Annuler";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonWithoutTicket
            // 
            this.buttonWithoutTicket.AccessibleName = "noTicket";
            this.buttonWithoutTicket.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonWithoutTicket.FlatAppearance.BorderSize = 0;
            this.buttonWithoutTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithoutTicket.Location = new System.Drawing.Point(3, 278);
            this.buttonWithoutTicket.Name = "buttonWithoutTicket";
            this.buttonWithoutTicket.Size = new System.Drawing.Size(315, 77);
            this.buttonWithoutTicket.TabIndex = 14;
            this.buttonWithoutTicket.Text = "Sans ticket";
            this.buttonWithoutTicket.UseVisualStyleBackColor = true;
            this.buttonWithoutTicket.Click += new System.EventHandler(this.buttonWithoutTicket_Click);
            // 
            // buttonTicket2
            // 
            this.buttonTicket2.AccessibleName = "ticket2";
            this.buttonTicket2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonTicket2.FlatAppearance.BorderSize = 0;
            this.buttonTicket2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTicket2.Location = new System.Drawing.Point(3, 195);
            this.buttonTicket2.Name = "buttonTicket2";
            this.buttonTicket2.Size = new System.Drawing.Size(315, 77);
            this.buttonTicket2.TabIndex = 13;
            this.buttonTicket2.Text = "Ticket et duplicata";
            this.buttonTicket2.UseVisualStyleBackColor = true;
            this.buttonTicket2.Click += new System.EventHandler(this.buttonTicket2_Click);
            // 
            // buttonTicket
            // 
            this.buttonTicket.AccessibleName = "ticket";
            this.buttonTicket.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonTicket.FlatAppearance.BorderSize = 0;
            this.buttonTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTicket.Location = new System.Drawing.Point(3, 112);
            this.buttonTicket.Name = "buttonTicket";
            this.buttonTicket.Size = new System.Drawing.Size(315, 77);
            this.buttonTicket.TabIndex = 12;
            this.buttonTicket.Text = "Ticket";
            this.buttonTicket.UseVisualStyleBackColor = true;
            this.buttonTicket.Click += new System.EventHandler(this.buttonTicket_Click);
            // 
            // TicketSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonWithoutTicket);
            this.Controls.Add(this.buttonTicket2);
            this.Controls.Add(this.buttonTicket);
            this.Name = "TicketSelection";
            this.Size = new System.Drawing.Size(321, 386);
            this.Load += new System.EventHandler(this.TicketSelection_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonWithoutTicket;
        private System.Windows.Forms.Button buttonTicket2;
        private System.Windows.Forms.Button buttonTicket;
    }
}


namespace Carburant
{
    partial class FuelSelection
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
            this.buttonSP98 = new System.Windows.Forms.Button();
            this.buttonE10 = new System.Windows.Forms.Button();
            this.buttonGazole = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSP98
            // 
            this.buttonSP98.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSP98.FlatAppearance.BorderSize = 2;
            this.buttonSP98.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSP98.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSP98.Location = new System.Drawing.Point(3, 96);
            this.buttonSP98.Name = "buttonSP98";
            this.buttonSP98.Size = new System.Drawing.Size(315, 77);
            this.buttonSP98.TabIndex = 0;
            this.buttonSP98.Text = "SP98";
            this.buttonSP98.UseVisualStyleBackColor = true;
            this.buttonSP98.Click += new System.EventHandler(this.buttonSP98_Click);
            // 
            // buttonE10
            // 
            this.buttonE10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonE10.FlatAppearance.BorderSize = 2;
            this.buttonE10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonE10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonE10.Location = new System.Drawing.Point(3, 179);
            this.buttonE10.Name = "buttonE10";
            this.buttonE10.Size = new System.Drawing.Size(315, 77);
            this.buttonE10.TabIndex = 1;
            this.buttonE10.Text = "E10";
            this.buttonE10.UseVisualStyleBackColor = true;
            this.buttonE10.Click += new System.EventHandler(this.buttonE10_Click);
            // 
            // buttonGazole
            // 
            this.buttonGazole.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonGazole.FlatAppearance.BorderSize = 2;
            this.buttonGazole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGazole.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGazole.Location = new System.Drawing.Point(3, 262);
            this.buttonGazole.Name = "buttonGazole";
            this.buttonGazole.Size = new System.Drawing.Size(315, 77);
            this.buttonGazole.TabIndex = 2;
            this.buttonGazole.Text = "Gazole";
            this.buttonGazole.UseVisualStyleBackColor = true;
            this.buttonGazole.Click += new System.EventHandler(this.buttonGazole_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDelete.Location = new System.Drawing.Point(243, 15);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 75);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Annuler";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FuelSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonGazole);
            this.Controls.Add(this.buttonE10);
            this.Controls.Add(this.buttonSP98);
            this.Name = "FuelSelection";
            this.Size = new System.Drawing.Size(321, 386);
            this.Load += new System.EventHandler(this.FuelSelection_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSP98;
        private System.Windows.Forms.Button buttonE10;
        private System.Windows.Forms.Button buttonGazole;
        private System.Windows.Forms.Button buttonDelete;
    }
}

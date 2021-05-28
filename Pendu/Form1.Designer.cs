namespace Pendu
{
    partial class fen
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
            this.lblInstruc = new System.Windows.Forms.Label();
            this.txtMot = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picPendu = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpbButtons = new System.Windows.Forms.GroupBox();
            this.lbLettresTestées = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPendu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gpbButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstruc
            // 
            this.lblInstruc.AutoSize = true;
            this.lblInstruc.Location = new System.Drawing.Point(19, 0);
            this.lblInstruc.Name = "lblInstruc";
            this.lblInstruc.Size = new System.Drawing.Size(111, 17);
            this.lblInstruc.TabIndex = 5;
            this.lblInstruc.Text = "Mot à chercher :";
            // 
            // txtMot
            // 
            this.txtMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMot.Location = new System.Drawing.Point(21, 30);
            this.txtMot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMot.Name = "txtMot";
            this.txtMot.Size = new System.Drawing.Size(403, 34);
            this.txtMot.TabIndex = 1;
            this.txtMot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMot_KeyPress);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(579, 284);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 43);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lettres testées";
            // 
            // picPendu
            // 
            this.picPendu.Image = global::Pendu.Properties.Resources.pendu0;
            this.picPendu.Location = new System.Drawing.Point(459, 14);
            this.picPendu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPendu.Name = "picPendu";
            this.picPendu.Size = new System.Drawing.Size(309, 265);
            this.picPendu.TabIndex = 6;
            this.picPendu.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMot);
            this.groupBox1.Controls.Add(this.lblInstruc);
            this.groupBox1.Location = new System.Drawing.Point(11, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(431, 79);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // gpbButtons
            // 
            this.gpbButtons.Controls.Add(this.lbLettresTestées);
            this.gpbButtons.Controls.Add(this.label1);
            this.gpbButtons.Location = new System.Drawing.Point(20, 127);
            this.gpbButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbButtons.Name = "gpbButtons";
            this.gpbButtons.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbButtons.Size = new System.Drawing.Size(400, 199);
            this.gpbButtons.TabIndex = 8;
            this.gpbButtons.TabStop = false;
            // 
            // lbLettresTestées
            // 
            this.lbLettresTestées.AutoSize = true;
            this.lbLettresTestées.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLettresTestées.Location = new System.Drawing.Point(24, 98);
            this.lbLettresTestées.Name = "lbLettresTestées";
            this.lbLettresTestées.Size = new System.Drawing.Size(0, 25);
            this.lbLettresTestées.TabIndex = 6;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(83, 342);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 9;
            // 
            // fen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 409);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.gpbButtons);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picPendu);
            this.Controls.Add(this.btnReset);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fen";
            this.Text = "Pendu";
            ((System.ComponentModel.ISupportInitialize)(this.picPendu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbButtons.ResumeLayout(false);
            this.gpbButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruc;
        private System.Windows.Forms.TextBox txtMot;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picPendu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpbButtons;
        private System.Windows.Forms.Label lbLettresTestées;
        private System.Windows.Forms.Label lblResult;
    }
}


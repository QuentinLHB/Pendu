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
            this.txbMot = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbLettres = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picPendu = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.lbLettresTestées = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPendu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstruc
            // 
            this.lblInstruc.AutoSize = true;
            this.lblInstruc.Location = new System.Drawing.Point(19, 0);
            this.lblInstruc.Name = "lblInstruc";
            this.lblInstruc.Size = new System.Drawing.Size(111, 17);
            this.lblInstruc.TabIndex = 0;
            this.lblInstruc.Text = "Mot à chercher :";
            // 
            // txbMot
            // 
            this.txbMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMot.Location = new System.Drawing.Point(22, 30);
            this.txbMot.Name = "txbMot";
            this.txbMot.Size = new System.Drawing.Size(222, 34);
            this.txbMot.TabIndex = 1;
            this.txbMot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMot_KeyPress);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(447, 284);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 43);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbLettres
            // 
            this.cbLettres.BackColor = System.Drawing.SystemColors.Window;
            this.cbLettres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLettres.Enabled = false;
            this.cbLettres.Location = new System.Drawing.Point(12, 38);
            this.cbLettres.Name = "cbLettres";
            this.cbLettres.Size = new System.Drawing.Size(51, 24);
            this.cbLettres.TabIndex = 4;
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
            this.picPendu.Location = new System.Drawing.Point(372, 13);
            this.picPendu.Name = "picPendu";
            this.picPendu.Size = new System.Drawing.Size(310, 265);
            this.picPendu.TabIndex = 6;
            this.picPendu.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbMot);
            this.groupBox1.Controls.Add(this.lblInstruc);
            this.groupBox1.Location = new System.Drawing.Point(10, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 79);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTest);
            this.groupBox2.Controls.Add(this.lbLettresTestées);
            this.groupBox2.Controls.Add(this.cbLettres);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(20, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 172);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(89, 38);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(63, 23);
            this.btnTest.TabIndex = 7;
            this.btnTest.Text = "TEST";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
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
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(104, 347);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 29);
            this.lblResult.TabIndex = 9;
            // 
            // fen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 409);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picPendu);
            this.Controls.Add(this.btnReset);
            this.Name = "fen";
            this.Text = "Pendu";
            this.Load += new System.EventHandler(this.fen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPendu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruc;
        private System.Windows.Forms.TextBox txbMot;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cbLettres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picPendu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbLettresTestées;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnTest;
    }
}


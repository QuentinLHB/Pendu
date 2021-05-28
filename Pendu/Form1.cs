using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pendu
{
    public partial class fen : Form
    {
        string mot = "";
        int rate = 0;
        int score = 0;
        int LIMIT = 15;

        public fen()
        {
            InitializeComponent();
            initialiseBouttonsLettres();
            txtMot.Focus();
        }

        /// <summary>
        /// Initialise les boutons dans la groupbox.
        /// </summary>
        private void initialiseBouttonsLettres()
        {
            int x = 5; int y = 15; int MARGE = 5; int TAILLE = 30;
            for (int k = 0; k < 26; k++)
            {
                Button btn = new Button();
                gpbButtons.Controls.Add(btn);
                btn.Size = new Size(TAILLE, TAILLE);
                
                if (x+TAILLE+MARGE > gpbButtons.Width) //400 = largeur de la groupbox. //Saut de ligne
                {
                    y += TAILLE + MARGE;
                    x = 5;
                }
                btn.Location = new Point(x, y);
                btn.Text = ((char)('A' + k)).ToString();
                btn.Click += new EventHandler(Test_Click);
                x += TAILLE + MARGE;
            }
        }

        /// <summary>
        /// Vérifie si le charactère entré est dans la limite, et valide le mot entré avec la touche Entrée.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txbMot_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((!verifieLettreEntreAZ(e.KeyChar) && e.KeyChar != (char)Keys.Back) 
                || (txtMot.Text.Length >= LIMIT && e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                mot = txtMot.Text;
                txtMot.Enabled = false;
                LockUnlock(true);
                mot = mot.ToUpper();
                CacheMot(mot);
            }
        }

        /// <summary>
        /// Vérifie si une lettre est comprise entre A et Z, insensiblement à la casse.
        /// </summary>
        /// <param name="lettre">Lettre à vérifier.</param>
        /// <returns>True si compris entre A et Z (ou a et z), false sinon.</returns>
        private bool verifieLettreEntreAZ(char lettre)
        {
            return ((lettre >= 65) && (lettre <= 90)) || ((lettre >= 97 && lettre <= 122));
        }

        /// <summary>
        /// Effectue le test de la lettre cliquée.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Test_Click(object sender, EventArgs e)
        {
            Button btnClique = (Button)sender; 
            
            bool found = false;
            // Compare la lettre proposée avec chaque lettre du mot
            try
            {
                found = verifieMot(btnClique);
                gpbButtons.Controls[0].Focus();

                if (!found) //Raté : Met à jour le dessin 
                {
                    rate++;
                    btnClique.Enabled = false;
                    string penduImg = "pendu" + rate.ToString();
                    picPendu.Image = (Image)Properties.Resources.ResourceManager.GetObject(penduImg);

                    if (rate == 10) // Si partie finie
                    {
                        lblResult.Text = "Perdu !" ;
                        // Affiche la bonne réponse à la place des -
                        txtMot.Text = "";
                        for (int k = 0; k < mot.Length; k++)
                        {
                            txtMot.Text += mot[k] + " ";
                        }
                        LockUnlock(false);
                    }
                }

                if (score == mot.Length) // Fin de partie
                {
                    lblResult.Text = "Gagné !";
                    LockUnlock(false);
                    btnReset.Focus();
                }
            }
            catch{}

        }

        /// <summary>
        /// Vérifie si la lettre cliquée apparaît dans le mot, et met à jour le mot en conséquence.
        /// </summary>
        /// <param name="btnClique"></param>
        /// <returns>True si la lettre a été trouvée, False sinon.</returns>
        private bool verifieMot(Button btnClique)
        {
            bool found = false;
            for (int k = 0; k != mot.Length; k++)
            {
                int index = mot.IndexOf(btnClique.Text, k, 1);
                if (index != -1) // Remplace les - par la lettre
                {
                    txtMot.Text = txtMot.Text.Remove(index * 2, 1); //*2 pour les espaces
                    txtMot.Text = txtMot.Text.Insert(index * 2, btnClique.Text);
                    found = true;
                    btnClique.Enabled = false;
                    score++;
                    lblResult.Text = "";
                }
            }
            return found;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            mot = "";
            rate = 0;
            score = 0;
            picPendu.Image = (Image)Properties.Resources.ResourceManager.GetObject("pendu0");
            txtMot.Clear();
            txtMot.Enabled = true;
            lblResult.Text = "";
            LockUnlock(false);
            txtMot.Focus();

            foreach (Control btn in gpbButtons.Controls)
            {
                btn.Enabled = true;
            }
        }

        private void CacheMot(string mot)
        {
            txtMot.Text = "";
            for (int k = 0; k < mot.Length; k++)
            {
                txtMot.Text += "- ";
            }
        }

        private void LockUnlock(bool unlock)
        {
            for (int k = 0; k < gpbButtons.Controls.Count; k++)
            {
                gpbButtons.Controls[k].Enabled = unlock;
            }
        }

    }
}

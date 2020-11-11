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
        public fen()
        {
            InitializeComponent();
            
            for (char lettre = 'A'; lettre != 91; lettre++)
            {
                cbLettres.Items.Add(lettre.ToString());
            }
            txbMot.Focus();
        }

        private void txbMot_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char) Keys.Enter)
            {
                mot = txbMot.Text;
                txbMot.Enabled = false;
                cbLettres.Enabled = true;
                mot = mot.ToUpper();
                CacheMot(mot);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            bool found = false;
            // Compare la lettre proposée avec le 
            for (int k = 0; k != mot.Length; k++)
            {
                int index = mot.IndexOf(cbLettres.SelectedItem.ToString(), k, 1);
                if (index != -1) // Remplace les - par la lettre
                {
                    txbMot.Text = txbMot.Text.Remove(index * 2, 1); //*2 parce que les espaces
                    txbMot.Text = txbMot.Text.Insert(index * 2, cbLettres.SelectedItem.ToString());
                    found = true;
                    score++;
            }
            
            }

            if (found == false)
            {
                rate++;
                lbLettresTestées.Text += cbLettres.SelectedItem.ToString();
                string penduImg = "pendu" + rate.ToString();
                picPendu.Image = (Image)Properties.Resources.ResourceManager.GetObject(penduImg);

                if (rate == 10)
                {
                    lblResult.Text = "Pendu !";
                    cbLettres.Enabled = false;
                }
            }

            if (score == mot.Length)
            {
                lblResult.Text = "Gagné !";
            }


        }

        private void fen_Load(object sender, EventArgs e)
        {

        }

        private void CacheMot(string mot)
        {
            txbMot.Text = "";
            for (int k = 0; k < mot.Length; k++)
            {
                txbMot.Text += "- ";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            mot = "";
            rate = 0;
            score = 0;
            picPendu.Image = (Image)Properties.Resources.ResourceManager.GetObject("pendu0");
            txbMot.Text = "";
            txbMot.Enabled = true;
            cbLettres.Enabled = false;
            lblResult.Text = "";
        }
    }
}

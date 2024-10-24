namespace CompitoFormsJalba
{
    public partial class Form1 : Form
    {
        int chitarraCount;
        int batteristaCount;
        List<CStrumento> strumenti;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chitarraCount = 0;
            batteristaCount = 0;
            strumenti = new List<CStrumento>(5);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CStrumento? toAdd = null;

            if (radBtnBatterista.Checked && batteristaCount < 3)
            {
                FormBatteristai formBatterista = new FormBatteristai();

                if (formBatterista.ShowDialog() == DialogResult.OK)
                {
                    toAdd = formBatterista.getStrumento();
                    batteristaCount++;

                    lstBoxLista.Items.Add(toAdd.toString());
                    strumenti.Add(toAdd);
                }

            }
            else if (radBtnChitarra.Checked && chitarraCount < 3)
            {
                FormChitarra formChitarra = new FormChitarra();

                if (formChitarra.ShowDialog() == DialogResult.OK)
                {
                    toAdd = formChitarra.getStrumento();
                    chitarraCount++;

                    lstBoxLista.Items.Add(toAdd.toString());
                    strumenti.Add(toAdd);
                }

            }
            else
            {
                MessageBox.Show("Seleziona uno strumento!");
            }

            //lstBoxLista.Items.Add(toAdd.toString());
            //strumenti.Add(toAdd); fixxx
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstBoxLista.SelectedIndex != -1)
            {
                if (lstBoxLista.Items[lstBoxLista.SelectedIndex].ToString().Substring(0, 1) == "C")
                    chitarraCount--;
                else
                    batteristaCount--;

                strumenti.RemoveAt(lstBoxLista.SelectedIndex);
                lstBoxLista.Items.RemoveAt(lstBoxLista.SelectedIndex);
            }
            else
                MessageBox.Show("Seleziona uno strumento!");
        }

        private void button1_Click(object sender, EventArgs e) //play all
        {
            string r = string.Empty;

            foreach (CStrumento strumento in strumenti)
            {
                r += strumento.play() + " " + strumento.makeSound() + "\n";
            }

            lblInfo.Text = r;
        }

        private void btnPlaying_Click(object sender, EventArgs e)
        {
            string r = string.Empty;

            foreach (CStrumento strumento in strumenti)
            {
                if (strumento is CBatterista && (strumento as CBatterista).isPlaying())
                    r += strumento.play() + " " + strumento.makeSound() + "\n";
            }

            lblInfo.Text = r;
        }

        private void btnBatterista_Click(object sender, EventArgs e)
        {
            if (lstBoxLista.SelectedIndex != -1 && strumenti[lstBoxLista.SelectedIndex] is CBatterista && txtNuovoNome.Text.Length > 0)
            {
                (strumenti[lstBoxLista.SelectedIndex] as CBatterista).setName(txtNuovoNome.Text);
                lstBoxLista.Items[lstBoxLista.SelectedIndex] = strumenti[lstBoxLista.SelectedIndex].toString();
            }
            else
                MessageBox.Show("Selezionare batterista oppure inserire nome!");
        }

        private void button2_Click(object sender, EventArgs e) //modifica volume
        {
            if (lstBoxLista.SelectedIndex != -1)
            {
                strumenti[lstBoxLista.SelectedIndex].decreaseVolume(1);
                lstBoxLista.Items[lstBoxLista.SelectedIndex] = strumenti[lstBoxLista.SelectedIndex].toString();
            }
        }

        private void btnAddVolume_Click(object sender, EventArgs e)
        {
            if (lstBoxLista.SelectedIndex != -1)
            {
                strumenti[lstBoxLista.SelectedIndex].increaseVolume(1);
                lstBoxLista.Items[lstBoxLista.SelectedIndex] = strumenti[lstBoxLista.SelectedIndex].toString();
            }
        }

        int scelto = -1;

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (scelto != -1 && lstBoxLista.SelectedIndex != -1 && strumenti[lstBoxLista.SelectedIndex] is CChitarra)
            {
                string r;
                switch ((strumenti[scelto] as CChitarra).CompareTo(strumenti[lstBoxLista.SelectedIndex] as CChitarra))
                {
                    case 1: //fix
                        r = $"Chitarra in posizione {scelto} suona meglio della chitarra in posizione {lstBoxLista.SelectedIndex}";
                        break;
                    case 0:
                        r = $"Le due chitarre suonano uguali";
                        break;
                    case -1:
                        r = $"Chitarra in posizione {scelto} suona peggio della chitarra in posizione {lstBoxLista.SelectedIndex}";
                        break;
                    default:
                        r = "Errore";
                        break;
                }

                lblInfo.Text = r;
            }
            else
                MessageBox.Show("Errore");
        }

        private void btnPrimaChitarra_Click(object sender, EventArgs e)
        {
            if (lstBoxLista.SelectedIndex != -1 && strumenti[lstBoxLista.SelectedIndex] is CChitarra)
            {
                scelto = lstBoxLista.SelectedIndex;
            }
        }
    }
}
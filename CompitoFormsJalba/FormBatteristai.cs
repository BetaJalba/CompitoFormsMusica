using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompitoFormsJalba
{
    public partial class FormBatteristai : Form //mi pento
    {
        CStrumento toPass;

        public FormBatteristai()
        {
            InitializeComponent();
        }

        private void FormBatteristai_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string? nome = txtNome.Text;
            int skillLevel;
            bool isPlaying = cekBoxPlaying.Checked;

            if (numSkill.Value <= 0 || numSkill.Value > 10)
            {
                MessageBox.Show("Ricorda che la destrezza punta da 1 a 10");
                return;
            }

            skillLevel = (int)numSkill.Value;

            toPass = new CBatterista(nome, skillLevel, isPlaying);
            DialogResult = DialogResult.OK;
        }

        public CStrumento getStrumento()
        {
            return toPass;
        }
    }
}

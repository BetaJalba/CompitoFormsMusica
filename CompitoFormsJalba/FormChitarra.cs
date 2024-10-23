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
    public partial class FormChitarra : Form
    {
        CStrumento toPass;

        public FormChitarra()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int volume;

            if (numSuono.Value <= 0 || numSuono.Value > 10)
            {
                MessageBox.Show("Ricorda che la destrezza punta da 1 a 10");
                return;
            }

            volume = (int)numSuono.Value;

            toPass = new CChitarra(volume);
            DialogResult = DialogResult.OK;
        }

        public CStrumento getStrumento()
        {
            return toPass;
        }
    }
}

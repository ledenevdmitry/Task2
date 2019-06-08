using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class SetTForm : Form
    {
        public SetTForm()
        {
            InitializeComponent();
        }

        public string T { get; private set; }
        public string ZMin { get; private set; }
        public string ZMax { get; private set; }
        public string ZStep { get; private set; }

        private void BtSubmit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            T = TbT.Text;
            ZMin = TbZMin.Text;
            ZMax = TbZMax.Text;
            ZStep = TbZStep.Text;

            Close();
        }

        private void Double_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && (sender as TextBox).Text != "")
            {
                e.Handled = true;
            }
        }
    }
}

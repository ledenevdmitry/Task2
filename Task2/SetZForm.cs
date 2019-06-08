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
    public partial class SetZForm : Form
    {
        public SetZForm()
        {
            InitializeComponent();
        }

        public string Z { get; private set; }
        public string TMin { get; private set; }
        public string TMax { get; private set; }
        public string TStep { get; private set; }

        private void BtSubmit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Z = TbZ.Text;
            TMin = TbTMin.Text;
            TMax = TbTMax.Text;
            TStep = TbTStep.Text;

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

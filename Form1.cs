using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarAttempt
{
    public partial class Form1 : Form
    {
        private bool ext = true;

        public Form1()
        {
            InitializeComponent();
            extMenu.Visible = true;
            intMenu.Visible = false;
        }

        private void extBlue_CheckedChanged(object sender, EventArgs e)
        {
            if((sender as RadioButton).Checked)
                extView.Image = CarAttempt.Properties.Resources.extBlue;
        }

        private void extBlack_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                extView.Image = CarAttempt.Properties.Resources.extBlack;
        }

        private void extSilver_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                extView.Image = CarAttempt.Properties.Resources.extSilver;
        }

        private void extBeige_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                extView.Image = CarAttempt.Properties.Resources.extBeige;
        }

        private void extWhite_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                extView.Image = CarAttempt.Properties.Resources.extWhite;
        }

        private void exterior_CheckedChanged(object sender, EventArgs e)
        {
            if((sender as RadioButton).Checked)
            {
                extMenu.Visible = true;
                intMenu.Visible = false;
            }

            //if (!b)
            //    extMenu.SendToBack();
        }

        private void interior_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                intMenu.Visible = true;
                extMenu.Visible = false;
            }

            //if (!b)
            //    intMenu.SendToBack();
        }

        private void intBrown_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                intView.Image = CarAttempt.Properties.Resources.intBrown;
        }

        private void intRed_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                intView.Image = CarAttempt.Properties.Resources.intRed;
        }

        private void intBeige_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                intView.Image = CarAttempt.Properties.Resources.intBeige;
        }
    }
}

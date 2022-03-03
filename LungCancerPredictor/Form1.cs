using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MLM;

namespace LungCancerPredictor
{
    public partial class Form1 : Form
    {
        ANN lungCancerModel;
        Matrix x = new Matrix(1, 15);

        public Form1()
        {
            InitializeComponent();
            lungCancerModel = new ANN(15, new int[] { 16, 8 }, 2);
            trainingStatus.Text = "";
            lungCancerProbability.Text = "";
        }

        private void sMale_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 0] = sMale.Checked ? 1 : x[0, 0];
        }

        private void sFemale_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 0] = sFemale.Checked ? 0 : x[0, 0];
        }

        private void age_ValueChanged(object sender, EventArgs e)
        {
            x[0, 1] = (double)age.Value;
        }

        private void smoking_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 2] = smoking.Checked ? 1 : 0;
        }

        private void yellowFingers_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 3] = yellowFingers.Checked ? 1 : 0;
        }

        private void anxiety_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 4] = anxiety.Checked ? 1 : 0;
        }

        private void peerPressure_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 5] = peerPressure.Checked ? 1 : 0;
        }

        private void chronicDisease_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 6] = chronicDisease.Checked ? 1 : 0;
        }

        private void fatigue_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 7] = fatigue.Checked ? 1 : 0;
        }

        private void allergy_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 8] = allergy.Checked ? 1 : 0;
        }

        private void wheezing_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 9] = wheezing.Checked ? 1 : 0;
        }

        private void alcohol_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 10] = alcohol.Checked ? 1 : 0;
        }

        private void coughing_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 11] = coughing.Checked ? 1 : 0;
        }

        private void shortnessOfBreath_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 12] = shortnessOfBreath.Checked ? 1 : 0;
        }

        private void swallowingDifficulty_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 13] = swallowingDifficulty.Checked ? 1 : 0;
        }

        private void chestPain_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 14] = chestPain.Checked ? 1 : 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trainingStatus.Text = "Training...";
            trainingStatus.Refresh();
        }
    }
}

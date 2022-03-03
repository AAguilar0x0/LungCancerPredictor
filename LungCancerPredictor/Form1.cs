using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MLM;
using CsvHelper;
using System.IO;
using System.Globalization;

namespace LungCancerPredictor
{
    public partial class Form1 : Form
    {
        ANN lungCancerModel;
        Matrix x;
        List<Matrix> X;
        List<Matrix> Y;

        public Form1()
        {
            InitializeComponent();
            lungCancerModel = new ANN(15, new int[] { 8 }, 1, "Lung Cancer Model");
            x = new Matrix(1, 15, false, -1);
            X = new List<Matrix>();
            Y = new List<Matrix>();
            trainingStatus.Text = "";
            lungCancerProbability.Text = "";
        }

        private void sMale_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 0] = sMale.Checked ? 1 : x[0, 0];
        }

        private void sFemale_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 0] = sFemale.Checked ? -1 : x[0, 0];
        }

        private void age_ValueChanged(object sender, EventArgs e)
        {
            x[0, 1] = (double)age.Value;
        }

        private void smoking_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 2] = smoking.Checked ? 1 : -1;
        }

        private void yellowFingers_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 3] = yellowFingers.Checked ? 1 : -1;
        }

        private void anxiety_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 4] = anxiety.Checked ? 1 : -1;
        }

        private void peerPressure_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 5] = peerPressure.Checked ? 1 : -1;
        }

        private void chronicDisease_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 6] = chronicDisease.Checked ? 1 : -1;
        }

        private void fatigue_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 7] = fatigue.Checked ? 1 : -1;
        }

        private void allergy_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 8] = allergy.Checked ? 1 : -1;
        }

        private void wheezing_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 9] = wheezing.Checked ? 1 : -1;
        }

        private void alcohol_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 10] = alcohol.Checked ? 1 : -1;
        }

        private void coughing_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 11] = coughing.Checked ? 1 : -1;
        }

        private void shortnessOfBreath_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 12] = shortnessOfBreath.Checked ? 1 : -1;
        }

        private void swallowingDifficulty_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 13] = swallowingDifficulty.Checked ? 1 : -1;
        }

        private void chestPain_CheckedChanged(object sender, EventArgs e)
        {
            x[0, 14] = chestPain.Checked ? 1 : -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trainingStatus.Text = "Training...";
            trainingStatus.Refresh();
            if (X.Count == 0 && Y.Count == 0)
                using (var reader = new StreamReader("./lung_cancer_data.csv"))
                {
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        csv.Read();
                        csv.ReadHeader();
                        while (csv.Read())
                        {
                            X.Add(new Matrix(new double[,] { {
                                csv.GetField<string>("GENDER") == "M" ? 1 : -1,
                                csv.GetField<double>("AGE"),
                                csv.GetField<double>("SMOKING") == 2 ? 1 : -1,
                                csv.GetField<double>("YELLOW_FINGERS") == 2 ? 1 : -1,
                                csv.GetField<double>("ANXIETY") == 2 ? 1 : -1,
                                csv.GetField<double>("PEER_PRESSURE") == 2 ? 1 : -1,
                                csv.GetField<double>("CHRONIC DISEASE") == 2 ? 1 : -1,
                                csv.GetField<double>("FATIGUE") == 2 ? 1 : -1,
                                csv.GetField<double>("ALLERGY") == 2 ? 1 : -1,
                                csv.GetField<double>("WHEEZING") == 2 ? 1 : -1,
                                csv.GetField<double>("ALCOHOL CONSUMING") == 2 ? 1 : -1,
                                csv.GetField<double>("COUGHING") == 2 ? 1 : -1,
                                csv.GetField<double>("SHORTNESS OF BREATH") == 2 ? 1 : -1,
                                csv.GetField<double>("SWALLOWING DIFFICULTY") == 2 ? 1 : -1,
                                csv.GetField<double>("CHEST PAIN") == 2 ? 1 : -1,
                            } }));
                            Y.Add(new Matrix(new double[,] { {
                                csv.GetField<string>("LUNG_CANCER") == "YES" ? 1 : 0
                            } }));
                        }
                    }
                }
            lungCancerModel.Train(X, Y, (int)iterations.Value, 0.01);
            trainingStatus.Text = "Trained";
            trainingStatus.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Matrix H = lungCancerModel.Infer(x);
            double max = H[0, 0];
            lungCancerProbability.Text = (max * 100).ToString("#.##") + "%";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            lungCancerModel = ANN.Load(openFileDialog1.FileName);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            lungCancerModel.Save(saveFileDialog1.FileName);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lungCancerModel = new ANN(15, new int[] { 8 }, 1, "Lung Cancer Model");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using MLM;
using MathNet.Numerics.LinearAlgebra;
using CsvHelper;
using System.IO;
using System.Globalization;

namespace LungCancerPredictor
{
    public partial class Form1 : Form
    {
        ANN lungCancerModel;
        Matrix<double> x;
        List<Matrix<double>> X;
        List<Matrix<double>> Y;
        readonly int[] defaultInnerLayers = { 8 };
        const double defaultAlpha = 0.03;
        const int defaultAge = 10;

        public Form1()
        {
            InitializeComponent();
            lungCancerModel = new ANN(15, defaultInnerLayers, 1, "Lung Cancer Model");
            learningRate.Text = defaultAlpha.ToString();
            x = Matrix<double>.Build.Dense(1, 15, -1);
            X = new List<Matrix<double>>();
            Y = new List<Matrix<double>>();
            trainingStatus.Text = "";
            lungCancerProbability.Text = "";
            openFileDialog1.InitialDirectory =
                saveFileDialog1.InitialDirectory =
                Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @".\models"));
            age.Value = defaultAge;
            x[0, 1] = defaultAge;
            try
            {
                using (var reader = new StreamReader("./datasets/train.csv"))
                {
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        csv.Read();
                        csv.ReadHeader();
                        while (csv.Read())
                        {
                            X.Add(Matrix<double>.Build.DenseOfArray(new double[,] { {
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
                            Y.Add(Matrix<double>.Build.DenseOfArray(new double[,] { {
                                csv.GetField<string>("LUNG_CANCER") == "YES" ? 1 : 0
                            } }));
                        }
                    }
                }
            }
            catch (Exception)
            {
                button1.Enabled = false;
                MessageBox.Show(
                    "Missing \"train.csv\" in \"datasets\" folder.\n" +
                    "To enable the training capability,\n" +
                    "please provide the missing file in the specified folder.\n" +
                    "Then restart the program afterwards.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                    );
            }
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
            try
            {
                double alpha = Convert.ToDouble(learningRate.Text);
                trainingStatus.Text = "Training...";
                trainingStatus.Refresh();
                lungCancerModel.Train(X, Y, (int)iterations.Value, alpha);
                trainingStatus.Text = "Trained";
                trainingStatus.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Invalid learning rate.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Matrix<double> H = lungCancerModel.Infer(x);
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
            lungCancerModel = new ANN(15, defaultInnerLayers, 1, "Lung Cancer Model");
        }
    }
}

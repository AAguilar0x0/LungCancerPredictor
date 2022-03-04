namespace LungCancerPredictor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.trainingStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sMale = new System.Windows.Forms.RadioButton();
            this.sFemale = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chestPain = new System.Windows.Forms.CheckBox();
            this.swallowingDifficulty = new System.Windows.Forms.CheckBox();
            this.shortnessOfBreath = new System.Windows.Forms.CheckBox();
            this.coughing = new System.Windows.Forms.CheckBox();
            this.alcohol = new System.Windows.Forms.CheckBox();
            this.wheezing = new System.Windows.Forms.CheckBox();
            this.allergy = new System.Windows.Forms.CheckBox();
            this.fatigue = new System.Windows.Forms.CheckBox();
            this.chronicDisease = new System.Windows.Forms.CheckBox();
            this.peerPressure = new System.Windows.Forms.CheckBox();
            this.anxiety = new System.Windows.Forms.CheckBox();
            this.smoking = new System.Windows.Forms.CheckBox();
            this.yellowFingers = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lungCancerProbability = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.iterations = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.learningRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.age)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterations)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Train";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trainingStatus
            // 
            this.trainingStatus.AutoSize = true;
            this.trainingStatus.Location = new System.Drawing.Point(93, 70);
            this.trainingStatus.Name = "trainingStatus";
            this.trainingStatus.Size = new System.Drawing.Size(35, 13);
            this.trainingStatus.TabIndex = 1;
            this.trainingStatus.Text = "status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sex:";
            // 
            // sMale
            // 
            this.sMale.AutoSize = true;
            this.sMale.Location = new System.Drawing.Point(40, 28);
            this.sMale.Name = "sMale";
            this.sMale.Size = new System.Drawing.Size(48, 17);
            this.sMale.TabIndex = 7;
            this.sMale.TabStop = true;
            this.sMale.Text = "Male";
            this.sMale.UseVisualStyleBackColor = true;
            this.sMale.CheckedChanged += new System.EventHandler(this.sMale_CheckedChanged);
            // 
            // sFemale
            // 
            this.sFemale.AutoSize = true;
            this.sFemale.Checked = true;
            this.sFemale.Location = new System.Drawing.Point(94, 28);
            this.sFemale.Name = "sFemale";
            this.sFemale.Size = new System.Drawing.Size(59, 17);
            this.sFemale.TabIndex = 8;
            this.sFemale.TabStop = true;
            this.sFemale.Text = "Female";
            this.sFemale.UseVisualStyleBackColor = true;
            this.sFemale.CheckedChanged += new System.EventHandler(this.sFemale_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Age:";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(206, 25);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(112, 20);
            this.age.TabIndex = 9;
            this.age.ValueChanged += new System.EventHandler(this.age_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chestPain);
            this.groupBox1.Controls.Add(this.swallowingDifficulty);
            this.groupBox1.Controls.Add(this.shortnessOfBreath);
            this.groupBox1.Controls.Add(this.coughing);
            this.groupBox1.Controls.Add(this.alcohol);
            this.groupBox1.Controls.Add(this.wheezing);
            this.groupBox1.Controls.Add(this.allergy);
            this.groupBox1.Controls.Add(this.fatigue);
            this.groupBox1.Controls.Add(this.chronicDisease);
            this.groupBox1.Controls.Add(this.peerPressure);
            this.groupBox1.Controls.Add(this.anxiety);
            this.groupBox1.Controls.Add(this.smoking);
            this.groupBox1.Controls.Add(this.yellowFingers);
            this.groupBox1.Controls.Add(this.age);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.sMale);
            this.groupBox1.Controls.Add(this.sFemale);
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 213);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Predictors";
            // 
            // chestPain
            // 
            this.chestPain.AutoSize = true;
            this.chestPain.Location = new System.Drawing.Point(174, 166);
            this.chestPain.Name = "chestPain";
            this.chestPain.Size = new System.Drawing.Size(76, 17);
            this.chestPain.TabIndex = 22;
            this.chestPain.Text = "Chest pain";
            this.chestPain.UseVisualStyleBackColor = true;
            this.chestPain.CheckedChanged += new System.EventHandler(this.chestPain_CheckedChanged);
            // 
            // swallowingDifficulty
            // 
            this.swallowingDifficulty.AutoSize = true;
            this.swallowingDifficulty.Location = new System.Drawing.Point(174, 143);
            this.swallowingDifficulty.Name = "swallowingDifficulty";
            this.swallowingDifficulty.Size = new System.Drawing.Size(120, 17);
            this.swallowingDifficulty.TabIndex = 21;
            this.swallowingDifficulty.Text = "Swallowing difficulty";
            this.swallowingDifficulty.UseVisualStyleBackColor = true;
            this.swallowingDifficulty.CheckedChanged += new System.EventHandler(this.swallowingDifficulty_CheckedChanged);
            // 
            // shortnessOfBreath
            // 
            this.shortnessOfBreath.AutoSize = true;
            this.shortnessOfBreath.Location = new System.Drawing.Point(174, 120);
            this.shortnessOfBreath.Name = "shortnessOfBreath";
            this.shortnessOfBreath.Size = new System.Drawing.Size(118, 17);
            this.shortnessOfBreath.TabIndex = 20;
            this.shortnessOfBreath.Text = "Shortness of breath";
            this.shortnessOfBreath.UseVisualStyleBackColor = true;
            this.shortnessOfBreath.CheckedChanged += new System.EventHandler(this.shortnessOfBreath_CheckedChanged);
            // 
            // coughing
            // 
            this.coughing.AutoSize = true;
            this.coughing.Location = new System.Drawing.Point(174, 97);
            this.coughing.Name = "coughing";
            this.coughing.Size = new System.Drawing.Size(71, 17);
            this.coughing.TabIndex = 19;
            this.coughing.Text = "Coughing";
            this.coughing.UseVisualStyleBackColor = true;
            this.coughing.CheckedChanged += new System.EventHandler(this.coughing_CheckedChanged);
            // 
            // alcohol
            // 
            this.alcohol.AutoSize = true;
            this.alcohol.Location = new System.Drawing.Point(174, 74);
            this.alcohol.Name = "alcohol";
            this.alcohol.Size = new System.Drawing.Size(61, 17);
            this.alcohol.TabIndex = 18;
            this.alcohol.Text = "Alcohol";
            this.alcohol.UseVisualStyleBackColor = true;
            this.alcohol.CheckedChanged += new System.EventHandler(this.alcohol_CheckedChanged);
            // 
            // wheezing
            // 
            this.wheezing.AutoSize = true;
            this.wheezing.Location = new System.Drawing.Point(174, 51);
            this.wheezing.Name = "wheezing";
            this.wheezing.Size = new System.Drawing.Size(74, 17);
            this.wheezing.TabIndex = 17;
            this.wheezing.Text = "Wheezing";
            this.wheezing.UseVisualStyleBackColor = true;
            this.wheezing.CheckedChanged += new System.EventHandler(this.wheezing_CheckedChanged);
            // 
            // allergy
            // 
            this.allergy.AutoSize = true;
            this.allergy.Location = new System.Drawing.Point(9, 189);
            this.allergy.Name = "allergy";
            this.allergy.Size = new System.Drawing.Size(57, 17);
            this.allergy.TabIndex = 16;
            this.allergy.Text = "Allergy";
            this.allergy.UseVisualStyleBackColor = true;
            this.allergy.CheckedChanged += new System.EventHandler(this.allergy_CheckedChanged);
            // 
            // fatigue
            // 
            this.fatigue.AutoSize = true;
            this.fatigue.Location = new System.Drawing.Point(9, 166);
            this.fatigue.Name = "fatigue";
            this.fatigue.Size = new System.Drawing.Size(61, 17);
            this.fatigue.TabIndex = 15;
            this.fatigue.Text = "Fatigue";
            this.fatigue.UseVisualStyleBackColor = true;
            this.fatigue.CheckedChanged += new System.EventHandler(this.fatigue_CheckedChanged);
            // 
            // chronicDisease
            // 
            this.chronicDisease.AutoSize = true;
            this.chronicDisease.Location = new System.Drawing.Point(9, 143);
            this.chronicDisease.Name = "chronicDisease";
            this.chronicDisease.Size = new System.Drawing.Size(101, 17);
            this.chronicDisease.TabIndex = 14;
            this.chronicDisease.Text = "Chronic disease";
            this.chronicDisease.UseVisualStyleBackColor = true;
            this.chronicDisease.CheckedChanged += new System.EventHandler(this.chronicDisease_CheckedChanged);
            // 
            // peerPressure
            // 
            this.peerPressure.AutoSize = true;
            this.peerPressure.Location = new System.Drawing.Point(9, 120);
            this.peerPressure.Name = "peerPressure";
            this.peerPressure.Size = new System.Drawing.Size(91, 17);
            this.peerPressure.TabIndex = 13;
            this.peerPressure.Text = "Peer pressure";
            this.peerPressure.UseVisualStyleBackColor = true;
            this.peerPressure.CheckedChanged += new System.EventHandler(this.peerPressure_CheckedChanged);
            // 
            // anxiety
            // 
            this.anxiety.AutoSize = true;
            this.anxiety.Location = new System.Drawing.Point(9, 97);
            this.anxiety.Name = "anxiety";
            this.anxiety.Size = new System.Drawing.Size(60, 17);
            this.anxiety.TabIndex = 12;
            this.anxiety.Text = "Anxiety";
            this.anxiety.UseVisualStyleBackColor = true;
            this.anxiety.CheckedChanged += new System.EventHandler(this.anxiety_CheckedChanged);
            // 
            // smoking
            // 
            this.smoking.AutoSize = true;
            this.smoking.Location = new System.Drawing.Point(9, 51);
            this.smoking.Name = "smoking";
            this.smoking.Size = new System.Drawing.Size(67, 17);
            this.smoking.TabIndex = 10;
            this.smoking.Text = "Smoking";
            this.smoking.UseVisualStyleBackColor = true;
            this.smoking.CheckedChanged += new System.EventHandler(this.smoking_CheckedChanged);
            // 
            // yellowFingers
            // 
            this.yellowFingers.AutoSize = true;
            this.yellowFingers.Location = new System.Drawing.Point(9, 74);
            this.yellowFingers.Name = "yellowFingers";
            this.yellowFingers.Size = new System.Drawing.Size(91, 17);
            this.yellowFingers.TabIndex = 11;
            this.yellowFingers.Text = "Yellow fingers";
            this.yellowFingers.UseVisualStyleBackColor = true;
            this.yellowFingers.CheckedChanged += new System.EventHandler(this.yellowFingers_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lungCancerProbability);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(12, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 54);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prediction";
            // 
            // lungCancerProbability
            // 
            this.lungCancerProbability.AutoSize = true;
            this.lungCancerProbability.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lungCancerProbability.Location = new System.Drawing.Point(213, 24);
            this.lungCancerProbability.Name = "lungCancerProbability";
            this.lungCancerProbability.Size = new System.Drawing.Size(65, 13);
            this.lungCancerProbability.TabIndex = 2;
            this.lungCancerProbability.Text = "probability";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lung cancer probability:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Predict";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // iterations
            // 
            this.iterations.Location = new System.Drawing.Point(228, 41);
            this.iterations.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.iterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iterations.Name = "iterations";
            this.iterations.Size = new System.Drawing.Size(102, 20);
            this.iterations.TabIndex = 5;
            this.iterations.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Load";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(93, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "JSON|*.json;";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JSON|*.json;";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(174, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // learningRate
            // 
            this.learningRate.Location = new System.Drawing.Point(92, 40);
            this.learningRate.Name = "learningRate";
            this.learningRate.Size = new System.Drawing.Size(76, 20);
            this.learningRate.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Iteration:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Learning Rate:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 379);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.learningRate);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.iterations);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trainingStatus);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lung Cancer Predictor";
            ((System.ComponentModel.ISupportInitialize)(this.age)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label trainingStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton sMale;
        private System.Windows.Forms.RadioButton sFemale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown age;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chestPain;
        private System.Windows.Forms.CheckBox swallowingDifficulty;
        private System.Windows.Forms.CheckBox shortnessOfBreath;
        private System.Windows.Forms.CheckBox coughing;
        private System.Windows.Forms.CheckBox alcohol;
        private System.Windows.Forms.CheckBox wheezing;
        private System.Windows.Forms.CheckBox allergy;
        private System.Windows.Forms.CheckBox fatigue;
        private System.Windows.Forms.CheckBox chronicDisease;
        private System.Windows.Forms.CheckBox peerPressure;
        private System.Windows.Forms.CheckBox anxiety;
        private System.Windows.Forms.CheckBox smoking;
        private System.Windows.Forms.CheckBox yellowFingers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lungCancerProbability;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown iterations;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox learningRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


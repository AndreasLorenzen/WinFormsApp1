using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int centerValue;

        public Form1()
        {
            InitializeComponent();
            GenerateRandomCenterValue();
        }

        private void GenerateRandomCenterValue()
        {
            Random random = new Random();
            centerValue = random.Next(1, 101); // Generer et tilfældigt tal mellem 1 og 100
            txtCenter.Text = centerValue.ToString();
            txtRight.Text = ""; // Højre boks er tom ved opstart
            txtTop.Text = ""; // Øverste boks er tom ved opstart
            txtBottom.Text = ""; // Nederste boks er tom ved opstart
            txtLeft.Text = ""; // Venstre boks er tom ved opstart
        }

        private void UpdateRightBox()
        {
            // Opdater højre boks baseret på centerValue
            txtRight.Text = (centerValue + 1).ToString();
        }

        private void txtCenter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                centerValue = int.Parse(txtCenter.Text);
                UpdateRightBox();
                ResetTextBoxColors();
            }
            catch
            {
                // Håndter fejl ved ugyldigt input
                ResetTextBoxColors();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                bool isCorrect = true;

                // Tjek de andre tekstbokse mod de forventede værdier
                if (int.TryParse(txtTop.Text, out int topValue) && topValue == centerValue + 10)
                {
                    txtTop.BackColor = Color.Green;
                }
                else
                {
                    txtTop.BackColor = Color.Red;
                    isCorrect = false;
                }

                if (int.TryParse(txtBottom.Text, out int bottomValue) && bottomValue == centerValue - 10)
                {
                    txtBottom.BackColor = Color.Green;
                }
                else
                {
                    txtBottom.BackColor = Color.Red;
                    isCorrect = false;
                }

                if (int.TryParse(txtRight.Text, out int rightValue) && rightValue == centerValue + 1)
                {
                    txtRight.BackColor = Color.Green;
                }
                else
                {
                    txtRight.BackColor = Color.Red;
                    isCorrect = false;
                }

                if (int.TryParse(txtLeft.Text, out int leftValue) && leftValue == centerValue - 1)
                {
                    txtLeft.BackColor = Color.Green;
                }
                else
                {
                    txtLeft.BackColor = Color.Red;
                    isCorrect = false;
                }

                if (isCorrect)
                {
                    MessageBox.Show("Korrekt! Alle værdier er rigtige.");
                }
                else
                {
                    MessageBox.Show("Fejl! Nogle værdier er forkerte.");
                }
            }
            catch
            {
                MessageBox.Show("Indtast venligst kun tal i alle bokse.");
            }
        }

        private void ResetTextBoxColors()
        {
            txtTop.BackColor = Color.White;
            txtBottom.BackColor = Color.White;
            txtLeft.BackColor = Color.White;
            txtRight.BackColor = Color.White;
        }
    }
}

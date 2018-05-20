using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_117_Exercise_6
{
    public partial class snakeEyesForm : Form
    {
        private int fontSize = 50;
        private int rollCount = 0;
        private Dice diceOne;
        private Dice diceTwo;
        private int diceOneResults = 0;
        private int diceTwoResults = 0;

        public snakeEyesForm()
        {
            InitializeComponent();
            diceOne = new Dice(6);
            diceTwo = new Dice(6);
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            startRoll();
            while (!isSnakeEyes())
            {
                rollDice();
                System.Threading.Thread.Sleep(500);
            }
            rollButton.Enabled = true;
            resultsLabel.Text = "It took " + rollCount.ToString() + " to get snake eyes";
        }
        private void startRoll()
        {
            rollButton.Enabled = false;
            diceOneResults = 0;
            diceTwoResults = 0;
            resultsLabel.Text = "Rolling";
            rollCount = 0;
        }
        private void rollDice()
        {
            rollCount++;
            diceOneResults = diceOne.rollDie();
            diceTwoResults = diceTwo.rollDie();
            updateDice();
        }
        private bool isSnakeEyes()
        {
            return diceOneResults == 1 && diceTwoResults == 1;
        }
        private void updateDice()
        {
            SolidBrush sbBlack = new SolidBrush(Color.Black);
            Graphics diceOnePanelGraphics = diceOnePanel.CreateGraphics();
            Font diceOneFont = new Font("Arial", fontSize);
            diceOnePanelGraphics.FillRectangle(sbBlack, 0, 0, diceOnePanel.Width, diceOnePanel.Height);
            diceOnePanelGraphics.DrawString(diceOneResults.ToString(), diceOneFont, Brushes.White, new PointF((diceOnePanel.Width / 2) - (fontSize / 1.5F), (diceOnePanel.Height / 2) - (fontSize / 1.5F)));

            SolidBrush sbGreen = new SolidBrush(Color.Green);
            Graphics diceTwoPanelGraphics = diceTwoPanel.CreateGraphics();
            Font diceTwoFont = new Font("Times New Roman", fontSize);
            diceTwoPanelGraphics.FillRectangle(sbGreen, 0, 0, diceTwoPanel.Width, diceTwoPanel.Height);
            diceTwoPanelGraphics.DrawString(diceTwoResults.ToString(), diceTwoFont, Brushes.White, new PointF((diceTwoPanel.Width / 2) - (fontSize / 1.5F), (diceTwoPanel.Height / 2) - (fontSize / 1.5F)));
        }
    }
}

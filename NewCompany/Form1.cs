using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCompany
{


    public partial class Form1 : Form
    {
        public const int StartCoins = 10;
        public const bool StartWorksForHimSelf = true;
        public const int StartCoinIncrement = 1;
        
        public int coins;
        public bool WorksForHimSelf;
        public int CoinIncrement;
        public Form1()
        {
            InitializeComponent();
        }

        public void gameEnd()
        {
            foreach (Control c in this.Controls)
            {
                c.Visible = false;
            }
            ExitButton.Visible = true;
            coins = StartCoins;
            WorksForHimSelf = StartWorksForHimSelf;
            CoinIncrement = StartCoinIncrement;
            NewGameButton.Visible = true;
        }


        public void gameStart()
        {
            foreach (Control c in this.Controls)
            {
                c.Visible = true;
            }
            coins = StartCoins;
            WorksForHimSelf = StartWorksForHimSelf;
            NewGameButton.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameEnd();
        }

        private void NewTurn_Click(object sender, EventArgs e)
        {
            
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            gameStart();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    public static class BooleanExtensions
    {
        public static string ToYesNoString(this bool value)
        {
            return value ? "да" : "нет";
        }
    }
    public static class StringExtensions
    {
        public static bool ToTrueFalseBool(this string value)
        {
            return value == "да" ? true : false;
        }
    }
}

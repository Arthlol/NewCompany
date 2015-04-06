﻿using System;
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
    public partial class Form1 : Form
    {
        public static int StartCoins = 10;
        public static bool StartWorksForHimSelf = true;
        public static int CoinIncrement = 1;
        
        public int coins;
        public bool WorksForHimSelf;
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
            coins = StartCoins;
            WorksForHimSelf = StartWorksForHimSelf;
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
            CoinsLabelValue.Text = coins.ToString();
            WorksForHimSelfLabelValue.Text = WorksForHimSelf.ToYesNoString();
            NewGameButton.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameEnd();
        }

        private void NewTurn_Click(object sender, EventArgs e)
        {
            if (WorksForHimSelfLabelValue.Text.ToTrueFalseBool()) coins++;
            CoinsLabelValue.Text = coins.ToString();

            if (Convert.ToInt32(CoinsLabelValue.Text) == 27) {
                MessageBox.Show("Игра окончена!");
                gameEnd();
            }
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            gameStart();
        }
    }
}

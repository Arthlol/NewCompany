using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCompany
{


    public partial class Form1 : Form
    {

        public int coins;
        public bool WorksForHimSelf;
        public int CoinIncrement;

        List<Control> StartPage = new List<Control>();
        Entities db = new Entities();
        public Form1()
        {
            InitializeComponent();
            StartPage.Add(EnterSessionDataGroupBox);
            StartPage.Add(WelcomeLabel);
            StartPage.Add(NewGameButton);
        }

        public void gameEnd()
        {
            foreach (Control c in this.Controls)
            {
                c.Visible = false;
            }
            foreach (Control c in StartPage)
            {
                c.Visible = true;
            }
            ExitButton.Visible = true;
            AnalyseButton.Visible = true;
            EnterSessionDataGroupBox.Visible = true;
            NewGameButton.Visible = true;
        }


        public void gameStart()
        {
            //foreach (Control c in this.Controls)
            //{
            //    c.Visible = true;
            //}
            //foreach (Control c in StartPage)
            //{
            //    c.Visible = false;
            //}
            //NewGameButton.Visible = false;
            this.Visible = false;
            var TestForm = new TestForm();
            TestForm.Show(this);

        }

        public bool saveSessionData()
        {
            bool res = true;
            string message = "Введенные данные неверны. Заполните поля:\n";
            if (SurnameTextBox.Text.Length < 1)
            {
                res = false;
                message += "\t• Фамилия\n";
            }
            if (NameTextBox.Text.Length < 2)
            {
                res = false;
                message += "\t• Имя\n";
            }
            if (GroupTextBox.Text.Length < 5)
            {
                res = false;
                message += "\t• Группа\n";
            }
            if (!res) MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK);
            else
            {
                var item = new Session()
                {
                    Surname = SurnameTextBox.Text,
                    Name = NameTextBox.Text,
                    Group = GroupTextBox.Text,
                    DateStart = DateTime.Now
                };
                db.Session.Add(item);
                db.SaveChanges();
            }
            return res;
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
            if (saveSessionData()) gameStart();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult Exit = MessageBox.Show("Все несохраненные изменения будут утеряны. \nВы уверенны, что хотите выйти?", "Предупреждение", MessageBoxButtons.OKCancel);
            if (Exit.Equals(DialogResult.OK)) Application.Exit();
        }

        private void OnlyLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void AnalyseButton_Click(object sender, EventArgs e)
        {
            var af = new AccessForm();
            af.Show(this);
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

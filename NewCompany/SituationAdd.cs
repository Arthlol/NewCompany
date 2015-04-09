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
    public partial class SituationAdd : Form
    {
        public SituationAdd()
        {
            InitializeComponent();
        }

        Entities db = new Entities();
        //       private List<Session> SessionList = new List<Session>();

        private void SituationAdd_Load(object sender, EventArgs e)
        {



        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string Name = NameTextBox.Text;
            string Description = DescriptionTextBox.Text;
            var Situation = new Situation();
            DialogResult Approve = MessageBox.Show("Вы уверенны, что хотите добавить данную ситуацию?", "Предупреждение", MessageBoxButtons.OKCancel);
            if (Approve.Equals(DialogResult.OK))
            {
                if (HasText(Name, Description))
                {
                    try
                    {
                        Situation.Name = Name;
                        Situation.Description = Description;
                        db.Situation.Add(Situation);
                        db.SaveChanges();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Произошла ошибка добавления");
                    }

                    DialogResult res = MessageBox.Show("Ситуация успешно добавлена. \n Хотите добавить новую ситуацию?", "", MessageBoxButtons.OKCancel);

                    if (res.Equals(DialogResult.OK))
                    {
                        this.DescriptionTextBox.Text = "";
                        this.NameTextBox.Text = "";
                    }
                    else
                    {
                        this.Close();
                    }

                }
            }

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            //MessageBox вы уверены что хотите выйти?
            DialogResult Exit = MessageBox.Show("Вы уверенны, что хотите выйти?", "Предупреждение", MessageBoxButtons.OKCancel);
            if (Exit.Equals(DialogResult.OK))
            {
                this.Owner.Visible = true;
                this.Owner.Show();
                this.Close();
            }
        }
        private bool HasText(string Name, string Description)
        {
            return (!string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Description));
        }
    }
}

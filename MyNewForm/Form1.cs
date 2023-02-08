using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNewForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(124, 152, 133);
            headerLbl.BackColor = Color.FromArgb(11,60,73);
            changeBtn.BackColor = Color.FromArgb(11,60,73);
            addBtn.BackColor = Color.FromArgb(11,60,73);
            loadBtn.BackColor = Color.FromArgb(11,60,73);
            saveBtn.BackColor = Color.FromArgb(11,60,73);
            exitBtn.BackColor = Color.FromArgb(11,60,73);
        }

        Person person = new Person();
        Person user = new Person();
        FileHelper fileHelper = new FileHelper();
        List<Person> humans = new List<Person> { };
        private void nameTxb_TextChanged(object sender, EventArgs e)
        {
            person.Name = nameTxb.Text;
            person.Filename = person.Name;
        }

        private void surnameTxb_TextChanged(object sender, EventArgs e)
        {
            person.Surname = surnameTxb.Text;
        }

        private void emailTxb_TextChanged(object sender, EventArgs e)
        {
            person.Email = emailTxb.Text;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            person.Number = numberTxb.Text.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            person.Birthdate = birthdatetime.Value;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            humanslistBox.Items.Add(person);
            humanslistBox.DisplayMember = nameof(Person.Name);
            filenameTxb.Text = person.Filename+".json";
            if (!humanslistBox.Items.Equals(person.Id))
            {
                humans.Add(person);
            }

            if (!filenameTxb.Text.Contains(".json"))
            {
                filenameTxb.Text = person.Filename + ".json";
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            fileHelper.Write(person);
            nameTxb.Text = "";
            surnameTxb.Text = "";
            emailTxb.Text = "";
            numberTxb.Text = "";
            birthdatetime.Text = "";
            filenameTxb.Text = "";
        }


        private void loadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var path=Directory.GetCurrentDirectory()+"\\"+filenameTxb.Text;
                if (File.Exists(path) || File.Exists(path+".json"))
                {
                    changeBtn.Location = new Point(309, 324);
                    addBtn.Location = new Point(309, 375);
                }
                if (filenameTxb.Text != "" && !filenameTxb.Text.Contains(".json"))
                {
                    filenameTxb.Text += ".json";
                }
                if (File.Exists(filenameTxb.Text))
                {
                    user = fileHelper.Read(filenameTxb.Text);
                }
                else
                {

                }
                nameTxb.Text = user.Name;
                surnameTxb.Text = user.Surname;
                emailTxb.Text = user.Email;
                numberTxb.Text = user.Number.ToString();
                birthdatetime.Text = user.Birthdate.ToString();
            }
            catch
            {

            }
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            filenameTxb.Text = user.Filename+".json";
            if (nameTxb.Text != user.Name)
            {
                user.Name = nameTxb.Text;
            }
            if (person.Name != user.Name)
            {               
                person.Filename = user.Filename;
            }
            else
            {
                filenameTxb.Text = user.Filename + ".json";
            }
            if (surnameTxb.Text != user.Surname)
            {
                user.Surname = surnameTxb.Text;
            }
            if (emailTxb.Text != user.Email)
            {
                user.Email = emailTxb.Text;
            }
            if (numberTxb.Text != user.Number)
            {
                user.Number = numberTxb.Text;
            }
            if (birthdatetime.Text != user.Birthdate.ToString())
            {
                user.Birthdate = birthdatetime.Value;
            }
            person = user;
            fileHelper.Write(person);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void humanslistBox_DoubleClick(object sender, EventArgs e)
        {
            var human = humanslistBox.SelectedItem as Person;
            filenameTxb.Text = human.Filename;
        }
    }
}

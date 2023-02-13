using Newtonsoft.Json;
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
        List<Person> humans = new List<Person>();
        Person user = new Person();
        Person person = new Person();
        List<Person> GetAllPersons()
        {
            List<Person> persons = new List<Person>();
            var files = Directory.GetFiles(".");
            foreach (var item in files)
            {
                if (item.EndsWith(".json"))
                {
                    var obj = JsonConvert.DeserializeObject<Person>(File.ReadAllText(item));
                    persons.Add(obj);
                }
            }
            return persons;
        }
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(124, 152, 133);
            headerLbl.BackColor = Color.FromArgb(11, 60, 73);
            changeBtn.BackColor = Color.FromArgb(11, 60, 73);
            addBtn.BackColor = Color.FromArgb(11, 60, 73);
            loadBtn.BackColor = Color.FromArgb(11, 60, 73);
            saveBtn.BackColor = Color.FromArgb(11, 60, 73);
            exitBtn.BackColor = Color.FromArgb(11, 60, 73);
        }

        FileHelper fileHelper = new FileHelper();



        private void addBtn_Click(object sender, EventArgs e)
        {
            person = new Person();
            person.Name = nameTxb.Text;
            person.Filename = person.Name;
            person.Surname = surnameTxb.Text;
            person.Email = emailTxb.Text;
            person.Number = numberTxb.Text;
            person.Birthdate = birthdatetime.Value;
            humanslistBox.DisplayMember = nameof(Person.Name);
            filenameTxb.Text = person.Filename + ".json";
            if (!humanslistBox.Items.Equals(person.Id))
            {
                humanslistBox.Items.Add(person);
            }

            if (!filenameTxb.Text.Contains(".json"))
            {
                filenameTxb.Text = person.Filename + ".json";
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            fileHelper.Write(person);
            //fileHelper.WriteListBox(humanslistBox.Items.ToString());
            changeBtn.Location = new Point(309, 375);
            addBtn.Location = new Point(309, 324);
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
                if (filenameTxb.Text == "")
                {
                    var persons = GetAllPersons();
                    humanslistBox.Items.Clear();
                    humanslistBox.Items.AddRange(persons.ToArray());
                    humanslistBox.DisplayMember = nameof(Person.Name);
                }
                var path = Directory.GetCurrentDirectory() + "\\" + filenameTxb.Text;
                if (File.Exists(path) || File.Exists(path + ".json"))
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
                    nameTxb.Text = user.Name;
                    surnameTxb.Text = user.Surname;
                    emailTxb.Text = user.Email;
                    numberTxb.Text = user.Number;
                    birthdatetime.Text = user.Birthdate.ToString();
                }

            }
            catch
            {

            }
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            filenameTxb.Text = user.Filename + ".json";
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

        private void humanslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var human = humanslistBox.SelectedItem as Person;
            filenameTxb.Text = human.Filename;

            nameTxb.Text = human.Name;
            surnameTxb.Text = human.Surname;
            emailTxb.Text = human.Email;
            numberTxb.Text = human.Number;
            birthdatetime.Text = human.Birthdate.ToString();
        }

        private void nameTxb_TextChanged(object sender, EventArgs e)
        {
            person.Filename = person.Name;
        }
    }
}

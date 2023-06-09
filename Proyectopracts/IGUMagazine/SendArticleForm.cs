﻿using Magazine.Entities;
using Magazine.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IGUMagazine
{
    public partial class SendArticleForm : Form
    {


        public SendArticleForm()
        {
            InitializeComponent();
            
            //DEBUG
            CoAuthorTextBoxName1.Text = LoginForm.service.UserLogged().Name;
            CoAuthorTextBoxSurName1.Text = LoginForm.service.UserLogged().Surname;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int count = 1;
        private void AddCoAuthorClick(object sender, EventArgs e)
        {
            count++;
            switch (count)
            {
                case 2:
                    CoAuthorTextBoxName2.Show();
                    CoAuthorTextBoxSurName2.Show();
                    CoAuthor2Button.Show();
                    Subbutton.Enabled = true;
                    break;

                case 3:
                    CoAuthorTextBoxName3.Show();
                    CoAuthorTextBoxSurName3.Show();
                    CoAuthor3Button.Show();
                    break;

                case 4:
                    CoAuthorTextBoxName4.Show();
                    CoAuthorTextBoxSurName4.Show();
                    CoAuthor4Button.Show();
                    Addbutton.Enabled = false;
                    break;

            }
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        List<Person> CoAuthors = new List<Person>();
        private void SubstractCoAuthorClick(object sender, EventArgs e)
        {
            
            switch (count)
            {
                case 2:
                    CoAuthorTextBoxName2.Hide();
                    CoAuthorTextBoxName2.Clear();


                    CoAuthorTextBoxSurName2.Hide();
                    CoAuthorTextBoxSurName2.Clear();

                    CoAuthor2Button.Hide();

                    Subbutton.Enabled = false;
                    break;

                case 3:
                    CoAuthorTextBoxName3.Hide();
                    CoAuthorTextBoxName3.Clear();

                    CoAuthorTextBoxSurName3.Hide();
                    CoAuthorTextBoxSurName3.Clear();

                    CoAuthor3Button.Hide();

                    break;

                case 4:
                    CoAuthorTextBoxName4.Hide();
                    CoAuthorTextBoxName4.Clear();

                    CoAuthorTextBoxSurName4.Hide();
                    CoAuthorTextBoxSurName4.Clear();

                    CoAuthor4Button.Hide();

                    Addbutton.Enabled = true;
                    break;
            }
            count--;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Area_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private Magazine.Entities.Area area;
        private void AreaTextBoxLeave(object sender, EventArgs e)
        {
            if (AreaTextBox.Text != "") {
                try
                {
                    area = LoginForm.service.FindAreaByName(AreaTextBox.Text);
                    TitleTextBox.ReadOnly = false;
                    AreaTextBox.ReadOnly = true;

                }
                catch (ServiceException ex)
                {
                    MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AreaTextBox.Focus();
                }
            }

            
        }

        private void titulo_txt_TextChanged(object sender, EventArgs e)
        {
            if (TitleTextBox.Text != "")
            {
                Send_Button.Enabled = true;
            }
            else { 
                Send_Button.Enabled = false;
            }
        }

        private void EditAreaDoubleClick(object sender, EventArgs e)
        {
            if (AreaTextBox.ReadOnly == true) {
                AreaTextBox.ReadOnly = false;
                TitleTextBox.ReadOnly = true;
            }
        }

        private void CoAutorTextBoxSurName4_TextChanged(object sender, EventArgs e)
        {

        }

        private void CoAuthorTextBoxSurName2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CoAuthorTextBoxSurName3_TextChanged(object sender, EventArgs e)
        {

        }

        private string GenerateRandomId() {
            Random _random = new Random();
            string _id = _random.Next(0, 9999).ToString("D4");

            return _id;
        }

        private void CoAuthor2Button_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            if (CoAuthorTextBoxName2.ReadOnly == true)
            {
                CoAuthorTextBoxName2.ReadOnly = false;
                CoAuthorTextBoxSurName2.ReadOnly = false;

                CoAuthor2Button.Text = "✓";

                CoAuthors.Remove(person);
            }
            else
            {
                person.Id = GenerateRandomId();
                person.Name = CoAuthorTextBoxName2.Text;
                person.Surname = CoAuthorTextBoxSurName2.Text;

                try
                {
                    LoginForm.service.AddPerson(person);
                    CoAuthorTextBoxName2.ReadOnly = true;
                    CoAuthorTextBoxSurName2.ReadOnly = true;

                    CoAuthor2Button.Text = "✎";

                    CoAuthors.Add(person);
                }
                catch (ServiceException ex)
                {
                    MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CoAuthor3Button_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            if (CoAuthorTextBoxName3.ReadOnly == true)
            {
                CoAuthorTextBoxName3.ReadOnly = false;
                CoAuthorTextBoxSurName3.ReadOnly = false;

                CoAuthor3Button.Text = "✓";

                CoAuthors.Remove(person);
            }
            else
            {
                person.Id = GenerateRandomId();
                person.Name = CoAuthorTextBoxName3.Text;
                person.Surname = CoAuthorTextBoxSurName3.Text;

                try
                {
                    LoginForm.service.AddPerson(person);
                    CoAuthorTextBoxName3.ReadOnly = true;
                    CoAuthorTextBoxSurName3.ReadOnly = true;

                    CoAuthor3Button.Text = "✎";

                    CoAuthors.Add(person);
                }
                catch (ServiceException ex)
                {
                    MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CoAuthor4Button_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            if (CoAuthorTextBoxName4.ReadOnly == true)
            {
                CoAuthorTextBoxName4.ReadOnly = false;
                CoAuthorTextBoxSurName4.ReadOnly = false;

                CoAuthor4Button.Text = "✓";

                CoAuthors.Remove(person);
            }
            else
            {
                person.Id = GenerateRandomId();
                person.Name = CoAuthorTextBoxName4.Text;
                person.Surname = CoAuthorTextBoxSurName4.Text;

                try
                {
                    LoginForm.service.AddPerson(person);
                    CoAuthorTextBoxName4.ReadOnly = true;
                    CoAuthorTextBoxSurName4.ReadOnly = true;

                    CoAuthor4Button.Text = "✎";

                    CoAuthors.Add(person);
                }
                catch (ServiceException ex)
                {
                    MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Send_Button_Click(object sender, EventArgs e)
        {
            try
            {
                String title = TitleTextBox.Text;
                DateTime currentDate = DateTime.Now;
                User responsableUser = LoginForm.service.UserLogged();
                Paper paper = new Paper(title, currentDate, area, responsableUser);
                

                foreach(Person person in CoAuthors) {
                    //Console.WriteLine(person.Name);
                    paper.AddCoAuthor(person);
                }

                //Console.WriteLine(paper.ToString());
                LoginForm.service.AddPaper(paper);
                LoginForm.service.AddPendingEvaluatePaperToArea(area, paper);
                this.Close();
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
            }

            
        }

        private void CoAuthorTextBoxName4_TextChanged(object sender, EventArgs e)
        {

        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

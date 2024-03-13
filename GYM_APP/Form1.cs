using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GYM.Model;
using Microsoft.EntityFrameworkCore;


namespace GYM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool permission = false;
        private Context? dbContext;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new Context();

            this.dbContext.Database.EnsureCreated();

            this.userBindingSource.DataSource = dbContext.Users.Local.ToBindingList();

            this.dbContext.Users.Load();

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void LoadData()
        {
            using (var context = new Context())
            {
                dataGridViewUsers.DataSource = context.Users.ToList();
            }
        }

        public string ShortName(string name)
        {
            string[] names = name.Split(' ');
            string shortName = names[0];
            return shortName;
        }
        private void CleanTextsAdd()
        {
            Txt_AddName.Text = string.Empty;
            Txt_AddBirth.Text = string.Empty;
            Cmb_AddGender.SelectedIndex = 0;
            Txt_AddEmail.Text = string.Empty;
            Txt_AddPhone.Text = string.Empty;
        }

        private void CleanAndCancelTextsEdit()
        {

            Txt_EditName.Text = string.Empty;
            Txt_EditBirth.Text = string.Empty;
            Cmb_EditGender.SelectedIndex = 0;
            Txt_EditEmail.Text = string.Empty;
            Txt_EditPhoneNumber.Text = string.Empty;
            Txt_EditSearchId.Text = string.Empty;

            Txt_EditName.ReadOnly = true;
            Txt_EditBirth.ReadOnly = true;
            Txt_EditEmail.ReadOnly = true;
            Txt_EditPhoneNumber.ReadOnly = true;
        }

        private void AllowEdit()
        {
            Txt_EditName.ReadOnly = false;
            Txt_EditBirth.ReadOnly = false;
            Txt_EditEmail.ReadOnly = false;
            Txt_EditPhoneNumber.ReadOnly = false;
        }

        private void Btn_AddMember_Click(object sender, EventArgs e)
        {
            bool birthDate = Txt_AddBirth.Text.Trim().Replace("/", "").Length == 8;
            bool email = Txt_AddEmail.Text.Contains("@") && Txt_AddEmail.Text.ToLower().Contains(".com");

            if (!string.IsNullOrEmpty(Txt_AddName.Text) &&
                birthDate &&
                !string.IsNullOrEmpty(Cmb_AddGender.Text) &&
                !string.IsNullOrEmpty(Txt_AddEmail.Text) &&
                email
                )
            {
                User person = new User
                {
                    Name = Txt_AddName.Text.ToUpper(),
                    BirthDate = Txt_AddBirth.Text,
                    Gender = Cmb_AddGender.Text,
                    PhoneNumber = Txt_AddPhone.Text,
                    Email = Txt_AddEmail.Text.ToUpper(),
                    Username = Txt_AddEmail.Text.Substring(0, Txt_AddEmail.Text.IndexOf("@")).ToLower(),
                    FirstName = ShortName(Txt_AddName.Text),
                    Password = Txt_AddBirth.Text.Replace("/", "").Substring(0, 4)
                };


                using (var context = new Context())
                {
                    context.Users.Add(person);
                    context.SaveChanges();
                }

                CleanTextsAdd();
                LoadData();
            }
        }

        private void Btn_CancelAdd_Click(object sender, EventArgs e)
        {
            CleanTextsAdd();
        }

        private void Btn_SelectEdit_Click(object sender, EventArgs e)
        {
            int searchId = Convert.ToInt32(Txt_EditSearchId.Text);
            using (var context = new Context())
            {
                var user = context.Users.FirstOrDefault(u => u.Id == searchId);

                if (user != null)
                {
                    AllowEdit();


                    Txt_EditName.Text = user.Name;
                    Txt_EditBirth.Text = user.BirthDate;
                    Cmb_EditGender.Text = user.Gender;
                    Txt_EditPhoneNumber.Text = user.PhoneNumber;
                    Txt_EditEmail.Text = user.Email;

                    permission = true;
                }
                else
                {
                    MessageBox.Show("User not found!");
                }
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (permission)
            {
                int searchId = Convert.ToInt32(Txt_EditSearchId.Text);
                using (var context = new Context())
                {
                    var user = context.Users.First(u => u.Id == searchId);

                    bool birthDate = Txt_EditBirth.Text.Trim().Replace("/", "").Length == 8;
                    bool email = Txt_EditEmail.Text.Contains("@") && Txt_EditEmail.Text.ToLower().Contains(".com");

                    if (!string.IsNullOrEmpty(Txt_EditName.Text) &&
                        birthDate &&
                        !string.IsNullOrEmpty(Cmb_EditGender.Text) &&
                        !string.IsNullOrEmpty(Txt_EditEmail.Text) &&
                        email
                        )
                    {
                        user.Name = Txt_EditName.Text.ToUpper();
                        user.BirthDate = Txt_EditBirth.Text;
                        user.Gender = Cmb_EditGender.Text;
                        user.PhoneNumber = Txt_EditPhoneNumber.Text;
                        user.Email = Txt_EditEmail.Text.ToUpper();
                        user.Username = Txt_EditEmail.Text.Substring(0, Txt_EditEmail.Text.IndexOf("@")).ToLower();
                        user.FirstName = ShortName(Txt_EditName.Text);
                        user.Password = Txt_EditBirth.Text.Replace("/", "").Substring(0, 4);

                        context.SaveChanges();

                    }

                    CleanAndCancelTextsEdit();
                    LoadData();

                    permission = false;
                }
            }
            ;
        }

        private void Btn_EditCancel_Click(object sender, EventArgs e)
        {
            CleanAndCancelTextsEdit();
        }

        private void Btn_DeleteConfirm_Click(object sender, EventArgs e)
        {
            if (permission)
            {
                int searchId = Convert.ToInt32(Txt_EditSearchId.Text);
                using (var context = new Context())
                {
                    var user = context.Users.FirstOrDefault(u => u.Id == searchId);

                    context.Users.Remove(user);

                    context.SaveChanges();

                    permission = false;

                    CleanAndCancelTextsEdit();

                    LoadData();
                }
            }
        }

        private void Txt_EditSearchId_KeyUp(object sender, KeyEventArgs e)
        {
            if (Txt_EditSearchId.Text.Length > 0)
            {
                char lastChar = Txt_EditSearchId.Text[Txt_EditSearchId.Text.Length - 1];

                if (!char.IsDigit(lastChar))
                {
                    Txt_EditSearchId.Text = Txt_EditSearchId.Text.Remove(Txt_EditSearchId.Text.Length - 1);
                    Txt_EditSearchId.SelectionStart = Txt_EditSearchId.Text.Length;
                }
            }
        }

        private void Btn_LoginEnter_Click(object sender, EventArgs e)
        {
            string username = Txt_LoginUser.Text.ToLower();
            string password = Txt_LoginPassword.Text;


            using (var context = new Context())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

                if (user != null)
                {
                    MessageBox.Show("Welcome to the GYM " + user.Name);
                }
                else
                {
                    MessageBox.Show("Username or Password incorrect!");
                }
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            string name = Txt_NameSearch.Text.ToUpper();

            using (var context = new Context())
            {
                var users = context.Users.Where(u => u.Name.Contains(name)).ToList();
                dataGridViewUsers.DataSource = users;
            }
        }

        private void Btn_CancelSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Btn_LoginCancel_Click(object sender, EventArgs e)
        {
            Txt_LoginUser.Text = null;
            Txt_LoginPassword.Text = null;
        }
    }
}

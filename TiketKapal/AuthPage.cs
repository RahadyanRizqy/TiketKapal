using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiketKapal
{
    public partial class AuthPage : Form
    {
        public int user_id;
        public int b;
        public AuthPage()
        {
            InitializeComponent();
            UPassText.PasswordChar = '*';

        }
        private void CallMainPage(int user_id)
        {
            MainPage mp = new MainPage(user_id);
            mp.Show();
            this.Hide();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            Database uname = new Database($"SELECT COUNT(user_name) FROM user WHERE user_name = '{UNameText.Text}';");
            Database upass = new Database($"SELECT COUNT(user_password) FROM user WHERE user_password = '{UPassText.Text}';");
            uname.FetchValue();
            upass.FetchValue();
            if (!(string.IsNullOrEmpty(UNameText.Text) || UNameText.Text == "") && !(string.IsNullOrEmpty(UPassText.Text) || UPassText.Text == ""))
            {
                if (uname.value == "1" && upass.value == "1")
                {
                    Database userid = new Database($"SELECT user_id FROM user WHERE user_name = '{UNameText.Text}' and user_password = '{UPassText.Text}';");
                    userid.FetchValue();
                    user_id = Convert.ToInt32(userid.value);
                    CallMainPage(user_id);
                }
                else
                {
                    MessageBox.Show("Username atau Password salah");
                }
            }
            else
            {
                MessageBox.Show("Isi dengan benar");
            }

        }
        private void Register_Click(object sender, EventArgs e)
        {
            Database uname = new Database($"SELECT COUNT(user_name) FROM user WHERE user_name = '{UNameText.Text}';");
            Database upass = new Database($"SELECT COUNT(user_password) FROM user WHERE user_password = '{UPassText.Text}';");
            uname.FetchValue();
            upass.FetchValue();
            try
            {
                if (!(string.IsNullOrEmpty(UNameText.Text) || UNameText.Text == "") && !(string.IsNullOrEmpty(UPassText.Text) || UPassText.Text == "")) {
                    Database db = new Database($"INSERT INTO user (user_name, user_password) VALUES ('{UNameText.Text}', '{UPassText.Text}');");
                    db.ExecNonQuery();
                    MessageBox.Show("Berhasil Register");
                    CallMainPage(user_id);
                }
                else
                {
                    MessageBox.Show("Isi dengan benar");
                }

            }
            catch (Exception)       
            {
                MessageBox.Show("Username atau Password sudah ada");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Salameh
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

        }

        private void flatLabel2_Click(object sender, EventArgs e)
        {

        }

        private void flatTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            string sql = "Data Source = Data.db";
            SQLiteConnection conn = new SQLiteConnection(sql);
            conn.Open();
            string query = "SELECT count(*) FROM Login WHERE Login_user = '" + textBox1.Text + "' AND Login_pass = '" + textBox2.Text + "' ";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            int result = Convert.ToInt16(cmd.ExecuteScalar());
            if (result > 0)
            {

                this.Hide();
                main main = new main();
                main.Show();
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("أسم المستخدم أو كلمة المرور خطأ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formSkin1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Data.SQLite;

namespace Salameh
{
    public partial class insert : MetroFramework.Forms.MetroForm
    {
        public insert()
        {
            InitializeComponent();
        }

        private void insert_Load(object sender, EventArgs e)
        {

        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            main ma = new main();
            ma.Show();
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" | textBox1.Text == " " | textBox1.Text == "  " | textBox1.Text == "   ")
            {
              MessageBox.Show("يرجى ادخال البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else
            {
                string sql = " data source = Data.db";
                SQLiteConnection conn = new SQLiteConnection(sql);
                conn.Open();
                string query = "insert into Pharm (Pharm_name,Pharm_ghram,Pharm_price,Pharm_quan,Pharm_pro,Pharm_exp,Pharm_company) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + Convert.ToInt64(textBox3.Text) + "','" + Convert.ToInt64(textBox4.Text) + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("تم الادخال", "معلومات الادخال", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void UserNumbersOnly(KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':case '1':case '2':case '3':case '4':case '5':case '6':case '7':case '8': case '9':case'.':case (char)Keys.Back: case (char)Keys.Enter:
                    e.Handled = false;
                    break;
                default :
                    MessageBox.Show("أدخل أرقاما فقط", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = true;
                    break;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            UserNumbersOnly(e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            UserNumbersOnly(e);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            UserNumbersOnly(e);
        }
    }
}

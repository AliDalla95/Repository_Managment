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
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {

        public Form3()
        {
            InitializeComponent();
            DataTable dd = new DataTable();

            DataTable dt = new DataTable();
            string sql = "data source = Data.db";
            SQLiteConnection conn = new SQLiteConnection(sql);
            string query = "select Members_name from Members";
            SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
            da.Fill(dt);
            AutoCompleteStringCollection datasearch = new AutoCompleteStringCollection();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                datasearch.Add(dt.Rows[i][0].ToString());
            }
            this.textBox6.AutoCompleteCustomSource = datasearch;
            this.textBox6.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.textBox6.AutoCompleteMode = AutoCompleteMode.Append;


            conn.Open();
            string query1 = "select Members_id as 'Id', Members_name as'الأسم', Members_add as'العنوان', Members_tel as'الهاتف', Members_name_pharm as'أسم الصيدلية', Members_num as'رقم فاتورته' from Members";
            SQLiteDataAdapter da1 = new SQLiteDataAdapter(query1, conn);
            da1.Fill(dd);
            dataGridView1.DataSource = dd;
            conn.Close();



        }


        private void Form3_Load(object sender, EventArgs e)
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
            string sql = "data source = Data.db";
            SQLiteConnection conn = new SQLiteConnection(sql);
            if (textBox1.Text == "" | textBox1.Text == " " | textBox1.Text == "  " | textBox1.Text == "   ")
            {
                MessageBox.Show("يرجى ادخال البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else
            {

                conn.Open();
                string query = " insert into Members (Members_name,Members_add,Members_tel,Members_name_pharm,Members_num) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "') ";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("تمت الاضافة", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();

            }

            DataTable dd = new DataTable();
            conn.Open();
            string query1 = "select Members_id as 'Id', Members_name as'الأسم', Members_add as'العنوان', Members_tel as'الهاتف', Members_name_pharm as'أسم الصيدلية', Members_num as'رقم فاتورته' from Members";
            SQLiteDataAdapter da1 = new SQLiteDataAdapter(query1, conn);
            da1.Fill(dd);
            dataGridView1.DataSource = dd;
            conn.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        private void flatButton4_Click(object sender, EventArgs e)
        {
            string sql = "data source = Data.db";
            SQLiteConnection conn = new SQLiteConnection(sql);
            DataTable dd = new DataTable();
            conn.Open();
            string query1 = "select Members_id as 'Id', Members_name as'الأسم', Members_add as'العنوان', Members_tel as'الهاتف', Members_name_pharm as'أسم الصيدلية', Members_num as'رقم فاتورته' from Members";
            SQLiteDataAdapter da1 = new SQLiteDataAdapter(query1, conn);
            da1.Fill(dd);
            dataGridView1.DataSource = dd;
            conn.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            AutoCompleteStringCollection datasearch = new AutoCompleteStringCollection();
            textBox6.AutoCompleteCustomSource = datasearch;
            textBox6.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox6.AutoCompleteMode = AutoCompleteMode.Append;

            DataTable dd = new DataTable();
            dd.Clear();
            string sql = "data source = Data.db";
            SQLiteConnection conn = new SQLiteConnection(sql);
            conn.Open();
            string query1 = "select Members_id as 'Id', Members_name as'الأسم', Members_add as'العنوان', Members_tel as'الهاتف', Members_name_pharm as'أسم الصيدلية', Members_num as'رقم فاتورته' from Members where Members_name like '%" + textBox6.Text + "%' ";
            SQLiteDataAdapter da1 = new SQLiteDataAdapter(query1, conn);
            da1.Fill(dd);
            dataGridView1.DataSource = dd;
            conn.Close();

        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            string sql = " data source = Data.db";
            SQLiteConnection conn = new SQLiteConnection(sql);

            if (textBox1.Text == "" | textBox1.Text == " " | textBox1.Text == "  " | textBox1.Text == "   ")
            {
                MessageBox.Show("يرجى ادخال البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else
            {
                conn.Open();
                string q = "update Members set  Members_name=@Members_name,Members_add=@Members_add,Members_tel=@Members_tel,Members_name_pharm=@Members_name_pharm,Members_num=@Members_num where Members_id = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                SQLiteCommand cmd1 = new SQLiteCommand(q, conn);
                cmd1.Parameters.AddWithValue("@Members_name", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                cmd1.Parameters.AddWithValue("@Members_add", dataGridView1.CurrentRow.Cells[2].Value.ToString());
                cmd1.Parameters.AddWithValue("@Members_tel", dataGridView1.CurrentRow.Cells[3].Value.ToString());
                cmd1.Parameters.AddWithValue("@Members_name_pharm", dataGridView1.CurrentRow.Cells[4].Value.ToString());
                cmd1.Parameters.AddWithValue("@Members_num", dataGridView1.CurrentRow.Cells[5].Value.ToString());
                cmd1.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                string query1 = "Select Members_id as 'ID', Members_name as 'الأسم' , Members_add as 'العنوان',Members_tel as 'الهاتف'  , Members_name_pharm as 'أسم الصيدلية', Members_num as 'رقم فاتورته' from Members ";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query1, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();

                MessageBox.Show("تم التعديل", "معلومات التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



            DataTable dd = new DataTable();
            conn.Open();
            string query3 = "select Members_id as 'Id', Members_name as'الأسم', Members_add as'العنوان', Members_tel as'الهاتف', Members_name_pharm as'أسم الصيدلية', Members_num as'رقم فاتورته' from Members";
            SQLiteDataAdapter da1 = new SQLiteDataAdapter(query3, conn);
            da1.Fill(dd);
            dataGridView1.DataSource = dd;
            conn.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void flatButton5_Click(object sender, EventArgs e)
        {
            string sql = " data source = Data.db";
            SQLiteConnection conn = new SQLiteConnection(sql);

            if (textBox1.Text == "" | textBox1.Text == " " | textBox1.Text == "  " | textBox1.Text == "   ")
            {
                MessageBox.Show("أدخل الأسم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                string query = "delete from Members where Members_id = '" + dataGridView1.CurrentRow.Cells[0].Value + "'";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                textBox1.Clear();
                MessageBox.Show("تم الحذف", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);


                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }

            DataTable dd = new DataTable();
            conn.Open();
            string query1 = "select Members_id as 'Id', Members_name as'الأسم', Members_add as'العنوان', Members_tel as'الهاتف', Members_name_pharm as'أسم الصيدلية', Members_num as'رقم فاتورته' from Members";
            SQLiteDataAdapter da1 = new SQLiteDataAdapter(query1, conn);
            da1.Fill(dd);
            dataGridView1.DataSource = dd;
            conn.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClassNumbersOnly ccc = new ClassNumbersOnly();
            ccc.UserNumbersOnly(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClassNumbersOnly ccc = new ClassNumbersOnly();
            ccc.UserNumbersOnly(e);
        }
    }
}

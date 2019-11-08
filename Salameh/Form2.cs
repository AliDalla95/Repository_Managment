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
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();

            string sql = "data source = Data.db";
            SQLiteConnection conn = new SQLiteConnection(sql);
            DataTable dd = new DataTable();
            dd.Clear();
            conn.Open();
            string query1 = "select Bills_id as 'معرف الفاتورة', Bills_members_id as'معرف فاتورةالعميل', Bills_members_name as'أسم العميل',Bills_pharm_id as'معرف الدواء',Bills_pharm as'أسم الدواء', Bills_count as'عددالأدوية في الفاتورة', Bills_pharm_quan as'كمية الدواء', Bills_pharm_ghram as'عيار الدواء', Bills_pharm_price as'سعر الدواء', Bills_sum as'مجموع الفاتورة' from Bills";
            SQLiteDataAdapter da1 = new SQLiteDataAdapter(query1, conn);
            da1.Fill(dd);
            dataGridView1.DataSource = dd;
            conn.Close();



            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value);
            }
            this.textBox13.Text = sum.ToString();

        }

        private void Form2_Load(object sender, EventArgs e)
        {



            DataTable dt = new DataTable();
            string sql = "data source = Data.db";
            SQLiteConnection conn = new SQLiteConnection(sql);
            string query = "select Bills_id from Bills";
            SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
            da.Fill(dt);
            AutoCompleteStringCollection datasearch = new AutoCompleteStringCollection();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                datasearch.Add(dt.Rows[i][0].ToString());
            }
            this.textBox10.AutoCompleteCustomSource = datasearch;
            this.textBox10.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.textBox10.AutoCompleteMode = AutoCompleteMode.Append;

      
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            main ma = new main();
            ma.Show();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
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
            string query1 = "select Bills_id as 'معرف الفاتورة', Bills_members_id as'معرف فاتورةالعميل', Bills_members_name as'أسم العميل',Bills_pharm_id as'معرف الدواء',Bills_pharm as'أسم الدواء', Bills_count as'عددالأدوية في الفاتورة', Bills_pharm_quan as'كمية الدواء', Bills_pharm_ghram as'عيار الدواء', Bills_pharm_price as'سعر الدواء', Bills_sum as'مجموع الفاتورة' from Bills where Bills_id = '" + textBox10.Text + "' or Bills_members_name like '%" + textBox10.Text + "%' ";
            SQLiteDataAdapter da1 = new SQLiteDataAdapter(query1, conn);
            da1.Fill(dd);
            dataGridView1.DataSource = dd;
            conn.Close();

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value);
            }
            textBox13.Text = sum.ToString();

        }

        private void flatLabel10_Click(object sender, EventArgs e)
        {

        }

        private void flatButton4_Click(object sender, EventArgs e)
        {
            Print pt = new Print();
            pt.ShowDialog();
        }

        private void flatLabel6_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            string sql = "data source = Data.db";
            SQLiteConnection conn = new SQLiteConnection(sql);
            conn.Open();
            string query = "insert into Bills (Bills_id,Bills_members_id,Bills_members_name,Bills_pharm_id,Bills_pharm,Bills_pharm_quan,Bills_pharm_ghram,Bills_pharm_price,Bills_count) values('" + Convert.ToInt64(textBox1.Text) + "','" + Convert.ToInt64(textBox2.Text) + "','" + textBox3.Text + "','" + Convert.ToInt64(textBox4.Text) + "','" + textBox5.Text + "','" + Convert.ToInt64(textBox6.Text) + "','" + textBox7.Text + "','" + Convert.ToInt64(textBox8.Text) + "','" + Convert.ToInt64(textBox9.Text) + "')";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("تم الأمر", "اضافة فاتورة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();

            DataTable dd = new DataTable();
            dd.Clear();
            conn.Open();
            string query1 = "select Bills_id as 'معرف الفاتورة', Bills_members_id as'معرف فاتورةالعميل', Bills_members_name as'أسم العميل',Bills_pharm_id as'معرف الدواء',Bills_pharm as'أسم الدواء', Bills_count as'عددالأدوية في الفاتورة', Bills_pharm_quan as'كمية الدواء', Bills_pharm_ghram as'عيار الدواء', Bills_pharm_price as'سعر الدواء', Bills_sum as'مجموع الفاتورة' from Bills";
            SQLiteDataAdapter da1 = new SQLiteDataAdapter(query1, conn);
            da1.Fill(dd);
            dataGridView1.DataSource = dd;
            conn.Close();

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value);
            }
            textBox13.Text = sum.ToString();


        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            string sql = "data source = Data.db";
            SQLiteConnection conn = new SQLiteConnection(sql);
            DataTable dd = new DataTable();
            dd.Clear();
            conn.Open();
            string query1 = "select Bills_id as 'معرف الفاتورة', Bills_members_id as'معرف فاتورةالعميل', Bills_members_name as'أسم العميل',Bills_pharm_id as'معرف الدواء',Bills_pharm as'أسم الدواء', Bills_count as'عددالأدوية في الفاتورة', Bills_pharm_quan as'كمية الدواء', Bills_pharm_ghram as'عيار الدواء', Bills_pharm_price as'سعر الدواء', Bills_sum as'مجموع الفاتورة' from Bills";
            SQLiteDataAdapter da1 = new SQLiteDataAdapter(query1, conn);
            da1.Fill(dd);
            dataGridView1.DataSource = dd;
            conn.Close();

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value);
            }
            textBox13.Text = sum.ToString();
        }

        private void flatButton5_Click(object sender, EventArgs e)
        {
            string sql = "data source = Data.db";
            SQLiteConnection conn = new SQLiteConnection(sql);
            DataTable dd = new DataTable();
            dd.Clear();
            conn.Open();
            string query1 = "select Bills_id as 'معرف الفاتورة', Bills_members_id as'معرف فاتورةالعميل', Bills_members_name as'أسم العميل',Bills_pharm_id as'معرف الدواء',Bills_pharm as'أسم الدواء', Bills_count as'عددالأدوية في الفاتورة', Bills_pharm_quan as'كمية الدواء', Bills_pharm_ghram as'عيار الدواء', Bills_pharm_price as'سعر الدواء', Bills_sum as'مجموع الفاتورة' from Bills";
            SQLiteDataAdapter da1 = new SQLiteDataAdapter(query1, conn);
            da1.Fill(dd);
            dataGridView1.DataSource = dd;
            conn.Close();

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value);
            }
            textBox13.Text = sum.ToString();

        }

        private void flatButton6_Click(object sender, EventArgs e)
        {
            string sql = "data source = Data.db";
            SQLiteConnection conn = new SQLiteConnection(sql);
            DataTable dd = new DataTable();
            dd.Clear();
            conn.Open();
            string query1 = "select Bills_id as 'معرف الفاتورة', Bills_members_id as'معرف فاتورةالعميل', Bills_members_name as'أسم العميل',Bills_pharm_id as'معرف الدواء',Bills_pharm as'أسم الدواء', Bills_count as'عددالأدوية في الفاتورة', Bills_pharm_quan as'كمية الدواء', Bills_pharm_ghram as'عيار الدواء', Bills_pharm_price as'سعر الدواء', Bills_sum as'مجموع الفاتورة' from Bills";
            SQLiteDataAdapter da1 = new SQLiteDataAdapter(query1, conn);
            da1.Fill(dd);
            dataGridView1.DataSource = dd;
            conn.Close();

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value);
            }
            textBox13.Text = sum.ToString();
        }
    }
}

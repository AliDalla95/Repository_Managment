﻿using System;
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
    public partial class update : MetroFramework.Forms.MetroForm
    {
        public update()
        {
            InitializeComponent();
            DataTable dd = new DataTable();

            DataTable dt = new DataTable();
            string sql = "data source = Data.db";
            SQLiteConnection conn = new SQLiteConnection(sql);
            string query = "select Pharm_name from Pharm";
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
            string query1 = "Select Pharm_id as 'Id', Pharm_name as 'الأسم',Pharm_ghram as 'عيار الدواء' , Pharm_price as 'السعر',Pharm_quan as 'الكمية'  , Pharm_pro as 'تاريخ الانتاج', Pharm_exp as 'تاريخ الانتهاء' , Pharm_company as 'الشركة المصنعة' from Pharm ";
            SQLiteDataAdapter da1 = new SQLiteDataAdapter(query1, conn);
            da1.Fill(dd);
            dataGridView1.DataSource = dd;
            conn.Close();
        }

        private void update_Load(object sender, EventArgs e)
        {
            string sql = "data source = Data.db";
            SQLiteConnection conn = new SQLiteConnection(sql);
            string query = "Select Pharm_id as 'Id', Pharm_name as 'الأسم',Pharm_ghram as 'عيار الدواء' , Pharm_price as 'السعر',Pharm_quan as 'الكمية'  , Pharm_pro as 'تاريخ الانتاج', Pharm_exp as 'تاريخ الانتهاء' , Pharm_company as 'الشركة المصنعة' from Pharm ";
            SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            main ma = new main();
            ma.Show();
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            DataTable dt3 = new DataTable();
            string sql2 = " data source = Data.db";
            SQLiteConnection conn = new SQLiteConnection(sql2);
            if (dataGridView1.CurrentRow.Cells[1].Value.ToString() == "" | dataGridView1.CurrentRow.Cells[1].Value.ToString() == " " | dataGridView1.CurrentRow.Cells[1].Value.ToString() == "  " | dataGridView1.CurrentRow.Cells[1].Value.ToString() == "   "|textBox1.Text == "" | textBox1.Text == " " | textBox1.Text == "  " | textBox1.Text == "   ")
            {
                MessageBox.Show("يرجى ادخال البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                string query2 = "update Pharm set  Pharm_name=@Pharm_name,Pharm_ghram=@Pharm_ghram,Pharm_price=@Pharm_price,Pharm_quan=@Pharm_quan,Pharm_pro=@Pharm_pro,Pharm_exp=@Pharm_exp,Pharm_company=@Pharm_company where Pharm_id = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                SQLiteCommand cmd2 = new SQLiteCommand(query2, conn);
                cmd2.Parameters.AddWithValue("@Pharm_name", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                cmd2.Parameters.AddWithValue("@Pharm_price", Convert.ToInt64(dataGridView1.CurrentRow.Cells[3].Value.ToString()));
                cmd2.Parameters.AddWithValue("@Pharm_quan", Convert.ToInt64(dataGridView1.CurrentRow.Cells[4].Value.ToString()));
                cmd2.Parameters.AddWithValue("@Pharm_pro", dataGridView1.CurrentRow.Cells[5].Value.ToString());
                cmd2.Parameters.AddWithValue("@Pharm_exp", dataGridView1.CurrentRow.Cells[6].Value.ToString());
                cmd2.Parameters.AddWithValue("@Pharm_company", dataGridView1.CurrentRow.Cells[7].Value.ToString());
                cmd2.Parameters.AddWithValue("@Pharm_ghram", dataGridView1.CurrentRow.Cells[2].Value.ToString());
                cmd2.ExecuteNonQuery();

                string query1 = "Select Pharm_id as 'ID', Pharm_name as 'الأسم',Pharm_ghram as 'عيار الدواء' , Pharm_price as 'السعر',Pharm_quan as 'الكمية'  , Pharm_pro as 'الانتاج', Pharm_exp as 'الانتهاء' , Pharm_company as 'الشركة المصنعة' from Pharm ";
                SQLiteDataAdapter da2 = new SQLiteDataAdapter(query1, conn);
                da2.Fill(dt3);
                dataGridView1.DataSource = dt3;
                conn.Close();

                MessageBox.Show("تم التعديل", "معلومات التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           
        }

        private void flatButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            main ma = new main();
            ma.Show();
        }

        private void dataGridView1_SystemColorsChanged(object sender, EventArgs e)
        {

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
                textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            
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
            string query1 = "select Pharm_id as 'Id', Pharm_name as'الأسم',Pharm_ghram as 'عيار الدواء' , Pharm_price as'السعر', Pharm_quan as'الكمية', Pharm_pro as'تاريخ الانتاج', Pharm_exp as'تاريخ الانتهاء',Pharm_company as 'الشركة المصنعة' from Pharm where Pharm_name like '%" + textBox8.Text + "%' ";
            SQLiteDataAdapter da1 = new SQLiteDataAdapter(query1, conn);
            da1.Fill(dd);
            dataGridView1.DataSource = dd;
            conn.Close();
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" | textBox1.Text == " " | textBox1.Text == "  " | textBox1.Text == "   ")
            {
                MessageBox.Show("أدخل الأسم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sql = " data source = Data.db";
                SQLiteConnection conn = new SQLiteConnection(sql);
                conn.Open();
                string query = "delete from Pharm where Pharm_id = '" + dataGridView1.CurrentRow.Cells[0].Value + "'";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();

                conn.Open();
                string query1 = "Select Pharm_id as 'ID', Pharm_name as 'الأسم',Pharm_ghram as 'عيار الدواء' , Pharm_price as 'السعر',Pharm_quan as 'الكمية'  , Pharm_pro as 'الانتاج', Pharm_exp as 'الانتهاء' , Pharm_company as 'الشركة المصنعة' from Pharm ";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query1, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();

                MessageBox.Show("تم الحذف", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void flatButton4_Click(object sender, EventArgs e)
        {
            string sql = "data source = Data.db";
            SQLiteConnection conn = new SQLiteConnection(sql);
            DataTable dd = new DataTable();
            conn.Open();
            string query1 = "select Pharm_id as 'Id', Pharm_name as'الأسم',Pharm_ghram as 'عيار الدواء' , Pharm_price as'السعر', Pharm_quan as'الكمية', Pharm_pro as'تاريخ الانتاج', Pharm_exp as'تاريخ الانتهاء',Pharm_company as 'الشركة المصنعة' from Pharm";
            SQLiteDataAdapter da1 = new SQLiteDataAdapter(query1, conn);
            da1.Fill(dd);
            dataGridView1.DataSource = dd;
            conn.Close();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClassNumbersOnly classnumbers = new ClassNumbersOnly();
            classnumbers.UserNumbersOnly(e);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClassNumbersOnly classnumbers = new ClassNumbersOnly();
            classnumbers.UserNumbersOnly(e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void flatButton5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[1].Value.ToString() != "" | dataGridView1.CurrentRow.Cells[1].Value.ToString() == " " | dataGridView1.CurrentRow.Cells[1].Value.ToString() == "  ")
            {
                string sql2 = " data source = Data.db";
                SQLiteConnection conn = new SQLiteConnection(sql2);
                conn.Open();
                string query2 = "insert into Pharm (Pharm_name,Pharm_ghram,Pharm_price,Pharm_quan,Pharm_pro,Pharm_exp,Pharm_company) values (@Pharm_name,@Pharm_ghram,@Pharm_price,@Pharm_quan,@Pharm_pro,@Pharm_exp,@Pharm_company)";
                SQLiteCommand cmd2 = new SQLiteCommand(query2, conn);
                cmd2.Parameters.AddWithValue("@Pharm_name", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                cmd2.Parameters.AddWithValue("@Pharm_price", Convert.ToInt64(dataGridView1.CurrentRow.Cells[3].Value.ToString()));
                cmd2.Parameters.AddWithValue("@Pharm_quan", Convert.ToInt64(dataGridView1.CurrentRow.Cells[4].Value.ToString()));
                cmd2.Parameters.AddWithValue("@Pharm_pro", dataGridView1.CurrentRow.Cells[5].Value.ToString());
                cmd2.Parameters.AddWithValue("@Pharm_exp", dataGridView1.CurrentRow.Cells[6].Value.ToString());
                cmd2.Parameters.AddWithValue("@Pharm_company", dataGridView1.CurrentRow.Cells[7].Value.ToString());
                cmd2.Parameters.AddWithValue("@Pharm_ghram", dataGridView1.CurrentRow.Cells[2].Value.ToString());
                cmd2.ExecuteNonQuery();
                conn.Close();
                DataTable dt3 = new DataTable();
                conn.Open();
                string query1 = "Select Pharm_id as 'ID', Pharm_name as 'الأسم',Pharm_ghram as 'عيار الدواء' , Pharm_price as 'السعر',Pharm_quan as 'الكمية'  , Pharm_pro as 'الانتاج', Pharm_exp as 'الانتهاء' , Pharm_company as 'الشركة المصنعة' from Pharm ";
                SQLiteDataAdapter da2 = new SQLiteDataAdapter(query1, conn);
                da2.Fill(dt3);
                dataGridView1.DataSource = dt3;
                conn.Close();

                MessageBox.Show("تمت الاضافة", "معلومات الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("يرجى ادخال الأسم", "معلومات الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            
        }
    }
}

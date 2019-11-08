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
    public partial class del : MetroFramework.Forms.MetroForm
    {
        public del()
        {
            InitializeComponent();
        }

        private void del_Load(object sender, EventArgs e)
        {

        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            main ma = new main();
            ma.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void flatButton1_Click(object sender, EventArgs e)
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
               string query = "delete from Pharm where Pharm_name = '" + textBox1.Text + "'";
               SQLiteCommand cmd = new SQLiteCommand(query, conn);
               cmd.ExecuteNonQuery();
               conn.Close();
               textBox1.Clear();
               MessageBox.Show("تم الحذف", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }

           }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClassNumbersOnly ClassChar = new ClassNumbersOnly();
            ClassChar.UserCharsOnly(e);
        }

    }
}

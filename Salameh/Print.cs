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
    public partial class Print : MetroFramework.Forms.MetroForm
    {
        public Print()
        {
            InitializeComponent();
        }

        private void Print_Load(object sender, EventArgs e)
        {

        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flatTextBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "data source = Data.db";
            SQLiteConnection conn = new SQLiteConnection(sql);
            conn.Open();
            string query = "select Bills_id as 'معرف الفاتورة', Bills_members_id as'معرف فاتورة العميل', Bills_count as'عدد الأدوية في الفاتورة', Bills_sum as'مجموع الفاتورة' from Bills where Bills_id = '" + flatTextBox1.Text + "'";
            SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}

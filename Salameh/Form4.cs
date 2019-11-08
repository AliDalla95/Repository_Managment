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
    public partial class Form4 : MetroFramework.Forms.MetroForm
    {
        public Form4()
        {
            InitializeComponent();

            DataTable dd = new DataTable();
            string sql = "data source = Data.db";
            SQLiteConnection conn = new SQLiteConnection(sql);
            conn.Open();
            string query = "select Pharm_id as 'Id', Pharm_name as'أسم الدواء',Pharm_ghram as 'عيار الدواء',Pharm_price as'السعر',Pharm_quan as'الكمية',Pharm_pro as'تاريخ الانتاج',Pharm_exp as 'تاريخ الانتهاء',Pharm_company as'أسم الشركة'   from Pharm";
            SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
            da.Fill(dd);
            dataGridView1.DataSource = dd;
            conn.Close();

            DataTable ddd = new DataTable();
            conn.Open();
            string query1 = "select Members_id as 'Id', Members_name as'أسم العميل', Members_add as'العنوان', Members_tel as'الهاتف', Members_name_pharm as'أسم الصيدلية', Members_num as'رقم فاتورته' from Members";
            SQLiteDataAdapter da1 = new SQLiteDataAdapter(query1, conn);
            da1.Fill(ddd);
            dataGridView2.DataSource = ddd;
            conn.Close();

            DataTable dddd = new DataTable();
            conn.Open();
            string query2 = "select Bills_id as 'معرف الفاتورة', Bills_members_id as'معرف فاتورة العميل', Bills_count as'عدد الأدوية في الفاتورة', Bills_sum as'مجموع الفاتورة' from Bills";
            SQLiteDataAdapter da2 = new SQLiteDataAdapter(query2, conn);
            da2.Fill(dddd);
            dataGridView3.DataSource = dddd;
            conn.Close();


        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            main ma = new main();
            ma.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

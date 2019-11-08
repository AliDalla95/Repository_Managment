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
    public partial class Form5 : MetroFramework.Forms.MetroForm
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void metroB2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroB1_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection (" Data Source = Data.db ");
            conn.Open();
            if (metroT2.Text == metroT3.Text)
            {
                SQLiteDataAdapter ad = new SQLiteDataAdapter("update Login set Login_pass = '" + metroT3.Text + "' where  Login_user = '" + metroT1.Text + "' ", conn);
                ad.SelectCommand.ExecuteNonQuery();
                MessageBox.Show(" تم  ", "التغييرات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            else
            {
                MessageBox.Show("عدم تطابق كلمة السر يرجى اعادة المحاولة", "خطأ", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            conn.Close();
            metroT1.Clear();
            metroT2.Clear();
            metroT3.Clear();
            
        }

        private void metroT1_Click(object sender, EventArgs e)
        {

        }

        private void metroT2_Click(object sender, EventArgs e)
        {

        }
    }
}

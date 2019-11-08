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
    public partial class main : MetroFramework.Forms.MetroForm
    {
        public main()
        {
            InitializeComponent();

        }

        private void formSkin1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void flatButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            insert ins = new insert();
            ins.Show();
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            del d = new del();
            d.Show();
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            update up = new update();
            up.Show();
        }

        private void flatButton6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login log = new Login();
            log.Show();
        }

        private void flatButton5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void اضافةمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void flatContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login log = new Login();
            log.Show();
        }

        private void انشاءنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "Data Source = Data.db";
            SQLiteConnection conn = new SQLiteConnection(sql);
            conn.Open();
            string baack = @"Data source = D:\Data.db ";
            SQLiteConnection bacck = new SQLiteConnection(baack);
            bacck.Open();
            conn.BackupDatabase(bacck, "main", "main", -1, null, 0);
            bacck.Close();
            conn.Close();
            MessageBox.Show("تم الأمر","معلومات",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
            
        }

        private void لوحةالتحكمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
        }

        private void عنالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.ShowDialog();
        }
    }
}

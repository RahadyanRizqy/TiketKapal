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

namespace TiketKapal
{
    public partial class TransactionHistoryPage : Form
    {
        public string ticket_id;
        public int tra_user_id;
        public string destination;
        public string tra_date;
        public string tra_id;
        public TransactionHistoryPage(int tra_user_id)
        {
            InitializeComponent();
            this.tra_user_id = tra_user_id;
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = "Cetak!";
            button.Text = "Pilih";
            button.Width = 75;
            button.UseColumnTextForButtonValue = true;
            this.dgv2.Columns.Add(button);
            Database tra = new Database($"SELECT tra.transaction_id as \"Transaksi ID\", t.ticket_id as \"ID Tiket\", u.user_name as \"Nama\", tra.transaction_date as \"Tgl Transaksi\" FROM \"transaction\" tra JOIN \"ticket\" t ON tra.ticket_id_fk = t.ticket_id JOIN \"user\" u ON tra.user_id_fk = u.user_id and u.user_id = '{tra_user_id}' ORDER BY tra.ticket_id_fk;");
            DataTable dt = new DataTable();
            tra.TableReader(dgv2, dt);
            dgv2.RowHeadersVisible = false;

        }
        private void TransactionHistoryPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainPage mp = new MainPage(tra_user_id);
            mp.Show();
            this.Hide();
        }

        private void TransactionHistoryPage_Load(object sender, EventArgs e)
        {

        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dgv2.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgv2.Rows[selectedrowindex];
            this.tra_id = Convert.ToString(selectedRow.Cells[1].Value);
            this.ticket_id = Convert.ToString(selectedRow.Cells[2].Value);
            this.tra_date = Convert.ToString(selectedRow.Cells[4].Value);
            CallInvoicePage();
        }

        private void ShowTransact_Click(object sender, EventArgs e)
        {

        }
        private void CallInvoicePage()
        {
            Database user_name = new Database($"SELECT user_name FROM user WHERE user_id = {tra_user_id};");
            Database dest = new Database($"SELECT d1.destination_port ||', '|| d1.destination_city ||' - '|| d2.destination_port ||', '|| d2.destination_city FROM \"transaction\" tra JOIN ticket t ON tra.ticket_id_fk = t.ticket_id LEFT JOIN destination d1 ON d1.destination_id = t.depart_from LEFT JOIN destination d2 ON d2.destination_id = t.arrive_at WHERE tra.ticket_id_fk = '{ticket_id}';");
            Database price = new Database($"SELECT t.price FROM \"transaction\" tra JOIN ticket t ON tra.ticket_id_fk = t.ticket_id LEFT JOIN destination d1 ON d1.destination_id = t.depart_from LEFT JOIN destination d2 ON d2.destination_id = t.arrive_at WHERE tra.ticket_id_fk = '{ticket_id}';");
            price.FetchValue();
            user_name.FetchValue();
            dest.openConn();
            SQLiteCommand cmd = new SQLiteCommand(dest.query, dest.conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                this.destination = reader.GetString(0);
            }
            InvoicePage ip = new InvoicePage(tra_id, tra_date, user_name.value, Convert.ToInt32(tra_user_id), ticket_id, Convert.ToInt32(price.value), destination);
            ip.Show();
            this.Hide();
        }
    }
}

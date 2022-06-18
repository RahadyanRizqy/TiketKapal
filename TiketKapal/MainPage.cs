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
    public partial class MainPage : Form
    {
        private string date;
        private string depart_from;
        private string arrive_at;
        private int price;
        private int depart_id;
        private int arrive_id;
        private string ticket_id;
        private int ticket_type;
        public int user_id;
        public string destination;
        public string tra_id;
        public string tra_date;
        

        public MainPage(int user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
            Database db = new Database("SELECT destination_city FROM destination;");
            db.openConn();
            SQLiteCommand cmd = new SQLiteCommand(db.query, db.conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            ToComboBox.Items.Add("");
            FromComboBox.Items.Add("");
            while (reader.Read())
            {
                ToComboBox.Items.Add(reader[0]);
                FromComboBox.Items.Add(reader[0]);
            }
            PriceComboBox.Items.Add("");
            int[] price_list = { 50000, 100000, 150000, 200000, 250000, 300000, 350000, 400000, 450000, 500000, 550000, 600000, 650000, 700000, 750000, 800000, 850000, 900000, 1000000};
            foreach (int i in price_list)
            {
                PriceComboBox.Items.Add(i);
            }
            CheckTransact.Text = "Cek Riwayat Transaksi";
            ShowAll.Text = "Cek Semua Tiket";
            Regular.Text = "Reguler";
            Executive.Text = "Eksekutif";
            From.Text = "Dari";
            To.Text = "Ke";
            Price.Text = "Harga";
            Database uname = new Database($"SELECT user_name FROM user WHERE user_id = '{user_id}';");
            uname.FetchValue();
            WelcomeMessage.Text = $"Selamat Datang : {uname.value}";
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = "Pesan!";
            button.Text = "Beli";
            button.Width = 75;
            button.UseColumnTextForButtonValue = true;
            this.dgv1.Columns.Add(button);
            dgv1.RowHeadersVisible = false;
            DateTime datetime = DateTime.Now;
            this.tra_date = datetime.ToString("dd-MM-yyyy");
            this.tra_id = GenTraId(6);            

        }
        
        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dgv1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgv1.Rows[selectedrowindex];
            this.ticket_id = Convert.ToString(selectedRow.Cells[1].Value);
            this.price = Convert.ToInt32(selectedRow.Cells[3].Value);
            bool condition = true;
            if (MessageBox.Show("Beli Sekarang?", $"Tiket Yang Dipilih {ticket_id}", MessageBoxButtons.YesNo, MessageBoxIcon.Question, condition ? MessageBoxDefaultButton.Button2 : MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (MessageBox.Show("Pemesanan Berhasil Cetak Transaksi?", $"Tiket Yang Dipilih {ticket_id}", MessageBoxButtons.YesNo, MessageBoxIcon.Question, condition ? MessageBoxDefaultButton.Button2 : MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    
                    MessageBox.Show("Transaksi Berhasil Dicetak");
                    CallInvoicePage();
                }

                else
                {
                    MessageBox.Show("Transaksi Disimpan Dalam Riwayat");
                    CallTransactPage(user_id);
                }
                Database transact = new Database($"INSERT INTO \"transaction\" (transaction_id, transaction_date, transaction_status, user_id_fk, ticket_id_fk) VALUES ('{tra_id}', '{tra_date}', 1, '{user_id}', '{ticket_id}');");
                transact.openConn();
                transact.ExecNonQuery();
                Database ticket = new Database($"UPDATE ticket SET status = 0 WHERE ticket_id = '{ticket_id}';");
                ticket.openConn();
                ticket.ExecNonQuery();
            }
            else
            {
                MessageBox.Show("Pemesanan Dibatalkan");
            }
        }

        private void FromComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((FromComboBox.SelectedItem.ToString() == "")) 
            {
               depart_id = 0;
            }

            else
            {
                Database db = new Database($"SELECT destination_id FROM destination WHERE destination_city = '{FromComboBox.SelectedItem.ToString()}';");
                db.FetchValue();
                depart_id = Convert.ToInt32(db.value);
            }
        }

        private void ToComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((ToComboBox.SelectedItem.ToString() == ""))
            {
                arrive_id = 0;
            }

            else
            {
                Database db = new Database($"SELECT destination_id FROM destination WHERE destination_city = '{ToComboBox.SelectedItem.ToString()}';");
                db.FetchValue();
                arrive_id = Convert.ToInt32(db.value);
            }
        }

        private void WelcomeMessage_Click(object sender, EventArgs e)
        {
            
        }

        private void PriceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                price = Convert.ToInt32(PriceComboBox.SelectedItem.ToString());
            }
            catch (Exception)
            {
                price = 0;
            }
        }

        private void Executive_CheckedChanged(object sender, EventArgs e)
        {
            if (!(Executive.Checked))
            {
                ticket_type = 0;
            }
            else
            {
                ticket_type = 2;
            }
        }
        private void Regular_CheckedChanged(object sender, EventArgs e)
        {
            if (!(Regular.Checked))
            {
                ticket_type = 0;
            }
            else
            {
                ticket_type = 1;
            }
        }

        private void CheckTransact_Click(object sender, EventArgs e)
        {
            CallTransactPage(user_id);
        }

        private void TicketFilter_Click(object sender, EventArgs e)
        {
            string query = $"SELECT t.ticket_id as \"ID Tiket\", tkt.ticket_type_name as \"Tipe Tiket\", t.price as \"Harga\", t.depart_schedule as \"Tgl Brgkt\", t.arrival_schedule as \"Tgl Kdtgn\", d1.destination_port ||', '|| d1.destination_city as \"Keberangkatan\", d2.destination_port ||', '|| d2.destination_city as \"Kedatangan\", t.expire_date as \"Kadaluarsa\" FROM ticket t LEFT JOIN destination d1 ON t.depart_from = d1.destination_id LEFT JOIN destination d2 ON t.arrive_at = d2.destination_id JOIN ticket_type tkt ON t.ticket_type_id_fk = tkt.ticket_type_id WHERE t.status = 1 and (t.ticket_type_id_fk = {ticket_type} or t.depart_from = {depart_id} or t.arrive_at = {arrive_id} or t.price = {price});";
            Database ticket = new Database(query);
            ticket.openConn();
            DataTable dt = new DataTable();
            ticket.TableReader(dgv1, dt);

        }
        private void ShowAll_Click(object sender, EventArgs e)
        {
            string query = "SELECT t.ticket_id as \"ID Tiket\", tkt.ticket_type_name as \"Tipe Tiket\", t.price as \"Harga\", t.depart_schedule as \"Tgl Brgkt\", t.arrival_schedule as \"Tgl Kdtgn\", d1.destination_port ||', '|| d1.destination_city as \"Keberangkatan\", d2.destination_port ||', '|| d2.destination_city as \"Kedatangan\", t.expire_date as \"Kadaluarsa\" FROM ticket t LEFT JOIN destination d1 ON t.depart_from = d1.destination_id LEFT JOIN destination d2 ON t.arrive_at = d2.destination_id JOIN ticket_type tkt ON t.ticket_type_id_fk = tkt.ticket_type_id WHERE t.status = 1;";
            Database ticket = new Database(query);
            ticket.openConn();
            DataTable dt = new DataTable();
            ticket.TableReader(dgv1, dt);
        }
        private void MakeInvoice()
        {
            
        }
        private void CallTransactPage(int tra_user_id)
        {
            TransactionHistoryPage thp = new TransactionHistoryPage(tra_user_id);
            thp.Show();
            this.Hide();
        }
        private void CallInvoicePage()
        {
            Database b = new Database($"SELECT user_name FROM user WHERE user_id = {user_id};");
            Database c = new Database($"SELECT d1.destination_port ||', '|| d1.destination_city ||' - '|| d2.destination_port ||', '|| d2.destination_city FROM ticket t LEFT JOIN destination d1 ON d1.destination_id = t.depart_from LEFT JOIN destination d2 ON d2.destination_id = t.arrive_at WHERE t.ticket_id = '{ticket_id}';");
            b.FetchValue();
            c.openConn();
            SQLiteCommand cmd = new SQLiteCommand(c.query, c.conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                this.destination = reader.GetString(0);
            }
            InvoicePage ip = new InvoicePage(tra_id, tra_date, b.value, Convert.ToInt32(user_id), ticket_id, price, destination);
            ip.Show();
            this.Hide();
        }
        private string GenTraId(int length)
        {
            string valid = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
    }
}
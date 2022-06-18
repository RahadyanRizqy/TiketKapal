using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiketKapal
{
    public partial class InvoicePage : Form
    {
        public string transaction_id;
        public string transaction_date;
        public string user_name;
        public int user_id;
        public string ticket_id;
        public int price;
        public string destination;
        public InvoicePage(string transaction_id, string transaction_date, string user_name, int user_id, string ticket_id, int price, string destination)
        {
            InitializeComponent();
            this.user_id = user_id;
            TransactionInvoice.Text += "-------------------------------------\n";
            TransactionInvoice.Text += "\n";
            TransactionInvoice.Text += "--             INVOICE             --\n";
            TransactionInvoice.Text += "\n";
            TransactionInvoice.Text += "-------------------------------------\n";
            TransactionInvoice.Text += "\n";
            TransactionInvoice.Text += $"No Transaksi : {transaction_id} \n";
            TransactionInvoice.Text += $"Tanggal      : {transaction_date} \n";
            TransactionInvoice.Text += $"Nama         : {user_name} \n";
            TransactionInvoice.Text += $"ID User      : {user_id.ToString()} \n";
            TransactionInvoice.Text += $"ID Tiket     : {ticket_id} \n";
            TransactionInvoice.Text += $"Harga Tiket  : {price} \n";
            TransactionInvoice.Text += $"Dari - Ke    : {destination} \n";
            TransactionInvoice.Text += "\n";
            TransactionInvoice.Text += "\n";
            TransactionInvoice.Text += "-------------------------------------\n";
            TransactionInvoice.Font = new Font("Courier New", 12, FontStyle.Bold);        
        }

        private void TransactionInvoice_TextChanged(object sender, EventArgs e)
        {
        }

        private void InvoicePage_Load(object sender, EventArgs e)
        {

        }

        private void InvoicePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainPage mp = new MainPage(user_id);
            mp.Show();
            this.Hide();
        }
    }
}

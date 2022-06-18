namespace TiketKapal
{
    partial class InvoicePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TransactionInvoice = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TransactionInvoice
            // 
            this.TransactionInvoice.Location = new System.Drawing.Point(12, 12);
            this.TransactionInvoice.Name = "TransactionInvoice";
            this.TransactionInvoice.Size = new System.Drawing.Size(483, 410);
            this.TransactionInvoice.TabIndex = 0;
            this.TransactionInvoice.Text = "";
            this.TransactionInvoice.TextChanged += new System.EventHandler(this.TransactionInvoice_TextChanged);
            // 
            // InvoicePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 434);
            this.Controls.Add(this.TransactionInvoice);
            this.Name = "InvoicePage";
            this.Text = "InvoicePage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InvoicePage_FormClosing);
            this.Load += new System.EventHandler(this.InvoicePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox TransactionInvoice;
    }
}
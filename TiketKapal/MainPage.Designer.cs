namespace TiketKapal
{
    partial class MainPage
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.CheckTransact = new System.Windows.Forms.Button();
            this.FromComboBox = new System.Windows.Forms.ComboBox();
            this.From = new System.Windows.Forms.Label();
            this.To = new System.Windows.Forms.Label();
            this.ToComboBox = new System.Windows.Forms.ComboBox();
            this.ShowAll = new System.Windows.Forms.Button();
            this.Regular = new System.Windows.Forms.RadioButton();
            this.Executive = new System.Windows.Forms.RadioButton();
            this.PriceComboBox = new System.Windows.Forms.ComboBox();
            this.Price = new System.Windows.Forms.Label();
            this.TicketFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 193);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 29;
            this.dgv1.Size = new System.Drawing.Size(776, 245);
            this.dgv1.TabIndex = 1;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WelcomeMessage.Location = new System.Drawing.Point(12, 9);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(169, 28);
            this.WelcomeMessage.TabIndex = 2;
            this.WelcomeMessage.Text = "WelcomeMessage";
            this.WelcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WelcomeMessage.Click += new System.EventHandler(this.WelcomeMessage_Click);
            // 
            // CheckTransact
            // 
            this.CheckTransact.Location = new System.Drawing.Point(604, 152);
            this.CheckTransact.Name = "CheckTransact";
            this.CheckTransact.Size = new System.Drawing.Size(184, 29);
            this.CheckTransact.TabIndex = 3;
            this.CheckTransact.Text = "CheckTransactButton>>>";
            this.CheckTransact.UseVisualStyleBackColor = true;
            this.CheckTransact.Click += new System.EventHandler(this.CheckTransact_Click);
            // 
            // FromComboBox
            // 
            this.FromComboBox.FormattingEnabled = true;
            this.FromComboBox.Location = new System.Drawing.Point(12, 98);
            this.FromComboBox.Name = "FromComboBox";
            this.FromComboBox.Size = new System.Drawing.Size(150, 28);
            this.FromComboBox.TabIndex = 4;
            this.FromComboBox.SelectedIndexChanged += new System.EventHandler(this.FromComboBox_SelectedIndexChanged);
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Location = new System.Drawing.Point(12, 75);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(43, 20);
            this.From.TabIndex = 5;
            this.From.Text = "From";
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.Location = new System.Drawing.Point(12, 129);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(25, 20);
            this.To.TabIndex = 6;
            this.To.Text = "To";
            // 
            // ToComboBox
            // 
            this.ToComboBox.FormattingEnabled = true;
            this.ToComboBox.Location = new System.Drawing.Point(12, 152);
            this.ToComboBox.Name = "ToComboBox";
            this.ToComboBox.Size = new System.Drawing.Size(151, 28);
            this.ToComboBox.TabIndex = 7;
            this.ToComboBox.SelectedIndexChanged += new System.EventHandler(this.ToComboBox_SelectedIndexChanged);
            // 
            // ShowAll
            // 
            this.ShowAll.Location = new System.Drawing.Point(604, 117);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(184, 29);
            this.ShowAll.TabIndex = 8;
            this.ShowAll.Text = "Show All Tickets";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // Regular
            // 
            this.Regular.AutoSize = true;
            this.Regular.Location = new System.Drawing.Point(188, 98);
            this.Regular.Name = "Regular";
            this.Regular.Size = new System.Drawing.Size(81, 24);
            this.Regular.TabIndex = 9;
            this.Regular.TabStop = true;
            this.Regular.Text = "Regular";
            this.Regular.UseVisualStyleBackColor = true;
            this.Regular.CheckedChanged += new System.EventHandler(this.Regular_CheckedChanged);
            // 
            // Executive
            // 
            this.Executive.AutoSize = true;
            this.Executive.Location = new System.Drawing.Point(272, 98);
            this.Executive.Name = "Executive";
            this.Executive.Size = new System.Drawing.Size(92, 24);
            this.Executive.TabIndex = 10;
            this.Executive.TabStop = true;
            this.Executive.Text = "Executive";
            this.Executive.UseVisualStyleBackColor = true;
            this.Executive.CheckedChanged += new System.EventHandler(this.Executive_CheckedChanged);
            // 
            // PriceComboBox
            // 
            this.PriceComboBox.FormattingEnabled = true;
            this.PriceComboBox.Location = new System.Drawing.Point(188, 152);
            this.PriceComboBox.Name = "PriceComboBox";
            this.PriceComboBox.Size = new System.Drawing.Size(151, 28);
            this.PriceComboBox.TabIndex = 11;
            this.PriceComboBox.SelectedIndexChanged += new System.EventHandler(this.PriceComboBox_SelectedIndexChanged);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(188, 129);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(41, 20);
            this.Price.TabIndex = 12;
            this.Price.Text = "Price";
            // 
            // TicketFilter
            // 
            this.TicketFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TicketFilter.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TicketFilter.Location = new System.Drawing.Point(401, 117);
            this.TicketFilter.Name = "TicketFilter";
            this.TicketFilter.Size = new System.Drawing.Size(163, 63);
            this.TicketFilter.TabIndex = 13;
            this.TicketFilter.Text = "TicketFilter";
            this.TicketFilter.UseVisualStyleBackColor = true;
            this.TicketFilter.Click += new System.EventHandler(this.TicketFilter_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.TicketFilter);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.PriceComboBox);
            this.Controls.Add(this.Executive);
            this.Controls.Add(this.Regular);
            this.Controls.Add(this.ShowAll);
            this.Controls.Add(this.ToComboBox);
            this.Controls.Add(this.To);
            this.Controls.Add(this.From);
            this.Controls.Add(this.FromComboBox);
            this.Controls.Add(this.CheckTransact);
            this.Controls.Add(this.WelcomeMessage);
            this.Controls.Add(this.dgv1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainPage";
            this.Text = "PT. Jaya Lelana Samudra";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dgv1;
        private Label WelcomeMessage;
        private Button CheckTransact;
        private ComboBox FromComboBox;
        private Label From;
        private Label To;
        private ComboBox ToComboBox;
        private Button ShowAll;
        private RadioButton Regular;
        private RadioButton Executive;
        private ComboBox PriceComboBox;
        private Label Price;
        private Button TicketFilter;
    }
}
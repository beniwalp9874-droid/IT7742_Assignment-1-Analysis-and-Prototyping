namespace BankSprint1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox comboBox1;
        private TextBox txtAmount;
        private Button btnDeposit;
        private Button btnWithdraw;
        private Button btnInterest;
        private ListBox listBox1;
        private Label labelInfo;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel headerPanel;

        private Label lblAccount;
        private Label lblAmount;
        private Label lblHistory;

        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.BackColor = System.Drawing.Color.FromArgb(34, 40, 49);
            this.ClientSize = new System.Drawing.Size(420, 500);
            this.Text = "SmartBank App";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // HEADER PANEL
            headerPanel = new Panel();
            headerPanel.BackColor = System.Drawing.Color.FromArgb(0, 173, 181);
            headerPanel.Location = new System.Drawing.Point(0, 0);
            headerPanel.Size = new System.Drawing.Size(420, 70);

            lblTitle = new Label();
            lblTitle.Text = "SmartBank";
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(20, 10);
            lblTitle.AutoSize = true;

            lblSubtitle = new Label();
            lblSubtitle.Text = "Modern Banking System";
            lblSubtitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9);
            lblSubtitle.Location = new System.Drawing.Point(22, 40);
            lblSubtitle.AutoSize = true;

            headerPanel.Controls.Add(lblTitle);
            headerPanel.Controls.Add(lblSubtitle);

            // LABEL SELECT ACCOUNT
            lblAccount = new Label();
            lblAccount.Text = "Select Account";
            lblAccount.ForeColor = System.Drawing.Color.White;
            lblAccount.Location = new System.Drawing.Point(30, 90);
            lblAccount.AutoSize = true;

            // COMBOBOX
            comboBox1 = new ComboBox();
            comboBox1.Location = new System.Drawing.Point(30, 110);
            comboBox1.Size = new System.Drawing.Size(340, 25);
            comboBox1.FlatStyle = FlatStyle.Flat;

            comboBox1.Items.AddRange(new object[]
            {
                "Everyday Account",
                "Investment Account",
                "Omni Account"
            });

            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            // LABEL AMOUNT
            lblAmount = new Label();
            lblAmount.Text = "Enter Amount";
            lblAmount.ForeColor = System.Drawing.Color.White;
            lblAmount.Location = new System.Drawing.Point(30, 150);
            lblAmount.AutoSize = true;

            // TEXTBOX
            txtAmount = new TextBox();
            txtAmount.Location = new System.Drawing.Point(30, 170);
            txtAmount.Size = new System.Drawing.Size(340, 25);
            txtAmount.Font = new System.Drawing.Font("Segoe UI", 10);

            // BUTTON DEPOSIT
            btnDeposit = new Button();
            btnDeposit.Text = "Deposit";
            btnDeposit.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            btnDeposit.ForeColor = System.Drawing.Color.White;
            btnDeposit.FlatStyle = FlatStyle.Flat;
            btnDeposit.Location = new System.Drawing.Point(30, 220);
            btnDeposit.Size = new System.Drawing.Size(100, 40);
            btnDeposit.Click += btnDeposit_Click;

            // BUTTON WITHDRAW
            btnWithdraw = new Button();
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.BackColor = System.Drawing.Color.FromArgb(244, 67, 54);
            btnWithdraw.ForeColor = System.Drawing.Color.White;
            btnWithdraw.FlatStyle = FlatStyle.Flat;
            btnWithdraw.Location = new System.Drawing.Point(150, 220);
            btnWithdraw.Size = new System.Drawing.Size(100, 40);
            btnWithdraw.Click += btnWithdraw_Click;

            // BUTTON INTEREST
            btnInterest = new Button();
            btnInterest.Text = "Interest";
            btnInterest.BackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            btnInterest.ForeColor = System.Drawing.Color.Black;
            btnInterest.FlatStyle = FlatStyle.Flat;
            btnInterest.Location = new System.Drawing.Point(270, 220);
            btnInterest.Size = new System.Drawing.Size(100, 40);
            btnInterest.Click += btnInterest_Click;

            // LABEL HISTORY
            lblHistory = new Label();
            lblHistory.Text = "Transaction History";
            lblHistory.ForeColor = System.Drawing.Color.White;
            lblHistory.Location = new System.Drawing.Point(30, 280);
            lblHistory.AutoSize = true;

            // LISTBOX HISTORY
            listBox1 = new ListBox();
            listBox1.Location = new System.Drawing.Point(30, 300);
            listBox1.Size = new System.Drawing.Size(340, 100);
            listBox1.Font = new System.Drawing.Font("Consolas", 9);

            // INFO LABEL
            labelInfo = new Label();
            labelInfo.Location = new System.Drawing.Point(30, 410);
            labelInfo.Size = new System.Drawing.Size(340, 40);
            labelInfo.ForeColor = System.Drawing.Color.LightGreen;
            labelInfo.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);

            // ADD CONTROLS
            Controls.Add(headerPanel);
            Controls.Add(lblAccount);
            Controls.Add(comboBox1);
            Controls.Add(lblAmount);
            Controls.Add(txtAmount);
            Controls.Add(btnDeposit);
            Controls.Add(btnWithdraw);
            Controls.Add(btnInterest);
            Controls.Add(lblHistory);
            Controls.Add(listBox1);
            Controls.Add(labelInfo);

            this.ResumeLayout(false);
        }
    }
}
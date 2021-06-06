
namespace Klinik_Mangga_Management_Form
{
    partial class Billing_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BillBox = new System.Windows.Forms.TextBox();
            this.StaffIDBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ClientNameBox = new System.Windows.Forms.TextBox();
            this.ClientIDBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TotalLink = new System.Windows.Forms.LinkLabel();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.MedicinePriceBox = new System.Windows.Forms.TextBox();
            this.TreatmentBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NoteBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TransRadBut = new System.Windows.Forms.RadioButton();
            this.EWalRadBut = new System.Windows.Forms.RadioButton();
            this.CardRadBut = new System.Windows.Forms.RadioButton();
            this.CashRadBut = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PaymentButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.PayBox = new System.Windows.Forms.TextBox();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.MethodLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16F);
            this.label1.Location = new System.Drawing.Point(207, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Billing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(143, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bill No. :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(160, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Staff :";
            // 
            // BillBox
            // 
            this.BillBox.Location = new System.Drawing.Point(212, 60);
            this.BillBox.Name = "BillBox";
            this.BillBox.Size = new System.Drawing.Size(100, 20);
            this.BillBox.TabIndex = 4;
            // 
            // StaffIDBox
            // 
            this.StaffIDBox.FormattingEnabled = true;
            this.StaffIDBox.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.StaffIDBox.Location = new System.Drawing.Point(212, 97);
            this.StaffIDBox.Name = "StaffIDBox";
            this.StaffIDBox.Size = new System.Drawing.Size(100, 21);
            this.StaffIDBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(331, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Client Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(357, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Client ID :";
            // 
            // ClientNameBox
            // 
            this.ClientNameBox.Location = new System.Drawing.Point(434, 59);
            this.ClientNameBox.Name = "ClientNameBox";
            this.ClientNameBox.Size = new System.Drawing.Size(197, 20);
            this.ClientNameBox.TabIndex = 9;
            // 
            // ClientIDBox
            // 
            this.ClientIDBox.Location = new System.Drawing.Point(434, 97);
            this.ClientIDBox.Name = "ClientIDBox";
            this.ClientIDBox.Size = new System.Drawing.Size(197, 20);
            this.ClientIDBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TotalLink);
            this.groupBox1.Controls.Add(this.TotalPriceLabel);
            this.groupBox1.Controls.Add(this.MedicinePriceBox);
            this.groupBox1.Controls.Add(this.TreatmentBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(12, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 131);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Treatment and Medicine";
            // 
            // TotalLink
            // 
            this.TotalLink.AutoSize = true;
            this.TotalLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TotalLink.LinkColor = System.Drawing.Color.OrangeRed;
            this.TotalLink.Location = new System.Drawing.Point(49, 92);
            this.TotalLink.Name = "TotalLink";
            this.TotalLink.Size = new System.Drawing.Size(81, 17);
            this.TotalLink.TabIndex = 23;
            this.TotalLink.TabStop = true;
            this.TotalLink.Text = "Total :   RM";
            this.TotalLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TotalLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TotalLink_LinkClicked);
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TotalPriceLabel.Location = new System.Drawing.Point(148, 92);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(115, 17);
            this.TotalPriceLabel.TabIndex = 22;
            this.TotalPriceLabel.Text = "[Insert total here]";
            this.TotalPriceLabel.Visible = false;
            // 
            // MedicinePriceBox
            // 
            this.MedicinePriceBox.Location = new System.Drawing.Point(151, 64);
            this.MedicinePriceBox.Name = "MedicinePriceBox";
            this.MedicinePriceBox.Size = new System.Drawing.Size(120, 21);
            this.MedicinePriceBox.TabIndex = 13;
            // 
            // TreatmentBox
            // 
            this.TreatmentBox.FormattingEnabled = true;
            this.TreatmentBox.Items.AddRange(new object[] {
            "Pimple Treatment",
            "Stretch Treatment",
            "Dermabrasion",
            "Chemical Peel"});
            this.TreatmentBox.Location = new System.Drawing.Point(103, 26);
            this.TreatmentBox.Name = "TreatmentBox";
            this.TreatmentBox.Size = new System.Drawing.Size(168, 23);
            this.TreatmentBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(25, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Medicine :   RM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(16, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Treatment :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.Location = new System.Drawing.Point(380, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Note :";
            // 
            // NoteBox
            // 
            this.NoteBox.Location = new System.Drawing.Point(434, 187);
            this.NoteBox.Multiline = true;
            this.NoteBox.Name = "NoteBox";
            this.NoteBox.Size = new System.Drawing.Size(197, 84);
            this.NoteBox.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TransRadBut);
            this.groupBox2.Controls.Add(this.EWalRadBut);
            this.groupBox2.Controls.Add(this.CardRadBut);
            this.groupBox2.Controls.Add(this.CashRadBut);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox2.Location = new System.Drawing.Point(12, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 100);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type of Payment :";
            // 
            // TransRadBut
            // 
            this.TransRadBut.AutoSize = true;
            this.TransRadBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TransRadBut.Location = new System.Drawing.Point(151, 61);
            this.TransRadBut.Name = "TransRadBut";
            this.TransRadBut.Size = new System.Drawing.Size(116, 21);
            this.TransRadBut.TabIndex = 19;
            this.TransRadBut.TabStop = true;
            this.TransRadBut.Text = "Bank Transfer";
            this.TransRadBut.UseVisualStyleBackColor = true;
            // 
            // EWalRadBut
            // 
            this.EWalRadBut.AutoSize = true;
            this.EWalRadBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EWalRadBut.Location = new System.Drawing.Point(19, 61);
            this.EWalRadBut.Name = "EWalRadBut";
            this.EWalRadBut.Size = new System.Drawing.Size(79, 21);
            this.EWalRadBut.TabIndex = 18;
            this.EWalRadBut.TabStop = true;
            this.EWalRadBut.Text = "E-Wallet";
            this.EWalRadBut.UseVisualStyleBackColor = true;
            // 
            // CardRadBut
            // 
            this.CardRadBut.AutoSize = true;
            this.CardRadBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CardRadBut.Location = new System.Drawing.Point(151, 25);
            this.CardRadBut.Name = "CardRadBut";
            this.CardRadBut.Size = new System.Drawing.Size(56, 21);
            this.CardRadBut.TabIndex = 15;
            this.CardRadBut.TabStop = true;
            this.CardRadBut.Text = "Card";
            this.CardRadBut.UseVisualStyleBackColor = true;
            // 
            // CashRadBut
            // 
            this.CashRadBut.AutoSize = true;
            this.CashRadBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CashRadBut.Location = new System.Drawing.Point(19, 25);
            this.CashRadBut.Name = "CashRadBut";
            this.CashRadBut.Size = new System.Drawing.Size(58, 21);
            this.CashRadBut.TabIndex = 14;
            this.CashRadBut.TabStop = true;
            this.CashRadBut.Text = "Cash";
            this.CashRadBut.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(384, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Paid :  RM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(361, 358);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Balance :  RM";
            // 
            // PaymentButton
            // 
            this.PaymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PaymentButton.Location = new System.Drawing.Point(383, 404);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(85, 37);
            this.PaymentButton.TabIndex = 19;
            this.PaymentButton.Text = "&Pay";
            this.PaymentButton.UseVisualStyleBackColor = true;
            this.PaymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PrintButton.Location = new System.Drawing.Point(510, 404);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(85, 37);
            this.PrintButton.TabIndex = 20;
            this.PrintButton.Text = "Prin&t";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // PayBox
            // 
            this.PayBox.Location = new System.Drawing.Point(463, 322);
            this.PayBox.Name = "PayBox";
            this.PayBox.Size = new System.Drawing.Size(120, 20);
            this.PayBox.TabIndex = 17;
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BalanceLabel.Location = new System.Drawing.Point(463, 359);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(138, 17);
            this.BalanceLabel.TabIndex = 21;
            this.BalanceLabel.Text = "[Insert balance here]";
            this.BalanceLabel.Visible = false;
            // 
            // MethodLabel
            // 
            this.MethodLabel.AutoSize = true;
            this.MethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MethodLabel.Location = new System.Drawing.Point(27, 404);
            this.MethodLabel.Name = "MethodLabel";
            this.MethodLabel.Size = new System.Drawing.Size(123, 17);
            this.MethodLabel.TabIndex = 24;
            this.MethodLabel.Text = "[Type of Payment]";
            this.MethodLabel.Visible = false;
            // 
            // Billing_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 463);
            this.Controls.Add(this.MethodLabel);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.PayBox);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.PaymentButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.NoteBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClientIDBox);
            this.Controls.Add(this.ClientNameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StaffIDBox);
            this.Controls.Add(this.BillBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Billing_Form";
            this.Text = "Billing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BillBox;
        private System.Windows.Forms.ComboBox StaffIDBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ClientNameBox;
        private System.Windows.Forms.TextBox ClientIDBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MedicinePriceBox;
        private System.Windows.Forms.ComboBox TreatmentBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NoteBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton TransRadBut;
        private System.Windows.Forms.RadioButton EWalRadBut;
        private System.Windows.Forms.RadioButton CardRadBut;
        private System.Windows.Forms.RadioButton CashRadBut;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button PaymentButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.TextBox PayBox;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.LinkLabel TotalLink;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Label MethodLabel;
    }
}
namespace ROS
{
    partial class Payment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            paymentLabel = new Label();
            orderListBox = new GroupBox();
            dataGridView1 = new DataGridView();
            customerDetailsBox = new GroupBox();
            deliveryCombo = new ComboBox();
            deliveryTypeTextBox = new Label();
            paymentTypeTextBox = new Label();
            paymentCombo = new ComboBox();
            totalBill = new Label();
            label1 = new Label();
            emailTextBox = new TextBox();
            customerEmail = new Label();
            phoneTextBox = new TextBox();
            customerPhone = new Label();
            nameTextBox = new TextBox();
            customerName = new Label();
            confirmButton = new Button();
            updateCurrentOrderButton = new Button();
            orderListBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            customerDetailsBox.SuspendLayout();
            SuspendLayout();
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.Font = new Font("Segoe Script", 48F, FontStyle.Regular, GraphicsUnit.Point);
            paymentLabel.Location = new Point(263, 19);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new Size(346, 102);
            paymentLabel.TabIndex = 0;
            paymentLabel.Text = "Payment";
            // 
            // orderListBox
            // 
            orderListBox.Controls.Add(dataGridView1);
            orderListBox.Location = new Point(70, 140);
            orderListBox.Name = "orderListBox";
            orderListBox.Size = new Size(761, 229);
            orderListBox.TabIndex = 1;
            orderListBox.TabStop = false;
            orderListBox.Text = "Order Items";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(749, 201);
            dataGridView1.TabIndex = 0;
            // 
            // customerDetailsBox
            // 
            customerDetailsBox.BackColor = Color.White;
            customerDetailsBox.Controls.Add(deliveryCombo);
            customerDetailsBox.Controls.Add(deliveryTypeTextBox);
            customerDetailsBox.Controls.Add(paymentTypeTextBox);
            customerDetailsBox.Controls.Add(paymentCombo);
            customerDetailsBox.Controls.Add(totalBill);
            customerDetailsBox.Controls.Add(label1);
            customerDetailsBox.Controls.Add(emailTextBox);
            customerDetailsBox.Controls.Add(customerEmail);
            customerDetailsBox.Controls.Add(phoneTextBox);
            customerDetailsBox.Controls.Add(customerPhone);
            customerDetailsBox.Controls.Add(nameTextBox);
            customerDetailsBox.Controls.Add(customerName);
            customerDetailsBox.Location = new Point(70, 386);
            customerDetailsBox.Name = "customerDetailsBox";
            customerDetailsBox.Size = new Size(761, 168);
            customerDetailsBox.TabIndex = 2;
            customerDetailsBox.TabStop = false;
            customerDetailsBox.Text = "Customer Details";
            // 
            // deliveryCombo
            // 
            deliveryCombo.FormattingEnabled = true;
            deliveryCombo.Items.AddRange(new object[] { "Dine In", "Take Away" });
            deliveryCombo.Location = new Point(375, 78);
            deliveryCombo.Name = "deliveryCombo";
            deliveryCombo.Size = new Size(121, 23);
            deliveryCombo.TabIndex = 11;
            // 
            // deliveryTypeTextBox
            // 
            deliveryTypeTextBox.AutoSize = true;
            deliveryTypeTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            deliveryTypeTextBox.Location = new Point(257, 78);
            deliveryTypeTextBox.Name = "deliveryTypeTextBox";
            deliveryTypeTextBox.Size = new Size(101, 17);
            deliveryTypeTextBox.TabIndex = 10;
            deliveryTypeTextBox.Text = "Delivery Type :";
            // 
            // paymentTypeTextBox
            // 
            paymentTypeTextBox.AutoSize = true;
            paymentTypeTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            paymentTypeTextBox.Location = new Point(257, 33);
            paymentTypeTextBox.Name = "paymentTypeTextBox";
            paymentTypeTextBox.Size = new Size(103, 17);
            paymentTypeTextBox.TabIndex = 9;
            paymentTypeTextBox.Text = "Payment Type :";
            // 
            // paymentCombo
            // 
            paymentCombo.FormattingEnabled = true;
            paymentCombo.Items.AddRange(new object[] { "Cash", "Credit Card" });
            paymentCombo.Location = new Point(375, 31);
            paymentCombo.Name = "paymentCombo";
            paymentCombo.Size = new Size(121, 23);
            paymentCombo.TabIndex = 8;
            // 
            // totalBill
            // 
            totalBill.AutoSize = true;
            totalBill.BackColor = Color.IndianRed;
            totalBill.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            totalBill.Location = new Point(604, 87);
            totalBill.Name = "totalBill";
            totalBill.Size = new Size(80, 23);
            totalBill.TabIndex = 7;
            totalBill.Text = "$ 0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(607, 28);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 6;
            label1.Text = "Total Bill";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(85, 120);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(138, 23);
            emailTextBox.TabIndex = 5;
            // 
            // customerEmail
            // 
            customerEmail.AutoSize = true;
            customerEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            customerEmail.Location = new Point(16, 120);
            customerEmail.Name = "customerEmail";
            customerEmail.Size = new Size(54, 17);
            customerEmail.TabIndex = 4;
            customerEmail.Text = "Email : ";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(85, 78);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(138, 23);
            phoneTextBox.TabIndex = 3;
            // 
            // customerPhone
            // 
            customerPhone.AutoSize = true;
            customerPhone.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            customerPhone.Location = new Point(16, 78);
            customerPhone.Name = "customerPhone";
            customerPhone.Size = new Size(55, 17);
            customerPhone.TabIndex = 2;
            customerPhone.Text = "Phone :";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(85, 32);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(138, 23);
            nameTextBox.TabIndex = 1;
            // 
            // customerName
            // 
            customerName.AutoSize = true;
            customerName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            customerName.Location = new Point(16, 32);
            customerName.Name = "customerName";
            customerName.Size = new Size(52, 17);
            customerName.TabIndex = 0;
            customerName.Text = "Name :";
            // 
            // confirmButton
            // 
            confirmButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            confirmButton.Location = new Point(370, 571);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(145, 45);
            confirmButton.TabIndex = 8;
            confirmButton.Text = "Confirm Order";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // updateCurrentOrderButton
            // 
            updateCurrentOrderButton.Location = new Point(756, 111);
            updateCurrentOrderButton.Name = "updateCurrentOrderButton";
            updateCurrentOrderButton.Size = new Size(75, 23);
            updateCurrentOrderButton.TabIndex = 9;
            updateCurrentOrderButton.Text = "See Order";
            updateCurrentOrderButton.UseVisualStyleBackColor = true;
            updateCurrentOrderButton.Click += updateCurrentOrderButton_Click;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            Controls.Add(updateCurrentOrderButton);
            Controls.Add(confirmButton);
            Controls.Add(customerDetailsBox);
            Controls.Add(orderListBox);
            Controls.Add(paymentLabel);
            Name = "Payment";
            Size = new Size(883, 635);
            orderListBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            customerDetailsBox.ResumeLayout(false);
            customerDetailsBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label paymentLabel;
        private GroupBox orderListBox;
        private DataGridView dataGridView1;
        private GroupBox customerDetailsBox;
        private Label totalBill;
        private Label label1;
        private TextBox emailTextBox;
        private Label customerEmail;
        private TextBox phoneTextBox;
        private Label customerPhone;
        private TextBox nameTextBox;
        private Label customerName;
        private Button confirmButton;
        private ComboBox deliveryCombo;
        private Label deliveryTypeTextBox;
        private Label paymentTypeTextBox;
        private ComboBox paymentCombo;
        private Button updateCurrentOrderButton;
    }
}

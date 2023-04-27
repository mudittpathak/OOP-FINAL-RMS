namespace ROS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            companyName = new Label();
            companyAddress = new Label();
            label2 = new Label();
            companyPhone = new Label();
            companyEmail = new Label();
            loginGroupBox = new GroupBox();
            loginButton = new Button();
            loginPasswordField = new TextBox();
            loginEmailField = new TextBox();
            label1 = new Label();
            label3 = new Label();
            menu1 = new Menu();
            pictureBox1 = new PictureBox();
            payment1 = new Payment();
            orders1 = new Orders();
            loginGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // companyName
            // 
            companyName.AutoSize = true;
            companyName.BackColor = SystemColors.Control;
            companyName.Font = new Font("Perpetua Titling MT", 36F, FontStyle.Bold, GraphicsUnit.Point);
            companyName.Location = new Point(328, 56);
            companyName.Name = "companyName";
            companyName.Size = new Size(201, 58);
            companyName.TabIndex = 0;
            companyName.Text = "label1";
            // 
            // companyAddress
            // 
            companyAddress.AutoSize = true;
            companyAddress.BackColor = SystemColors.Control;
            companyAddress.Font = new Font("Script MT Bold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            companyAddress.Location = new Point(318, 125);
            companyAddress.Name = "companyAddress";
            companyAddress.Size = new Size(38, 15);
            companyAddress.TabIndex = 1;
            companyAddress.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 510);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 2;
            label2.Text = "Contact Us :";
            // 
            // companyPhone
            // 
            companyPhone.AutoSize = true;
            companyPhone.Font = new Font("MS Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            companyPhone.Location = new Point(23, 601);
            companyPhone.Name = "companyPhone";
            companyPhone.Size = new Size(55, 13);
            companyPhone.TabIndex = 3;
            companyPhone.Text = "label1";
            // 
            // companyEmail
            // 
            companyEmail.AutoSize = true;
            companyEmail.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            companyEmail.Location = new Point(23, 564);
            companyEmail.Name = "companyEmail";
            companyEmail.Size = new Size(45, 18);
            companyEmail.TabIndex = 4;
            companyEmail.Text = "label1";
            // 
            // loginGroupBox
            // 
            loginGroupBox.Controls.Add(loginButton);
            loginGroupBox.Controls.Add(loginPasswordField);
            loginGroupBox.Controls.Add(loginEmailField);
            loginGroupBox.Controls.Add(label1);
            loginGroupBox.Controls.Add(label3);
            loginGroupBox.Location = new Point(318, 211);
            loginGroupBox.Name = "loginGroupBox";
            loginGroupBox.Size = new Size(268, 204);
            loginGroupBox.TabIndex = 5;
            loginGroupBox.TabStop = false;
            loginGroupBox.Text = "Login";
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.Location = new Point(75, 134);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(120, 48);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // loginPasswordField
            // 
            loginPasswordField.Location = new Point(91, 78);
            loginPasswordField.Name = "loginPasswordField";
            loginPasswordField.Size = new Size(152, 23);
            loginPasswordField.TabIndex = 4;
            // 
            // loginEmailField
            // 
            loginEmailField.Location = new Point(91, 39);
            loginEmailField.Name = "loginEmailField";
            loginEmailField.Size = new Size(152, 23);
            loginEmailField.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 81);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 2;
            label1.Text = "Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 42);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 1;
            label3.Text = "Email :";
            // 
            // menu1
            // 
            menu1.BackgroundImage = (Image)resources.GetObject("menu1.BackgroundImage");
            menu1.Location = new Point(-1, -1);
            menu1.Name = "menu1";
            menu1.Size = new Size(876, 640);
            menu1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(733, 510);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // payment1
            // 
            payment1.BackgroundImage = (Image)resources.GetObject("payment1.BackgroundImage");
            payment1.Location = new Point(-1, -1);
            payment1.Name = "payment1";
            payment1.Size = new Size(876, 640);
            payment1.TabIndex = 9;
            // 
            // orders1
            // 
            orders1.BackgroundImage = (Image)resources.GetObject("orders1.BackgroundImage");
            orders1.Location = new Point(-1, -1);
            orders1.Name = "orders1";
            orders1.Size = new Size(876, 640);
            orders1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 637);
            Controls.Add(orders1);
            Controls.Add(payment1);
            Controls.Add(pictureBox1);
            Controls.Add(loginGroupBox);
            Controls.Add(companyEmail);
            Controls.Add(companyPhone);
            Controls.Add(label2);
            Controls.Add(companyAddress);
            Controls.Add(companyName);
            Controls.Add(menu1);
            Name = "Form1";
            Text = "Form1";
            loginGroupBox.ResumeLayout(false);
            loginGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label companyName;
        private Label companyAddress;
        private Label label2;
        private Label companyPhone;
        private Label companyEmail;
        private GroupBox loginGroupBox;
        private Button loginButton;
        private TextBox loginPasswordField;
        private TextBox loginEmailField;
        private Label label1;
        private Label label3;
        private Menu menu1;
        private PictureBox pictureBox1;
        private Payment payment1;
        private Orders orders1;
    }
}
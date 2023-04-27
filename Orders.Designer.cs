namespace ROS
{
    partial class Orders
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
            label1 = new Label();
            allOrdersBox = new GroupBox();
            dataGridView1 = new DataGridView();
            exitButton = new Button();
            updateAllOrdersButton = new Button();
            allOrdersBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(379, 24);
            label1.Name = "label1";
            label1.Size = new Size(131, 41);
            label1.TabIndex = 0;
            label1.Text = "Orders";
            // 
            // allOrdersBox
            // 
            allOrdersBox.BackColor = Color.PeachPuff;
            allOrdersBox.Controls.Add(dataGridView1);
            allOrdersBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            allOrdersBox.Location = new Point(86, 86);
            allOrdersBox.Name = "allOrdersBox";
            allOrdersBox.Size = new Size(727, 456);
            allOrdersBox.TabIndex = 1;
            allOrdersBox.TabStop = false;
            allOrdersBox.Text = "Your Orders";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(715, 413);
            dataGridView1.TabIndex = 0;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.Location = new Point(355, 589);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(114, 40);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // updateAllOrdersButton
            // 
            updateAllOrdersButton.BackColor = Color.DarkOrange;
            updateAllOrdersButton.Location = new Point(738, 57);
            updateAllOrdersButton.Name = "updateAllOrdersButton";
            updateAllOrdersButton.Size = new Size(75, 23);
            updateAllOrdersButton.TabIndex = 1;
            updateAllOrdersButton.Text = "Update";
            updateAllOrdersButton.UseVisualStyleBackColor = false;
            updateAllOrdersButton.Click += updateAllOrdersButton_Click;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.last;
            Controls.Add(updateAllOrdersButton);
            Controls.Add(exitButton);
            Controls.Add(allOrdersBox);
            Controls.Add(label1);
            Name = "Orders";
            Size = new Size(897, 674);
            allOrdersBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox allOrdersBox;
        private DataGridView dataGridView1;
        private Button exitButton;
        private Button updateAllOrdersButton;
    }
}

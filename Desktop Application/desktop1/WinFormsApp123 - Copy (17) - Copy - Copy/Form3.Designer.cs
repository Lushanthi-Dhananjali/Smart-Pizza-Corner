namespace WinFormsApp123
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            dataGridView1 = new DataGridView();
            item_name = new DataGridViewTextBoxColumn();
            unit_price = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { item_name, unit_price, quantity, total });
            dataGridView1.Location = new Point(528, 68);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(548, 267);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // item_name
            // 
            item_name.HeaderText = "Item name";
            item_name.MinimumWidth = 6;
            item_name.Name = "item_name";
            item_name.Width = 125;
            // 
            // unit_price
            // 
            unit_price.HeaderText = "Unit Price";
            unit_price.MinimumWidth = 6;
            unit_price.Name = "unit_price";
            unit_price.Width = 125;
            // 
            // quantity
            // 
            quantity.HeaderText = "Quantity";
            quantity.MinimumWidth = 6;
            quantity.Name = "quantity";
            quantity.Width = 125;
            // 
            // total
            // 
            total.HeaderText = "Total";
            total.MinimumWidth = 6;
            total.Name = "total";
            total.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaShell;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumTurquoise;
            label1.Location = new Point(46, 100);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 1;
            label1.Text = "Item Name";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MistyRose;
            textBox1.Location = new Point(218, 209);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 27);
            textBox1.TabIndex = 50;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SeaShell;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MediumTurquoise;
            label2.Location = new Point(46, 208);
            label2.Name = "label2";
            label2.Size = new Size(95, 28);
            label2.TabIndex = 5;
            label2.Text = "Quantity";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SeaShell;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MediumTurquoise;
            label3.Location = new Point(49, 155);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 6;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MistyRose;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(218, 155);
            label4.Name = "label4";
            label4.Size = new Size(100, 28);
            label4.TabIndex = 7;
            label4.Text = "___________";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Brown;
            label5.Location = new Point(49, 31);
            label5.Name = "label5";
            label5.Size = new Size(54, 28);
            label5.TabIndex = 8;
            label5.Text = "EXIT";
            label5.Click += label5_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.MistyRose;
            textBox2.Location = new Point(218, 100);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 27);
            textBox2.TabIndex = 18;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Artifakt Element", 10.7999992F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "Hot and Spicy Chicken Pizza", "Chesese Lovers Pizza", "Suasage Spicy Pizza", "Veggitable Pizza", "BBQ Mixer Pizza", "Fish Devile Pizza", "Masala Pizza", "Black Chicken Pizza", "Beef Pizza", "Thai Pizza", "Suprime Chicken Burger", "Chickrn Monston Burger", "Steakhouse Burger", "Texas Smokehouse Burger", "Chick N'Crisp Burger", "Crispy Fried Chicken Sabmarine", "Tandoori Chicken Sabmarine", "Grill Hot Sabmarine" });
            listBox1.Location = new Point(785, 423);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(304, 354);
            listBox1.TabIndex = 10;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.Font = new Font("Bell MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.LightGoldenrodYellow;
            button1.Location = new Point(86, 527);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(132, 40);
            button1.TabIndex = 11;
            button1.Text = "Order";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SeaShell;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.MediumTurquoise;
            label6.Location = new Point(46, 255);
            label6.Name = "label6";
            label6.Size = new Size(59, 28);
            label6.TabIndex = 12;
            label6.Text = "Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.MistyRose;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(218, 255);
            label7.Name = "label7";
            label7.Size = new Size(100, 28);
            label7.TabIndex = 13;
            label7.Text = "___________";
            label7.Click += label7_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.SeaShell;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.MediumTurquoise;
            label8.Location = new Point(276, 525);
            label8.Name = "label8";
            label8.Size = new Size(187, 37);
            label8.TabIndex = 14;
            label8.Text = "Sub Total :     ";
            label8.Click += label8_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.Font = new Font("Bell MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.LightGoldenrodYellow;
            button2.Location = new Point(528, 656);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(155, 40);
            button2.TabIndex = 15;
            button2.Text = "Print";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.SeaShell;
            label9.Font = new Font("Jokerman", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.ForestGreen;
            label9.Location = new Point(30, 758);
            label9.Name = "label9";
            label9.Size = new Size(729, 117);
            label9.TabIndex = 16;
            label9.Text = "YMU YMU PIZZA";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DarkBlue;
            label10.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Honeydew;
            label10.Location = new Point(46, 660);
            label10.Name = "label10";
            label10.Size = new Size(395, 26);
            label10.TabIndex = 51;
            label10.Text = "If you like you can get print of bill";
            label10.Click += label10_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1138, 908);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn item_name;
        private DataGridViewTextBoxColumn unit_price;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn total;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private ListBox listBox1;
        private Button button1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button2;
        private Label label9;
        private Label label10;
    }
}
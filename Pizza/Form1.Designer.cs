namespace Pizza
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Cesitlerimiz = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            label7 = new Label();
            label8 = new Label();
            listBox2 = new ListBox();
            label9 = new Label();
            listBox3 = new ListBox();
            label10 = new Label();
            listBox4 = new ListBox();
            label11 = new Label();
            listBox5 = new ListBox();
            label12 = new Label();
            listBox6 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Cesitlerimiz.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(151, 32);
            label1.TabIndex = 0;
            label1.Text = "Pizza House";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 49);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 1;
            label2.Text = "Adı Soyadı:";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(157, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(8, 94);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 4;
            label3.Text = "Telefon:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(8, 135);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 5;
            label4.Text = "Adres";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(106, 137);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(161, 88);
            textBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(8, 234);
            label5.Name = "label5";
            label5.Size = new Size(79, 21);
            label5.TabIndex = 7;
            label5.Text = "PizzaBoy";
            label5.Click += label5_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kucuk", "Orta", "Buyuk\t\t" });
            comboBox1.Location = new Point(106, 236);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(161, 23);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Su\t", "Kola", "Fanta", "Gazoz", "Ayran\t", "Soda" });
            comboBox2.Location = new Point(106, 287);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(161, 23);
            comboBox2.TabIndex = 10;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(8, 285);
            label6.Name = "label6";
            label6.Size = new Size(58, 21);
            label6.TabIndex = 9;
            label6.Text = "Icecek";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(873, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(40, 36);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(75, 25);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Sucuk";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(40, 61);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(70, 25);
            checkBox2.TabIndex = 13;
            checkBox2.Text = "Kasar";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(40, 86);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(78, 25);
            checkBox3.TabIndex = 14;
            checkBox3.Text = "Zeytin";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(39, 111);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(67, 25);
            checkBox4.TabIndex = 15;
            checkBox4.Text = "Misir";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(39, 136);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(69, 25);
            checkBox5.TabIndex = 16;
            checkBox5.Text = "Biber";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(40, 161);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(67, 25);
            checkBox6.TabIndex = 17;
            checkBox6.Text = "Misir";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // Cesitlerimiz
            // 
            Cesitlerimiz.Controls.Add(checkBox4);
            Cesitlerimiz.Controls.Add(checkBox6);
            Cesitlerimiz.Controls.Add(checkBox1);
            Cesitlerimiz.Controls.Add(checkBox5);
            Cesitlerimiz.Controls.Add(checkBox2);
            Cesitlerimiz.Controls.Add(checkBox3);
            Cesitlerimiz.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Cesitlerimiz.Location = new Point(288, 9);
            Cesitlerimiz.Name = "Cesitlerimiz";
            Cesitlerimiz.Size = new Size(324, 192);
            Cesitlerimiz.TabIndex = 18;
            Cesitlerimiz.TabStop = false;
            Cesitlerimiz.Text = "Cesitlerimiz";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(288, 215);
            button1.Name = "button1";
            button1.Size = new Size(106, 33);
            button1.TabIndex = 19;
            button1.Text = "SiparisAl";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(410, 215);
            button2.Name = "button2";
            button2.Size = new Size(90, 33);
            button2.TabIndex = 20;
            button2.Text = "Temizle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 356);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(24, 332);
            label7.Name = "label7";
            label7.Size = new Size(92, 21);
            label7.TabIndex = 22;
            label7.Text = "Adı Soyadı";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(173, 332);
            label8.Name = "label8";
            label8.Size = new Size(67, 21);
            label8.TabIndex = 24;
            label8.Text = "Telefon";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(161, 356);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 94);
            listBox2.TabIndex = 23;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(316, 332);
            label9.Name = "label9";
            label9.Size = new Size(60, 21);
            label9.TabIndex = 26;
            label9.Text = "Adress";
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(304, 356);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(120, 94);
            listBox3.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(457, 332);
            label10.Name = "label10";
            label10.Size = new Size(83, 21);
            label10.TabIndex = 28;
            label10.Text = "Pizza Boy";
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(445, 356);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(120, 94);
            listBox4.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(600, 332);
            label11.Name = "label11";
            label11.Size = new Size(58, 21);
            label11.TabIndex = 30;
            label11.Text = "Icecek";
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 15;
            listBox5.Location = new Point(588, 356);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(120, 94);
            listBox5.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(741, 332);
            label12.Name = "label12";
            label12.Size = new Size(67, 21);
            label12.TabIndex = 32;
            label12.Text = "Cesitler";
            // 
            // listBox6
            // 
            listBox6.FormattingEnabled = true;
            listBox6.ItemHeight = 15;
            listBox6.Location = new Point(729, 356);
            listBox6.Name = "listBox6";
            listBox6.Size = new Size(120, 94);
            listBox6.TabIndex = 31;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(1022, 529);
            Controls.Add(label12);
            Controls.Add(listBox6);
            Controls.Add(label11);
            Controls.Add(listBox5);
            Controls.Add(label10);
            Controls.Add(listBox4);
            Controls.Add(label9);
            Controls.Add(listBox3);
            Controls.Add(label8);
            Controls.Add(listBox2);
            Controls.Add(label7);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Cesitlerimiz);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Pizzacı";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Cesitlerimiz.ResumeLayout(false);
            Cesitlerimiz.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label6;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox Cesitlerimiz;
        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private Label label7;
        private Label label8;
        private ListBox listBox2;
        private Label label9;
        private ListBox listBox3;
        private Label label10;
        private ListBox listBox4;
        private Label label11;
        private ListBox listBox5;
        private Label label12;
        private ListBox listBox6;
    }
}

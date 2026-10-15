namespace imtahansistemorxan
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
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            richTextBox3 = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox4 = new MaskedTextBox();
            maskedTextBox5 = new MaskedTextBox();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(3, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(973, 184);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(3, 3);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(852, 184);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(498, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(586, 67);
            label1.Name = "label1";
            label1.Size = new Size(246, 41);
            label1.TabIndex = 2;
            label1.Text = "İmtahan Sistemi";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(3, 200);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(852, 399);
            richTextBox3.TabIndex = 3;
            richTextBox3.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 235);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 307);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 379);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 6;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 465);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 7;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 542);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 8;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(43, 72);
            label7.Name = "label7";
            label7.Size = new Size(122, 28);
            label7.TabIndex = 9;
            label7.Text = "Ad ve Soyad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.Location = new Point(43, 191);
            label8.Name = "label8";
            label8.Size = new Size(142, 28);
            label8.TabIndex = 10;
            label8.Text = "Telebe nomresi";
            label8.Click += label8_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(101, 232);
            maskedTextBox1.Mask = "00000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(59, 27);
            maskedTextBox1.TabIndex = 11;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(101, 535);
            maskedTextBox2.Mask = "00000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(59, 27);
            maskedTextBox2.TabIndex = 12;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(101, 458);
            maskedTextBox3.Mask = "00000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(59, 27);
            maskedTextBox3.TabIndex = 13;
            maskedTextBox3.ValidatingType = typeof(int);
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(101, 372);
            maskedTextBox4.Mask = "00000";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(59, 27);
            maskedTextBox4.TabIndex = 14;
            maskedTextBox4.ValidatingType = typeof(int);
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.Location = new Point(101, 300);
            maskedTextBox5.Mask = "00000";
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(59, 27);
            maskedTextBox5.TabIndex = 15;
            maskedTextBox5.ValidatingType = typeof(int);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(176, 215);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(309, 347);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Telebe melumatlari";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 27);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(43, 237);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(224, 27);
            textBox2.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(43, 293);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "Netice";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(173, 293);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 14;
            button2.Text = "Temizle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(505, 215);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(350, 384);
            dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            Column1.HeaderText = "Ad ve Soyad";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "Telebe nomresi";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // Column3
            // 
            Column3.HeaderText = "Giris bali";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 50;
            // 
            // Column4
            // 
            Column4.HeaderText = "SSİ";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 50;
            // 
            // Column5
            // 
            Column5.HeaderText = "Netice";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 50;
            // 
            // Column6
            // 
            Column6.HeaderText = "Kateqoriya";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 50;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 611);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(maskedTextBox5);
            Controls.Add(maskedTextBox4);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(richTextBox3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private RichTextBox richTextBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox4;
        private MaskedTextBox maskedTextBox5;
        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}

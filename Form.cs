using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace imtahansistemorxan
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(maskedTextBox1, "SDF1 üçün qiymət aralığı: 0 - 10");
            toolTip1.SetToolTip(maskedTextBox2, "SDF2 üçün qiymət aralığı: 0 - 10");
            toolTip1.SetToolTip(maskedTextBox3, "FF üçün qiymət aralığı: 0 - 10");
            toolTip1.SetToolTip(maskedTextBox4, "Seminar üçün qiymət aralığı: 0 - 20");
            toolTip1.SetToolTip(maskedTextBox5, "Final (SSİ) üçün qiymət aralığı: 0 - 50");

            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hasError = false;

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Ad və soyad boş ola bilməz!");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(maskedTextBox6.Text.Replace("_", "").Trim()))
            {
                errorProvider1.SetError(maskedTextBox6, "Tələbə nömrəsi boş ola bilməz!");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text.Replace("_", "").Trim()))
            {
                errorProvider1.SetError(maskedTextBox1, "SDF1 boş ola bilməz!");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(maskedTextBox2.Text.Replace("_", "").Trim()))
            {
                errorProvider1.SetError(maskedTextBox2, "SDF2 boş ola bilməz!");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(maskedTextBox3.Text.Replace("_", "").Trim()))
            {
                errorProvider1.SetError(maskedTextBox3, "FF boş ola bilməz!");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(maskedTextBox4.Text.Replace("_", "").Trim()))
            {
                errorProvider1.SetError(maskedTextBox4, "Seminar boş ola bilməz!");
                hasError = true;
            }
            if (string.IsNullOrWhiteSpace(maskedTextBox5.Text.Replace("_", "").Trim()))
            {
                errorProvider1.SetError(maskedTextBox5, "Final boş ola bilməz!");
                hasError = true;
            }

            if (hasError) return;

            string telebeNomresi = maskedTextBox6.Text.Trim();
            if (telebeNomresi.Length != 9 || !long.TryParse(telebeNomresi, out _))
            {
                MessageBox.Show("Tələbə nömrəsi yanlışdır", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isSDF1 = int.TryParse(maskedTextBox1.Text, out int sdf1);
            bool isSDF2 = int.TryParse(maskedTextBox2.Text, out int sdf2);
            bool isFF = int.TryParse(maskedTextBox3.Text, out int ff);
            bool isSeminar = int.TryParse(maskedTextBox4.Text, out int seminar);
            bool isFinal = int.TryParse(maskedTextBox5.Text, out int final);

            if (!isSDF1 || !isSDF2 || !isFF || !isSeminar || !isFinal ||
                sdf1 < 0 || sdf1 > 10 ||
                sdf2 < 0 || sdf2 > 10 ||
                ff < 0 || ff > 10 ||
                seminar < 0 || seminar > 20 ||
                final < 0 || final > 50)
            {
                MessageBox.Show("Qiymətləndirmə yanlış aparılmışdır", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int girisBali = sdf1 + sdf2 + ff + seminar;
            int ssi = final;
            int netice = girisBali + ssi;

            if (final < 17)
            {
                MessageBox.Show("Tələbə Final imtahanından 17-dən aşağı topladığı üçün kəsr hesab olunur!", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (netice < 51)
            {
                MessageBox.Show("Tələbə cəm olaraq 51-dən yuxarı nəticə əldə etməlidir!", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string kateqoriya = "";
            if (netice >= 91) kateqoriya = "A";
            else if (netice >= 81) kateqoriya = "B";
            else if (netice >= 71) kateqoriya = "C";
            else if (netice >= 61) kateqoriya = "D";
            else if (netice >= 51) kateqoriya = "E";
            else kateqoriya = "F";

            dataGridView1.Rows.Add(textBox1.Text.Trim(), telebeNomresi, girisBali, ssi, netice, kateqoriya);

            notifyIcon1.ShowBalloonTip(8000, "Proqram bildirişi", "Tələbənin məlumatları sistemə əlavə edildi", ToolTipIcon.Info);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            maskedTextBox6.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            maskedTextBox4.Clear();
            maskedTextBox5.Clear();
            errorProvider1.Clear();
        }
    }
}

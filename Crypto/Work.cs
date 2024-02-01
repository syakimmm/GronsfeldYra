using System;
using System.Windows.Forms;

namespace Crypto
{
    public partial class Work : Form
    {
        private Gronsfeld alg = new Gronsfeld();
      
        // конструктор формы
        public Work()
        {
            InitializeComponent();
        }

        // загрузка формы
        private void Work_Load(object sender, System.EventArgs e)
        {
            DialogResult authResult = new FormAuth().ShowDialog();
            if (authResult == DialogResult.Cancel)
            {
                this.Close();
            }
        }

        // изменение ключа
        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            alg.Key = textBoxKey.Text;
            textBoxEncrypted.Text = "";
        }

        // зашифровать
        private void bCrypt_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxKey.Text))
            {
                MessageBox.Show("Нет ключа для шифрования", "Ошибка");
                return;
            }
            if (!int.TryParse(textBoxKey.Text, out int key))
            {
                MessageBox.Show("Ключ для шифрования должен быть числовым", "Ошибка");
                return;
            }
            if (string.IsNullOrEmpty(textBoxOriginal.Text))
            {
                MessageBox.Show("Нет данных для шифрования", "Ошибка");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxOriginal.Text, @"^[А-Яа-я\s\p{P}]+$"))
            {
                MessageBox.Show("Допустимы только символы русского алфавита для шифрования", "Ошибка");
                return;
            }
            else
            textBoxEncrypted.Text = alg.Crypt(textBoxOriginal.Text);
        }

        // расшифровать
        private void bDecode_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxKey.Text))
            {
                MessageBox.Show("Нет ключа для дешифрования", "Ошибка");
                return;
            }
            if (!int.TryParse(textBoxKey.Text, out int key))
            {
                MessageBox.Show("Ключ для дешифрования должен быть числовым", "Ошибка");
                return;
            }
            if (string.IsNullOrEmpty(textBoxEncrypted.Text))
            {
                MessageBox.Show("Нет данных для дешифрования", "Ошибка");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxEncrypted.Text, @"^[А-Яа-я\s\p{P}]+$"))
            {
                MessageBox.Show("Допустимы только символы русского алфавита для шифрования", "Ошибка");
                return;
            }
            string encryptText = alg.Decrypt(textBoxEncrypted.Text);
            MessageBox.Show(encryptText, "Расшифровка по ключу "+alg.Key);
            textBoxOriginal.Text = encryptText;
        }

        // метод для сохранения зашифрованного текста в файл
        private void SaveEncryptedTextToFile(string encryptedText)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                saveFileDialog1.Title = "Сохранить зашифрованный текст";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    // Записываем зашифрованный текст в выбранный файл
                    System.IO.File.WriteAllText(saveFileDialog1.FileName, encryptedText);
                    MessageBox.Show("Зашифрованный текст сохранен в файл " + saveFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении зашифрованного текста: " + ex.Message);
            }
        }

        // метод для сохранения дешифрованного текста в файл
        private void SaveDecryptedTextToFile(string decryptedText)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                saveFileDialog1.Title = "Сохранить дешифрованный текст";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    // Записываем дешифрованный текст в выбранный файл
                    System.IO.File.WriteAllText(saveFileDialog1.FileName, decryptedText);
                    MessageBox.Show("Дешифрованный текст сохранен в файл " + saveFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении дешифрованного текста: " + ex.Message);
            }
        }


        private void button1_Click(object sender, System.EventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBoxEncrypted.Text))
            {
                MessageBox.Show("Нет данных для сохранения", "Ошибка");
                return;
            }

            string encryptedText = alg.Crypt(textBoxOriginal.Text);
            SaveEncryptedTextToFile(encryptedText);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxOriginal.Text))
            {
                MessageBox.Show("Нет данных для сохранения", "Ошибка");
                return;
            }

            string decryptedText = alg.Decrypt(textBoxEncrypted.Text);
            SaveDecryptedTextToFile(decryptedText);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxKey.Text))
            {
                MessageBox.Show("Нет ключа для дешифрования", "Ошибка");
                return;
            }
            if (!string.IsNullOrEmpty(textBoxKey.Text)) // Проверяем, что значение в поле не пустое
            {
                MessageBox.Show("Проверьте ключ для шифрования");
            }

            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                openFileDialog1.Title = "Выберите файл для дешифровки";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Считываем зашифрованный текст из выбранного файла
                    string encryptedText = System.IO.File.ReadAllText(openFileDialog1.FileName);

                    // Показываем зашифрованный текст в textBoxEncrypted
                    textBoxEncrypted.Text = encryptedText;

                    // Осуществляем дешифровку текста
                    string decryptedText = alg.Decrypt(encryptedText);

                    // Показываем расшифрованный текст в textBoxOriginal
                    textBoxOriginal.Text = decryptedText;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии и дешифровке файла: " + ex.Message);
            }
        }
    }
}

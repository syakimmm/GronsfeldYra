using System;
using System.Windows.Forms;

namespace Crypto
{
    public partial class FormReg : Form
    {
        private Datebase db = null;
        public FormReg()
        {
            InitializeComponent();
        }

        // проверка поля на доступные условия
        private bool CheckData(TextBox text, string name = "Логин")
        {
            // проверка на отсутствие текста
            if (string.IsNullOrWhiteSpace(text.Text))
            {
                MessageBox.Show($"{name} не задан! Укажите {name.ToLower()} вашей учётной записи...");
                return false;
            }
            // проверка на минимально допустимый размер
            if (text.Text.Length < 3)
            {
                MessageBox.Show($"{name} не удовлетворяет условиям! Длина {name.ToLower()} должна быть больше 2 символов...");
                return false;
            }
            // проверка на максимально допустимый размер
            if (text.Text.Length > 8)
            {
                MessageBox.Show($"{name} не удовлетворяет условиям! Длина {name.ToLower()} не должна превышать 8 символов...");
                return false;
            }
            return true;
        }


        private void bReg_Click(object sender, EventArgs e)
        {
            // проверки
            if (!CheckData(tLoginReg)) return;
            if (db.CheckUser(tLoginReg.Text, tPassReg1.Text, true))
            {
                MessageBox.Show("Указанный логин уже используется! Придумайте новый логин...");
                return;
            }
            if (!CheckData(tPassReg1, "Пароль")) return;
            if (tPassReg1.Text != tPassReg2.Text)
            {
                MessageBox.Show("Проверка пароля не прошла. Вы указали в поле проверки не верный пароль. Укажите ваш пароль...");
                return;
            }
            // создание пользователя
            if (db.CreateUser(tLoginReg.Text, tPassReg1.Text))
            {
                MessageBox.Show("Вы успешно зарегистрировались!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void FormReg_Load(object sender, EventArgs e)
        {
            // настроим подключение к бд
            db = new Datebase("Data Source=dateBase.db; Version = 3;");
        }
    }
}

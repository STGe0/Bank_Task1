using System.Security.Cryptography;
using System.Text;

namespace cur
{
    public partial class LoginP : Form
    {
        public byte[] passwordP = Encoding.UTF8.GetBytes(Properties.Resource1.passwordP);
        public byte[] saltP = Encoding.UTF8.GetBytes(Guid.NewGuid().ToString("N"));
        public string login;
        public byte[] password;

        public static bool butV = false;
        public static bool butO = false;


        public LoginP()
        {
            InitializeComponent();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty & textBox2.Text != string.Empty)
            {
                login = textBox1.Text;
                password = Encoding.UTF8.GetBytes(textBox2.Text);

                if (login == Properties.Resource1.loginP & CompareByteArrays(GenerateSaltedHash(password, saltP), GenerateSaltedHash(passwordP, saltP)))
                {
                    MessageBox.Show("Вход выполнен успешно", "Вход выполнен успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    butV = true;
                    butO = true;                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль", "Неправильный логин или пароль", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Заполните поля", "Заполните поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        static byte[] GenerateSaltedHash(byte[] plainText, byte[] salt)
        {
            HashAlgorithm algorithm = new SHA256Managed();

            byte[] plainTextWithSaltBytes = new byte[plainText.Length + salt.Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                plainTextWithSaltBytes[i] = plainText[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                plainTextWithSaltBytes[plainText.Length + i] = salt[i];
            }

            return algorithm.ComputeHash(plainTextWithSaltBytes);
        }
        public static bool CompareByteArrays(byte[] array1, byte[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

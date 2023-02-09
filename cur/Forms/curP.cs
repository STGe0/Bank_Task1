using BankService;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Xml;

namespace cur
{
    public partial class curP : Form
    {
        public List<Currency> currency = new List<Currency>();

        public List<Currency> currencyF = new List<Currency>();

        private Control oldParent;
        private Panel oldPanel;

        DataBase db = new DataBase();
        public curP()
        {
            InitializeComponent();

            using var client = new BankService.DailyInfoSoapClient(DailyInfoSoapClient.EndpointConfiguration.DailyInfoSoap);
            DateTime dateV = client.GetLatestDateTime();

            var curs = client.GetCursOnDateXML(dateV);

            foreach (XmlNode curItem in curs.ChildNodes)
            {
                currency.Add(new Currency()
                {
                    Code_Currency = int.Parse(curItem["Vcode"].InnerText),
                    Currency_Short = curItem["VchCode"].InnerText.Trim(),
                    Currency_Name = curItem["Vname"].InnerText.Trim(),
                    Currency_Curs = decimal.Parse(curItem["Vcurs"]!.InnerText.Trim(), CultureInfo.InvariantCulture),
                    Currency_Nominal = int.Parse(curItem["Vnom"].InnerText)
                });
            }
            dataGridViewCur.DataSource = currency;

            dataGridViewCur.Columns[0].HeaderText= "Код валюты";
            dataGridViewCur.Columns[0].Width = 150;
            dataGridViewCur.Columns[1].HeaderText = "Символьное обозначение";
            dataGridViewCur.Columns[1].Width = 150;
            dataGridViewCur.Columns[2].HeaderText = "Название валюты";
            dataGridViewCur.Columns[2].Width = 270;
            dataGridViewCur.Columns[3].HeaderText = "Курс валюты";
            dataGridViewCur.Columns[3].Width = 150;
            dataGridViewCur.Columns[4].HeaderText = "Номинал";
            dataGridViewCur.Columns[4].Width = 150;

        }

        private void tabCur_Selected(object sender, TabControlEventArgs e)
        {

            if(e.TabPageIndex == 1)
            {
                deleteF.Enabled = true;
                addF.Enabled = false;

                Update();
            }
            else
            {
                deleteF.Enabled = false;
                addF.Enabled = true;
            }
        }
        private Boolean check()
        {
            var row = dataGridViewCur.CurrentRow.Index;

            int Code_Currency = int.Parse(dataGridViewCur[0, row].Value.ToString());

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string SqlCheckQuery = $"select * from Currency where code_currency = {Code_Currency}";

            SqlCommand sqlCom = new SqlCommand(SqlCheckQuery, db.getConnection());

            adapter.SelectCommand = sqlCom;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void addF_Click(object sender, EventArgs e)
        {

            if (dataGridViewCur.CurrentRow != null && check())
            {
                var row = dataGridViewCur.CurrentRow.Index;

                int Code_Currency = int.Parse(dataGridViewCur[0, row].Value.ToString());
                string Currency_Short = dataGridViewCur[1, row].Value.ToString();
                string Currency_Name = dataGridViewCur[2, row].Value.ToString();
                string Currency_Curs = dataGridViewCur[3, row].Value.ToString().Replace(",", ".");
                int Currency_Nominal = int.Parse(dataGridViewCur[4, row].Value.ToString());
                

                string query = $"insert into Currency(code_currency, currency_korotko, name_currency, curs_currency, nom_currency) values ({Code_Currency}, '{Currency_Short}', '{Currency_Name}', {Currency_Curs}, {Currency_Nominal})";

                SqlCommand com = new SqlCommand(query, db.getConnection());

                db.openConnection();

                if (com.ExecuteNonQuery() == 1)
                {
                    Console.Write("123");
                }

                dataGridViewF.DataSource = currencyF;

                dataGridViewF.Refresh();
                MessageBox.Show("Успешно", "Успешно");
            }
            else
            {
                MessageBox.Show("Ошибка", "Ошибка");
            }
            }

        private void deleteF_Click(object sender, EventArgs e)
        {
            var row = dataGridViewF.CurrentRow.Index;

            int Code_Currency = int.Parse(dataGridViewF[0, row].Value.ToString());

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sqlQuery = $"DELETE from Currency where code_currency = {Code_Currency}";
            SqlCommand sqlCom = new SqlCommand(sqlQuery, db.getConnection());

            db.openConnection();
            if (dataGridViewF.CurrentRow is null)
            {
                MessageBox.Show("Выберите строку для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult res = MessageBox.Show("Удалить строку?", "Удаление строки", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    MessageBox.Show("Строка удалена", "Строка удалена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlCom.ExecuteNonQuery();
                }
            }
            Update();
            dataGridViewF.Refresh();
            db.closeConnection();
        }
        private void Update()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string sqlQuery = $"select code_currency, currency_korotko, name_currency, curs_currency, nom_currency from Currency";

            SqlCommand sqlCom = new SqlCommand(sqlQuery, db.getConnection());

            adapter.SelectCommand = sqlCom;
            adapter.Fill(table);

            dataGridViewF.DataSource = table;

            dataGridViewF.Columns[0].HeaderText = "Код валюты";
            dataGridViewF.Columns[0].Width = 150;
            dataGridViewF.Columns[1].HeaderText = "Символьное обозначение";
            dataGridViewF.Columns[1].Width = 150;
            dataGridViewF.Columns[2].HeaderText = "Название валюты";
            dataGridViewF.Columns[2].Width = 270;
            dataGridViewF.Columns[3].HeaderText = "Курс валюты";
            dataGridViewF.Columns[3].Width = 150;
            dataGridViewF.Columns[4].HeaderText = "Номинал";
            dataGridViewF.Columns[4].Width = 150;
        }
    }
    }

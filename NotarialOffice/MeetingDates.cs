using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.String;

namespace NotarialOffice
{
    public partial class MeetingDates : Form
    {
        private readonly string _connect = $@"Data Source={MainForm.DataSource};Initial Catalog={MainForm.InitialCatalog};Integrated Security=True";
        private const string Query = @"select C.LastName as Фамилия, C.FirstName as Имя, C.MiddleName as Отчество, [DateTime] as [Дата и время], Comment as Описание from Meetings M left join Customers C on M.CustomerID = C.CustomerID";

        private DataSet _dataSet; 
        private SqlDataAdapter _sqlDataAdapter;
        
        public MeetingDates()
        {
            InitializeComponent();
            
            dateBox.Value = DateTime.Today;
            using (var connection = new SqlConnection(_connect))
            {
                connection.Open();
                _sqlDataAdapter = new SqlDataAdapter(Query, connection);
                _dataSet = new DataSet();
                _sqlDataAdapter.Fill(_dataSet);
                customersTable.DataSource = _dataSet.Tables[0];
                customersTable.Columns[3].Width = 150;
                customersTable.Columns[4].Width = 200;
            }
            Update();
        }

        private void setNullSeacher_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            seacher.Text = Empty;
        }

        private void seacher_TextChanged(object sender, EventArgs e)
        {
            Update();
        }

        private new void Update()
        {
            using (var connection = new SqlConnection(_connect))
            {
                connection.Open();
                _sqlDataAdapter = new SqlDataAdapter(Query + $" where [DateTime] like '%{dateBox.Value:yyyy-MM-dd}%' and (LastName like '%{seacher.Text.Trim()}%' or FirstName like '%{seacher.Text.Trim()}%' or MiddleName like '%{seacher.Text.Trim()}%')", connection);
                _dataSet = new DataSet();
                _sqlDataAdapter.Fill(_dataSet);
                customersTable.DataSource = _dataSet.Tables[0];
            }
        }

        private void dateBox_ValueChanged(object sender, EventArgs e)
        {
            Update();
        }
    }
}
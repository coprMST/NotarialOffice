using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.String;

namespace NotarialOffice
{
    public partial class CustomersForm : Form
    {
        private readonly string _connect = $@"Data Source={MainForm.DataSource};Initial Catalog={MainForm.InitialCatalog};Integrated Security=True";
        private const string Query = @"select CustomerID, AccountID, LastName as [Фамилия], FirstName as [Имя], MiddleName as [Отчество], DateOfBith as [Дата рождения] from Customers";

        private DataSet _dataSet; 
        private SqlDataAdapter _sqlDataAdapter;

        public CustomersForm()
        {
            InitializeComponent();
            
            using (var connection = new SqlConnection(_connect))
            {
                connection.Open();
                _sqlDataAdapter = new SqlDataAdapter(Query, connection);
                _dataSet = new DataSet();
                _sqlDataAdapter.Fill(_dataSet);
                customersTable.DataSource = _dataSet.Tables[0];
            }
            
            customersTable.Columns[0].Visible = false;
            customersTable.Columns[1].Visible = false;
        }

        private void Connect()
        {
            using (var connection = new SqlConnection(_connect))
            {
                connection.Open();
                _sqlDataAdapter = new SqlDataAdapter(Query, connection);
                _sqlDataAdapter.Update(_dataSet);
            }
        }

        private void goToDelete_Click(object sender, EventArgs e)
        {
            var accountId = customersTable[1, customersTable.SelectedCells[0].RowIndex].Value.ToString();

            var name = customersTable[2, customersTable.SelectedCells[0].RowIndex].Value + " " + customersTable[3, customersTable.SelectedCells[0].RowIndex].Value.ToString().Substring(0, 1) + "." + customersTable[4, customersTable.SelectedCells[0].RowIndex].Value.ToString().Substring(0, 1);
            var res = MessageBox.Show(this, $@"Вы точно хотите удалить клиента {name}?", @"Удаление клиента", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res != DialogResult.Yes) return;
            
            try
            {
                MainForm.GetData($"delete from Customers where AccountID = '{accountId}'");
                
                customersTable.Rows.RemoveAt(customersTable.SelectedCells[0].RowIndex);
                _dataSet.AcceptChanges();
                MessageBox.Show(@"Вы успешно удалили клиента", @"Уведомление", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Connect();
            }
            catch
            {
                MessageBox.Show(@"Не удалось удалить клиента", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GoToMove(object sender, EventArgs e)
        {
            var accountId = customersTable[1, customersTable.SelectedCells[0].RowIndex].Value.ToString();
            
            var name = customersTable[2, customersTable.SelectedCells[0].RowIndex].Value + " " + customersTable[3, customersTable.SelectedCells[0].RowIndex].Value.ToString().Substring(0, 1) + "." + customersTable[4, customersTable.SelectedCells[0].RowIndex].Value.ToString().Substring(0, 1) + ".";
            var res = MessageBox.Show(this, $@"Вы точно хотите перенести клиента {name} в группу сотрудников?", @"Изменение прав клиента", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res != DialogResult.Yes) return;
            
            try
            {
                MainForm.GetData($"exec [dbo].[MoveCustomerToEmployee] '{accountId}'");
    
                customersTable.Rows.RemoveAt(customersTable.SelectedCells[0].RowIndex);
                _dataSet.AcceptChanges();
                MessageBox.Show(@"Вы успешно перенесли клиента в группу сотрудников", @"Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Connect();
            }
            catch
            {
                MessageBox.Show(@"Не удалось перенести клиента в группу сотрудников", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void seacher_TextChanged(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(_connect))
            {
                connection.Open();
                _sqlDataAdapter = new SqlDataAdapter($"select CustomerID, AccountID, LastName as [Фамилия], FirstName as [Имя], MiddleName as [Отчество], DateOfBith as [Дата рождения] from Customers where LastName like '%{seacher.Text.Trim()}%' or FirstName like '%{seacher.Text.Trim()}%' or MiddleName like '%{seacher.Text.Trim()}%' or DateOfBith like '%{seacher.Text.Trim()}%'", connection);
                _dataSet = new DataSet();
                _sqlDataAdapter.Fill(_dataSet);
                customersTable.DataSource = _dataSet.Tables[0];
            }
        }

        private void setNullSeacher_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            seacher.Text = Empty;
        }
    }
}
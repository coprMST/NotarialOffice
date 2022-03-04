using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.String;

namespace NotarialOffice
{
    public partial class EmployeesForm : Form
    {
        private readonly string _connect = $@"Data Source={MainForm.DataSource};Initial Catalog={MainForm.InitialCatalog};Integrated Security=True";
        private const string Query = @"select EmployeeID, E.AccountID, Email as [Почта], PhoneNumber as [Телефон], P.PositionName as [Должность], LastName as [Фамилия], FirstName as [Имя], MiddleName as [Отчество], DateOfBith as [Дата рождения] from Employees E inner join Accounts A on E.AccountID = A.AccountID left join Positions P on E.PositionID = P.PositionID";

        private DataSet _dataSet; 
        private SqlDataAdapter _sqlDataAdapter;

        public EmployeesForm()
        {
            InitializeComponent();
            
            using (var connection = new SqlConnection(_connect))
            {
                connection.Open();
                _sqlDataAdapter = new SqlDataAdapter(Query, connection);
                _dataSet = new DataSet();
                _sqlDataAdapter.Fill(_dataSet);
                employeesTable.DataSource = _dataSet.Tables[0];
                employeesTable.Columns[2].Width = 150;
            }
            
            employeesTable.Columns[0].Visible = false;
            employeesTable.Columns[1].Visible = false;
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
            var accountId = employeesTable[1, employeesTable.SelectedCells[0].RowIndex].Value.ToString();

            var name = employeesTable[5, employeesTable.SelectedCells[0].RowIndex].Value + " " + employeesTable[6, employeesTable.SelectedCells[0].RowIndex].Value.ToString().Substring(0, 1) + ".";
            if (!IsNullOrEmpty(employeesTable[7, employeesTable.SelectedCells[0].RowIndex].Value.ToString()))
                name += employeesTable[7, employeesTable.SelectedCells[0].RowIndex].Value.ToString().Substring(0, 1);
            
            if (accountId == MainForm.AccountId)
            {
                MessageBox.Show($@"Нельзя удалить себя.", @"Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            var res = MessageBox.Show($@"Вы точно хотите удалить сотрудника {name}?", @"Удаление",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (res != DialogResult.Yes) return;

            try
            {
                MainForm.GetData($"delete from Employees where AccountID = '{accountId}'");
                
                employeesTable.Rows.RemoveAt(employeesTable.SelectedCells[0].RowIndex);
                _dataSet.AcceptChanges();
                MessageBox.Show($@"Вы успешно удалили сотрудника {name}.", @"Уведомление", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Connect();
            }
            catch
            {
                MessageBox.Show($@"Не удалось удалить сотрудника {name}.", @"Ошибка", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void GoToMove(object sender, EventArgs e)
        {
            var accountId = employeesTable[1, employeesTable.SelectedCells[0].RowIndex].Value.ToString();
            
            var name = employeesTable[5, employeesTable.SelectedCells[0].RowIndex].Value + " " + employeesTable[6, employeesTable.SelectedCells[0].RowIndex].Value.ToString().Substring(0, 1) + ".";
            if (!IsNullOrEmpty(employeesTable[7, employeesTable.SelectedCells[0].RowIndex].Value.ToString()))
                name += employeesTable[7, employeesTable.SelectedCells[0].RowIndex].Value.ToString().Substring(0, 1) + ".";

            if (accountId == MainForm.AccountId)
            {
                MessageBox.Show($@"Нельзя перести себя в группу клиентов.", @"Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            var res = MessageBox.Show($@"Вы точно хотите перенести сотрудника {name} в группу клиентов?", 
                @"Изменение прав", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res != DialogResult.Yes) return;
            
            try
            {
                MainForm.GetData($"exec [dbo].[MoveEmployeeToCustomer] '{accountId}'");
    
                employeesTable.Rows.RemoveAt(employeesTable.SelectedCells[0].RowIndex);
                _dataSet.AcceptChanges();
                MessageBox.Show($@"Вы успешно перенесли сотрудника {name} в группу клиентов.", @"Уведомление",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Connect();
            }
            catch
            {
                MessageBox.Show($@"Не удалось перенести сотрудника {name} в группу клиентов.", @"Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void seacher_TextChanged(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(_connect))
            {
                connection.Open();
                _sqlDataAdapter = new SqlDataAdapter(Query + $" where PositionName like '%{seacher.Text.Trim()}%' or PhoneNumber like '%{seacher.Text.Trim()}%' or Email like '%{seacher.Text.Trim()}%' or LastName like '%{seacher.Text.Trim()}%' or FirstName like '%{seacher.Text.Trim()}%' or MiddleName like '%{seacher.Text.Trim()}%' or DateOfBith like '%{seacher.Text.Trim()}%'", connection);
                _dataSet = new DataSet();
                _sqlDataAdapter.Fill(_dataSet);
                employeesTable.DataSource = _dataSet.Tables[0];
            }
        }

        private void setNullSeacher_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            seacher.Text = Empty;
        }
    }
}
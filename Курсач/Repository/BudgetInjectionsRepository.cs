using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using CourseWork.Model;
using Dapper;
using MySql.Data.MySqlClient;

namespace CourseWork.Repository;

public class BudgetInjectionsRepository
{
    #region Fields

    private readonly string _connection;

    #endregion

    #region Constructor

    public BudgetInjectionsRepository(string connection)
    {
        _connection = connection;
        CheckDatabaseConnection();
    }

    #endregion

    #region Methods

    private bool CheckDatabaseConnection()
    {
        try
        {
            using (IDbConnection db = new MySqlConnection(_connection))
            {
                db.Open();
                return true;
            }
        }
        catch (Exception e)
        {
            MessageBox.Show("Подключение к базе данных недоступно" + e.Message);
            throw;
        }
    }
    
    
    public List<BudgetRecord> InspectBudgetRecords()
    {
        try
        {
            using (IDbConnection db = new MySqlConnection(_connection))
            {
                List<BudgetRecord> records = db.Query<BudgetRecord>("SELECT * from coursework.databudget").ToList();
                return records;
            }

        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
            throw;
        }
    }
    public List<BudgetRecord> GetRecordsByCategory(BudgetRecord budgetRecord)
    {
        try
        {
            using (IDbConnection db = new MySqlConnection(_connection))
            {
                List<BudgetRecord> records = db.Query<BudgetRecord>("SELECT * from coursework.databudget WHERE category = @category", budgetRecord).ToList();
                return records;
            }

        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
            throw;
        }
    }
    public bool AddBudgetRecord(BudgetRecord budgetRecord)
    {
        try
        {
            using (IDbConnection db = new MySqlConnection(_connection))
            {
                string sqlcom1 = "INSERT INTO databudget (sum, category, date) VALUES (@sum, @category, @date)";
                db.Execute(sqlcom1, budgetRecord);
            }
            return true;
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
            throw;
        }

    }

    public bool ClearBudgetRecords()
    {
        try
        {
            using (IDbConnection db = new MySqlConnection(_connection))
            {
                string sqlcom = "DELETE FROM databudget WHERE ID = @id";
                db.Execute(sqlcom);
                return true;
            }
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
            throw;
        }
    }

    public bool UpdateBudgetRecord(BudgetRecord budgetRecord)
    {
        try
        {
            using (IDbConnection db = new MySqlConnection(_connection))
            {
                string sqlcom = "UPDATE databudget SET sum = @sum, category = @category, date = @date WHERE ID = @id;";
                db.Execute(sqlcom, budgetRecord);
                return true;
            }
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
            throw;
        }
    }

    public bool DeleteBudgetRecord(BudgetRecord budgetRecord)
    {
        try
        {
            using (IDbConnection db = new MySqlConnection(_connection))
            {
                string sqlcom = "DELETE FROM databudget WHERE ID = @id;";
                db.Execute(sqlcom, budgetRecord);
                return true;
            }
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
            throw;
        }
    }

    public double GetFinalSum()
    {
        try
        {
            double sum = 0;
            using (IDbConnection db = new SqlConnection(_connection))
            {
                List<BudgetRecord> records = InspectBudgetRecords();
                
                foreach (var record in records)
                {
                    sum = sum + record.sum;
                }
            }
            return sum;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            throw;
        }
    }

    #endregion
    
}
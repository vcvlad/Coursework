using System.Data;
using MySql.Data.MySqlClient;
using programm;
using Курсовая_работа.Model;
using Dapper;

namespace Курсовая_работа.Repository;

public class BudgetInjectionsRepository
{
    #region Fields

    private readonly string _connection;

    #endregion

    #region Constructor

    public BudgetInjectionsRepository(string connection)
    {
        _connection = connection;
    }

    #endregion

    #region Methods

    public List<BudgetRecords> InspectBudgetRecords()
    {
        try
        {
            using (IDbConnection db = new MySqlConnection(_connection))
            {
                List<BudgetRecords> records = db.Query<BudgetRecords>("SELECT * from coursework.databudget").ToList();
                return records;
            }

        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
            throw;
        }
    }

    public bool AddBudgetRecord(BudgetRecords budgetRecord)
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

    public bool UpdateBudgetRecord(BudgetRecords budgetRecord)
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

    public bool DeleteBudgetRecord(BudgetRecords budgetRecord)
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

    #endregion
    
}
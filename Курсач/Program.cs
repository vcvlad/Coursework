using CourseWork.Windows;
using CourseWork.Repository;

namespace CourseWork
{
    internal static class Program
    {
        static void Main()
        {
            try
            {

                BudgetInjectionsRepository budgetInjectionsRepository =
                    new BudgetInjectionsRepository("Server=localhost;database=coursework;Uid=root;Pwd=root;");
                ApplicationConfiguration.Initialize();
                Application.Run(new Budget(budgetInjectionsRepository));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
using Курсовая_работа.Repository;

namespace programm
{
    internal static class Program
    {
        static void Main()
        {
            BudgetInjectionsRepository budgetInjectionsRepository = new BudgetInjectionsRepository("Server=localhost;database = coursework;Uid=root;Pwd=root;");
            ApplicationConfiguration.Initialize();
            Application.Run(new Budget(budgetInjectionsRepository));
        }
    }
}
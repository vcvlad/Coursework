using CourseWork.Model;
using CourseWork.Repository;

namespace CourseWork.Windows
{
    public partial class Recommendation : Form
    {
        private readonly BudgetInjectionsRepository _budgetInjectionsRepository;
        public Recommendation(BudgetInjectionsRepository budgetInjectionsRepository)
        {
            _budgetInjectionsRepository = budgetInjectionsRepository; 
            InitializeComponent();
        }


        private void Calculate_Click(object sender, EventArgs e)
        {
            double sum = _budgetInjectionsRepository.GetFinalSum();
            OutputNeeds.Text = (sum * 0.5d).ToString();
            OutputWishes.Text = (sum * 0.3d).ToString();
            OutputBank.Text = (sum * 0.2d).ToString();
            
        }
    }
}

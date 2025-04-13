using CourseWork.Model;
using CourseWork.Repository;

namespace CourseWork.Windows
{
    public partial class ChangeBudget : Form
    {
        private BudgetRecord _budgetRecord;
        private readonly BudgetInjectionsRepository _budgetInjectionsRepository;
        
        public ChangeBudget(BudgetRecord budgetRecord, BudgetInjectionsRepository budgetInjectionsRepository)
        
        {
            _budgetRecord = budgetRecord;
            _budgetInjectionsRepository = budgetInjectionsRepository; 
            InitializeComponent();
        }

        public BudgetRecord BudgetRecord
        {
            get => _budgetRecord;
            set => _budgetRecord = value;
        }
        
        private void ChangeBudget_Load(object sender, EventArgs e)
        {
            Sum.Text = _budgetRecord.sum.ToString();
            Category.Text = _budgetRecord.category;
            Date.Value = _budgetRecord.date; 
            
            if (int.Parse(Sum.Text) < 0)
            {
                Consump.Checked = true;
                Sum.Text = (int.Parse(Sum.Text) * -1).ToString();
            }
            else
            {
                Income.Checked = true;
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите изменить данные?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    double sum = double.Parse(Sum.Text);
                    if (Consump.Checked == true)
                    {
                        sum = sum * -1;
                    }
                    if (_budgetInjectionsRepository.UpdateBudgetRecord(new BudgetRecord()
                        {
                            category = Category.Text,
                            date = Date.Value,
                            sum = sum,
                            ID = _budgetRecord.ID,
                        })) ;
                    {
                        this.Close();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    throw;
                }
            }
        }

        private void Consump_CheckedChanged(object sender, EventArgs e)
        {
            if (Consump.Checked == true)
            {
                Income.Checked = false;

            }
        }

        private void Income_CheckedChanged(object sender, EventArgs e)
        {
            if (Income.Checked == true)
            {
                Consump.Checked = false;
            }
        }
        
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

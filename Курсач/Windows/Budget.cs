using CourseWork.Model;
using CourseWork.Repository;

namespace CourseWork.Windows
{

    public partial class Budget : Form
    {
        private readonly BudgetInjectionsRepository _budgetInjectionsRepository;
        public Budget(BudgetInjectionsRepository budgetInjectionsRepository)
        {
            _budgetInjectionsRepository = budgetInjectionsRepository;
            InitializeComponent();

        }
        private void Budget_Load(object sender, EventArgs e)
        {



            var SumColumn = new DataGridViewColumn();
            SumColumn.HeaderText = "Сумма";
            SumColumn.ReadOnly = true;
            SumColumn.Name = "sum";
            SumColumn.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView1.Columns.Add(SumColumn);

            var CategoryColumn = new DataGridViewColumn();
            CategoryColumn.HeaderText = "Категория";
            CategoryColumn.ReadOnly = true;
            CategoryColumn.Name = "category";
            CategoryColumn.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView1.Columns.Add(CategoryColumn);

            var DateColumn = new DataGridViewColumn();
            DateColumn.HeaderText = "Дата";
            DateColumn.ReadOnly = true;
            DateColumn.Name = "Date";
            DateColumn.CellTemplate = new DataGridViewTextBoxCell();
            DateColumn.Width = 200;
            dataGridView1.Columns.Add(DateColumn);

            var IdColumn = new DataGridViewColumn();
            IdColumn.ReadOnly = true;
            IdColumn.Visible = false;
            IdColumn.Name = "ID";
            IdColumn.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView1.Columns.Add(IdColumn);

            LoadRecords();
        }

        private void LoadRecords()
        {
            dataGridView1.Rows.Clear();
            try
            {
                List<BudgetRecord> records = _budgetInjectionsRepository.InspectBudgetRecords();
                foreach (var record in records)
                {
                    dataGridView1.Rows.Add(record.sum, record.category, record.date, record.ID);
                }

                double sum = _budgetInjectionsRepository.GetFinalSum();
                CurrentSum.Text = sum.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

        public void Add_Click(object sender, EventArgs e)
        {

            var form2 = new AddBudget(_budgetInjectionsRepository);
            form2.Show();
            form2.Closed += OnFormClosed;
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadRecords();
        }
        
        private void Clear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите очистить данные?", "Подтверждение",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                dataGridView1.Rows.Clear();

                CurrentSum.Clear();
                try
                {
                    _budgetInjectionsRepository.ClearBudgetRecords();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
            }
        }
        
        private void ChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int budgetRecordId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
            string category = dataGridView1.CurrentRow.Cells["category"].Value.ToString();
            DateTime date  = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["date"].Value);
            double sum = Convert.ToDouble(dataGridView1.CurrentRow.Cells["sum"].Value);
                    
            
            ChangeBudget frm3 = new ChangeBudget(new BudgetRecord() 
                { category = category, date = date, ID = budgetRecordId, sum = sum }, _budgetInjectionsRepository);
            frm3.Show();
            frm3.Closed += OnFormClosed;
        }
        
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите удалить данные?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }

                try
                {
                    _budgetInjectionsRepository.DeleteBudgetRecord(new BudgetRecord() {ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value)});
                    LoadRecords();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    throw;
                }
            }
        }

        private void Recommendation_Click(object sender, EventArgs e)
        {
            Recommendation frm4 = new Recommendation(_budgetInjectionsRepository);
            frm4.Show();
        }

        private void CategoryData_Click(object sender, EventArgs e)
        {
            CategoryData frm = new CategoryData(_budgetInjectionsRepository);
            frm.Show();
        }
    }
}

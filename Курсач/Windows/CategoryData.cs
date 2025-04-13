using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсовая_работа.Model;
using Курсовая_работа.Repository;

namespace Курсовая_работа
{
    public partial class CategoryData : Form
    {
        private readonly BudgetInjectionsRepository _budgetInjectionsRepository;
        
        public CategoryData(BudgetInjectionsRepository budgetInjectionsRepository)
        {
            _budgetInjectionsRepository = budgetInjectionsRepository;
            InitializeComponent();
        }
        
        private void CategoryData_Load(object sender, EventArgs e)
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
            dataGridView1.Columns.Add(DateColumn);

            var IdColumn = new DataGridViewColumn();
            IdColumn.ReadOnly = true;
            IdColumn.Visible = false;
            IdColumn.Name = "ID";
            IdColumn.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView1.Columns.Add(IdColumn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                List<BudgetRecords> records = _budgetInjectionsRepository.InspectBudgetRecords();
                foreach (var record in records)
                {
                    dataGridView1.Rows.Add(record.sum, record.category, record.date, record.ID);
                    double sum = 0; 
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        sum = sum + Convert.ToDouble(dataGridView1[0, i].Value);
                    }
                    
                    textBox1.Text = sum.ToString() + " р.";
                }


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
            
            
        }
    }
}

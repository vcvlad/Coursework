using Accessibility;
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

namespace programm
{
    public partial class AddBudget : Form
    {
        private readonly BudgetInjectionsRepository _budgetInjectionsRepository;
        public AddBudget(BudgetInjectionsRepository budgetInjectionsRepository)
        {
            _budgetInjectionsRepository = budgetInjectionsRepository;
            InitializeComponent();
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
        
        private void Add_Click(object sender, EventArgs e)
        {
            double buff = double.Parse(Sum.Text);
            if (Consump.Checked == true)
            {
                buff = buff * -1;
            }

            try
            {
                if (_budgetInjectionsRepository.AddBudgetRecord(new BudgetRecords()
                    {
                        sum = buff,
                        category = Category.Text,
                        date = date.Value,
                    }))
                {
                    DialogResult = MessageBox.Show("Расход/доход успешно добавлен", "Успех", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

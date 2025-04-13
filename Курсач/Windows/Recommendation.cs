using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class Recommendation : Form
    {
        public Recommendation()
        {
            InitializeComponent();
        }


        private void Calculate_Click(object sender, EventArgs e)
        {
            OutputNeeds.Text = (double.Parse(Input.Text) * 0.5d).ToString();
            OutputWishes.Text = (double.Parse(Input.Text) * 0.3d).ToString();
            OutputBank.Text = (double.Parse(Input.Text) * 0.2d).ToString();
            
        }
    }
}

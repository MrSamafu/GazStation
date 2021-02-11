using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carburant
{
    public partial class ClavierNum : UserControl
    {
        public delegate void DelegateBtn(string button);
        public event DelegateBtn clickButton;
        public ClavierNum()
        {
            InitializeComponent();
        }

        private void ClavierNum_Load(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (clickButton != null)
            {
                clickButton(((Button)sender).Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clickButton != null)
            {
                clickButton(((Button)sender).Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clickButton != null)
            {
                clickButton(((Button)sender).Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (clickButton != null)
            {
                clickButton(((Button)sender).Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (clickButton != null)
            {
                clickButton(((Button)sender).Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (clickButton != null)
            {
                clickButton(((Button)sender).Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (clickButton != null)
            {
                clickButton(((Button)sender).Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (clickButton != null)
            {
                clickButton(((Button)sender).Text);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (clickButton != null)
            {
                clickButton(((Button)sender).Text);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (clickButton != null)
            {
                clickButton(((Button)sender).Text);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (clickButton != null)
            {
                clickButton(((Button)sender).Text);
            }
        }

        private void buttonCorrecct_Click(object sender, EventArgs e)
        {
            if (clickButton != null)
            {
                clickButton(((Button)sender).Text);
            }
        }

        private void buttonValid_Click(object sender, EventArgs e)
        {
            if (clickButton != null)
            {
                clickButton(((Button)sender).Text);
            }
        }
    }
}

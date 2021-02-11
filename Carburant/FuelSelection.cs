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
    public partial class FuelSelection : UserControl
    {
        public delegate void DelegateBtn(string button,float price);
        public event DelegateBtn clickButton;
        public FuelSelection()
        {
            InitializeComponent();
        }

        private void FuelSelection_Load(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(clickButton != null)
            {
                clickButton(((Button)sender).Text,0f);
            }
        }

        private void buttonSP98_Click(object sender, EventArgs e)
        {
            if (clickButton != null)
            {
                clickButton(((Button)sender).Text,1.329f);
            }
        }

        private void buttonE10_Click(object sender, EventArgs e)
        {
            if (clickButton != null)
            {
                clickButton(((Button)sender).Text,1.279f);
            }
        }

        private void buttonGazole_Click(object sender, EventArgs e)
        {
            if (clickButton != null)
            {
                clickButton(((Button)sender).Text,1.169f);
            }
        }
    }
}

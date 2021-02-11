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
    public partial class Form2 : Form
    {
        public delegate void DelegateBtn(string button);
        public event DelegateBtn clickButton;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonCard_Click(object sender, EventArgs e)
        {
            if (clickButton != null)
            {
                clickButton(((Button)sender).Text);
            }
            if(buttonCard.Text == "Card Off")
            {
                buttonCard.Text = "Card On";
            }
            else if(buttonCard.Text == "Card On")
            {
                buttonCard.Text = "Card Off";
            }
        }

        private void buttonFuelGun_Click(object sender, EventArgs e)
        {
            if (clickButton != null)
            {
                clickButton(((Button)sender).Text);
            }
            if (buttonFuelGun.Text == "Gun Off")
            {
                buttonFuelGun.Text = "Gun On";
            }
            else if (buttonFuelGun.Text == "Gun On")
            {
                buttonFuelGun.Text = "Gun Off";
            }
        }
    }
}

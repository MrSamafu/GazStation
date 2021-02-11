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
    public partial class TicketSelection : UserControl
    {
        public delegate void DelegateBtn(string button);
        public event DelegateBtn clickButton;
        public TicketSelection()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (clickButton != null)
            {
                clickButton(((Button)sender).Text);
            }
        }

        private void buttonTicket_Click(object sender, EventArgs e)
        {
            if (clickButton != null)
            {
                clickButton(((Button)sender).AccessibleName);
            }
        }

        private void buttonTicket2_Click(object sender, EventArgs e)
        {
            if (clickButton != null)
            {
                clickButton(((Button)sender).AccessibleName);
            }
        }

        private void buttonWithoutTicket_Click(object sender, EventArgs e)
        {
            if (clickButton != null)
            {
                clickButton(((Button)sender).AccessibleName);
            }
        }

        private void TicketSelection_Load(object sender, EventArgs e)
        {

        }
    }
}

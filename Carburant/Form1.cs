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
    public partial class Form1 : Form
    {
        public Form2 externalAction = new Form2();
        public bool card = false;
        public bool gun = false;
        public bool payementAccept = false;
        public bool fuelSelect = false;
        public float price;
        public string fuelName;
        public string code;
        public int ticket;
        public Form1()
        {
            InitializeComponent();
            externalAction.Show();
            fuelSelection1.Visible = false;
            ticketSelection1.Visible = false;
            clavierNum1.Visible = false;
            externalAction.clickButton += ExternalAction_clickButton;
            fuelSelection1.clickButton += FuelSelection1_clickButton;
            clavierNum1.clickButton += ClavierNum1_clickButton;
            ticketSelection1.clickButton += TicketSelection1_clickButton;
        }

        private void TicketSelection1_clickButton(string button)
        {
            switch (button)
            {
                //a changer
                case "Annuler":
                    ticketSelection1.Visible = false;
                    labelGeneral.Text = "Veuillez retirer votre carte et vous servir";
                    break;
                case "ticket":
                    ticket = 1;
                    ticketSelection1.Visible = false;
                    labelGeneral.Text = "Veuillez retirer votre carte et vous servir";
                    break;
                case "ticket2":
                    ticket = 2;
                    ticketSelection1.Visible = false;
                    labelGeneral.Text = "Veuillez retirer votre carte et vous servir";
                    break;
                case "noTicket":
                    ticket = 0;
                    ticketSelection1.Visible = false;
                    labelGeneral.Text = "Veuillez retirer votre carte et vous servir";
                    break;
            }
        }

        private void ClavierNum1_clickButton(string button)
        {
            switch (button)
            {
                case "Annuler":
                    card = false;
                    gun = false;
                    payementAccept = false;
                    price = 0f;
                    fuelName = "";
                    code = "";
                    labelCode.Text = code;
                    break;
                case "Corriger":
                    if(code.Length > 0)
                    {
                        code = code.Remove(code.Length - 1);
                        labelCode.Text = code;
                    }
                    break;
                case "Valider":
                        if(code == "3848")
                    {
                        payementAccept = true;
                        clavierNum1.Visible = false;
                        ticketSelection1.Visible = true;
                        code = "";
                        labelCode.Text = code;
                        labelGeneral.Text = "Voulez vous un ticket ?";
                    }
                    else
                    {
                        labelGeneral.Text = "Mauvais code";
                        code = "";
                        labelCode.Text = code;
                    }
                    break;
                default:
                    code += button;
                    labelCode.Text = code;
                    break;
            }
        }

        private void FuelSelection1_clickButton(string button, float price)
        {
            fuelSelect = true;
            this.price = price;
            fuelName = button;
            fuelSelection1.Visible = false;
            clavierNum1.Visible = true;
            labelGeneral.Text = fuelName + " " + price + " €/L\nVeuillez entrer votre code.";
        }

        private void ExternalAction_clickButton(string button)
        {
            if (!fuelSelect && !payementAccept)
            {
                if(button == "Gun Off")
                {
                    labelGeneral.Text = "Veuillez raccrocher le pistolet \n et inserer d'abord votre carte.";
                    gun = true;
                }
                if(button == "Gun On")
                {
                    labelGeneral.Text = "Inserer votre carte.";
                    gun = false;
                }
                else if(button == "Card Off")
                {
                    labelGeneral.Text = "Sélectionnez votre carburant";
                    card = true;
                    fuelSelection1.Visible = true;
                    
                }
                else if(button == "Card On")
                {
                    fuelSelection1.Visible = false;
                    card = false;
                    labelGeneral.Text = "Erreur carte arraché";
                }
            }
            else if (fuelSelect && payementAccept)
            {
                if (button == "Gun Off")
                {
                    if (!card)
                    {
                        labelGeneral.Text = "Servez vous jusqu'à plus soif";
                        gun = true;
                    }
                    else
                    {
                        labelGeneral.Text = "Retirez votre carte.";
                        gun = true;
                    }
                }
                if (button == "Gun On")
                {
                    labelGeneral.Text = "Merci de votre visite";
                    gun = false;
                }
                else if (button == "Card Off")
                {
                    labelGeneral.Text = "retirez votre carte";
                    card = true;
                }
                else if (button == "Card On")
                {
                    labelGeneral.Text = "Servez vous jusqu'à plus soif";
                    card = false;
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void reloadFuelStation()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airport
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FlightButton_Click(object sender, EventArgs e)
        {
            FlightsForm flightsForm = new FlightsForm();
            flightsForm.ShowDialog(); // Показываем форму как диалог
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.ShowDialog(); // Показываем форму как диалог
        }
    }
}

using ControlProteinasClient.RegistroProteinas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ControlProteinasClient
{
    public partial class ControlProteinasForm : Form
    {
        private RegistroProteinasServicesSoapClient service = new RegistroProteinasServicesSoapClient();
        private User[] users;
        public ControlProteinasForm()
        {
            InitializeComponent();
        }

        private void Onload(object sender, EventArgs e)
        {
            users = service.listUsers();
            cmbuser.DataSource = users;
            cmbuser.DisplayMember = "Name";
            cmbuser.ValueMember = "UserId";
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            service.AddUser(txtName.Text, int.Parse(txtGoal.Text));
            users = service.listUsers();
            cmbuser.DataSource = users;
            CleanText();
        }

        private void CleanText()
        {
            txtName.Text = "";
            txtGoal.Text = "";
            txtProtein.Text = "";
        }

        private void OnUserChanged(object sender, EventArgs e)
        {
            var index = cmbuser.SelectedIndex;
            lbltotal.Text = users[index].Total.ToString();
            lblGoal.Text = users[index].Goal.ToString();
        }

        private void AddProtein_Click(object sender, EventArgs e)
        {
            var userId = users[cmbuser.SelectedIndex].UserId;
            var newTotal = service.AddProtein(int.Parse(txtProtein.Text), userId);
            users[cmbuser.SelectedIndex].Total = newTotal;
            lbltotal.Text = newTotal.ToString();

        }
    }
}

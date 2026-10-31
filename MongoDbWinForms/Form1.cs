using MongoDbWinForms.Entities;
using MongoDbWinForms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDbWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigureVisuals();
            ConfigureCustomerGrid();
            btnClear.Click += btnClear_Click;
        }

        private void ConfigureCustomerGrid()
        {
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.Columns[0].DataPropertyName = "CustomerId";
            dgvCustomers.Columns[0].HeaderText = "ID";
            dgvCustomers.Columns[1].DataPropertyName = "CustomerName";
            dgvCustomers.Columns[1].HeaderText = "Ad";
            dgvCustomers.Columns[2].DataPropertyName = "CustomerCity";
            dgvCustomers.Columns[2].HeaderText = "Şehir";
            dgvCustomers.Columns[3].DataPropertyName = "CustomerBalance";
            dgvCustomers.Columns[3].HeaderText = "Bakiye";

            DataGridViewTextBoxColumn surnameColumn = new DataGridViewTextBoxColumn
            {
                Name = "CustomerSurname",
                HeaderText = "Soyad",
                DataPropertyName = "CustomerSurname"
            };
            DataGridViewTextBoxColumn shoppingCountColumn = new DataGridViewTextBoxColumn
            {
                Name = "CustomerShoppingCount",
                HeaderText = "Alışveriş sayısı",
                DataPropertyName = "CustomerShoppingCount"
            };

            dgvCustomers.Columns.Insert(2, surnameColumn);
            dgvCustomers.Columns.Add(shoppingCountColumn);
        }

        private void ConfigureVisuals()
        {
            Label[] fieldLabels =
            {
                lblCustomerId,
                lblCustomerName,
                lblCustomerSurname,
                lblCustomerCity,
                lblBalance,
                lblPurchaseAmount
            };

            foreach (Label label in fieldLabels)
            {
                label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                label.ForeColor = Color.FromArgb(80, 94, 117);
            }

            Button[] buttons =
            {
                btnDashboard,
                btnCustomers,
                btnSettings,
                btnList,
                btnAdd,
                btnDelete,
                btnUpdate,
                btnClear
            };

            foreach (Button button in buttons)
            {
                button.Cursor = Cursors.Hand;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerId.Clear();
            txtCustomerName.Clear();
            txtCustomerSurname.Clear();
            txtCustomerCity.Clear();
            txtBalance.Clear();
            txtPurchaseAmount.Clear();
            txtCustomerId.Focus();
        }

        CustomerOperations customerOperations = new CustomerOperations();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                CustomerName = txtCustomerName.Text,
                CustomerSurname = txtCustomerSurname.Text,
                CustomerCity = txtCustomerCity.Text,
                CustomerBalance = decimal.Parse(txtBalance.Text),
                CustomerShoppingCount = int.Parse(txtPurchaseAmount.Text)
            };

            customerOperations.AddCustomer(customer);
            MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<Customer> customers = customerOperations.GetAllCustomer();
            dgvCustomers.DataSource = customers;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string customerId = txtCustomerId.Text;
            customerOperations.DeleteCustomer(customerId);

            MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string customerId = txtCustomerId.Text;
            customerOperations.UpdateCustomer(new Customer
            {
                CustomerId = customerId,
                CustomerName = txtCustomerName.Text,
                CustomerSurname = txtCustomerSurname.Text,
                CustomerCity = txtCustomerCity.Text,
                CustomerBalance = decimal.Parse(txtBalance.Text),
                CustomerShoppingCount = int.Parse(txtPurchaseAmount.Text)
            });
            MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
           string id = txtCustomerId.Text;
            Customer customers = customerOperations.GetCustomerById(id);
            dgvCustomers.DataSource = new List<Customer> { customers };

        }
    }
}

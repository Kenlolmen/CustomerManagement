namespace CustomerCRUD
{
    public partial class Form1 : Form
    {
        CustomerContext customerDB;
        List<Customer> customerList;
        public Form1()
        {

            customerDB = new CustomerContext();
            InitializeComponent();
            listView1.View = View.List;

            customerList = customerDB.Customers.Select(c => c).ToList();
        }

        private void ShowCustomers()
        {
            listView1.Items.Clear();

            foreach (Customer customer in customerList)
            {
                var listViewItem = new ListViewItem(customer.ToString())
                {
                    Tag = customer
                };
                listView1.Items.Add(listViewItem);
            }
        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMinBudget_Click(object sender, EventArgs e)
        {
            float minBudgetSearch = float.Parse(textMinBudget.Text);

            var filteredCustomers = customerDB.Customers
                .Where(c => c.Budget >= minBudgetSearch)
                .ToList();

            listView1.Items.Clear();

            foreach (var customer in filteredCustomers)
            {
                listView1.Items.Add(customer.ToString());
            }

            textMinBudget.Text = "";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void buttonSearchID_button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            Customer? cust = customerDB.Customers.Where(c => c.ID == id).FirstOrDefault();

            listView1.Items.Clear();

            if (cust != null)
            {
                listView1.Items.Add(cust.ToString());
            }
            textID.Text = "";

        }
        private void EnterId_Click(object sender, EventArgs e) { }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void Select_Click(object sender, EventArgs e) { }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            Customer AddCustomer = new Customer()
            {
                Name = textBoxName.Text,
                Adress = textBoxAddress.Text,
                Email = textBoxEmail.Text,
                PhoneNumber = long.Parse(textBoxPhone.Text),
                Budget = int.Parse(textBoxBudget.Text)
            };

            customerDB.Customers.Add(AddCustomer);
            customerDB.SaveChanges();

            customerList.Add(AddCustomer);

            //  listView1.Items.Clear();
            var listViewItem = new ListViewItem(AddCustomer.ToString())
            {
                Tag = AddCustomer
            };
            listView1.Items.Add(listViewItem);

            textBoxName.Text = "";
            textBoxAddress.Text = "";
            textBoxEmail.Text = "";
            textBoxPhone.Text = "";
            textBoxBudget.Text = "";

        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            ShowCustomers();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];

                // Sprawdzenie, czy Tag jest typu Customer
                if (selectedItem.Tag is Customer selectedCustomer)
                {
                    // Wype³nij pola tekstowe danymi klienta
                    textBoxEditName.Text = selectedCustomer.Name;
                    textBoxEditAddress.Text = selectedCustomer.Adress;
                    textBoxEditEmail.Text = selectedCustomer.Email;
                    textBoxEditPhone.Text = selectedCustomer.PhoneNumber.ToString();
                    textBoxEditBudget.Text = selectedCustomer.Budget.ToString();
                }
                else
                {
                    MessageBox.Show("The selected item is not a customer.");
                }
            }
            else if (listView1.SelectedItems.Count > 1)
            {
                MessageBox.Show("Select only one customer.");
            }
            else
            {
                MessageBox.Show("Select customer. ");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];


                if (selectedItem.Tag is Customer selectedCustomer)
                {

                    selectedCustomer.Name = textBoxEditName.Text;
                    selectedCustomer.Adress = textBoxEditAddress.Text;
                    selectedCustomer.Email = textBoxEditEmail.Text;
                    selectedCustomer.PhoneNumber = long.Parse(textBoxEditPhone.Text);
                    selectedCustomer.Budget = int.Parse(textBoxEditBudget.Text);


                    customerDB.Customers.Update(selectedCustomer);
                    customerDB.SaveChanges();

                    textBoxEditName.Text = "";
                    textBoxEditAddress.Text = "";
                    textBoxEditEmail.Text = "";
                    textBoxEditPhone.Text = "";
                    textBoxEditBudget.Text = "";
                    ShowCustomers();


                    MessageBox.Show("Customer data has been saved.");
                }
                else
                {
                    MessageBox.Show("The selected item is not a customer.");
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to save changes.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];

                
                if (selectedItem.Tag is Customer selectedCustomer)
                {
                    
                    customerDB.Customers.Remove(selectedCustomer);
                    customerDB.SaveChanges();

                    // Remove customer from local list
                    customerList.Remove(selectedCustomer);

                    // Remove item directly from listView1
                    listView1.Items.Remove(selectedItem);

                    MessageBox.Show("Customer has been deleted.");
                }
                else
                {
                    MessageBox.Show("The selected item is not a customer.");
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }
        }

    }
}

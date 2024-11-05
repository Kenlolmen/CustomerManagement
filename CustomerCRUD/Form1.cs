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
                listView1.Items.Add(customer.ToString());
            }
        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMinBudget_Click(object sender, EventArgs e)
        {
            float minBudgetSearch = float.Parse(textMinBudget.Text);
            customerList = customerDB.Customers
                .Where(c => c.Budget >= minBudgetSearch)
                .Select(c => c).ToList();
            ShowCustomers();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearchID_button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            Customer? cust = customerDB.Customers.Where(c => c.ID == id).FirstOrDefault();

            listView1.Items.Clear();

            if (cust != null)
            {
                listView1.Items.Add(cust.ToString());
            }

        }
        private void EnterId_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Select_Click(object sender, EventArgs e)
        {

        }

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

            listView1.Items.Clear();
            listView1.Items.Add(AddCustomer.ToString());

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
                    MessageBox.Show("Wybrany element nie jest klientem."); // Informacja o b³êdzie
                }
            }
            else if(listView1.SelectedItems.Count > 1)
            {
                MessageBox.Show("Wybierz tylko 1 klienta do edycji.");
            }
            else
            {
                MessageBox.Show("Wybierz klienta do edycji.");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
    }
}

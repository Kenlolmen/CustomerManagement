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

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMinBudget_Click(object sender, EventArgs e)
        {
            float minBudgetSearch = float.Parse(textMinBudget.Text);
            customerList = customerDB.Customers
                .Where(c => c.Budget > minBudgetSearch)
                .Select(c => c).ToList();
            listView1.Items.Clear();

            foreach (Customer customer in customerList)
            {
                listView1.Items.Add(customer.ToString());
            }
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
    }
}

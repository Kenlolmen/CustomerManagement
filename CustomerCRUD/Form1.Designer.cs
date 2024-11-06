namespace CustomerCRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EnterminBudget = new Label();
            textMinBudget = new TextBox();
            buttonMinBudget = new Button();
            buttonSearchID = new Button();
            textID = new TextBox();
            EnterId = new Label();
            listView1 = new ListView();
            Select = new Label();
            textBoxName = new TextBox();
            labelCustName = new Label();
            textBoxAddress = new TextBox();
            labelCustAddress = new Label();
            textBoxEmail = new TextBox();
            labelCustEmail = new Label();
            textBoxBudget = new TextBox();
            labelCustBudg = new Label();
            textBoxPhone = new TextBox();
            labelCustPhone = new Label();
            Create = new Label();
            buttonAddCustomer = new Button();
            ShowAllButton = new Button();
            buttonSave = new Button();
            label1 = new Label();
            textBoxEditPhone = new TextBox();
            labelEditPhone = new Label();
            textBoxEditBudget = new TextBox();
            labelEditBudget = new Label();
            textBoxEditEmail = new TextBox();
            labelEditEmail = new Label();
            textBoxEditAddress = new TextBox();
            labelEditAddress = new Label();
            textBoxEditName = new TextBox();
            labelEditName = new Label();
            buttonEdit = new Button();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // EnterminBudget
            // 
            EnterminBudget.AutoSize = true;
            EnterminBudget.Location = new Point(30, 34);
            EnterminBudget.Name = "EnterminBudget";
            EnterminBudget.Size = new Size(137, 15);
            EnterminBudget.TabIndex = 1;
            EnterminBudget.Text = "Enter minimum budget: ";
            // 
            // textMinBudget
            // 
            textMinBudget.Location = new Point(173, 31);
            textMinBudget.Name = "textMinBudget";
            textMinBudget.Size = new Size(97, 23);
            textMinBudget.TabIndex = 2;
            // 
            // buttonMinBudget
            // 
            buttonMinBudget.Location = new Point(296, 34);
            buttonMinBudget.Name = "buttonMinBudget";
            buttonMinBudget.Size = new Size(75, 23);
            buttonMinBudget.TabIndex = 3;
            buttonMinBudget.Text = "Search";
            buttonMinBudget.UseVisualStyleBackColor = true;
            buttonMinBudget.Click += buttonMinBudget_Click;
            // 
            // buttonSearchID
            // 
            buttonSearchID.Location = new Point(226, 60);
            buttonSearchID.Name = "buttonSearchID";
            buttonSearchID.Size = new Size(75, 23);
            buttonSearchID.TabIndex = 9;
            buttonSearchID.Text = "Search";
            buttonSearchID.UseVisualStyleBackColor = true;
            buttonSearchID.Click += buttonSearchID_button1_Click;
            // 
            // textID
            // 
            textID.Location = new Point(99, 60);
            textID.Name = "textID";
            textID.Size = new Size(97, 23);
            textID.TabIndex = 8;
            textID.TextChanged += textID_TextChanged;
            // 
            // EnterId
            // 
            EnterId.AutoSize = true;
            EnterId.Location = new Point(30, 63);
            EnterId.Name = "EnterId";
            EnterId.Size = new Size(63, 15);
            EnterId.TabIndex = 7;
            EnterId.Text = "Enter ID :   ";
            EnterId.Click += EnterId_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(446, 20);
            listView1.Name = "listView1";
            listView1.Size = new Size(805, 346);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Select
            // 
            Select.AutoSize = true;
            Select.Location = new Point(30, 9);
            Select.Name = "Select";
            Select.Size = new Size(45, 15);
            Select.TabIndex = 11;
            Select.Text = "SELECT";
            Select.Click += Select_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(173, 136);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(146, 23);
            textBoxName.TabIndex = 13;
            // 
            // labelCustName
            // 
            labelCustName.AutoSize = true;
            labelCustName.Location = new Point(30, 139);
            labelCustName.Name = "labelCustName";
            labelCustName.Size = new Size(130, 15);
            labelCustName.TabIndex = 12;
            labelCustName.Text = "Enter Customer Name: ";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(173, 170);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(146, 23);
            textBoxAddress.TabIndex = 16;
            // 
            // labelCustAddress
            // 
            labelCustAddress.AutoSize = true;
            labelCustAddress.Location = new Point(30, 173);
            labelCustAddress.Name = "labelCustAddress";
            labelCustAddress.Size = new Size(143, 15);
            labelCustAddress.TabIndex = 15;
            labelCustAddress.Text = "Enter Customer Address:  ";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(173, 204);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(146, 23);
            textBoxEmail.TabIndex = 19;
            // 
            // labelCustEmail
            // 
            labelCustEmail.AutoSize = true;
            labelCustEmail.Location = new Point(30, 207);
            labelCustEmail.Name = "labelCustEmail";
            labelCustEmail.Size = new Size(127, 15);
            labelCustEmail.TabIndex = 18;
            labelCustEmail.Text = "Enter Customer Email: ";
            // 
            // textBoxBudget
            // 
            textBoxBudget.Location = new Point(173, 235);
            textBoxBudget.Name = "textBoxBudget";
            textBoxBudget.Size = new Size(97, 23);
            textBoxBudget.TabIndex = 22;
            // 
            // labelCustBudg
            // 
            labelCustBudg.AutoSize = true;
            labelCustBudg.Location = new Point(30, 238);
            labelCustBudg.Name = "labelCustBudg";
            labelCustBudg.Size = new Size(136, 15);
            labelCustBudg.TabIndex = 21;
            labelCustBudg.Text = "Enter Customer Budget: ";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(173, 269);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(110, 23);
            textBoxPhone.TabIndex = 25;
            // 
            // labelCustPhone
            // 
            labelCustPhone.AutoSize = true;
            labelCustPhone.Location = new Point(30, 272);
            labelCustPhone.Name = "labelCustPhone";
            labelCustPhone.Size = new Size(132, 15);
            labelCustPhone.TabIndex = 24;
            labelCustPhone.Text = "Enter Customer Phone: ";
            // 
            // Create
            // 
            Create.AutoSize = true;
            Create.Location = new Point(30, 114);
            Create.Name = "Create";
            Create.Size = new Size(47, 15);
            Create.TabIndex = 27;
            Create.Text = "CREATE";
            // 
            // buttonAddCustomer
            // 
            buttonAddCustomer.Location = new Point(323, 238);
            buttonAddCustomer.Name = "buttonAddCustomer";
            buttonAddCustomer.Size = new Size(108, 54);
            buttonAddCustomer.TabIndex = 28;
            buttonAddCustomer.Text = "ADD";
            buttonAddCustomer.UseVisualStyleBackColor = true;
            buttonAddCustomer.Click += buttonAddCustomer_Click;
            // 
            // ShowAllButton
            // 
            ShowAllButton.Location = new Point(1128, 382);
            ShowAllButton.Name = "ShowAllButton";
            ShowAllButton.Size = new Size(123, 36);
            ShowAllButton.TabIndex = 29;
            ShowAllButton.Text = "Show All";
            ShowAllButton.UseVisualStyleBackColor = true;
            ShowAllButton.Click += ShowAllButton_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(323, 458);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(108, 54);
            buttonSave.TabIndex = 41;
            buttonSave.Text = "SAVE";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 334);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 40;
            label1.Text = "EDIT";
            // 
            // textBoxEditPhone
            // 
            textBoxEditPhone.Location = new Point(173, 489);
            textBoxEditPhone.Name = "textBoxEditPhone";
            textBoxEditPhone.Size = new Size(110, 23);
            textBoxEditPhone.TabIndex = 39;
            // 
            // labelEditPhone
            // 
            labelEditPhone.AutoSize = true;
            labelEditPhone.Location = new Point(30, 492);
            labelEditPhone.Name = "labelEditPhone";
            labelEditPhone.Size = new Size(125, 15);
            labelEditPhone.TabIndex = 38;
            labelEditPhone.Text = "Edit Customer Phone: ";
            // 
            // textBoxEditBudget
            // 
            textBoxEditBudget.Location = new Point(173, 455);
            textBoxEditBudget.Name = "textBoxEditBudget";
            textBoxEditBudget.Size = new Size(97, 23);
            textBoxEditBudget.TabIndex = 37;
            // 
            // labelEditBudget
            // 
            labelEditBudget.AutoSize = true;
            labelEditBudget.Location = new Point(30, 458);
            labelEditBudget.Name = "labelEditBudget";
            labelEditBudget.Size = new Size(129, 15);
            labelEditBudget.TabIndex = 36;
            labelEditBudget.Text = "Edit Customer Budget: ";
            // 
            // textBoxEditEmail
            // 
            textBoxEditEmail.Location = new Point(173, 424);
            textBoxEditEmail.Name = "textBoxEditEmail";
            textBoxEditEmail.Size = new Size(146, 23);
            textBoxEditEmail.TabIndex = 35;
            // 
            // labelEditEmail
            // 
            labelEditEmail.AutoSize = true;
            labelEditEmail.Location = new Point(30, 427);
            labelEditEmail.Name = "labelEditEmail";
            labelEditEmail.Size = new Size(120, 15);
            labelEditEmail.TabIndex = 34;
            labelEditEmail.Text = "Edit Customer Email: ";
            // 
            // textBoxEditAddress
            // 
            textBoxEditAddress.Location = new Point(173, 390);
            textBoxEditAddress.Name = "textBoxEditAddress";
            textBoxEditAddress.Size = new Size(146, 23);
            textBoxEditAddress.TabIndex = 33;
            // 
            // labelEditAddress
            // 
            labelEditAddress.AutoSize = true;
            labelEditAddress.Location = new Point(30, 393);
            labelEditAddress.Name = "labelEditAddress";
            labelEditAddress.Size = new Size(136, 15);
            labelEditAddress.TabIndex = 32;
            labelEditAddress.Text = "Edit Customer Address:  ";
            // 
            // textBoxEditName
            // 
            textBoxEditName.Location = new Point(173, 356);
            textBoxEditName.Name = "textBoxEditName";
            textBoxEditName.Size = new Size(146, 23);
            textBoxEditName.TabIndex = 31;
            // 
            // labelEditName
            // 
            labelEditName.AutoSize = true;
            labelEditName.Location = new Point(30, 359);
            labelEditName.Name = "labelEditName";
            labelEditName.Size = new Size(123, 15);
            labelEditName.TabIndex = 30;
            labelEditName.Text = "Edit Customer Name: ";
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(984, 382);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(123, 36);
            buttonEdit.TabIndex = 42;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(845, 382);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(123, 36);
            buttonDelete.TabIndex = 43;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 587);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonSave);
            Controls.Add(label1);
            Controls.Add(textBoxEditPhone);
            Controls.Add(labelEditPhone);
            Controls.Add(textBoxEditBudget);
            Controls.Add(labelEditBudget);
            Controls.Add(textBoxEditEmail);
            Controls.Add(labelEditEmail);
            Controls.Add(textBoxEditAddress);
            Controls.Add(labelEditAddress);
            Controls.Add(textBoxEditName);
            Controls.Add(labelEditName);
            Controls.Add(ShowAllButton);
            Controls.Add(buttonAddCustomer);
            Controls.Add(Create);
            Controls.Add(textBoxPhone);
            Controls.Add(labelCustPhone);
            Controls.Add(textBoxBudget);
            Controls.Add(labelCustBudg);
            Controls.Add(textBoxEmail);
            Controls.Add(labelCustEmail);
            Controls.Add(textBoxAddress);
            Controls.Add(labelCustAddress);
            Controls.Add(textBoxName);
            Controls.Add(labelCustName);
            Controls.Add(Select);
            Controls.Add(listView1);
            Controls.Add(buttonSearchID);
            Controls.Add(textID);
            Controls.Add(EnterId);
            Controls.Add(buttonMinBudget);
            Controls.Add(textMinBudget);
            Controls.Add(EnterminBudget);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label EnterminBudget;
        private TextBox textMinBudget;
        private Button buttonMinBudget;
        private Button buttonSearchID;
        private TextBox textID;
        private Label EnterId;
        private ListView listView1;
        private Label Select;
        private TextBox textBoxName;
        private Label labelCustName;
        private TextBox textBoxAddress;
        private Label labelCustAddress;
        private TextBox textBoxEmail;
        private Label labelCustEmail;
        private TextBox textBoxBudget;
        private Label labelCustBudg;
        private TextBox textBoxPhone;
        private Label labelCustPhone;
        private Label Create;
        private Button buttonAddCustomer;
        private Button ShowAllButton;
        private Button buttonSave;
        private Label label1;
        private TextBox textBoxEditPhone;
        private Label labelEditPhone;
        private TextBox textBoxEditBudget;
        private Label labelEditBudget;
        private TextBox textBoxEditEmail;
        private Label labelEditEmail;
        private TextBox textBoxEditAddress;
        private Label labelEditAddress;
        private TextBox textBoxEditName;
        private Label labelEditName;
        private Button buttonEdit;
        private Button buttonDelete;
    }
}

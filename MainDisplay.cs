using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class MainDisplay : UserControl
    {

        public MainDisplay()
        {
            InitializeComponent();
            
            // Update and populate the parts and products tables
            updatePartsTable();
            updateProductsTable();
        }

        // Method to handle clicks on add part button
        private void btnAddPart_Click(object sender, EventArgs e)
        {
            // Assign the AddPart user control and MainWindow form to variables
            AddPart addPartScreen = new AddPart();
            Form mainWindow = this.ParentForm;

            // Add the addPartScreen as a control in the MainWindow Form
            mainWindow.Controls.Add(addPartScreen);
            // Set the add part screen as the active control
            mainWindow.ActiveControl = addPartScreen;

            // Set title on addPartScreen
            addPartScreen.setTitle("Add Part");

            // Set the location of the add part screen, make sure it's in the front, and set it as the input focus
            addPartScreen.Location = new Point(this.Width / 4, this.Height / 4);
            addPartScreen.BringToFront();
            addPartScreen.Focus();
        }

        // Method to handle clicks on modify part button
        private void btnModifyPart_Click(object sender, EventArgs e)
        {
            // Assign the AddPart user control and MainWindow form to variables
            AddPart modPartScreen = new AddPart();
            Form mainWindow = this.ParentForm;

            // Get the selected Part
            Object selected = partsDataView.SelectedRows[0].DataBoundItem;

            if (selected is Inhouse)
            {
                // Set the modify parts screen for an inhouse part
                modPartScreen.ModInhousePart(selected as Inhouse);
            }
            else
            {
                // Set the modiy parts screen for an outsourced part
                modPartScreen.ModOutsourcedPart(selected as Outsourced);
            }


            // Add the addPartScreen as a control in the MainWindow Form
            mainWindow.Controls.Add(modPartScreen);
            // Set the add part screen as the active control
            mainWindow.ActiveControl = modPartScreen;

            // Set title on addPartScreen
            modPartScreen.setTitle("Modify Part");

            // Set the location of the add part screen, make sure it's in the front, and set it as the input focus
            modPartScreen.Location = new Point(this.Width / 4, this.Height / 4);
            modPartScreen.BringToFront();
            modPartScreen.Focus();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Assign the AddPart user control and MainWindow form to variables
            AddProduct addProductScreen = new AddProduct();
            Form mainWindow = this.ParentForm;

            // Add the addPartScreen as a control in the MainWindow Form
            mainWindow.Controls.Add(addProductScreen);
            // Set the add part screen as the active control
            mainWindow.ActiveControl = addProductScreen;

            // Set title on addPartScreen
            addProductScreen.setTitle("Add Product");

            // Set the location of the add part screen, make sure it's in the front, and set it as the input focus
            addProductScreen.Location = new Point(8, 8);
            addProductScreen.BringToFront();
            addProductScreen.Focus();
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {

            // Assign the AddPart user control and MainWindow form to variables
            AddProduct modProductScreen = new AddProduct();
            Form mainWindow = this.ParentForm;

            // Get the selected Part
            Product selected = productsDataView.SelectedRows[0].DataBoundItem as Product;

            // Add the addPartScreen as a control in the MainWindow Form
            mainWindow.Controls.Add(modProductScreen);
            // Set the add part screen as the active control
            mainWindow.ActiveControl = modProductScreen;

            // Set title on addPartScreen
            modProductScreen.setTitle("Modify Product");
            modProductScreen.setModProduct(selected);

            // Set the location of the add part screen, make sure it's in the front, and set it as the input focus
            modProductScreen.Location = new Point(8, 8);
            modProductScreen.BringToFront();
            modProductScreen.Focus();
        }

        // When the MainDisplay is enabled/disabled
        private void MainDisplay_EnabledChanged(object sender, EventArgs e)
        {
            // Update tables
            updatePartsTable();
            updateProductsTable();
            checkTableStatus();
        }

        // Check the tables' status to enable/disable buttons
        private void checkTableStatus()
        {
            // Check if the tables are empty, if so, disable the modify, delete, and search buttons
            if (isTableEmpty(partsDataView))
            {
                disableButtons("Parts");
            }
            else
            {
                enableButtons("Parts");
            }
            if (isTableEmpty(productsDataView))
            {
                disableButtons("Products");
            }
            else
            {
                enableButtons("Products");
            }
        }

        // Disable buttons if a table is empty
        private void disableButtons(string source)
        {
            if (source == "Parts")
            {
                btnModifyPart.Enabled = false;
                btnDeletePart.Enabled = false;
                btnPartsSearch.Enabled = false;
            }
            if (source == "Products")
            {
                btnModifyProduct.Enabled = false;
                btnDeleteProduct.Enabled = false;
                btnProductsSearch.Enabled = false;
            }

        }

        // Enable buttons if a table is not empty
        private void enableButtons(string source)
        {
            if (source == "Parts")
            {
                btnModifyPart.Enabled = true;
                btnDeletePart.Enabled = true;
                btnPartsSearch.Enabled = true;
            }
            if (source == "Products")
            {
                btnModifyProduct.Enabled = true;
                btnDeleteProduct.Enabled = true;
                btnProductsSearch.Enabled = true;
            }
        }

        // Check if a table is empty
        private bool isTableEmpty(DataGridView table)
        {
            if (table.Rows.Count == 0)
            {
                return true;
            }
            return false;
        }

        // Method to update the parts table
        private void updatePartsTable()
        {
            DataGridView partsTable = this.partsDataView;
            partsTable.DataSource = Inventory.AllParts;

            // Check the tables' status to enable/disable buttons
            checkTableStatus();
        }

        // Method to update the products table
        private void updateProductsTable()
        {
            DataGridView productsTable = this.productsDataView;
            productsTable.DataSource = Inventory.Products;

            // Check the tables' status to enable/disable buttons
            checkTableStatus();
        }

        // Delete a part from the partsDataView
        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            // Get the selected part from the partsDataView
            Part selected = partsDataView.SelectedRows[0].DataBoundItem as Part;

            // If the part is NOT associated with a product
            if (!checkAssociation(selected))
            {
                // Create a message with part info to display to the user
                String message = $"Are you sure you want to permanently delete this part?\n" +
                       $"ID: {selected.PartID}\n" +
                       $"Name: {selected.Name}\n" +
                       $"Price: {selected.Price}";

                // Display a yes/no dialog to the user to confirm delete of part
                DialogResult result = MessageBox.Show(message, "Warning!", MessageBoxButtons.YesNo);

                // If the user selected yes
                if (result == DialogResult.Yes)
                {
                    // Delete the part and update the parts table
                    Inventory.deletePart(selected);
                    updatePartsTable();
                }
                // Check all tables' status and update
                checkTableStatus();
            }
        }

        // Delete Product from products table
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            // Get the selected product from the table
            Product selected = productsDataView.SelectedRows[0].DataBoundItem as Product;

            // If there are parts associated with the product
            if (selected.AssociatedParts.Count > 0)
            {
                // Create a string to show parts' names
                String associatedParts = "";

                // Iterate through the list of parts
                foreach (Part associatedPart in selected.AssociatedParts)
                {
                    // Add the part name to the string
                    associatedParts += $"{associatedPart.Name}\n";
                }

                // Notify the user that the part can not be deleted due to association
                MessageBox.Show("This product can not be deleted.\n" +
                    "It is associated with the following parts:\n" +
                    $"{associatedParts}");
                // Return without deleting the product
                return;
            }

            // If there are no associated parts
            // Build a message to ask the user to confirm delete
            String message = $"Are you sure you want to permanently delete this product?\n" +
                   $"ID: {selected.ProductID}\n" +
                   $"Name: {selected.Name}\n" +
                   $"Price: {selected.Price}";

            // Display a dialog asking teh user to confirm
            DialogResult result = MessageBox.Show(message, "Warning!", MessageBoxButtons.YesNo);

            // If the user selected yes
            if (result == DialogResult.Yes)
            {
                // Remove the product from the inventory and update the table
                Inventory.removeProduct(Inventory.Products.IndexOf(selected));
                updateProductsTable();
            }
            // Check the tables' status and update the buttons' status
            checkTableStatus();
        }

        // Method for parts search
        private void btnPartsSearch_Click(object sender, EventArgs e)
        {
            // Get the string from the users' input
            string searchTerm = inputPartSearch.Text;

            // If the string is just whitespace
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                // Clear the search box and update the table to display all parts again
                inputPartSearch.Text = string.Empty;
                updatePartsTable();
                return;
            }
            // If the user did not enter valid text
            else if (!searchTerm.All(x => Char.IsLetterOrDigit(x) || x == ' '))
            {
                partNotFound();
                return;
            }

            // If text is valid, call the search parts method
            var result = searchParts(searchTerm, Inventory.AllParts);

            // If the result returns null or is empty
            if (result == null || result.ToArray().Count() < 1)
            {
                partNotFound();
                return;
            }
            // If there are results
            else
            {
                // Set the partsDataView source as the search results
                partsDataView.DataSource = result.ToArray();

                // Select the first result, update, and refresh the view to display results
                partsDataView.Rows[0].Selected = true;
                partsDataView.Update();
                partsDataView.Refresh();
            }
        }

        // Method to clear the parts search and reset the parts table
        private void clearPartSearch_Click(object sender, EventArgs e)
        {
            inputPartSearch.Text = string.Empty;
            updatePartsTable();
        }

        // Method to search the products table
        private void btnProductsSearch_Click(object sender, EventArgs e)
        {
            // Get the string from the user input
            string searchTerm = inputProductSearch.Text;

            // If the string is whitespace or empty
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                // Clear the search box and reset the table
                inputProductSearch.Text = string.Empty;
                updateProductsTable();
                return;
            }
            // If the user did not enter valid text
            else if (!searchTerm.All(x => Char.IsLetterOrDigit(x) || x == ' '))
            {
                productNotFound();
                return;
            }
            // If the text is valid, call the searchProducts method
            var result = searchProducts(searchTerm, Inventory.Products);

            // If the result is null or empty
            if (result == null || result.ToArray().Count() < 1)
            {
                productNotFound();
                return;
            }
            // If there are results
            else
            {
                // Set the results as the productsDataView source
                productsDataView.DataSource = result.ToArray();
                // Select the top result, update, and refresh the table
                productsDataView.Rows[0].Selected = true;
                productsDataView.Update();
                productsDataView.Refresh();
            }
        }

        // Method to clear the product search and reset the table
        private void clearProductSearch_Click(object sender, EventArgs e)
        {
            inputProductSearch.Text = string.Empty;
            updateProductsTable();
        }

        // Method to exit the program when pressing the exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Check if a part is associated with a product
        private bool checkAssociation(Part part)
        {
            bool result = false;

            // Create a list to store products associated with the part
            List<String> productsWithParts = new List<string>();
            
            // Check all products that might be associated with the part
            foreach (Product product in Inventory.Products)
            {
                var existingPart = product.lookupAssociatedPart(part.PartID);

                // If the returned results are not null, add the product to the list
                // set result to true so the part will not be deleted
                if (existingPart != null)
                {
                    // Add the product name to the list to display to user
                    productsWithParts.Add(product.Name);
                    result = true;
                }
            }

            // If the part was found attatched to a product
            if (result)
            {
                // Create a string to store product names
                String productNames = "";

                // Append each product name to the string
                foreach (String name in productsWithParts) { productNames += $"{name}\n"; }

                // Notify the user
                MessageBox.Show(
                    "This part can not be deleted." +
                    "\nIt is associated with the following products:\n" +
                    $"{productNames}"
                    );
            }
            // return the result (If the part was found attatched to a product)
            return result;
        }

        // When MainDisplay is finished loading, check for empty tables
        private void MainDisplay_Load(object sender, EventArgs e)
        {
            checkTableStatus();
        }

        // Method for search the parts table
        private IOrderedEnumerable<Part> searchParts(String term, BindingList<Part> partsList)
        {
            // First, check if an integer was entered
            if (int.TryParse(term, out int id))
            {
                // Use LINQ to search for matching product ids
                var result =
                from part in partsList
                where part.PartID == id
                orderby part.PartID
                select part;

                return result;
            }
            // If not an integer, make sure it is a valid string and search for a match
            else if (term.All(x => Char.IsLetter(x) || x == ' '))
            {
                // Use LINQ to search for matching part names
                var result =
                    from part in partsList
                    where part.Name.ToUpper().Contains(term.ToUpper())
                    orderby part.Name.ToUpper()
                    select part;

                return result;
            }

            return null;
        }

        // Method for searching the products table
        private IOrderedEnumerable<Product> searchProducts(String term, BindingList<Product> productsList)
        {
            // First, check if an integer was entered
            if (int.TryParse(term, out int id))
            {
                // Use LINQ to search for matching product ids
                var result =
                from product in productsList
                where product.ProductID == id
                orderby product.ProductID
                select product;

                return result;
            }
            // If not an integer, make sure it is a valid string and search for a match
            else if (term.All(x => Char.IsLetter(x) || x == ' '))
            {
                // Use LINQ to search for matching product names
                var result =
                    from product in productsList
                    where product.Name.ToUpper().Contains(term.ToUpper())
                    orderby product.Name.ToUpper()
                    select product;

                return result;
            }

            return null;
        }

        // Error to display if the part is not found
        private void partNotFound()
        {
            MessageBox.Show("Part not found", "Error");
            inputPartSearch.Text = string.Empty;
            updatePartsTable();
        }

        // Error to display if the product is not found
        private void productNotFound()
        {
            MessageBox.Show("Product not found", "Error");
            inputProductSearch.Text = string.Empty;
            updateProductsTable();
        }
    }
}

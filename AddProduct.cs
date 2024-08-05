using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    internal partial class AddProduct : UserControl
    {
        // Set valid and invalid colors for use in the textboxes
        Color invalidColor = Color.FromArgb(255, 192, 192);
        Color validColor = SystemColors.Window;

        // Global variables to use throughout the class
        int productID;
        string productName;
        decimal productPrice;
        int inStock;
        int productMin;
        int productMax;
        int listElement = 0;
        bool validName, validPrice, validStock, validMin, validMax;

        Product thisProduct = new Product();
        // List of all parts associated with this part
        BindingList<Part> associatedList = new BindingList<Part>();

        // List of parts that were added during this session
        // to easily remove them if canceled
        List<Part> addedList = new List<Part>();
        // List of parts that were removed during this session
        // to easily add them back if canceled
        List<Part> deletedList = new List<Part>();

        DataGridView associatedPartsTable;
        DataGridView partsTable;


        internal AddProduct()
        {
            InitializeComponent();

            // Set the tables to variables
            associatedPartsTable = this.associatedPartsDataView;
            partsTable = this.allPartsDataView;
            // Set the all parts table data source
            partsTable.DataSource = Inventory.AllParts;

            // Generate a product ID
            generateProductID();
            // Check if the tables are empty and enable/disable buttons
            checkTableStatus();
        }

        internal int generateProductID()
        {
            // This will be overridden by the proper product ID if modifying a product
            int newProductID = 0;
            // Get the PartID from the last part in the inventory
            try
            {
                Product lastProduct = Inventory.lookupProduct(Inventory.Products.Count - 1);
                newProductID = lastProduct.ProductID + 1;

                // Add the empty list for a new product
                thisProduct.AssociatedParts = associatedList;
            }
            catch
            {
                // If index is out of Range, there are no parts in Inventory newPartID stays 0
            }
            // Set the global variable
            productID = newProductID;
            // Set the product ID in the form
            this.inputProductID.Text = productID.ToString();

            return newProductID;
        }

        // Method to update and reset the associated parts table
        private void updateAssociatedPartsTable()
        {
            // Reset the datasource, update, and refresh the table
            associatedPartsTable.DataSource = thisProduct.AssociatedParts;
            associatedPartsTable.Update();
            associatedPartsTable.Refresh();

            // Check if the table is empty and enable/disable the buttons
            checkTableStatus();
        }

        // Method to update and reset the AllParts table
        private void updateAllPartsTable()
        {
            // Reset the datasource, update, and refresh the table
            partsTable.DataSource = Inventory.AllParts;
            partsTable.Update();
            partsTable.Refresh();

            // Check if the table is empty and enable/disable the buttons
            checkTableStatus();
        }

        // Called from MainDisplay to set the UI to modify a product
        internal void setModProduct(Product product)
        {
            // Set this product to the selected product from MainDisplay
            thisProduct = product;
            // Get the index of this product in the inventory
            listElement = Inventory.Products.IndexOf(thisProduct);
            // Set the list of associated parts
            associatedList = thisProduct.AssociatedParts;
            // Set the associated parts table to the associatedList
            associatedPartsTable.DataSource = associatedList;

            // Fill the textboxes with this products data
            populateProductData(thisProduct);

        }

        // Method to set the textboxes to the modified products data
        private void populateProductData(Product product)
        {
            // Set all of the text boxes
            inputProductID.Text = product.ProductID.ToString();
            inputProductName.Text = product.Name;
            inputProductInv.Text = product.InStock.ToString();
            inputProductPrice.Text = product.Price.ToString();
            inputProductMax.Text = product.Max.ToString();
            inputProductMin.Text = product.Min.ToString();

            // Update the variables
            productID = product.ProductID;
            productName = product.Name;
            productPrice = product.Price;
            inStock = product.InStock;
            productMin = product.Min;
            productMax = product.Max;

            // Check the tables' status and enable/disable buttons
            checkTableStatus();
        }

        // Called from MainDisplay to set the title
        internal void setTitle(String title)
        {
            // Set the title to either Add or Modify Product
            this.labelAddProductTitle.Text = title;
        }

        // Handle button click to add a part to the product
        private void btnAddAssociatedPart_Click(object sender, EventArgs e)
        {
            // Get the selected Part
            Part selected = allPartsDataView.SelectedRows[0].DataBoundItem as Part;

            // Make sure part is not already associated with the product
            if (!isPartAssociated(selected))
            {
                // Add the part to this product
                thisProduct.addAssociatedPart(selected);
                // Add the part to the list of parts that were added during this session
                addedList.Add(selected);
            }
            else // If the part is already associated with this product
            {
                // Let the user know the part is already associated with this product
                MessageBox.Show("Part is already associated with this product.", "Error");
            }

            // Update the table
            updateAssociatedPartsTable();
        }

        // Check if a part is associated with the product
        private bool isPartAssociated(Part part)
        {
            // for each part in the list of associated parts
            foreach (Part p in associatedList)
            {
                // if it matches this part
                if (p == part)
                {
                    // return true
                    return true;
                }
            }
            // if the part is not already associated, return false
            return false;
        }

        // Method to handle removing an associated part
        private void btnDeleteAssociatedPart_Click(object sender, EventArgs e)
        {
            // Get the selected part
            Part selected = associatedPartsTable.SelectedRows[0].DataBoundItem as Part;

            // Create a message to ask the user to confirm
            String message = $"Are you sure you want remove this part from the Associated Parts?\n" +
                   $"Part ID: {selected.PartID}\n" +
                   $"Name: {selected.Name}\n" +
                   $"Price: {selected.Price}";

            // Display the confirmation dialog with yes/no buttons
            DialogResult result = MessageBox.Show(message, "Warning!", MessageBoxButtons.YesNo);

            // If yes
            if (result == DialogResult.Yes)
            {
                // Remove the part from the associated parts for this product
                thisProduct.removeAssociatedPart(selected);
                // Add it to the list of deleted parts, to add it back if canceled
                deletedList.Add(selected);
                // Update the table to reflect the changes
                updateAssociatedPartsTable();
            }
            // Check the tables' status and enable/disable appropriate buttons
            checkTableStatus();
        }

        // Show Error message for invalid input
        private void showError()
        {
            if (!validName)
            {
                MessageBox.Show("Invalid Name", "Error");
                return;
            }
            else if (!validPrice)
            {
                MessageBox.Show("Invalid Price", "Error");
                return;
            }
            else if (!validStock)
            {
                MessageBox.Show("Invalid Inventory", "Error");
                return;
            }
            else if (!validMax)
            {
                MessageBox.Show("Invalid Max", "Error");
                return;
            }
            else if (!validMin)
            {
                MessageBox.Show("Invalid Min", "Error");
                return;
            }
        }

        // Method to handle saving the product information
        private void btnSave_Click(object sender, EventArgs e)
        {
            // If the information entered is not valid
            if (!validateData())
            {
                // Show the related error
                showError();
                return;
            }

            // If instock is less than 1
            if (inStock < 1)
            {
                // Show error message
                MessageBox.Show("Inventory must be 1 or more!");
                inputProductInv.Text = "";
                return;
            }
            // If Min is more than Max
            else if (productMin > productMax)
            {
                // Show error message
                MessageBox.Show("Min can not be more than Max!");
                inputProductMin.Text = "";
                return;
            }
            // If instock is less than min
            else if (inStock < productMin)
            {
                // Show error message
                MessageBox.Show("Inventory must be more than min!");
                inputProductInv.Text = "";
                return;
            }
            // If instock is more than max
            else if (inStock > productMax)
            {
                // Show error message
                MessageBox.Show("Inventory must be less than Max!");
                inputProductInv.Text = "";
                return;
            }

            // Update all information
            thisProduct.ProductID = productID;
            thisProduct.Name = productName;
            thisProduct.Price = productPrice;
            thisProduct.InStock = inStock;
            thisProduct.Max = productMax;
            thisProduct.Min = productMin;

            // If Modifying a Product
            if (labelAddProductTitle.Text == "Modify Product")
            {
                // If no issues, then save the product to inventory
                Inventory.updateProduct(listElement, thisProduct);
            }
            // If adding a new product
            else
            {
                // Add the new product to inventory
                Inventory.addProduct(thisProduct);
            }


            // Close the pop-up
            this.Hide();
            this.ParentForm.Controls.Remove(this);
        }

        // When cancel is pressed
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Remove any parts that were added
            if (addedList.Count != 0)
            {
                // If count is 0, it is empty, so nothing to remove
                foreach (Part p in addedList)
                {
                    thisProduct.removeAssociatedPart(p);
                }
            }
            // Add back any parts that were deleted
            if (deletedList.Count != 0)
            {
                foreach (Part p in deletedList)
                {
                    thisProduct.addAssociatedPart(p);
                }
            }
            // Close the pop-up
            this.Hide();
            this.ParentForm.Controls.Remove(this);
        }

        // Check if the tables are empty and enable/disable the buttons accordningly
        private void checkTableStatus()
        {
            if (isTableEmpty(partsTable))
            {
                disableButtons("All Parts");
            }
            else
            {
                enableButtons("All Parts");
            }
            if (isTableEmpty(associatedPartsTable))
            {
                disableButtons("Associated Parts");
            }
            else
            {
                enableButtons("Associated Parts");
            }
        }

        // Method to disable buttons if the table is empty
        private void disableButtons(string source)
        {
            if (source == "All Parts")
            {
                btnAddAssociatedPart.Enabled = false;
                btnSearch.Enabled = false;
            }
            if (source == "Associated Parts")
            {
                btnDeleteAssociatedPart.Enabled = false;
            }

        }

        // Method to enable buttons if the table is not empty
        private void enableButtons(string source)
        {
            if (source == "All Parts")
            {
                btnAddAssociatedPart.Enabled = true;
                btnSearch.Enabled = true;
            }
            if (source == "Associated Parts")
            {
                btnDeleteAssociatedPart.Enabled = true;
            }
        }

        // Method to check if a table is empty
        private bool isTableEmpty(DataGridView table)
        {
            if (table.Rows.Count == 0)
            {
                return true;
            }
            return false;
        }

        // Method to validate text input
        private void validateText(TextBox field)
        {
            // If the string is only whitespace or an invalid character
            if (string.IsNullOrWhiteSpace(field.Text) || !field.Text.All(x => Char.IsLetter(x) || x == ' '))
            {
                // Change the back color to invalid
                field.BackColor = invalidColor;
                // Set validname bool to false
                validName = false;
            }
            else // If the text is valid
            {
                // Change the back color to valid
                field.BackColor = validColor;
                // Update the product name
                productName = field.Text;
                // Set valid name to true
                validName = true;
            }
        }
        // Method to check if the input is a valid number
        private void testValidNumber(TextBox field)
        {

            if (int.TryParse(field.Text, out int number))
            {
                field.BackColor = validColor;
            }
            else
            {
                field.BackColor = invalidColor;
            }

        }
        // Method to check all input for validity
        private bool validateData()
        {
            validPrice = decimal.TryParse(inputProductPrice.Text, out decimal price);
            validStock = int.TryParse(inputProductInv.Text, out int inv);
            validMax = int.TryParse(inputProductMax.Text, out int max);
            validMin = int.TryParse(inputProductMin.Text, out int min);

            // If all is valid
            if (validName &&
                validPrice &&
                validStock &&
                validMax &&
                validMin)
            {
                // Update the global variables and return true
                productPrice = price;
                inStock = inv;
                productMin = min;
                productMax = max;
                return true;
            }
            else // If all is not valid
            {
                // Return false
                return false;
            }

        }

        // Message to show if a part is not found in search
        private void partNotFound()
        {
            MessageBox.Show("Part not found", "Error");
            inputAllPartSearch.Text = string.Empty;

        }
        // Method to search for a part
        private IOrderedEnumerable<Part> searchParts(String term, BindingList<Part> partsList)
        {
            // First, check if an integer was entered
            if (int.TryParse(term, out int id))
            {
                // Search the partslist using LINQ for a matching partID
                var result =
                from part in partsList
                where part.PartID == id
                orderby part.PartID
                select part;

                return result;
            }
            // If not an integer, test for a valid string
            else if (term.All(x => Char.IsLetter(x) || Char.IsSeparator(x) || x == ' '))
            {
                // Search the partslist using LINQ for a matching part name
                var result =
                    from part in partsList
                    where part.Name.ToUpper().Contains(term.ToUpper())
                    orderby part.Name.ToUpper()
                    select part;

                return result;
            }
            // If nothing is found, return null
            return null;
        }
        // When the search button is clicked
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get the string from the input
            string searchTerm = inputAllPartSearch.Text;
            // If the string is empty or whitespace
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                // Clear the textbox and reset the table
                inputAllPartSearch.Text = string.Empty;
                updateAllPartsTable();
                return;
            }
            // If the string has invalid characters
            else if (!searchTerm.All(x => Char.IsLetterOrDigit(x) || x == ' '))
            {
                // Notify the user the part can not be found
                partNotFound();
                return;
            }
            // If the string is valid, call the searchParts method
            var result = searchParts(searchTerm, Inventory.AllParts);

            // If the result is empty, no parts were found
            if (result == null || result.ToArray().Count() < 1)
            {
                // Notify the user
                partNotFound();
                return;
            }
            else // If the result is not empty
            {
                // The table will display the results with the first result selected
                partsTable.DataSource = result.ToArray();
                partsTable.Rows[0].Selected = true;
                partsTable.Update();
                partsTable.Refresh();
            }
        }
        // When the clear search button is clicked
        private void clearSearch_Click(object sender, EventArgs e)
        {
            // Clear the search box
            inputAllPartSearch.Text = string.Empty;
            // Reset the table
            updateAllPartsTable();
        }
        // When the Price is changed
        private void inputProductPrice_TextChanged(object sender, EventArgs e)
        {
            // Set the input to a variable
            TextBox field = this.inputProductPrice;
            // Try to parse it to a double
            if (double.TryParse(field.Text, out double price))
            {
                // If it's valid, change the back color to valid
                field.BackColor = validColor;
            }
            else // If it's not valid, change the back color to invalid
            {
                field.BackColor = invalidColor;
            }
            // Validate all data
            validateData();
        }

        // When product name text is changed
        private void inputProductName_TextChanged(object sender, EventArgs e)
        {
            // Make sure it's valid text
            validateText(this.inputProductName);
            // Validate all data
            validateData();
        }

        // When inventory text is changed
        private void inputProductInv_TextChanged(object sender, EventArgs e)
        {
            // Test if it is a valid number
            testValidNumber(this.inputProductInv);
            // Validate all data
            validateData();
        }

        // When Max test is changed
        private void inputProductMax_TextChanged(object sender, EventArgs e)
        {
            // Test if it is a valid number
            testValidNumber(this.inputProductMax);
            // Validate all data
            validateData();
        }

        // When Min test is changed
        private void inputProductMin_TextChanged(object sender, EventArgs e)
        {
            // Test if it is a valid number
            testValidNumber(this.inputProductMin);
            // Validate all data
            validateData();
        }
        // When leaving the price text box
        private void inputProductPrice_Leave(object sender, EventArgs e)
        {
            // Set the textbox to a variable
            TextBox field = this.inputProductPrice;
            // Set the number format for 2 decimal places
            NumberFormatInfo setPrecision = new NumberFormatInfo();
            setPrecision.NumberDecimalDigits = 2;

            // If it can be parsed
            if (decimal.TryParse(field.Text, out decimal price))
            {
                // Set the textbox
                field.Text = price.ToString("N", setPrecision);
            }
            // Validate all data
            validateData();
        }

        // Validate all data when leaving text boxes
        private void inputProductName_Leave(object sender, EventArgs e)
        {
            validateData();
        }

        private void inputProductInv_Leave(object sender, EventArgs e)
        {
            validateData();
        }

        private void inputProductMax_Leave(object sender, EventArgs e)
        {
            validateData();
        }

        private void inputProductMin_Leave(object sender, EventArgs e)
        {
            validateData();
        }
    }
}

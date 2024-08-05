using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    internal partial class AddPart : UserControl
    {
        // Set valid and invalid colors for use in the textboxes
        Color invalidColor = Color.FromArgb(255, 192, 192);
        Color validColor = SystemColors.Window;

        // Global variables to use throughout the class
        int partID;
        string partName;
        decimal partPrice;
        int inStock;
        int partMin;
        int partMax;
        int machineID;
        string companyName;
        int listElement;
        bool validName, validPrice, validStock, validMin, validMax, validMachineID, validCompanyName;

        Inhouse modInhousePart = new Inhouse();
        Inhouse newInhousePart = new Inhouse();

        Outsourced modOutsourcedPart = new Outsourced();
        Outsourced newOutsourcedPart = new Outsourced();

        internal AddPart()
        {
            InitializeComponent();
            // Generate a partID when the class is created
            generatePartID();
        }

        // Set the title to either Add Part or Modify Part
        internal void setTitle(String title)
        {
            this.labelAddPartTitle.Text = title;
        }

        // Generate a new partID
        internal void generatePartID()
        {
            int newPartID = 0;
            // Get the PartID from the last part in the inventory
            try
            {
                Part lastPart = Inventory.lookupPart(Inventory.AllParts.Count - 1);
                newPartID = lastPart.PartID + 1;
            }
            catch
            {
                // If index is out of Range, there are no parts in Inventory newPartID stays 0
            }

            // Update the global partID variable
            partID = newPartID;
            // Set the partID in the form
            this.inputPartID.Text = partID.ToString();
        }

        // If modifying an Outsourced part, (Called from MainDisplay when the modify button is clicked)
        internal void ModOutsourcedPart(Outsourced part)
        {
            // Set the radiobutton to Oursourced
            rbOutsourced.Checked = true;
            // Set modOutsourcedPart as this part
            modOutsourcedPart = part;
            // Get the index of the part in inventory
            listElement = Inventory.AllParts.IndexOf(part);
            // Populate the text boxes with the part data
            populatePartData(modOutsourcedPart);
            // Set the Company name
            inputPartDynamic.Text = modOutsourcedPart.CompanyName;
        }

        // If modifying an Inhouse part, (Called from MainDisplay when the modify button is clicked)
        internal void ModInhousePart(Inhouse part)
        {
            // Set the radiobutton to Inhouse
            rbInHouse.Checked = true;
            // Set the modInhousePart to this part
            modInhousePart = part;
            // Get the index of teh part in inventory
            listElement = Inventory.AllParts.IndexOf(part);
            // Populate the text boxes with the part data
            populatePartData(modInhousePart);
            // Set the MachineID
            inputPartDynamic.Text = modInhousePart.MachineID.ToString();
        }

        // When the InHouse radio button is clicked
        private void rbInHouse_Click(object sender, EventArgs e)
        {
            // Set the label for Machine ID
            labelDynamicPart.Text = "Machine ID";
            // Validate the inputs
            validateData();
            validateDynamic();
        }

        // When the Outsourced radio button is clicked
        private void rbOutsourced_Click(object sender, EventArgs e)
        {
            // Set the label for Company Name
            labelDynamicPart.Text = "Company Name";
            // Validate the inputs
            validateData();
            validateDynamic();
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
            else if (!validMachineID)
            {
                MessageBox.Show("Invalid MachineID", "Error");
                return;
            }
            else if (!validCompanyName)
            {
                MessageBox.Show("Invalid Company Name", "Error");
                return;
            }
        }


        // Handle Save button clicks
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
                inputPartInv.Text = "";
                return;
            }
            // If Min is more than Max
            else if (partMin > partMax)
            {
                // Show error message
                MessageBox.Show("Min can not be more than Max!");
                inputPartMin.Text = "";
                return;
            }
            // If inStock is less than Min
            else if (inStock < partMin)
            {
                // Show error message
                MessageBox.Show("Inventory must be more than min!");
                inputPartInv.Text = "";
                return;
            }
            // If inStock is more than Max
            else if (inStock > partMax)
            {
                // Show error message
                MessageBox.Show("Inventory must be less than Max!");
                inputPartInv.Text = "";
                return;
            }
            // If modifying a part
            if (labelAddPartTitle.Text == "Modify Part")
            {
                // Update the part
                updatePart();
            }
            else // If adding a part
            {
                // If an Inhouse part
                if (rbInHouse.Checked)
                {
                    // Set all Inhouse part info
                    newInhousePart.PartID = partID;
                    newInhousePart.Name = partName;
                    newInhousePart.Price = partPrice;
                    newInhousePart.InStock = inStock;
                    newInhousePart.Min = partMin;
                    newInhousePart.Max = partMax;
                    newInhousePart.MachineID = machineID;

                    // Add the Part to inventory
                    Inventory.addPart(newInhousePart);
                }
                // In an Outsourced Part
                else
                {
                    // Set all Outsourced part info
                    newOutsourcedPart.PartID = partID;
                    newOutsourcedPart.Name = partName;
                    newOutsourcedPart.Price = partPrice;
                    newOutsourcedPart.InStock = inStock;
                    newOutsourcedPart.Max = partMax;
                    newOutsourcedPart.Min = partMin;
                    newOutsourcedPart.CompanyName = companyName;

                    // Add the Part to inventory
                    Inventory.addPart(newOutsourcedPart);
                }
            }

            // Close the pop-up
            this.Hide();
            this.ParentForm.Controls.Remove(this);
        }

        // Update an existing part that has been modified
        private void updatePart()
        {
            // If Inhouse
            if (rbInHouse.Checked)
            {
                // Set all part info
                modInhousePart.PartID = listElement;
                modInhousePart.Name = partName;
                modInhousePart.Price = partPrice;
                modInhousePart.InStock = (int)inStock;
                modInhousePart.Max = (int)partMax;
                modInhousePart.Min = (int)partMin;
                modInhousePart.MachineID = (int)machineID;

                // Update the part in inventory
                Inventory.updatePart(listElement, modInhousePart);
            }
            // If Outsourced
            else
            {
                // Set all part info
                modOutsourcedPart.PartID = listElement;
                modOutsourcedPart.Name = partName;
                modOutsourcedPart.Price = partPrice;
                modOutsourcedPart.InStock = (int)inStock;
                modOutsourcedPart.Max = (int)partMax;
                modOutsourcedPart.Min = (int)partMin;
                modOutsourcedPart.CompanyName = CompanyName;

                // Update the part in inventory
                Inventory.updatePart(listElement, modOutsourcedPart);
            }
        }

        // If Cancel is clicked
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the pop-up without making any changes
            this.Hide();
            this.ParentForm.Controls.Remove(this);
        }

        // When Part Name text is changed
        private void inputPartName_TextChanged(object sender, EventArgs e)
        {
            // Validate the input
            validateName(this.inputPartName);
            validateData();
        }

        private void validateName(TextBox field)
        {
            // If the sting is empty, is not an alphabetical or a valid separator
            if (string.IsNullOrWhiteSpace(field.Text) || !field.Text.All(x => Char.IsLetter(x) || Char.IsSeparator(x) || x == ' '))
            {
                // Set the textbox color to invalid and set the validName bool to false
                field.BackColor = invalidColor;
                validName = false;
            }
            else // If the string is a valid name
            {
                // Set the color as valid, add the text to the partName variable, and set the bool to true
                field.BackColor = validColor;
                partName = field.Text;
                validName = true;
            }
        }

        // When the inventory textbox is changed
        private void inputPartInv_TextChanged(object sender, EventArgs e)
        {
            // Test that a valid number was input
            testValidNumber(this.inputPartInv);
            validateData();
        }

        // When the Price/Cost textbox is changed
        private void inputPartPrice_TextChanged(object sender, EventArgs e)
        {
            // Set the textbox to a variable
            TextBox field = this.inputPartPrice;

            // If it is able to be parsed as a double
            if (double.TryParse(field.Text, out double price))
            {
                // Set the textbox background color as valid
                field.BackColor = validColor;
            }
            else // If it can not be parsed as a double
            {
                // Set the textbox color as invalid
                field.BackColor = invalidColor;
            }
            // Validate all data
            validateData();
        }

        // When leaving the Price textbox
        private void inputPartPrice_Leave(object sender, EventArgs e)
        {
            // Set the textbox to a variable
            TextBox field = this.inputPartPrice;

            // Set the number precision to 2 decimal points
            NumberFormatInfo setPrecision = new NumberFormatInfo();
            setPrecision.NumberDecimalDigits = 2;

            // Try to parse to a decimal
            if (decimal.TryParse(field.Text, out decimal price))
            {
                field.Text = price.ToString("N", setPrecision);
            }
            // Validate all data
            validateData();
        }

        // When the Max text is changed
        private void inputPartMax_TextChanged(object sender, EventArgs e)
        {
            // Make sure it is a valid number and validate all data
            testValidNumber(this.inputPartMax);
            validateData();
        }

        // When the Min text is changed
        private void inputPartMin_TextChanged(object sender, EventArgs e)
        {
            // Make sure it is a valid number and validate all data
            testValidNumber(this.inputPartMin);
            validateData();
        }

        // When the MachineID / Company Name text is changed
        private void inputPartDynamic_TextChanged(object sender, EventArgs e)
        {
            // Validate all data
            validateData();
            // set local bool variables to false
            validMachineID = false;
            validCompanyName = false;
            
            // If it is a valid number for machine ID or name for Company name
            if (validateDynamic())
            {
                // If inhouse
                if (rbInHouse.Checked)
                {
                    // set valid to true
                    validMachineID = true;
                    // parse the MachineID to an integer and store in MachineID
                    machineID = int.Parse(inputPartDynamic.Text);
                }
                else // if outsourced
                {
                    // set the companyName
                    companyName = inputPartDynamic.Text;
                    // set valid to true
                    validCompanyName = true;
                }
            // If not valid, booleans stay false and machineID/companyName are not updated
            }
        }

        // Method to test if text input is a valid number
        private bool testValidNumber(TextBox field)
        {
            // if the text can be parsed to an integer
            if (int.TryParse(field.Text, out int number))
            {
                // Set the textbox backcolor to valid
                field.BackColor = validColor;
                // Return true 
                return true;
            }
            else
            {
                // Set the textbox backcolor to invalid
                field.BackColor = invalidColor;
                // Return false
                return false;
            }
        }

        // Validate the text from the dynamic(MachineID/CompanyName) textbox
        private bool validateDynamic()
        {
            // Set the field variable to this textbox
            var field = this.inputPartDynamic;

            // If inhouse
            if (this.rbInHouse.Checked)
            {
                // Test if it is a valid number and return the result
                return testValidNumber(field);

            }
            else // If outsourced
            {
                // If it is not valid text input
                if (string.IsNullOrWhiteSpace(field.Text) || !field.Text.All(x => Char.IsLetter(x) || Char.IsSeparator(x) || Char.IsPunctuation(x) || x == ' '))
                {
                    // Set the back color to invalid and return false
                    field.BackColor = invalidColor;
                    return false;
                }
                else
                {
                    // Set the back color to valid and return true
                    field.BackColor = validColor;
                    return true;
                }
            }
        }

        // Method to validate all textfields
        private bool validateData()
        {
            // Try to parse numerical data
            validPrice = decimal.TryParse(inputPartPrice.Text, out decimal price);
            validStock = int.TryParse(inputPartInv.Text, out int inv);
            validMax = int.TryParse(inputPartMax.Text, out int max);
            validMin = int.TryParse(inputPartMin.Text, out int min);

            // If all data is valid
            if (validName &&
                validPrice &&
                validStock &&
                validMax &&
                validMin &&
                validateDynamic())
            {
                // Set global variables and return true
                partPrice = price;
                inStock = inv;
                partMin = min;
                partMax = max;
                return true;
            }
            else // If not all is valid
            {
                // Return false
                return false;
            }

        }

        // Method to populate all part data when modifying a part
        private void populatePartData(Part part)
        {
            // Set all textboxes from the part data
            inputPartName.Text = part.Name;
            inputPartID.Text = part.PartID.ToString();
            inputPartPrice.Text = part.Price.ToString();
            inputPartInv.Text = part.InStock.ToString();
            inputPartMin.Text = part.Min.ToString();
            inputPartMax.Text = part.Max.ToString();
        }

        // Validate all data when leaving the Textboxes
        private void inputPartDynamic_Leave(object sender, EventArgs e)
        {
            validateData();
        }

        private void inputPartName_Leave(object sender, EventArgs e)
        {
            validateData();
        }

        private void inputPartInv_Leave(object sender, EventArgs e)
        {
            validateData();
        }

        private void inputPartMax_Leave(object sender, EventArgs e)
        {
            validateData();
        }

        private void inputPartMin_Leave(object sender, EventArgs e)
        {
            validateData();
        }
    }
}

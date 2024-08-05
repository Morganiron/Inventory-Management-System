using System.ComponentModel;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            // Initialize the screens
            MainDisplay mainDisplay = new MainDisplay();
            AddPart addPart = new AddPart();
            AddProduct addProduct = new AddProduct();

            // Generate some default parts and products for testing
            generateDefaultParts();
            generateDefaultProduct();
        }

        private void MainWindow_ControlAdded(object sender, ControlEventArgs e)
        {
            // Disable the mainDisplay when another control is added as a pop-up
            mainDisplay1.Enabled = false;
        }

        private void MainWindow_ControlRemoved(object sender, ControlEventArgs e)
        {
            // Enable the mainDisplay when the pop-up is removed
            mainDisplay1.Enabled = true;
        }


        private void generateDefaultParts()
        {
            Inhouse part1 = new Inhouse();
            Inhouse part2 = new Inhouse();
            Outsourced part3 = new Outsourced();

            part1.PartID = 0;
            part2.PartID = 1;
            part3.PartID = 2;

            part1.Name = "Curved Handlebar";
            part2.Name = "Wide Seat";
            part3.Name = "Street Tire";

            part1.Price = 25.50M;
            part2.Price = 35.95M;
            part3.Price = 16.99M;

            part1.InStock = 2;
            part2.InStock = 3;
            part3.InStock = 4;

            part1.Min = 1;
            part2.Min = 1;
            part3.Min = 2;

            part1.Max = 5;
            part2.Max = 5;
            part3.Max = 50;

            part1.MachineID = 1;
            part2.MachineID = 4;
            part3.CompanyName = "Toyo";

            Inventory.addPart(part1);
            Inventory.addPart(part2);
            Inventory.addPart(part3);
        }

        private void generateDefaultProduct()
        {
            Product product1 = new Product();
            Product product2 = new Product();

            product1.AssociatedParts = new BindingList<Part>();
            product1.ProductID = 0;
            product1.Name = "Blue Bicycle";
            product1.Price = 250.95M;
            product1.InStock = 2;
            product1.Min = 1;
            product1.Max = 5;
            product1.addAssociatedPart(Inventory.AllParts[0] as Part);
            product1.addAssociatedPart(Inventory.AllParts[2] as Part);

            product2.AssociatedParts = new BindingList<Part>();
            product2.ProductID = 1;
            product2.Name = "Mountain Bike";
            product2.Price = 275.00M;
            product2.InStock = 2;
            product2.Min = 1;
            product2.Max = 5;
            product2.addAssociatedPart(Inventory.AllParts[1] as Part);

            Inventory.addProduct(product1);
            Inventory.addProduct(product2);
        }
    }
}

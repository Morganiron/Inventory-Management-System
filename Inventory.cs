using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    internal static class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();

        public static BindingList<Part> AllParts = new BindingList<Part>();

        // Add a product to the Products list
        public static void addProduct(Product product)
        {
            Products.Add(product);
        }

        // Remove a Product to the Products list
        public static bool removeProduct(int element)
        {
            bool removed = false;
            try
            {
                Products.RemoveAt(element);
                removed = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
            return removed;
        }

        // Lookup a product by element
        public static Product lookupProduct(int element)
        {
            return Products[element];
        }

        // Update an existing product
        public static void updateProduct(int element, Product product)
        {
            Products[element] = product;
        }

        // Add a Part to the AllParts list
        public static void addPart(Part part)
        {
            AllParts.Add(part);
        }

        // Delete a Part from the AllParts list
        public static bool deletePart(Part part)
        {
            bool removed = false;
            try
            {
                AllParts.Remove(part);
                removed = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
            return removed;
        }

        // Look up a Part from the AllParts list
        public static Part lookupPart(int element)
        {
            return AllParts[element];
        }

        // Update an existing Part
        public static void updatePart(int element, Part part)
        {
            AllParts[element] = part;
        }
    }
}

using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;

namespace Inventory_Management_System
{
    internal class Product
    {
        // Product Properties
        public BindingList<Part> AssociatedParts { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        // Methods to access and modify product properties

        // Add a Part to the AssociatedParts list, in the correct position
        public void addAssociatedPart(Part part)
        {

            // Check for the position to add the part to the associated parts list
            foreach (Part p in AssociatedParts)
            {
                if (p.PartID < part.PartID)
                {
                    // If the Part being added has higher PartID, then move to the next part in the list
                    continue;
                }
                else if (p.PartID > part.PartID)
                {
                    // If the Part being added has a smaller PartID, then insert it here
                    AssociatedParts.Insert(AssociatedParts.IndexOf(p), part);
                    return;

                }
            }

            // If neither of the conditions were met, add the part to the end of the list
            AssociatedParts.Add(part);
        }

        // Remove a Part from the AssociatedParts list
        public bool removeAssociatedPart(Part part)
        {
            bool removed = false;

            try
            {
                AssociatedParts.Remove(part);
                removed = true;
            }
            // If implemented correctly, this should never happen
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }

            return removed;
        }

        // Lookup an associated part by the partID
        public Part lookupAssociatedPart(int partID)
        {
            var result = from part in AssociatedParts
                         where partID == part.PartID
                         select part;
            // If the part is not found, return null
            if (result.Count() < 1)
                return null;
            // There should only be one part with the partID, return the first result
            return result.First();
        }
    }
}

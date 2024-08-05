namespace Inventory_Management_System
{
    abstract class Part
    {
        // Common properties shared by all parts
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

    }
}

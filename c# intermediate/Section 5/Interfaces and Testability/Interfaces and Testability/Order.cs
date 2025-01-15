namespace Interfaces_and_Testability
{
    public class Order
    {
        public DateTime DatePlaced { get; set; }
        public float TotalPrice { get; set; }
        public Shipment Shipment { get; set; }
        public Order()
        {
            this.Shipment = new Shipment();
        }

        public bool IsShipped 
        {
            get { return Shipment != null; }
        }
    }
}

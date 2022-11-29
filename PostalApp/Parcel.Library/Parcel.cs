namespace Postal.Library
{
    public class Parcel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? ParcelName { get; set; }
        public string? ParcelDescription { get; set; }
        public bool Delivery { get; set; }
        public double ParcelWeight { get; set; }
        public double ParcelPrice { get; set; }
        public DateTime SendDate { get; set; }
        public string? SentFrom { get; set; }
        public string? SentTo { get; set; }
        public byte StatusId { get; set; }
        public byte ShippingId { get; set; }
    }
}

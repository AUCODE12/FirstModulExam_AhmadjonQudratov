namespace ConsoleApp1.Models
{
    public class House
    {
        public Guid Id { get; set; }
        
        public string Location { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public int QuentityRooms {  get; set; }
    }
}

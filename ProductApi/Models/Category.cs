namespace ProductAPI.Models
{
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; } = null!;
        public string MainCategory { get; set; } = null!;

    }
}
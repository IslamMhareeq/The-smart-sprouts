namespace Learn_App
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ID { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public int Points { get; set; }
        public List<Product> PurchasedItems { get; set; }

        // Constructor for new user
        public User(string username, string password, string id, string email, string gender = null, int points = 0)
        {
            Username = username;
            Password = password;
            ID = id;
            Email = email;
            Gender = gender;
            Points = points;
            PurchasedItems = new List<Product>();
        }

        public bool VerifyPassword(string password)
        {
            return Password == password;
        }

        public void AddProduct(Product product)
        {
            var existingProduct = PurchasedItems.FirstOrDefault(p => p.Name == product.Name);
            if (existingProduct != null)
            {
                existingProduct.Quantity += 1;
            }
            else
            {
                PurchasedItems.Add(product);
            }
        }
    }
}

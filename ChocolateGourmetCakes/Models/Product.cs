using System.Text.Json;

namespace ChocolateGourmetCakes.Models
  {
  public class Product
    {
      public int Product_id { get; set; }
    public string Product_catagory { get; set; }
    public string Product_title { get; set; }  
    public string Product_description { get; set; }    
    
    public double Product_price { get; set; }
    public int[] Rating { get; set; }
    public override string ToString() => JsonSerializer.Serialize<Product>(this);
      


    }
  }

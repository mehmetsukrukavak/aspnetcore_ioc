using System;
namespace IOC.Console
{
	public class DAL:IDAL
	{
		public List<Product> GetProducts()
		{
			return new List<Product>()
			{
				new Product(){  Id=1, Name = "Test Product 1", Price=19.86, Stock=20},
                new Product(){  Id=2, Name = "Test Product 2", Price=85.96, Stock=15},
                new Product(){  Id=3, Name = "Test Product 3", Price=15.73, Stock=59},
				new Product(){  Id=4, Name = "Test Product 4", Price=16.56, Stock=42}
            }; 
		}
	}
}


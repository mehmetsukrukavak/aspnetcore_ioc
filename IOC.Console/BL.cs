using System;
namespace IOC.Console
{
	public class BL
	{
		private static  DAL dal;

		public BL()
		{
			dal = new DAL();
		}

		public List<Product> GetProducts()
		{
			return dal.GetProducts();
		}

	}
}


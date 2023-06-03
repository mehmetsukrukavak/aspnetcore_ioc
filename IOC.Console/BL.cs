using System;
namespace IOC.Console
{
	public class BL
	{
		private static  IDAL dal { get; set; }

		public BL()
		{
			dal = DALFactory.GetDAL();
		}

		public List<Product> GetProducts()
		{
			return dal.GetProducts();
		}

	}
}


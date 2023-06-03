using System;
namespace IOC.Console
{
	public class BL
	{
		private static  IDAL _dal { get; set; }

		public BL(IDAL dal)
		{
			_dal = dal;
		}

		public List<Product> GetProducts()
		{
			return _dal.GetProducts();
		}

	}
}


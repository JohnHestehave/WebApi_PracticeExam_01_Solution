using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiWebApplication.Models
{
	public class Item
	{
		public int ItemNumber { get; set; }
		public string ItemDescription { get; set; }
		public decimal RatingPrice { get; set; }
		public decimal BidPrice { get; set; }
		public string BidCustomName { get; set; }
		public string BidCustomPhone { get; set; }
		public DateTime BidTimestamp { get; set; }

		public Item(int a, string b, decimal c, decimal d, string e, string f, DateTime g)
		{
			ItemNumber = a;
			ItemDescription = b;
			RatingPrice = c;
			BidPrice = d;
			BidCustomName = e;
			BidCustomPhone = f;
			BidTimestamp = g;
		}
	}
}
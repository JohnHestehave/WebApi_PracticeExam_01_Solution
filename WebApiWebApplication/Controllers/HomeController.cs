using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiWebApplication.Models;

namespace WebApiWebApplication.Controllers
{
    public class HomeController : ApiController
    {
		public static List<Item> Items = new List<Item>() {
			new Item(5, "Dør", 100m, 20m, "John", "12345678", new DateTime(2017, 12, 07, 12, 12, 12)),
			new Item(10, "Vindue", 200m, 50m, "John", "12345678", new DateTime(2017, 12, 07, 22, 22, 22))
		};
		// GET: api/Home
		public IEnumerable<Item> Get()
        {
            return Items;
        }

        // GET: api/Home/5
        public Item Get(int id)
        {
			return Items.Find(x=>x.ItemNumber == id);
        }

        // POST: api/Home
        public string Post([FromBody]Bid bid)
        {
			var item = Items.Find(x => x.ItemNumber == bid.ItemNumber);
			if (item == null) return "Item does not exist";
			if (bid.Price > item.BidPrice)
			{
				item.BidPrice = bid.Price;
				item.BidCustomName = bid.CustomName;
				item.BidCustomPhone = bid.CustomPhone;
				item.BidTimestamp = DateTime.Now;
				return "OK";
			}
			return "Bid too low";
		}

        // PUT: api/Home/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Home/5
        public void Delete(int id)
        {
        }
    }
}

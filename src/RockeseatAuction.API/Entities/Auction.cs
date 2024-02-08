using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace RockeseatAuction.API.Entities
{
    public class Auction
    {
        public int Id { get; set; }
        public String Name { get; set; } = string.Empty;
        public DateTime Starts { get; set; }
        public DateTime Ends { get; set; }
        public ICollection<Item> Items { get; set; } = new Collection<Item>();
    }
}
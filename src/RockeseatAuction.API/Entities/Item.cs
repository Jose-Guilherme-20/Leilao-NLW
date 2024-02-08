using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RockeseatAuction.API.Entities
{
    [Table("Items")]
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public Condition Condition { get; set; }
        public decimal BasePrice { get; set; }
        public int AuctionId { get; set; }
    }
}
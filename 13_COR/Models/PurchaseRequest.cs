using System;
using System.Collections.Generic;
using System.Text;

namespace _13_COR.Models
{
    public class PurchaseRequest
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public PurchaseRequest(string description, decimal amount)
        {
            Description = description;
            Amount = amount;
        }
    }
}

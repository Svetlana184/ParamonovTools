using _13_COR.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _13_COR.Handlers
{
    public class DirectorHandler : ApprovalHandler
    {
        protected override void Approve(PurchaseRequest purchaseRequest)
        {
            Console.WriteLine($"Директор не согласовал запрос: {purchaseRequest.Description}" + $"\n{purchaseRequest.Amount} рублей");
        }

        protected override bool CanApprove(PurchaseRequest purchaseRequest)
        {
            return purchaseRequest.Amount <= 500000;
        }
    }
}

using _13_COR.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _13_COR.Handlers
{
    public abstract class ApprovalHandler
    {
        private ApprovalHandler? _nextHandler;
        public ApprovalHandler SetNext(ApprovalHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public void Handle(PurchaseRequest purchaseRequest)
        {
            if(CanApprove(purchaseRequest))
            {
                Approve(purchaseRequest);
                return;
            }
            if(_nextHandler != null)
            {
                _nextHandler.Handle(purchaseRequest);
                return;
            }
            Console.WriteLine($"Заявка {purchaseRequest.Description} - не согласована");
        }

         protected abstract bool CanApprove(PurchaseRequest purchaseRequest);
         protected abstract void Approve(PurchaseRequest purchaseRequest);
    }
}

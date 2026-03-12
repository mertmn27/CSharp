using System;
using System.Collections.Generic;
using System.Text;
using Uygulama.Core.Context;
using Uygulama.Entities;

namespace Uygulama.Core.BusinessLogicLayer
{
    internal class CallHistoryService
    {
        public readonly CallHistoryContext context;
        public CallHistoryService()
        {
            context = new CallHistoryContext();
        }

        private List<CallHistory> GetAll()
        {
            return context.Repository.GetAll();
        }

        public List<CallHistory> GetAllByCustomerID(Guid id)
        {
            List<CallHistory> callHistories = GetAll();
            List<CallHistory> callHistoryCustomer = new List<CallHistory>();
            foreach(CallHistory item in callHistories)
            {
                if(item.CompanyID == id)
                {
                    callHistoryCustomer.Add(item);
                }
            }
            return callHistoryCustomer;
        }

        public void Add(CallHistory callhistory)
        {
            List<CallHistory> callHistories = GetAll();
            callHistories.Add(callhistory);
            context.Repository.Save(callHistories);
        }

        public void Update(CallHistory callhistory)
        {
            List<CallHistory> callHistories = GetAll();
            foreach (CallHistory item in callHistories)
            {
                if (item.ID == callhistory.ID)
                {
                    item.CallType = callhistory.CallType;
                    item.CallValue = callhistory.CallValue;
                    item.CallNote = callhistory.CallNote;
                    item.UpdatedOn = callhistory.UpdatedOn;
                    break;
                }
            }
            context.Repository.Save(callHistories);
        }

        public void Delete(Guid id)
        {
            List<CallHistory> callHistories = GetAll();
            for (int i = 0; i < callHistories.Count; i++)
            {
                if (callHistories[i].ID == id)
                {
                    callHistories.RemoveAt(i);
                }
            }
            context.Repository.Save(callHistories);
        }
    }
}

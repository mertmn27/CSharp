using System;
using System.Collections.Generic;
using System.Text;
using Uygulama.Core.Context;
using Uygulama.Entities;

namespace Uygulama.Core.BusinessLogicLayer
{
    internal class CustomerService
    {
        public readonly CustomerContext context;

        public CustomerService()
        {
            context = new CustomerContext();
        }

        public List<Customer> GetAll()
        {
            List<Customer> customers = context.Repository.GetAll();
            return customers;
        }

        public Customer GetByID(Guid id)
        {
            List<Customer> customers = GetAll();
            
            foreach(Customer item in customers)
            {
                if(item.ID == id)
                {
                    return item;
                }
            }
            return null;
        }

        public void Add(Customer customer)
        {
            List<Customer> customers = GetAll();
            customers.Add(customer);
            context.Repository.Save(customers);
        }

        public void Update(Customer customer)
        {
            List<Customer> customers = GetAll();
            foreach(Customer item in customers)
            {
                if(item.ID == customer.ID)
                {
                    item.CompanyName = customer.CompanyName;
                    item.FirstName = customer.FirstName;
                    item.LastName = customer.LastName;
                    item.UserID = customer.UserID;
                    item.UpdatedOn = customer.UpdatedOn;
                    break;
                }
            }
            context.Repository.Save(customers);
        }

        public void Delete(Guid id)
        {
            List<Customer> customers = GetAll();
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].ID == id)
                {
                    customers.RemoveAt(i);
                    break;
                }
            }
            context.Repository.Save(customers);
        }
    }
}

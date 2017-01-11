﻿using BudgieDatabaseLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgieEFUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //THIS IS FOR CODEFIRST

            BudgieDBCFModel context = new BudgieDBCFModel();


            //Add
            //Broker newBroker = new Broker() { name = "Bishan", companyId = 1 };
            //context.brokers.Add(newBroker);


            //Update
            //Broker brokerToUpdate = context.brokers.Find(1);
            //brokerToUpdate.name = "Ben";


            //Remove
            //foreach (Broker broker in context.brokers)
            //{
            //    if (broker.id == 3)
            //    {
            //        context.brokers.Remove(broker);
            //    }
            //}


            //context.SaveChanges();

            //foreach (Broker broker in context.brokers)
            //{
            //    Console.WriteLine(broker.name, broker.companyId);
            //}


            //LINQ SQL
            var query = from b in context.budgieUsers
                        where b.lastName == "Bowes"
                        select b;

            foreach (var budgie in query)
            {
                Console.WriteLine(budgie.firstName + " " + budgie.lastName + " " + budgie.dob);
            }


            Console.ReadLine();
        }
    }
}

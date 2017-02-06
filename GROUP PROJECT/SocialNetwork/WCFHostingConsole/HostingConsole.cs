﻿using SocialNetwork.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFHostingConsole
{
    class HostingConsole
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(SearchLogic)))
            {
                string address = "http://" + Dns.GetHostName() + ":8081/Bookshop";
                host.AddServiceEndpoint(typeof(ISearchLogic), new BasicHttpBinding(), address); 
                host.Open();                
            }

            Console.WriteLine("Press any key to stop hosting");
            Console.ReadLine();


          

            
        }
    }
}

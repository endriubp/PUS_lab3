using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Hostt
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Service1)))
            {
                //host.AddServiceEndpoint(typeof(IServicee1), new BasicHttpBinding(), "http://localhost:52850/Service1.svc");
                host.Open(); 
                Console.WriteLine("Calculator.Service1 hosted."); 
                Console.ReadKey(true);
                host.Close();
            }

        }
    }
}

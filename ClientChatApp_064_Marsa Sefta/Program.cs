using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WCFService_2Way_064;

namespace ClientChatApp_064_Marsa_Sefta
{
    class Program
    {
        static void Main(string[] args)
        {
            InstanceContext context = new InstanceContext(new ClientCallback());
            serviceReference1.ServiceCallbackClient server = new serviceReference1.ServiceCallbackClient(context);

            Console.Writeline("Enter Username");
        } 
        public class ClientCallback : ServiceReference1.IserviceCallbackCallback
        {
            public void pesanKirim (string user,string pesan)
            {
                Console.WriteLine("{0}: {1}", user, pesan);
            }
        }

       
    }
}

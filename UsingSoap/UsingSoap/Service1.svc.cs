using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BilletLib;

namespace UsingSoap
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        Bil bil = new Bil("12345", new DateTime(2018, 2, 1), false, false);
        Bil bil2 = new Bil("12345", new DateTime(2018, 2, 1), false, false);

        MC mc1 = new MC("1234", new DateTime(2018, 2, 1), false, false);


        public int GetPrisBil()
        {
           return bil.Pris();
            
        }

        public string GetBil()
        {
            return bil2.Køretøj();
        }

        public int GetPrisMC()
        {
            return mc1.Pris();
        }
    }
}

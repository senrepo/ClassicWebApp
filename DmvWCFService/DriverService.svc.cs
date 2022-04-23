using DmvWCFServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DmvWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class DriverService : IDriverService
    {
        public Driver GetDriverDetails(Driver driver)
        {
            if (driver != null && driver.LicenseNo == "12345")
            {
                driver.Name = "Test Driver";
                driver.DOB = "01/01/1980";
                driver.LicenseState = "CT";
            }
            return driver;
        }
    }
}

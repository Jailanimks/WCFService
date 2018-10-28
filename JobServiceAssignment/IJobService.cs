using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace JobServiceAssignment
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IJobService
    {

        [OperationContract]
        List<JobOpenings> GetAllJobOpenings();

        [OperationContract]
        List<JobOpenings> GetJobOpeningsByRole(string Role);
        
    }

    public class JobOpenings
    {
        public string JobRole { get; set; }
        public string JobDesc { get; set; }
    }

}

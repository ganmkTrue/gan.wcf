using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace wcf.service
{
    [ServiceContract]
    interface IHomeService
    {
        [OperationContract]
        string DoWork(string msg);
    }
}

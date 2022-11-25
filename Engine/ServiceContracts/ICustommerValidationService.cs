using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.DataContracts;
using System.ServiceModel;

namespace Engine.ServiceContracts
{
    [ServiceContract]
    public interface ICustommerValidationService
    {
        [OperationContract]
        Error[] ValidateName(CustommerName custommerName);
        [OperationContract]
        Error[] Validate(Custommer custommer);
    }
}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resource.DataContracts;
using System.ServiceModel;

namespace Resource.ServiceContracts
{
    // Everything which is named Contract means that it's public to be readen by other services 
    [ServiceContract]
    public interface ICustommerResource
    {
        [OperationContract]
        List<Custommer> GetAllCustommers();
        [OperationContract]
        Custommer GetCustommerByID(Guid ID);
        [OperationContract]
        void InsertCustommer(Custommer custommer);
        [OperationContract]
        void UpdateCustommer(Custommer custommer);
        [OperationContract]
        void DeleteCustommer(Guid ID);
    }
}


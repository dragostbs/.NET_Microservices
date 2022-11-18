using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manager.DataContracts;
using Manager.ServiceContracts;
using Utilities;


namespace Manager.Services
{
    public class CustommerService : ICustommerService
    {
        private readonly CustommerResource.ICustommerResource custommerResource;
        public CustommerService()
        {
            this.custommerResource = new CustommerResource.CustommerResourceClient();
        }
        public Manager.DataContracts.Custommer[] GetCustommers()
        {
            //APEL RESURSA
            CustommerResource.Custommer[] custommers = custommerResource.GetAllCustommers();
            List<Custommer> custommerList = new List<Custommer>();
            //MAPARE OBIECTE DIN CONTRACTUL RESURSEI CATRE CONTRACTUL MANAGERULUI
            foreach (CustommerResource.Custommer custommer in custommers)
                custommerList.Add(custommer.MapObject<Manager.DataContracts.Custommer>());
            return custommerList.ToArray();
        }
        public Manager.DataContracts.Custommer GetCustommerByID(Guid ID)
        {
            CustommerResource.Custommer custommer = custommerResource.GetCustommerByID(ID);
            return custommer.MapObject<Manager.DataContracts.Custommer>();
        }
        public void AddCustommer(Custommer custommer)
        {
            CustommerResource.Custommer newCustommer = custommer.MapObject < CustommerResource.Custommer > ();
            custommerResource.InsertCustommer(newCustommer);
        }
    }
}




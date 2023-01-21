using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel; 
using Newtonsoft.Json; 
using Utilities;

namespace ResourceProxy
{
    #region ResourceModels
    public class Custommer
    {
        public Guid IDCustommer { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public string Resume { get; set; }
    }
    #endregion Resource Models

    public class CustommerResourceProxy
    {
        private readonly string serviceBaseAddress = "net.tcp://localhost:8523/DataServices/";
        private readonly NetTcpBinding binding = new NetTcpBinding();
        private readonly ChannelFactory<Resource.ServiceContracts.ICustommerResource> channelFactory;
        private Resource.ServiceContracts.ICustommerResource client = null;
        public CustommerResourceProxy()
        {
            this.channelFactory = new ChannelFactory<Resource.ServiceContracts.ICustommerResource>(binding, serviceBaseAddress);
        }

        #region ChannelHelperMethods
        private void InitializeCustommerResourceClient()
        {
            if (this.client != null && this.client.GetType() == typeof(Resource.ServiceContracts.ICustommerResource))
                return;

            Resource.ServiceContracts.ICustommerResource client = null;

            try
            {
                this.client = channelFactory.CreateChannel();
            }
            catch (Exception exception)
            {
                (this.client as ICommunicationObject)?.Abort();
                    throw exception;
            }
        }
        private void Abort()
        {
            (client as ICommunicationObject)?.Abort();
        }
        private void CloseChannel()
        {
            ((ICommunicationObject)client).Close();
            channelFactory.Close();
        }
        #endregion ChannelHelperMethods

        #region ServiceProxyMethods 
        public List<Custommer> GetAllCustommers()
        {
            try
            {
                InitializeCustommerResourceClient();
                string jsonResult = JsonConvert.SerializeObject(client.GetAllCustommers());
                List<Custommer> custommers = JsonConvert.DeserializeObject<List<Custommer>>(jsonResult);
                CloseChannel();
                return custommers;
            }
            catch (Exception exception)
            {
                Abort();
                throw exception;
            }
        }
        public Custommer GetCustommerByID(Guid ID)
        {
            try
            {
                InitializeCustommerResourceClient();
                string jsonResult = JsonConvert.SerializeObject(client.GetCustommerByID(ID));
                Custommer custommer = JsonConvert.DeserializeObject<Custommer>(jsonResult);
                CloseChannel();
                return custommer;
            }
            catch (Exception exception)
            {
                Abort();
                throw exception;
            }
        }
        public void InsertCustommer(Custommer custommer)
        {
            try
            {
                InitializeCustommerResourceClient();
                client.InsertCustommer(custommer.MapObject<Resource.DataContracts.Custommer>());
                CloseChannel();
            }
            catch (Exception exception)
            {
                Abort();
                throw exception;
            }
        }
        public void UpdateCustommer(Custommer custommer)
        {
            try
            {
                InitializeCustommerResourceClient();
                client.UpdateCustommer(custommer.MapObject<Resource.DataContracts.Custommer>());
                CloseChannel();
            }
            catch (Exception exception)
            {
                Abort();
                throw exception;
            }
        }
        public void DeleteCustommer(Guid ID)
        {
            try
            {
                InitializeCustommerResourceClient();
                client.DeleteCustommer(ID);
                CloseChannel();
            }
            catch (Exception exception)
            {
                Abort();
                throw exception;
            }
        }
        #endregion
    }
}

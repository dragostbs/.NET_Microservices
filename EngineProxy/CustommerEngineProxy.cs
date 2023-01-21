using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Newtonsoft.Json;
using Utilities;

namespace EngineProxy
{
    #region ServiceModels
    public class Custommer
    {
        public Guid IDCustommer { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public string Resume { get; set; }
    }
    public class CustommerName
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
    }
    public class Error
    {
        public string ErrorCode { get; set; }
        public string Message { get; set; }
    }
    #endregion Service Models

    public class CustommerValidationProxy
    {
        private readonly string serviceBaseAddress = "net.tcp://localhost:8550/CustommerEngineService/";
        private readonly NetTcpBinding binding = new NetTcpBinding();
        private readonly ChannelFactory<Engine.ServiceContracts.ICustommerValidationService> channelFactory;
        private Engine.ServiceContracts.ICustommerValidationService client = null;
        public CustommerValidationProxy()
        {
            this.channelFactory = new ChannelFactory<Engine.ServiceContracts.ICustommerValidationService>(binding, serviceBaseAddress);
        }

        #region ChannelHelperMethods
        private void InitializeCustommerEngineClient()
        {
            if (this.client != null && this.client.GetType() == typeof(Engine.ServiceContracts.ICustommerValidationService))
                return;

            Engine.ServiceContracts.ICustommerValidationService client = null;

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
           //(ICommunicationObject)client).Close();
            channelFactory.Close();
        }
        #endregion ChannelHelperMethods

        #region ServiceProxyMethods 
        public Error[] ValidateName(CustommerName custommerName)
        {
            try
            {
                InitializeCustommerEngineClient();
                string jsonResult = JsonConvert.SerializeObject(client.ValidateName(custommerName.MapObject<Engine.DataContracts.CustommerName>()));
                Error[] errors = JsonConvert.DeserializeObject<Error[]>(jsonResult);
              //CloseChannel();
                return errors;
            }
            catch (Exception exception)
            {
                Abort();
                throw exception;
            }
        }
        public Error[] Validate(Custommer custommer)
        {
            try
            {
                InitializeCustommerEngineClient();
                string jsonResult = JsonConvert.SerializeObject(client.Validate(custommer.MapObject<Engine.DataContracts.Custommer>()));
                Error[] errors = JsonConvert.DeserializeObject<Error[]>(jsonResult);
              //CloseChannel();
                return errors;
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

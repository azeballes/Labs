using System.ServiceModel;

namespace SOAPHost
{
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        string SayHello(string name);
    }
}

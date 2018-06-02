using System;
using System.ServiceModel;

namespace SOAPHost
{
    class Program
    {
        static ServiceHost _service;

        static void Main(string[] args)
        {
            try
            {                
                _service = new ServiceHost(typeof(MyService));
                _service.Open();                
                Console.WriteLine(_service.BaseAddresses[0].AbsoluteUri + '\n' + "Tecla para salir...");
            }
            catch (AddressAccessDeniedException ex)
            {
                Console.WriteLine("Debe ejecutar la app en modo administrador" + '\n' + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
            }
            finally {
                Console.ReadKey();
                if (_service?.State == CommunicationState.Opened)
                    _service.Close();
            }

        }
    }
}

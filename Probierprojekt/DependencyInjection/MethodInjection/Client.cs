using System;
namespace Probierprojekt.DependencyInjection.MethodInjection
{
    public class Client
    {
        private IService _service;

        public void Start(IService service)
        {
            
            this._service = service;
            Console.WriteLine("Service Started");
            this._service.Serve();
            //To Do: Some Stuff
        }
    }
}

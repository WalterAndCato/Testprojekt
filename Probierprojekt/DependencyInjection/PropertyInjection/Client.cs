using System;
namespace Probierprojekt.DependencyInjection.PropertyInjection
{

    public class Client
    {
        private IService _service;

        public IService Service
        {
            set
            {
                this._service = value;
            }
        }
    }
}

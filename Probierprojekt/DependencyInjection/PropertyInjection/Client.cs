using System;
namespace Probierprojekt.DependencyInjection.PropertyInjection
{
    
    public class Client
	{
		private IServicde _service;

		public IServicde Service
		{
			set
			{
				this._service = value;
			}
		}
}

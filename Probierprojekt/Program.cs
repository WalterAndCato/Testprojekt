using System;
using Probierprojekt.DependencyInjection.ConstructorInjection;


namespace Probierprojekt
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            StartConstructorInjectionClient();

        }


        private static void StartConstructorInjectionClient(){
		    Client client = new Client(new Service());
			client.Start();
        }

    }
}

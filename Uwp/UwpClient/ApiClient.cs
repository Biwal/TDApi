using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Uwp.UwpClient
{
    public class ApiClient : UwpClient
    {
        private static ApiClient instance;
        public static ApiClient Instance
        {
            get
            {
                if (instance == null) { instance = new ApiClient(); }
                return instance;
            }
        }

        private ApiClient() 
        {
        }

        // url de base du Web API
        private static Uri _baseUri = new Uri("https://localhost:44336");

        // événement permettant de contourner la vérification des certificats
        // (ce qui est notre cas en dév !)
        private static HttpClientHandler handler
        {
            get
            {
                var handler = new HttpClientHandler();
                handler.ClientCertificateOptions = ClientCertificateOption.Manual;
                handler.ServerCertificateCustomValidationCallback =
                    (httpRequestMessage, cert, cetChain, policyErrors) => {
                        return true;
                    };
                return handler;
            }
        }


    }
}

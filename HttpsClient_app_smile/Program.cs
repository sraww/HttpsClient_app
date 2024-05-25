using System;
using System.Threading.Tasks;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Io

namepace HttpsClient_spp_smile
    class Program
{
    public static string fileOutput = "@D:\\Программы\\Программирование\\Visual studio projects\\HttpsClient_app_smile\\HttpsClient_app_smile\\TextFile1.txt";
    public static  async Task <string> CallUrl (string url)
    {
        HttpClient httpClient = new HttpClient ();
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        ClientCertificateOption 
    }
}
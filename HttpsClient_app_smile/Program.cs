﻿using System;
using System.Threading.Tasks;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace HttpsClient_spp_smile;
class Program
    {
    public static string fileOutput = "@D:\\Программы\\Программирование\\Visual studio projects\\HttpsClient_app_smile\\HttpsClient_app_smile\\TextFile1.txt";
    static void main(string[] args)
    {
        Console.Write("Вставь ссылку!");
        string url = Console.ReadLine();
        var awaiter = CallUrl(url);
        if (awaiter.Result !="") 
        {
            File.WriteAllText(fileOutput, awaiter.Result);
            Console.WriteLine("tHML Response output to " + fileOutput);
        }
        Console.WriteLine("Нажми любую кнопку");
    }
        

    public static  async Task <string> CallUrl (string url)
    {
        HttpClient client = new HttpClient ();
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        client.DefaultRequestHeaders.Accept.Clear();
        var response = client.GetStringAsync (url).Result;
        return  await response;
    }
}



    
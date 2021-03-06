﻿using System;
using System.Collections.Generic;
using Alsein.Utilities;
using System.Linq;
using Cynthia.Card.Server;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Alsein.Utilities.IO;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.SignalR.Client;
using System.Net;

namespace Cynthia.Card.Test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var IP = Dns.GetHostEntry("cynthia.ovyno.com").AddressList[0];
            var client = new HubConnectionBuilder()
                .WithUrl($"http://{IP}:5000/hub/gwent").Build();
            await client.StartAsync();
            Console.WriteLine($"注册结果为{await client.InvokeAsync<bool>("Register", "gezi", "123456", "格子")}");
            try
            {
                Console.WriteLine($"注册结果为{await client.InvokeAsync<bool>("Register", "gezi", "123456", "格子")}");
            }
            catch
            {
                Console.WriteLine("发生了异常");
            }
            Console.ReadLine();
        }
    }
}
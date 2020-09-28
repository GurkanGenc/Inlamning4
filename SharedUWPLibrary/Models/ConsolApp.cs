using Microsoft.Azure.Devices.Client;
using SharedUWPLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedUWPLibrary.Models
{
    public static class ConsolApp
    {
        private static readonly string _conn = "HostName=Inlamning3-iothub.azure-devices.net;DeviceId=ConsoleApp;SharedAccessKey=ptX988yL+vj8vS/Z4KQzewzdmmF4IJGyD2SLXCjCtgY=";

        // When we have a "CreateFromConnectionString" we need a connection string and a way to send information via a protocol.
        // And this is the IoT Device.
        private static readonly DeviceClient deviceClient = DeviceClient.CreateFromConnectionString(_conn, TransportType.Mqtt);

        public static void SendMessageToCloud()
        {
            // We do like this instead creating an instance because the function is static.
            DeviceUWPService.SendMessageAsync(deviceClient).GetAwaiter();

            DeviceUWPService.ReceiveMessageAsync(deviceClient).GetAwaiter();
        }
    }
}
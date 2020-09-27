using Microsoft.Azure.Devices.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedUWPLibrary.Models;
using Newtonsoft.Json;
using MAD = Microsoft.Azure.Devices;

namespace SharedUWPLibrary.Services
{
    public static class DeviceUWPService
    {
        // Device Client = IoT Device
        public static async Task SendMessageAsync(DeviceClient deviceClient, Msg msgs)
        {
            // "Message" is coming from "Microsoft.Azure.Devices.Client". And with "Encoding" we are formattin the "message".
            // We also use "GetBytes" because computers can only understand of bytes.
            // json variable here is message that we want to send actually.
            var json = JsonConvert.SerializeObject(msgs);
            var payload = new Message(Encoding.UTF8.GetBytes(json));
            await deviceClient.SendEventAsync(payload);
            // Now we have a function that send a message to the Cloud.
            // And now we need a "DeviceClient deviceClient" as an argument to pass.

            Console.WriteLine($"Message sent: {json}"); // To see the message.
        } // Device specific

        // Device Client = IoT Device
        public static async Task ReceiveMessageAsync(DeviceClient deviceClient)
        {
            while (true)
            {
                var payload = await deviceClient.ReceiveAsync();

                if (payload == null)
                    continue;

                Console.WriteLine($"Message Received: { Encoding.UTF8.GetString(payload.GetBytes()) }");

                await deviceClient.CompleteAsync(payload);
            }
        } // Device specific

        // Service Client = IoT Hub
        public static async Task SendMessageToDeviceAsync(MAD.ServiceClient serviceClient, string targetDeviceId, string message)
        {
            var payload = new MAD.Message(Encoding.UTF8.GetBytes(message));
            await serviceClient.SendAsync(targetDeviceId, payload);
        }
    }
}

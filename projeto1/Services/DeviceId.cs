using DeviceId;
using DeviceId.Encoders;
using DeviceId.Formatters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistente_de_Instalação.Services
{
    public static class DeviceService
    {
        private static readonly StringDeviceIdFormatter formatter = new(new PlainTextDeviceIdComponentEncoder());

        public static string GetUserName()
        {
            return new DeviceIdBuilder().UseFormatter(formatter).AddUserName().ToString();
        }
        public static string GetMachineName()
        {
            return new DeviceIdBuilder().UseFormatter(formatter)
                .AddMachineName()
                .OnWindows(w => w.AddProcessorId())
                .ToString();  
        }
    }
}

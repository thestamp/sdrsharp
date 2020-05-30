using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SDRSharp.Radio;

namespace SDRSharp.RTLSDR.UiConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            uint deviceIndex = 0;
           

            var devices = DeviceDisplay.GetActiveDevices();
            foreach (var deviceDisplay in devices)
            {
                deviceIndex = deviceDisplay.Index;
                Console.WriteLine($"{deviceDisplay.Index}: {deviceDisplay.Name}");
            }


            using (var device = new RtlDevice(deviceIndex))
            {
                device.Start();
                Console.ReadLine();

                device.Stop();

            }

            var controller = new ExtIOController("C:\\TEMP\\extio.dll");

            controller.Start();











            Console.ReadLine();
            //using (var _rtlDevice = new RtlDevice(0)) 
            //{
            //    _rtlDevice.SamplesAvailable += rtlDevice_SamplesAvailable;
            //    _rtlDevice.Frequency = _frequency;
            //}
        }

       




    }

    
}

//namespace test
//{
//    public unsafe sealed class SignalsClass
//    {

//        private void FrontendFiller(IFrontendController sender, Complex* data, int len)
//        {
//            //if (_iqStream.Length < _inputBufferSize * 4)
//            //{
//            //    _iqStream.Write(samples, len);
//            //}
//        }
//    }
//}

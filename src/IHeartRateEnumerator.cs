using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Plugin.BLE.Abstractions.Contracts;
using System.Threading.Tasks;

namespace nicold.heartrate
{
    //public class HeartRateDevice
    //{
    //    string Name;
    //}

    //public class HeartRateDevices : EventArgs
    //{
    //    IEnumerable<IDevice> Devices;
    //}

    interface IHeartRateEnumerator
    {
        bool StartDeviceScan();
        bool StopDeviceScan();
        event EventHandler<IDevice> DeviceScanUpdate;
        event EventHandler DeviceScanTimeout;
    }
}
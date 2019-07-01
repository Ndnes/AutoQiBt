using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AutoQiBtUI.Droid
{
    [BroadcastReceiver(Enabled = true)]
    [IntentFilter(new[] { Intent.ActionBatteryChanged })]
    class ChargeBroadcastReceiver : BroadcastReceiver
    {

        public override void OnReceive(Context context, Intent intent)
        {
            ToneGenerator t = new ToneGenerator(Android.Media.Stream.Alarm, 100);
            Tone tTone = Tone.SupPip;
            t.StartTone(tTone, 1000);
        }
    }
}
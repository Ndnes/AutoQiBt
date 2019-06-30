using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace AutoQiBtUI
{
    public class Logic
    {
        /// <summary>
        /// The previous status of bluetooth activation.
        /// True: Bluetooth was active before Qi charging.
        /// </summary>
        private bool _previousStatus;

        public bool PreviousStatus
        {
            get { return _previousStatus; }
            set { _previousStatus = value; }
        }



        void onQiChargeDetectedOn()
        {
            PreviousStatus = checkBtStatus();
        }

        void onQiChargeDetectedOff()
        {
          
        }


        bool checkIfChargingWireless()
        {
            var state = Battery.State;

            if (state == BatteryState.Charging)
            {
                var source = Battery.PowerSource;
                if (source == BatteryPowerSource.Wireless)
                {
                    return true;
                }
            }
            return false;
        }

        bool checkBtStatus()
        {
            return false;
        }

        void activateBt()
        {

        }
        void deactivateBt()
        {

        }
    }
}

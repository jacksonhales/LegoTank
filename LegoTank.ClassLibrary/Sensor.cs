using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lego.Ev3.Core;

namespace LegoTank.ClassLibrary
{
    public class Sensor
    {

        private ICommunication sensorPort;
        private float sensorValue;

        public ICommunication SensorPort
        {
            get { return sensorPort; }
            set { sensorPort = value; }
        }

        public float SensorValue
        {
            get { return sensorValue; }
            set { sensorValue = value; }
        }

        public Sensor()
        {

        }

    }
}

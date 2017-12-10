using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lego.Ev3.Core;
using Lego.Ev3.Desktop;

namespace LegoTank.ClassLibrary
{
    public class Controller
    {
             
        private Brick brick;
        private Sensor colourSensor;
        private Sensor gyroSensor;
        private Sensor ultrasonicSensor;
        private Motor leftMotor;
        private Motor rightMotor;
        
        public Brick Brick
        {
            get { return brick; }
            set { brick = value; }
        }

        public Sensor ColourSensor
        {
            get { return colourSensor; }
            set { colourSensor = value; }
        }

        public Sensor GyroSensor
        {
            get { return gyroSensor; }
            set { gyroSensor = value; }
        }

        public Sensor UltrasonicSensor
        {
            get { return ultrasonicSensor; }
            set { ultrasonicSensor = value; }
        }
        
        public Motor LeftMotor
        {
            get { return leftMotor; }
            set { leftMotor = value; }
        }

        public Motor RightMotor
        {
            get { return rightMotor; }
            set { rightMotor = value; }
        }


        public Controller()
        {

            brick = new Brick(new BluetoothCommunication("COM5"));

            colourSensor = new Sensor();
            gyroSensor = new Sensor();
            ultrasonicSensor = new Sensor();

            leftMotor = new Motor(OutputPort.C);
            rightMotor = new Motor(OutputPort.B);


            try
            {
                brick.ConnectAsync();
            }
            catch (Exception)
            {
                throw new Exception("Brick connection error.");
            }

        }

        public async Task MoveForward()
        {
            await brick.DirectCommand.TurnMotorAtPowerForTimeAsync(leftMotor.OutputPort | rightMotor.OutputPort, 100, 1000, true);
        }

        public async Task MoveLeft()
        {

        }

        public async Task MoveRight()
        {

        }

        public async Task MoveBackward()
        {

        }

    }
}

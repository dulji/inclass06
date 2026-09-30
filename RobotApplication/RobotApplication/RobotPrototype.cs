using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApplication
{
    public abstract class RobotPrototype
    {
        public string modelName;
        public string batteryCapacity;
        public string softwareVersion;

        public RobotPrototype(string model, string battery, string softv)
        {
            this.modelName = model;
            this.batteryCapacity = battery;
            this.softwareVersion = softv;
        }

        public abstract RobotPrototype Clone();

        public abstract void Display();

    }
}

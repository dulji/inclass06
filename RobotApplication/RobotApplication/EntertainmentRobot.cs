using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApplication
{
    internal class EntertainmentRobot : RobotPrototype
    {
        public string entertainmentTask;
        public EntertainmentRobot(string modelName, string batteryCapacity, string softwareVersion, string entertainmentTask) : base(modelName, batteryCapacity, softwareVersion)
        {
            this.entertainmentTask = entertainmentTask;
        }

        public override RobotPrototype Clone()
        {
            return new EntertainmentRobot(modelName, batteryCapacity, softwareVersion, entertainmentTask);
        }

        public override void Display()
        {
            Console.WriteLine($"EntertainmentRobot - Model Name = {modelName} - Battery Capacity = {batteryCapacity} - Software Version = {softwareVersion} - EntertainmentTask = {entertainmentTask}");
        }
    }
}

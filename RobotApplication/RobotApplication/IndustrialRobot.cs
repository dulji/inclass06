using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApplication
{
    public class IndustrialRobot : RobotPrototype
    {
        public string industrialTask;
        public IndustrialRobot(string modelName, string batteryCapacity, string softwareVersion, string industrialTask) : base(modelName, batteryCapacity, softwareVersion)
        {
            this.industrialTask = industrialTask;
        }

        public override RobotPrototype Clone()
        {
            return new IndustrialRobot(modelName, batteryCapacity, softwareVersion, industrialTask);
        }

        public override void Display()
        {
            Console.WriteLine($"IndustrialRobot - Model Name = {modelName} - Battery Capacity = {batteryCapacity} - Software Version = {softwareVersion} - IndustrialTask = {industrialTask}");
        }
    }
}

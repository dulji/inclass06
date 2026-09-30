using System;
using System.Collections.Generic;
using System.Text;

namespace RobotApplication
{
    public class ServiceRobot : RobotPrototype
    {
        public string serviceTask;
        public ServiceRobot(string modelName, string batteryCapacity, string softwareVersion, string serviceTask) : base(modelName, batteryCapacity, softwareVersion)
        {
            this.serviceTask = serviceTask;
        }

        public override RobotPrototype Clone()
        {
            return new ServiceRobot(modelName, batteryCapacity, softwareVersion, serviceTask);
        }

        public override void Display()
        {
            Console.WriteLine($"ServiceRobot - Model Name = {modelName} - Battery Capacity = {batteryCapacity} - Software Version = {softwareVersion} - Service = {serviceTask}");
        }
    }
}

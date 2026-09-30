using RobotApplication;

//industrialRobots

IndustrialRobot i1 = new IndustrialRobot("I200", "10Kwh", "V23.5", "Assembly");
i1.Display();

IndustrialRobot i2 = (IndustrialRobot)i1.Clone();
i2.modelName = "I205";
i2.batteryCapacity = "25kwh";
i2.Display();

IndustrialRobot i3 = (IndustrialRobot)i1.Clone();
i3.industrialTask = "Welding";
i3.Display();

//service Robots
ServiceRobot s1 = new ServiceRobot("S200", "10Kwh", "V23.5", "Cleaning");
s1.Display();

ServiceRobot s2 = (ServiceRobot)s1.Clone();
s2.modelName = "S205";
s2.batteryCapacity = "30kwh";
s2.Display();


ServiceRobot s3 = (ServiceRobot)s1.Clone();
s3.serviceTask = "Organizing";
s3.Display();

//

EntertainmentRobot e1 = new EntertainmentRobot("E200", "10Kwh", "V23.5", "Dancing");
e1.Display();

EntertainmentRobot e3 = (EntertainmentRobot)e1.Clone();
e3.entertainmentTask = "SingingCharacter";
e3.Display();














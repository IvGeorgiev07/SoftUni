using NUnit.Framework;

namespace RobotFactory.Tests
{
    public class Tests
    {
        private Robot robot;
        private string model = "T25";
        private double price =250.00;
        private int interfaceStandard = 10045;

        private Supplement supplement;
        private string name = "Rocket";        
        private int SupInterfaceStandard = 10045;

        private Factory factory;
        private string FactoryName = "oklahoma";
        private int capacity = 1;


        [SetUp]
        public void Setup()
        {
            robot = new Robot(model, price, interfaceStandard);
            supplement = new Supplement(name, SupInterfaceStandard);
            factory = new Factory(FactoryName, capacity);
        }

        [Test]
        public void RobotValuesSetTest()
        {
            Assert.AreEqual(robot.Model, model);
            Assert.AreEqual(robot.Price, price);
            Assert.AreEqual(robot.InterfaceStandard, interfaceStandard);

        }

        [Test]
        public void supplementTest()
        {
            Assert.AreEqual(factory.Name, FactoryName);
            
            Assert.AreEqual(factory.Capacity, capacity);

        }
        [Test]
        public void FactoryTest()
        {
            Assert.AreEqual(supplement.Name, name);

            Assert.AreEqual(supplement.InterfaceStandard, SupInterfaceStandard);

        }

        [Test]
        public void ProduceRobotTest()
        {
            Assert.AreEqual(factory.Capacity, 1);
            string result = factory.ProduceRobot(model,price, interfaceStandard);
            Assert.AreEqual(result, "Produced --> Robot model: T25 IS: 10045, Price: 250.00");
            Assert.AreEqual(factory.Capacity, factory.Robots.Count);
            result = factory.ProduceRobot(model, price, interfaceStandard);
            Assert.AreEqual(result, "The factory is unable to produce more robots for this production day!");
            
        }

        [Test]
        public void ProduceSupplementTest()
        {
            Assert.AreEqual(factory.Supplements.Count, 0);
            string result = factory.ProduceSupplement(name, interfaceStandard);
            Assert.AreEqual(factory.Supplements.Count, 1);
            Assert.AreEqual(result, "Supplement: Rocket IS: 10045");
        }

        [Test]
        public void UpgradeRobotTest()
        {
            Assert.AreEqual(factory.UpgradeRobot(robot, supplement),true);
            
        }

        [Test]
        public void SellTest()
        {
            Robot newRobot = factory.SellRobot(price);
            Assert.AreEqual(factory.Robots.Count, 0);

        }
    }
}
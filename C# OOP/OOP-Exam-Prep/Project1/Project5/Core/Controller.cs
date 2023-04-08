using RobotService.Core.Contracts;
using RobotService.Models;
using RobotService.Models.Contracts;
using RobotService.Repositories;
using RobotService.Repositories.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Core
{
    public class Controller : IController
    {
        private readonly IRepository<ISupplement> supplements;
        private readonly IRepository<IRobot> robots;
        private readonly List<ISupplement> supplementsList;
        private readonly List<IRobot> robotsList;

        public Controller()
        {
            supplements = new SupplementRepository();
            robots = new RobotRepository();
            robotsList = new List<IRobot>();
            supplementsList = new List<ISupplement>();
        }
        public string CreateRobot(string model, string typeName)
        {
            IRobot robot;
            if (typeName == nameof(DomesticAssistant))
            {
                robot = new DomesticAssistant(model);
                robots.AddNew(robot);
                robotsList.Add(robot);
                return String.Format(OutputMessages.RobotCreatedSuccessfully, typeName,model);
            }
            else if (typeName == nameof(IndustrialAssistant))
            {
                robot = new IndustrialAssistant(model);
                robots.AddNew(robot);
                robotsList.Add(robot);
                return String.Format(OutputMessages.RobotCreatedSuccessfully, typeName,model);
            }

            return String.Format(OutputMessages.RobotCannotBeCreated, typeName);
        }

        public string CreateSupplement(string typeName)
        {
            ISupplement supplement;
            if (typeName == nameof(SpecializedArm))
            {
                supplement = new SpecializedArm();
                supplements.AddNew(supplement);
                supplementsList.Add(supplement);
                return String.Format(OutputMessages.SupplementCreatedSuccessfully, typeName);
            }
            else if (typeName == nameof(LaserRadar))
            {
                supplement = new LaserRadar();
                supplements.AddNew(supplement);
                supplementsList.Add(supplement);
                return String.Format(OutputMessages.SupplementCreatedSuccessfully, typeName);
            }

            return String.Format(OutputMessages.SupplementCannotBeCreated, typeName);
        }
        public string UpgradeRobot(string model, string supplementTypeName)
        {
            
            IRobot robot = robotsList.FirstOrDefault(x => x.Model == model);
            ISupplement supplement = supplementsList.FirstOrDefault(x=>x.GetType().Name== supplementTypeName);
            int interfaceValue = supplement.InterfaceStandard;
            if(robot ==null)
            {
                return String.Format(OutputMessages.AllModelsUpgraded,model);
            }
            IRobot newRobot = robotsList.First();
            newRobot.InstallSupplement(supplement);
            robotsList.Remove(newRobot);
            supplements.RemoveByName(supplementTypeName);
            return String.Format(OutputMessages.UpgradeSuccessful, model, supplementTypeName);


        }

        public string PerformService(string serviceName, int intefaceStandard, int totalPowerNeeded)
        {
            throw new NotImplementedException();
        }

        public string Report()
        {
            throw new NotImplementedException();
        }

        public string RobotRecovery(string model, int minutes)
        {
            throw new NotImplementedException();
        }


    }
}

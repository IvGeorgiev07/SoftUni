using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Models
{
    public class SpecializedArm : Supplement
    {
        private const int InterfaceStandart = 10045;
        private const int Battery = 10000;
        public SpecializedArm()
            : base(InterfaceStandart, Battery)
        {
        }
    }
}

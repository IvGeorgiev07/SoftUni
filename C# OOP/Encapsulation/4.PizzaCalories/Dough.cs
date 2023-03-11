
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PizzaCalories
{
    internal class Dough
    {
        private string bakingTechnique;
        private string flourType;
        private int weigh;
        public Dough(string flourType, string bakingTechnique, int weigh)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weigh = weigh;
        }

        private string FlourType
        { get => flourType;
            set
            {
                if(value != "White" && value != "Wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                    
                }
                flourType = value;
            }
        }
        private string BakingTechnique
        {
            get => bakingTechnique;
            set
            {
                if (value != "Crispy" && value != "Chewy" && value != "Homemade")
                {
                    throw new ArgumentException("Invalid type of dough.1");
                }
                bakingTechnique = value;
            }
        }
        private int Weigh
        {
            get => weigh;
            set
            {
                if(value < 1 || value >200 )
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weigh= value;
            }
        }
        static int CaloriesPerGram => 2;
        private double FlourModifier { get; set; }
        private double BakingModifier { get; set; }
        public double DoughCalories()
        {            
            if(FlourType == "White")
            {
                FlourModifier = 1.5;
            }
            else if(FlourType == "Wholegrain")
            {
                FlourModifier = 1.0;
            }

            if(BakingTechnique == "Crispy")
            {
                BakingModifier = 0.9;
            }
            else if (BakingTechnique == "Chewy")
            {
                BakingModifier = 1.1;
            }
            else if (BakingTechnique == "Homemade")
            {
                BakingModifier = 1.0;
            }

            double calories = Weigh * CaloriesPerGram * FlourModifier * BakingModifier;
            return calories;
        }

    }
}

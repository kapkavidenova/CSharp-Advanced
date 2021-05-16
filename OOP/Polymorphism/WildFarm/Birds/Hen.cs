using System.Collections.Generic;
using WildFarm.Animals.Birds;
using WildFarm.Foods;

namespace WildFarm.Birds
{
    public class Hen : Bird
    {
        private const double BaseWeightModifier = 0.35;

        private static HashSet<string> allowdFoods = new HashSet<string>
        {
            nameof(Meat),
            nameof(Vegetable),
            nameof(Fruit),
            nameof(Seeds)
        };
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, allowdFoods, BaseWeightModifier, wingSize)
        {
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}

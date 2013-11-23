using System.Collections.Generic;
namespace DrinksLib.Base{
    public class Drink{
        public string username { get; set; }
        public int Drink_ID { get; set; }
        public string Name { get; set; }
        public string Definition { get; set; }
        public int Avatar_ID { get; set; }
        public Avatar avatar { get; set; }
        public IEnumerable<Instruction> instructions { get; set; }
        public IEnumerable<Rating> ratings { get; set; }
        public IEnumerable<Ingredient> ingredients { get; set; }
    }
}

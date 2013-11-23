namespace DrinksLib.Base{
    public class Ingredient{
        public int Ingredient_ID { get; set; }
        public string Long_Name { get; set; }
        public string Short_Name { get; set; }
        public decimal Amount { get; set; }
        public int Unit_ID { get; set; }
        public Unit unit { get; set; }
        public int Drink_ID { get; set; }
    }
}

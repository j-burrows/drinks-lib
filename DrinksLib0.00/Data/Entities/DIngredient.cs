using System.Data;
using Repository.Data;
using Repository.Helpers;
namespace DrinksLib.Data.Entities{
    public class DIngredient : DrinksLib.Business.BIngredient, IDataUnit{
        public int key {
            get { return Ingredient_ID; }
            set { Ingredient_ID = value; }
        }

        public string dataError { get; set; }

        public void InitFromRow(DataRow row) {
            Ingredient_ID = row["Ingredient_ID"].ToInt();
            Long_Name = row["Long_Name"].ToStr();
            Short_Name = row["Short_Name"].ToStr();
            Amount = row["Amount"].ToInt();
            Unit_ID = row["Unit_ID"].ToInt();
            Drink_ID = row["Drink_ID"].ToInt();
        }
        
        public override bool Equivilant(Repository.Business.IBusinessUnit comparing){
            return this.MatchingKeyAndType<DIngredient>(comparing);
        }

        public void Scrub() {
            Long_Name = Long_Name.Scrub();
            Short_Name = Short_Name.Scrub();
        }
    }
}

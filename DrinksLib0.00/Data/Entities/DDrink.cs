using System.Data;
using DrinksLib.Factory;
using Repository.Data;
using Repository.Helpers;
namespace DrinksLib.Data.Entities{
    public class DDrink : DrinksLib.Business.BDrink, IDataUnit{
        public int key {
            get { return Drink_ID; }
            set { Drink_ID = value; }
        }

        public string dataError { get; set; }
        
        public void InitFromRow(DataRow row) {
            username = row["username"].ToStr();
            Drink_ID = row["Drink_ID"].ToInt();
            Name = row["Name"].ToStr();
            Definition = row["Definition"].ToStr();
            Avatar_ID = row["Avatar_ID"].ToInt();

            ingredients = RepositoryFactory.Instance.Construct<DIngredient>(Drink_ID);
        }
        
        public override bool Equivilant(Repository.Business.IBusinessUnit comparing){
            return this.MatchingKeyAndType<DDrink>(comparing);
        }

        public void Scrub() {
            Name = Name.Scrub();
            Definition = Definition.Scrub();
        }
    }
}

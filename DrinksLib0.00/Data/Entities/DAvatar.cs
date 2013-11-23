using System.Data;
using Repository.Data;
using Repository.Helpers;
namespace DrinksLib.Data.Entities{
    public class DAvatar : DrinksLib.Business.BAvatar, IDataUnit{
        public int key {
            get { return Avatar_ID; }
            set { Avatar_ID = value; }
        }

        public string dataError { get; set; }

        public void InitFromRow(DataRow row) {
            Avatar_ID = row["Ingredient_ID"].ToInt();
            Title = row["Title"].ToStr();
            Url = row["Url"].ToStr();
        }

        public override bool Equivilant(Repository.Business.IBusinessUnit comparing){
            return this.MatchingKeyAndType<DAvatar>(comparing);
        }

        public void Scrub() {
            Title = Title.Scrub();
            Url = Url.Scrub();
        }
    }
}

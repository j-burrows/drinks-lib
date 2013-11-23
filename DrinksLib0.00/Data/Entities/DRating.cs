using System.Data;
using Repository.Data;
using Repository.Helpers;
namespace DrinksLib.Data.Entities{
    public class DRating : DrinksLib.Business.BRating, IDataUnit{
        public int key {
            get { return Rating_ID; }
            set { Rating_ID = value; }
        }

        public string dataError { get; set; }

        public void InitFromRow(DataRow row) {
            Rating_ID = row["Rating_ID"].ToInt();
            Drink_ID = row["Drink_ID"].ToInt();
            Score = row["Score"].ToInt();
            Reasons = row["Reasons"].ToStr();
        }
        
        public override bool Equivilant(Repository.Business.IBusinessUnit comparing){
            return this.MatchingKeyAndType<DRating>(comparing);
        }

        public void Scrub() {
            Reasons = Reasons.Scrub();
        }
    }
}

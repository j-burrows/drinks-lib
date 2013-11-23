using System.Data;
using Repository.Data;
using Repository.Helpers;
namespace DrinksLib.Data.Entities{
    public class DUnit : DrinksLib.Business.BUnit, IDataUnit{
        public int key {
            get { return Unit_ID; }
            set { Unit_ID = value; }
        }

        public string dataError { get; set; }

        public void InitFromRow(DataRow row) {
            Unit_ID = row["Unit_ID"].ToInt();
            Long_Name = row["Long_Name"].ToStr();
            Short_Name = row["Short_Name"].ToStr();
        }
        
        public override bool Equivilant(Repository.Business.IBusinessUnit comparing){
            return this.MatchingKeyAndType<DUnit>(comparing);
        }

        public void Scrub() {
            Long_Name = Long_Name.Scrub();
            Short_Name = Short_Name.Scrub();
        }
    }
}

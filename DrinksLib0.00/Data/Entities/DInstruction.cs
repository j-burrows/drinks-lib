using System.Data;
using Repository.Data;
using Repository.Helpers;
namespace DrinksLib.Data.Entities{
    public class DInstruction : DrinksLib.Business.BInstruction, IDataUnit{
        public int key {
            get { return Instruction_ID; }
            set { Instruction_ID = value; }
        }

        public string dataError { get; set; }

        public void InitFromRow(DataRow row) {
            Instruction_ID = row["Instruction_ID"].ToInt();
            Description = row["Description"].ToStr();
            Time = row["Time"].ToInt();
            Drink_ID = row["Drink_ID"].ToInt();
        }
        
        public override bool Equivilant(Repository.Business.IBusinessUnit comparing){
            return this.MatchingKeyAndType<DInstruction>(comparing);
        }

        public void Scrub() {
            Description = Description.Scrub();
        }
    }
}

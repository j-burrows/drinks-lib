using System.Data;
using Repository.Data;
using Repository.Helpers;
namespace DrinksLib.Data.Entities{
    public class DDefined_Instruction : 
        DrinksLib.Business.BDefined_Instruction, 
        IDataUnit{
        public int key {
            get { return Defined_Instruction_ID; }
            set { Defined_Instruction_ID = value; }
        }

        public string dataError { get; set; }
        
        public void InitFromRow(DataRow row) {
            Defined_Instruction_ID = row["Defined_Instruction_ID"].ToInt();
            Description = row["Description"].ToStr();
        }

        public override bool Equivilant(Repository.Business.IBusinessUnit comparing){
            return this.MatchingKeyAndType<DDefined_Instruction>(comparing);
        }

        public void Scrub() {
            Description = Description.Scrub();
        }
    }
}

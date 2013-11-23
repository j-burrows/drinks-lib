using System.Data;
using System.Data.SqlClient;
using DrinksLib.Data.Entities;
using Repository.Data;
using Repository.Helpers;

namespace DrinksLib.Data.Repositories{
    public class SqlSDefined_InstructionRepository: SqlSRepository<DDefined_Instruction>{
        public SqlSDefined_InstructionRepository(int Drink_ID) {
            string query = string.Format(
                @"EXEC Drinks.Defined_Instruction_GetList';",
                Drink_ID
            );

            FillRepository(query);
        }

        protected override void CreateEval(DDefined_Instruction creating){
            SqlCommand cmd = new SqlCommand("Drinks.Defined_Instruction_Create");
            cmd.AddParam("Description", creating.Description);

            creating.key = ExecStoredProcedure(cmd);

            base.CreateEval(creating);
        }

        protected override void UpdateEval(DDefined_Instruction updating){
            SqlCommand cmd = new SqlCommand("Drinks.Defined_Instruction_Update");
            cmd.AddParam("Defined_Instruction_ID", updating.Defined_Instruction_ID);
            cmd.AddParam("Description", updating.Description);

            ExecNonReader(cmd);

            base.UpdateEval(updating);
        }

        protected override void DeleteEval(DDefined_Instruction deleting){
            SqlCommand cmd = new SqlCommand("Drinks.Defined_Instruction_Deleting");
            cmd.AddParam("Defined_Instruction_ID", deleting.Defined_Instruction_ID);

            ExecNonReader(cmd);

            base.DeleteEval(deleting);
        }
    }
}

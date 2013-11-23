using System.Data;
using System.Data.SqlClient;
using DrinksLib.Data.Entities;
using Repository.Data;
using Repository.Helpers;

namespace DrinksLib.Data.Repositories{
    public class SqlSInstructionRepository: SqlSRepository<DInstruction>{
        public SqlSInstructionRepository(int Drink_ID) {
            string query = string.Format(
                @"EXEC Drinks.Instruction_GetByDrink @Drink_ID = '{0}';",
                Drink_ID
            );
            FillRepository(query);
        }

        protected override void CreateEval(DInstruction creating){
            SqlCommand cmd = new SqlCommand("Drinks.Instruction_Create");
            cmd.AddParam("Description", creating.Description);
            cmd.AddParam("Time", creating.Time);
            cmd.AddParam("Drink_ID", creating.Drink_ID);

            creating.key = ExecStoredProcedure(cmd);

            base.CreateEval(creating);
        }

        protected override void UpdateEval(DInstruction updating){
            SqlCommand cmd = new SqlCommand("Drinks.Instruction_Update");
            cmd.AddParam("Description", updating.Description);
            cmd.AddParam("Time", updating.Time);
            cmd.AddParam("Instruction_ID", updating.Instruction_ID);

            ExecNonReader(cmd);

            base.UpdateEval(updating);
        }

        protected override void DeleteEval(DInstruction deleting){
            SqlCommand cmd = new SqlCommand("Drinks.Instruction_Delete");
            cmd.AddParam("Instruction_ID", deleting.Instruction_ID);

            ExecNonReader(cmd);

            base.DeleteEval(deleting);
        }
    }
}

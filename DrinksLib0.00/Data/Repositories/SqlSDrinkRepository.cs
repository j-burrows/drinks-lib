using System.Data;
using System.Data.SqlClient;
using DrinksLib.Data.Entities;
using Repository.Data;
using Repository.Helpers;

namespace DrinksLib.Data.Repositories{
    public class SqlSDrinkRepository: SqlSRepository<DDrink>{
        public SqlSDrinkRepository(string username) {
            string query = string.Format(
                @"EXEC Drinks.Drink_GetByUser @username = '{0}';",
                username
            );
            FillRepository(query);
        }

        protected override void CreateEval(DDrink creating){
            SqlCommand cmd = new SqlCommand("Drinks.Drink_Create");
            cmd.AddParam("username", creating.username);
            cmd.AddParam("Name", creating.Name);
            cmd.AddParam("Definition", creating.Definition);

            creating.key = ExecStoredProcedure(cmd);

            base.CreateEval(creating);
        }

        protected override void UpdateEval(DDrink updating){
            SqlCommand cmd = new SqlCommand("Drinks.Drink_Update");
            cmd.AddParam("Drink_ID", updating.Drink_ID);
            cmd.AddParam("Name", updating.Name);
            cmd.AddParam("Definition", updating.Definition);

            ExecNonReader(cmd);

            base.UpdateEval(updating);
        }

        protected override void DeleteEval(DDrink deleting){
            SqlCommand cmd = new SqlCommand("Drinks.Drink_Delete");
            cmd.AddParam("Drink_ID", deleting.Drink_ID);

            ExecNonReader(cmd);

            base.DeleteEval(deleting);
        }
    }
}

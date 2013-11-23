using System.Data;
using System.Data.SqlClient;
using DrinksLib.Data.Entities;
using Repository.Data;
using Repository.Helpers;
namespace DrinksLib.Data.Repositories{
    public class SqlSUnitRepository : SqlSRepository<DUnit>{
        public SqlSUnitRepository() {
            string query = string.Format(
                @"EXEC dbo.Unit_GetList;"
            );
            FillRepository(query);
        }

        public SqlSUnitRepository(int Ingredient_ID) {
            string query = string.Format(
                @"EXEC dbo.Unit_GetByIngredient @Ingredient_ID = '{0}';",
                Ingredient_ID
            );
            FillRepository(query);
        }

        protected override void CreateEval(DUnit creating){
            SqlCommand cmd = new SqlCommand("dbo.Unit_Create");
            cmd.AddParam("Short_Name", creating.Short_Name);
            cmd.AddParam("Long_Name", creating.Long_Name);

            creating.key = ExecStoredProcedure(cmd);

            base.CreateEval(creating);
        }

        protected override void UpdateEval(DUnit updating){
            SqlCommand cmd = new SqlCommand("dbo.Unit_Update");
            cmd.AddParam("Unit_ID", updating.Unit_ID);
            cmd.AddParam("Long_Name", updating.Long_Name);
            cmd.AddParam("Short_Name", updating.Short_Name);

            ExecNonReader(cmd);

            base.UpdateEval(updating);
        }

        protected override void DeleteEval(DUnit deleting){
            SqlCommand cmd = new SqlCommand("dbo.Unit_Delete");
            cmd.AddParam("Unit_ID", deleting.Unit_ID);

            ExecNonReader(cmd);

            base.DeleteEval(deleting);
        }
    }
}

using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DrinksLib.Data.Entities;
using Repository.Data;
using Repository.Helpers;

namespace DrinksLib.Data.Repositories{
    public class SqlSIngredientRepository: SqlSRepository<DIngredient>{
        public SqlSIngredientRepository(string username) {
            string query = string.Format(
                @"EXEC Drinks.Ingredient_GetByUser @username = '{0}';",
                username
            );

            FillRepository(query);
        }

        public SqlSIngredientRepository(int Drink_ID) {
            string query = string.Format(
                @"EXEC Drinks.Ingredient_GetByDrink @Drink_ID = '{0}';",
                Drink_ID
            );

            FillRepository(query);
        }

        protected override void CreateEval(DIngredient creating){
            SqlCommand cmd = new SqlCommand("Drinks.Ingredient_Create");
            cmd.AddParams(
                new Param("Drink_ID", creating.Drink_ID),
                new Param("Long_Name", creating.Long_Name),
                new Param("Short_Name", creating.Short_Name),
                new Param("Amount", creating.Amount),
                new Param("Unit_ID", creating.Unit_ID)
            );

            creating.key = ExecStoredProcedure(cmd);

            base.CreateEval(creating);
        }

        protected override void UpdateEval(DIngredient updating){
            SqlCommand cmd = new SqlCommand("Drinks.Ingredient_Update");
            cmd.AddParams(
                new Param("Ingredient_ID", updating.Ingredient_ID),
                new Param("Long_Name", updating.Long_Name),
                new Param("Short_Name", updating.Short_Name),
                new Param("Amount", updating.Amount),
                new Param("Unit_ID", updating.Unit_ID)
            );

            ExecNonReader(cmd);

            base.UpdateEval(updating);
        }

        protected override void DeleteEval(DIngredient deleting){
            SqlCommand cmd = new SqlCommand("Drinks.Ingredient_Delete");
            cmd.AddParam("Ingredient_ID", deleting.Ingredient_ID);

            ExecNonReader(cmd);

            base.DeleteEval(deleting);
        }
    }
}

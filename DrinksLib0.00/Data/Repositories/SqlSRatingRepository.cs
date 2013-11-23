using System.Data;
using System.Data.SqlClient;
using DrinksLib.Data.Entities;
using Repository.Data;
using Repository.Helpers;
namespace DrinksLib.Data.Repositories{
    public class SqlSRatingRepository: SqlSRepository<DRating>{
        public SqlSRatingRepository(int Drink_ID) {
            string query = string.Format(
                @"EXEC Drinks.Rating_GetByDrink @Drink_ID = '{0}';",
                Drink_ID
            );
            FillRepository(query);
        }

        public SqlSRatingRepository(string username, int Drink_ID) {
            string query = string.Format(
                @"EXEC Drinks.Rating_GetByUserDrink 
                    @username = '{0}',
                    @Drink_ID = '{1}';",
                username, Drink_ID
            );

            FillRepository(query);
        }

        protected override void CreateEval(DRating creating){
            SqlCommand cmd = new SqlCommand("Drinks.Rating_Create");
            cmd.AddParam("Drink_ID", creating.Drink_ID);
            cmd.AddParam("Score", creating.Score);
            cmd.AddParam("Reasons", creating.Reasons);

            creating.key = ExecStoredProcedure(cmd);

            base.CreateEval(creating);
        }

        protected override void UpdateEval(DRating updating){
            SqlCommand cmd = new SqlCommand("Drinks.Rating_Update");
            cmd.AddParam("Rating_ID", updating.Rating_ID);
            cmd.AddParam("Score", updating.Score);
            cmd.AddParam("Reasons", updating.Reasons);

            ExecNonReader(cmd);

            base.UpdateEval(updating);
        }

        protected override void DeleteEval(DRating deleting){
            SqlCommand cmd = new SqlCommand("Drinks.Rating_Delete");
            cmd.AddParam("Rating_ID", deleting.Rating_ID);

            ExecNonReader(cmd);

            base.DeleteEval(deleting);
        }
    }
}

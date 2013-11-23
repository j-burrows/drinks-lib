using System.Data;
using System.Data.SqlClient;
using DrinksLib.Data.Entities;
using Repository.Data;
using Repository.Helpers;

namespace DrinksLib.Data.Repositories{
    public class SqlSAvatarRepository : SqlSRepository<DAvatar>{
        public SqlSAvatarRepository(int Drink_ID) {
            //Collection is filled with all avatars associated with given drink.
            string query = string.Format(
                @"EXEC Drinks.Avatar_GetByDrink @Drink_ID = '{0}';",
                Drink_ID
            );
            FillRepository(query);
        }

        protected override void CreateEval(DAvatar creating){
            SqlCommand cmd = new SqlCommand("Drinks.Avatar_Create");
            cmd.AddParam("Title", creating.Title);
            cmd.AddParam("Url", creating.Url);

            creating.key = ExecStoredProcedure(cmd);

            base.CreateEval(creating);
        }

        protected override void UpdateEval(DAvatar updating){
            SqlCommand cmd = new SqlCommand("Drinks.Avatar_Update");
            cmd.AddParam("Avatar_ID", updating.Avatar_ID);
            cmd.AddParam("Title", updating.Title);
            cmd.AddParam("Url", updating.Url);

            ExecNonReader(cmd);

            base.UpdateEval(updating);
        }

        protected override void DeleteEval(DAvatar deleting){
            SqlCommand cmd = new SqlCommand("Drinks.Avatar_Delete");
            cmd.AddParam("Avatar_ID", deleting.Avatar_ID);

            ExecNonReader(cmd);

            base.DeleteEval(deleting);
        }
    }
}

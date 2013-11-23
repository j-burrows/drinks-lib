using System.Collections.Generic;
using DrinksLib.Data.Entities;
using DrinksLib.Factory;
using Repository.Data;
using System.Linq;
using System;

namespace DrinksLib{
    public class DrinksService : IDrinksService{
        public IEnumerable<DDrink> Avatar_Create(int drink_ID, DAvatar creating, 
            string username){
            //drinks is a collection of all drinks belonging to given user.
            IDataRepository<DDrink> drinks = 
                RepositoryFactory.Instance.Construct<DDrink>(username);
            DDrink parent;

            if((parent = drinks.FirstOrDefault(x => x.Drink_ID == drink_ID)) != null){
                //The drink having the avatar assigned belongs to the given user.
                IDataRepository<DAvatar> avatars = 
                    RepositoryFactory.Instance.Construct<DAvatar>(parent.Drink_ID);
                if (creating.CreateValid()) {
                    avatars.Create(creating);
                    //The drink has its avatar updated to reflect creation in repository
                    parent.avatar = creating;
                    parent.Avatar_ID = creating.Avatar_ID;
                }
            }
            return drinks;
        }

        public IEnumerable<DDrink> Avatar_Update(int drink_ID, DAvatar updating, 
            string username){
            //drinks is a collection of all drinks belonging to given user.
            IDataRepository<DDrink> drinks =
                RepositoryFactory.Instance.Construct<DDrink>(username);
            DDrink parent;

            if((parent = drinks.FirstOrDefault(x => x.Drink_ID == drink_ID)) != null){
                //The drink having the avatar assigned belongs to the given user.
                IDataRepository<DAvatar> avatars = 
                    RepositoryFactory.Instance.Construct<DAvatar>(parent.Drink_ID);
                if (updating.UpdateValid()) {
                    avatars.Update(updating);
                    //The drink has its avatar updated to reflect changes made in repository
                    parent.avatar = updating;
                    parent.Avatar_ID = updating.Avatar_ID;
                }
            }
            return drinks;                    //Targetted drink belongs to different user.
        }

        public IEnumerable<DDrink> Avatar_Delete(int drink_ID, DAvatar deleting, 
            string username) {
            //drinks is a collection of all drinks belonging to given user.
            IDataRepository<DDrink> drinks = 
                RepositoryFactory.Instance.Construct<DDrink>(username);
            DDrink parent;

            if((parent = drinks.FirstOrDefault(x => x.Drink_ID == drink_ID)) != null){
                IDataRepository<DAvatar> avatars = 
                    RepositoryFactory.Instance.Construct<DAvatar>(parent.Drink_ID);
                if (deleting.DeleteValid()) {
                    avatars.Update(deleting);
                    //The drink has its avatar updated to reflect deletion in repository
                    parent.avatar = null;
                    parent.Avatar_ID = 0;
                }
            }
            return drinks;                    //Targetted drink belongs to different user.
        }

        public IEnumerable<DDefined_Instruction> Defined_Instruction_GetList(){
            return RepositoryFactory.Instance.Construct<DDefined_Instruction>();
        }

        public IEnumerable<DDefined_Instruction> Defined_Instruction_Create(
            DDefined_Instruction creating){
            IDataRepository<DDefined_Instruction> definedInstructions =
                RepositoryFactory.Instance.Construct<DDefined_Instruction>();
            definedInstructions.Create(creating);
            return definedInstructions;
        }

        public IEnumerable<DDefined_Instruction> Defined_Instruction_Update(
            DDefined_Instruction updating){
            IDataRepository<DDefined_Instruction> definedInstructions =
                RepositoryFactory.Instance.Construct<DDefined_Instruction>();
            definedInstructions.Update(updating);
            return definedInstructions;
        }

        public IEnumerable<DDefined_Instruction> Defined_Instruction_Delete(
            DDefined_Instruction deleting){
            IDataRepository<DDefined_Instruction> definedInstructions =
                RepositoryFactory.Instance.Construct<DDefined_Instruction>();
            definedInstructions.Delete(deleting);
            return definedInstructions;
        }

        public IEnumerable<DDrink> Drink_GetByUser(string username){
            return RepositoryFactory.Instance.Construct<DDrink>(username);
        }

        public IEnumerable<DDrink> Drink_Create(DDrink creating, string username){
            IDataRepository<DDrink> drinks =
                RepositoryFactory.Instance.Construct<DDrink>(username);
            if(creating.username == username){
                drinks.Create(creating);
            }
            return drinks;
        }

        public IEnumerable<DDrink> Drink_Update(DDrink updating, string username){
            IDataRepository<DDrink> drinks =
                RepositoryFactory.Instance.Construct<DDrink>(username);
            if(updating.username == username){
                drinks.Update(updating);
            }
            return drinks;
        }

        public IEnumerable<DDrink> Drink_Delete(DDrink deleting, string username){
            IDataRepository<DDrink> drinks =
                RepositoryFactory.Instance.Construct<DDrink>(username);
            if(deleting.username == username){
                drinks.Delete(deleting);
            }
            return drinks;
        }

        public IEnumerable<DIngredient> Ingredient_GetByUser(string username){
            return RepositoryFactory.Instance.Construct<DIngredient>(username);
        }

        public IEnumerable<DDrink> Ingredient_Create(DIngredient creating, string username){
            IDataRepository<DDrink> drinks =
                RepositoryFactory.Instance.Construct<DDrink>(username);
            IDataRepository<DIngredient> ingredients;

            if((ingredients = drinks.FirstOrDefault(x => x.Drink_ID == creating.Drink_ID)
                .ingredients as IDataRepository<DIngredient>) != null){
                //Drinks for ingredient does belong to given user.
                ingredients.Create(creating);
            }
            return drinks;
        }

        public IEnumerable<DDrink> Ingredient_Update(DIngredient updating, string username){
            IDataRepository<DDrink> drinks =
                RepositoryFactory.Instance.Construct<DDrink>(username);
            IDataRepository<DIngredient> ingredients;

            if((ingredients = drinks.FirstOrDefault(x => x.Drink_ID == updating.Drink_ID)
                .ingredients as IDataRepository<DIngredient>) != null){
                //Drinks for ingredient does belong to given user.
                ingredients.Update(updating);
            }
            return drinks;
        }

        public IEnumerable<DDrink> Ingredient_Delete(DIngredient deleting, string username){
            IDataRepository<DDrink> drinks =
                RepositoryFactory.Instance.Construct<DDrink>(username);
            IDataRepository<DIngredient> ingredients;

            if ((ingredients = drinks.FirstOrDefault(x => x.Drink_ID == deleting.Drink_ID)
                .ingredients as IDataRepository<DIngredient>) != null){
                //Drinks for ingredient does belong to given user.
                ingredients.Delete(deleting);
            }
            return drinks;
        }

        public IEnumerable<DDrink> Instruction_Create(DInstruction creating,
            string username){
            IDataRepository<DDrink> drinks =
                RepositoryFactory.Instance.Construct<DDrink>(username);
            IDataRepository<DInstruction> instructions;

            if((instructions = drinks.FirstOrDefault(x => creating.Drink_ID == x.Drink_ID)
                .instructions as IDataRepository<DInstruction>) != null){
                //Drinks for instruction belong to the given user.
                instructions.Create(creating);
            }
            return drinks;
        }

        public IEnumerable<DDrink> Instruction_Update(DInstruction updating,
            string username){
            IDataRepository<DDrink> drinks =
                RepositoryFactory.Instance.Construct<DDrink>(username);
            IDataRepository<DInstruction> instructions;

            if((instructions = drinks.FirstOrDefault(x => updating.Drink_ID == x.Drink_ID)
                .instructions as IDataRepository<DInstruction>) != null){
                //Drinks for instruction belong to the given user.
                instructions.Update(updating);
            }
            return drinks;
        }

        public IEnumerable<DDrink> Instruction_Delete(DInstruction deleting,
            string username){
            IDataRepository<DDrink> drinks =
                RepositoryFactory.Instance.Construct<DDrink>(username);
            IDataRepository<DInstruction> instructions;

            if((instructions = drinks.FirstOrDefault(x => deleting.Drink_ID == x.Drink_ID)
                .instructions as IDataRepository<DInstruction>) != null){
                //Drinks for instruction belong to the given user.
                instructions.Delete (deleting);
            }
            return drinks;
        }

        public IEnumerable<DDrink> Rating_Create(DRating creating, string username){
            IDataRepository<DDrink> drinks =
                RepositoryFactory.Instance.Construct<DDrink>(username);
            IDataRepository<DRating> ratings;

            if((ratings = drinks.FirstOrDefault(x => x.Drink_ID == creating.Drink_ID)
                .ratings as IDataRepository<DRating>) != null){
                //Drink for the rating belongs to the given user, may proceed.
                ratings.Create(creating);
            }
            return drinks;
        }

        public IEnumerable<DDrink> Rating_Update(DRating updating, string username){
            IDataRepository<DDrink> drinks =
                RepositoryFactory.Instance.Construct<DDrink>(username);
            IDataRepository<DRating> ratings;

            if((ratings = drinks.FirstOrDefault(x => x.Drink_ID == updating.Drink_ID)
                .ratings as IDataRepository<DRating>) != null){
                //Drink for the rating belongs to the given user, may proceed.
                ratings.Update(updating);
            }
            return drinks;
        }

        public IEnumerable<DDrink> Rating_Delete(DRating deleting, string username){
            IDataRepository<DDrink> drinks =
                RepositoryFactory.Instance.Construct<DDrink>(username);
            IDataRepository<DRating> ratings;

            if((ratings = drinks.FirstOrDefault(x => x.Drink_ID == deleting.Drink_ID)
                .ratings as IDataRepository<DRating>) != null){
                //Drink for the rating belongs to the given user, may proceed.
                ratings.Delete(deleting);
            }
            return drinks;
        }

        public IEnumerable<DUnit> Unit_GetList() {
            return RepositoryFactory.Instance.Construct<DUnit>();
        }

        public IEnumerable<DUnit> Unit_Create(DUnit creating){
            IDataRepository<DUnit> units =
                RepositoryFactory.Instance.Construct<DUnit>();
            units.Create(creating);
            return units;
        }

        public IEnumerable<DUnit> Unit_Update(DUnit updating){
            IDataRepository<DUnit> units =
                RepositoryFactory.Instance.Construct<DUnit>();
            units.Update(updating);
            return units;
        }

        public IEnumerable<DUnit> Unit_Delete(DUnit deleting){
            IDataRepository<DUnit> units =
                RepositoryFactory.Instance.Construct<DUnit>();
            units.Delete(deleting);
            return units;
        }

    }
}

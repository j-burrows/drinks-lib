using System;
using System.Collections.Generic;
using System.ServiceModel;
using DrinksLib.Data.Entities;
using DrinksLib.Factory;
namespace DrinksLib{
    [ServiceContract]
    public interface IDrinksService{
        [OperationContract]
        IEnumerable<DDrink> Avatar_Create(int drink_ID, DAvatar creating, string username);

        [OperationContract]
        IEnumerable<DDrink> Avatar_Update(int drink_ID, DAvatar updating, string username);

        [OperationContract]
        IEnumerable<DDrink> Avatar_Delete(int drink_ID, DAvatar deleting, string username);

        [OperationContract]
        IEnumerable<DDefined_Instruction> Defined_Instruction_GetList();

        [OperationContract]
        IEnumerable<DDefined_Instruction> Defined_Instruction_Create(
            DDefined_Instruction creating);

        [OperationContract]
        IEnumerable<DDefined_Instruction> Defined_Instruction_Update(
            DDefined_Instruction updating);

        [OperationContract]
        IEnumerable<DDefined_Instruction> Defined_Instruction_Delete(
            DDefined_Instruction deleting);

        [OperationContract]
        IEnumerable<DDrink> Drink_GetByUser(string username);

        [OperationContract]
        IEnumerable<DDrink> Drink_Create(DDrink creating, string username);

        [OperationContract]
        IEnumerable<DDrink> Drink_Update(DDrink updating, string username);

        [OperationContract]
        IEnumerable<DDrink> Drink_Delete(DDrink deleting, string username);

        [OperationContract]
        IEnumerable<DIngredient> Ingredient_GetByUser(string username);

        [OperationContract]
        IEnumerable<DDrink> Ingredient_Create(DIngredient creating, string username);

        [OperationContract]
        IEnumerable<DDrink> Ingredient_Update(DIngredient updating, string username);

        [OperationContract]
        IEnumerable<DDrink> Ingredient_Delete(DIngredient deleting, string username);

        [OperationContract]
        IEnumerable<DDrink> Instruction_Create(DInstruction creating,
            string username);

        [OperationContract]
        IEnumerable<DDrink> Instruction_Update(DInstruction updating,
            string username);

        [OperationContract]
        IEnumerable<DDrink> Instruction_Delete(DInstruction deleting,
            string username);

        [OperationContract]
        IEnumerable<DDrink> Rating_Create(DRating creating, string username);

        [OperationContract]
        IEnumerable<DDrink> Rating_Update(DRating updating, string username);

        [OperationContract]
        IEnumerable<DDrink> Rating_Delete(DRating deleting, string username);

        [OperationContract]
        IEnumerable<DUnit> Unit_GetList();

        [OperationContract]
        IEnumerable<DUnit> Unit_Create(DUnit creating);

        [OperationContract]
        IEnumerable<DUnit> Unit_Update(DUnit updating);

        [OperationContract]
        IEnumerable<DUnit> Unit_Delete(DUnit deleting);
        
        /*
        [OperationContract]
        IEnumerable<Tuple<string, int>> UserAverageRating_GetList();

        [OperationContract]
        IEnumerable<Tuple<string, int>> FriendsAverageRating_GetList();
         * */
    }
}

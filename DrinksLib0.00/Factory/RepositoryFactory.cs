using System;
using DrinksLib.Base;
using DrinksLib.Data.Repositories;
using Repository.Data;
using Repository.Factory;
using Repository.Helpers;
namespace DrinksLib.Factory{
    public class SqlSRepositoryFactory : IRepositoryFactory{
        public IDataRepository<T> Construct<T>(params object[] args) where T : IDataUnit{
            if (Polymorphism.IsInHierachy(typeof(T), typeof(Avatar))){
                return (IDataRepository<T>)Activator.CreateInstance(
                    typeof(SqlSAvatarRepository), args);
            }
            if (Polymorphism.IsInHierachy(typeof(T), typeof(Defined_Instruction))){
                return (IDataRepository<T>)Activator.CreateInstance(
                    typeof(SqlSDefined_InstructionRepository), args);
            }
            else if (Polymorphism.IsInHierachy(typeof(T), typeof(Drink))){
                return (IDataRepository<T>)Activator.CreateInstance(
                    typeof(SqlSDrinkRepository), args);
            }
            else if (Polymorphism.IsInHierachy(typeof(T), typeof(Ingredient))){
                return (IDataRepository<T>)Activator.CreateInstance(
                    typeof(SqlSIngredientRepository), args);
            }
            else if (Polymorphism.IsInHierachy(typeof(T), typeof(Instruction))){
                return (IDataRepository<T>)Activator.CreateInstance(
                    typeof(SqlSInstructionRepository), args);
            }
            else if (Polymorphism.IsInHierachy(typeof(T), typeof(Rating))){
                //The given is of type place, but not state or country
                return (IDataRepository<T>)Activator.CreateInstance(
                    typeof(SqlSRatingRepository), args);
            }
            else if (Polymorphism.IsInHierachy(typeof(T), typeof(Unit))){
                return (IDataRepository<T>)Activator.CreateInstance(
                    typeof(SqlSUnitRepository), args);
            }
            return null;                    //Factory cannot build the requested order.
        }
    }
}

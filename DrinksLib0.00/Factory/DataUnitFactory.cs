using System.Data;
using DrinksLib.Data.Entities;
using Repository.Data;
using Repository.Factory;
namespace DrinksLib.Factory{
    public class DataUnitFactory : IDataUnitFactory{
        public T Construct<T>() where T : IDataUnit, new() {
            return new T();
        }

        public T ConstructFromRow<T>(DataRow parsing) where T : class, IDataUnit, new() {
            T constructing = new T();
            constructing.InitFromRow(parsing);
            return constructing;
        }
    }
}

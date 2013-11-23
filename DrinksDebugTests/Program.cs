using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinksLib.Data.Entities;
using DrinksLib.Data.Repositories;

namespace DrinksLibDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository.Configuration.connString = "Server=localhost;Database=ApplicationData;Trusted_Connection=True;";
            SqlSUnitRepository repo = new SqlSUnitRepository();
            ///repo.Update(new DUnit{ Long_Name="Short", Short_Name ="L"});
            ///Console.WriteLine(repo.Count());
        }
    }
}

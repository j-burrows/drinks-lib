using System.Linq;
using Repository.Presentation;
namespace DrinksLib.Presentation{
    public class PDrink : DrinksLib.Base.Drink, IPresentationUnit{
        public virtual void Format() {
            if (username == null) {
                username = string.Empty;
            }
            if(Name == null){
                Name = string.Empty;
            }
            if(Definition == null){
                Definition = string.Empty;
            }
            if(instructions == null){
                instructions = Enumerable.Empty<PInstruction>();
            }
            if(ratings == null){
                ratings = Enumerable.Empty<PRating>();
            }
            if (ingredients == null) {
                ingredients = Enumerable.Empty<PIngredient>();
            }
        }
    }
}

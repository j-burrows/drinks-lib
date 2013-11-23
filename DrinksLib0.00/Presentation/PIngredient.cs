using Repository.Presentation;
namespace DrinksLib.Presentation{
    public class PIngredient : DrinksLib.Base.Ingredient, IPresentationUnit{
        public virtual void Format() { 
            if(Long_Name == null){
                Long_Name = string.Empty;
            }
            if(Short_Name == null){
                Short_Name = string.Empty;
            }
            if (unit == null) {
                unit = new PUnit();
            }
        }
    }
}

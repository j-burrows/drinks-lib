using Repository.Presentation;
namespace DrinksLib.Presentation{
    public class PUnit : DrinksLib.Base.Unit, IPresentationUnit{
        public virtual void Format() {
            if(Long_Name == null){
                Long_Name = string.Empty;
            }
            if(Short_Name == null){
                Short_Name = string.Empty;
            }
        }
    }
}

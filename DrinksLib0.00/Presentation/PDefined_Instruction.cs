using Repository.Presentation;
namespace DrinksLib.Presentation{
    public class PDefined_Instruction :
        DrinksLib.Base.Defined_Instruction, 
        IPresentationUnit{
        public virtual void Format() {
            if (Description == null) {
                Description = string.Empty;
            }
        }
    }
}

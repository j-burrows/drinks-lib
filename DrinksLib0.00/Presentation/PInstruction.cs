using Repository.Presentation;
namespace DrinksLib.Presentation{
    public class PInstruction : DrinksLib.Base.Instruction, IPresentationUnit{
        public virtual void Format() { 
            if(Description == null){
                Description = string.Empty;
            }
        }
    }
}

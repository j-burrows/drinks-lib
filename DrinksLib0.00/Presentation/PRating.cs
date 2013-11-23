using Repository.Presentation;
namespace DrinksLib.Presentation{
    public class PRating : DrinksLib.Base.Rating, IPresentationUnit{
        public virtual void Format() {
            if(Reasons == null){
                Reasons = string.Empty;
            }
        }
    }
}

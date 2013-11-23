using Repository.Presentation;
namespace DrinksLib.Presentation{
    public class PAvatar : DrinksLib.Base.Avatar, IPresentationUnit{
        public virtual void Format() { 
            if(Title == null){
                Title = string.Empty;
            }
            if (Url == null) {
                Url = string.Empty;
            }
        }
    }
}

using Repository.Business;
using Repository.Business.Protocols;
namespace DrinksLib.Business{
    public class BAvatar : DrinksLib.Presentation.PAvatar, IBusinessUnit{
        public readonly ProtocolStack Avatar_ID_Rules = ProtocolStack.ForKey("Avatar_ID");
        public readonly ProtocolStack Title_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = false, maxLength = 16 }, "Title");
        public readonly ProtocolStack Url_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = false, maxLength = 1024 }, "Url");

        public virtual bool CreateValid() {
            bool isValid = true;
            isValid = Avatar_ID_Rules.Create.passes(Avatar_ID) && isValid;
            isValid = Title_Rules.Create.passes(Title) && isValid;
            isValid = Url_Rules.Create.passes(Url) && isValid;
            return isValid;
        }

        public virtual bool UpdateValid() {
            bool isValid = true;
            isValid = Avatar_ID_Rules.Update.passes(Avatar_ID) && isValid;
            isValid = Title_Rules.Update.passes(Title) && isValid;
            isValid = Url_Rules.Update.passes(Url) && isValid;
            return isValid;
        }

        public virtual bool DeleteValid() {
            return true;                    //Will always be delete valid at this leve.
        }

        public virtual bool Equivilant(IBusinessUnit comparing) {
            return false;                   //Will never be business equivilant.
        }
    }
}

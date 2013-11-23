using Repository.Business;
using Repository.Business.Protocols;
namespace DrinksLib.Business{
    public class BUnit: DrinksLib.Presentation.PUnit, IBusinessUnit{
        public static readonly ProtocolStack Long_Name_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = false, maxLength = 16}, "Long_Name");
        public static readonly ProtocolStack Short_Name_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = true, maxLength = 4}, "Short_Name");
        public static readonly ProtocolStack Unit_ID_Rules = ProtocolStack.ForKey("Unit_ID");

        public virtual bool CreateValid() {
            bool isValid = true;
            isValid = Long_Name_Rules.Create.passes(Long_Name) && isValid;
            isValid = Short_Name_Rules.Create.passes(Short_Name) && isValid;
            isValid = Unit_ID_Rules.Create.passes(Unit_ID) && isValid;
            return isValid;
        }

        public virtual bool UpdateValid() {
            bool isValid = true;
            isValid = Long_Name_Rules.Update.passes(Long_Name) && isValid;
            isValid = Short_Name_Rules.Update.passes(Short_Name) && isValid;
            isValid = Unit_ID_Rules.Update.passes(Unit_ID) && isValid;
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

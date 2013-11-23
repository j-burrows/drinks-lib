using Repository.Business;
using Repository.Business.Protocols;
namespace DrinksLib.Business{
    public class BIngredient : DrinksLib.Presentation.PIngredient, IBusinessUnit{
        public readonly ProtocolStack Ingredient_ID_Rules = ProtocolStack.ForKey("Ingredient_ID");
        public readonly ProtocolStack Long_Name_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = true, maxLength = 32 }, "Long_Name");
        public readonly ProtocolStack Short_Name_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = true, maxLength = 8 }, "Short_Name");

        public virtual bool CreateValid() {
            bool isValid = true;
            isValid = Ingredient_ID_Rules.Create.passes(Ingredient_ID) && isValid;
            isValid = Long_Name_Rules.Create.passes(Long_Name) && isValid;
            isValid = Short_Name_Rules.Create.passes(Short_Name) && isValid;
            return isValid;
        }

        public virtual bool UpdateValid() {
            bool isValid = true;
            isValid = Ingredient_ID_Rules.Update.passes(Ingredient_ID) && isValid;
            isValid = Long_Name_Rules.Update.passes(Long_Name) && isValid;
            isValid = Short_Name_Rules.Update.passes(Short_Name) && isValid;
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

using Repository.Business;
using Repository.Business.Protocols;
namespace DrinksLib.Business{
    public class BDrink : DrinksLib.Presentation.PDrink, IBusinessUnit{
        public readonly ProtocolStack username_Rules = ProtocolStack.ForUsername();
        public readonly ProtocolStack Drink_ID_Rules = ProtocolStack.ForKey("Drink_ID");
        public readonly ProtocolStack Name_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = false, maxLength = 16 }, "Name");
        public readonly ProtocolStack Definition_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = true, maxLength = 128 }, "Definition");
        public readonly ProtocolStack Avatar_ID_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = true, numeric = true, hidden = true, stepValue = 1 }, "Avatar_ID");

        public virtual bool CreateValid() {
            bool isValid = true;
            isValid = username_Rules.Create.passes(username) && isValid;
            isValid = Drink_ID_Rules.Create.passes(Drink_ID) && isValid;
            isValid = Name_Rules.Create.passes(Name) && isValid;
            isValid = Definition_Rules.Create.passes(Definition) && isValid;
            isValid = Avatar_ID_Rules.Create.passes(Avatar_ID) && isValid;
            return isValid;
        }

        public virtual bool UpdateValid() {
            bool isValid = true;
            isValid = username_Rules.Update.passes(username) && isValid;
            isValid = Drink_ID_Rules.Update.passes(Drink_ID) && isValid;
            isValid = Name_Rules.Update.passes(Name) && isValid;
            isValid = Definition_Rules.Update.passes(Definition) && isValid;
            isValid = Avatar_ID_Rules.Update.passes(Avatar_ID) && isValid;
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

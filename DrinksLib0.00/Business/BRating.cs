using Repository.Business;
using Repository.Business.Protocols;
namespace DrinksLib.Business{
    public class BRating : DrinksLib.Presentation.PRating, IBusinessUnit{
        public readonly ProtocolStack Rating_ID_Rules = ProtocolStack.ForKey("Rating_ID");
        public readonly ProtocolStack Drink_ID_Rules = ProtocolStack.ForKey("Drink_ID");
        public readonly ProtocolStack Score_Rules = ProtocolStack.WithPremise(
            new Premise{ numeric = true, stepValue = 0.5, minValue = 0, maxValue = 5, nullable = false },"Score");
        public readonly ProtocolStack Reasons_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = true, maxLength = 64 }, "Reasons");

        public virtual bool CreateValid() {
            bool isValid = true;
            isValid = Rating_ID_Rules.Create.passes(Rating_ID) && isValid;
            isValid = Drink_ID_Rules.Create.passes(Drink_ID) && isValid;
            isValid = Score_Rules.Create.passes(Score) && isValid;
            isValid = Reasons_Rules.Create.passes(Reasons) && isValid;
            return isValid;
        }

        public virtual bool UpdateValid() {
            bool isValid = true;
            isValid = Rating_ID_Rules.Update.passes(Rating_ID) && isValid;
            isValid = Drink_ID_Rules.Update.passes(Drink_ID) && isValid;
            isValid = Score_Rules.Update.passes(Score) && isValid;
            isValid = Reasons_Rules.Update.passes(Reasons) && isValid;
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

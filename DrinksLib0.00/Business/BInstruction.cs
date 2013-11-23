using Repository.Business;
using Repository.Business.Protocols;
namespace DrinksLib.Business{
    public class BInstruction : DrinksLib.Presentation.PInstruction, IBusinessUnit{
        public readonly 
        ProtocolStack Instruction_ID_Rules = ProtocolStack.ForKey("Instruction_ID");
        public readonly ProtocolStack Description_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = false, maxLength = 64}, "Description");
        public readonly ProtocolStack Time_Rules = ProtocolStack.WithPremise(
            new Premise { numeric = true, stepValue = 1, nullable = true, minValue = 0}, "Time");
        public readonly ProtocolStack Drink_ID_Rules = ProtocolStack.ForKey("Drink_ID");

        public virtual bool CreateValid() {
            bool isValid = true;
            isValid = Instruction_ID_Rules.Create.passes(Instruction_ID) && isValid;
            isValid = Description_Rules.Create.passes(Description) && isValid;
            isValid = Time_Rules.Create.passes(Time) && isValid;
            isValid = Drink_ID_Rules.Create.passes(Drink_ID) && isValid;
            return isValid;
        }

        public virtual bool UpdateValid() {
            bool isValid = true;
            isValid = Instruction_ID_Rules.Update.passes(Instruction_ID) && isValid;
            isValid = Description_Rules.Update.passes(Description) && isValid;
            isValid = Time_Rules.Update.passes(Time) && isValid;
            isValid = Drink_ID_Rules.Update.passes(Drink_ID) && isValid;
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

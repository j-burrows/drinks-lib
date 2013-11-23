using Repository.Business;
using Repository.Business.Protocols;
namespace DrinksLib.Business{
    public class BDefined_Instruction :
        DrinksLib.Presentation.PDefined_Instruction,
        IBusinessUnit{
        public readonly ProtocolStack Defined_Instruction_ID_Rules =
            ProtocolStack.ForKey("Defined_Instruction_ID");
        public readonly ProtocolStack Description_Rules = ProtocolStack.WithPremise(
            new Premise { nullable = false, maxLength = 64 }, "Description");

        public virtual bool CreateValid() {
            bool isValid = true;
            isValid = Defined_Instruction_ID_Rules.Create.passes(Defined_Instruction_ID) && isValid;
            isValid = Description_Rules.Create.passes(Description) && isValid;
            return isValid;
        }

        public virtual bool UpdateValid() {
            bool isValid = true;
            isValid = Defined_Instruction_ID_Rules.Update.passes(Defined_Instruction_ID) && isValid;
            isValid = Description_Rules.Update.passes(Description) && isValid;
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

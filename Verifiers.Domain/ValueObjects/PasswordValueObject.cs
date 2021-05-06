using Verifiers.Domain.ContractObjects;

namespace Verifiers.Domain.ValueObjects
{

    public class PasswordValueObject : PasswordContractObject
    {
        public PasswordValueObject(string password)
        {
            Password = password;
        }

        public string Password { get; private set; }

        public void Validate()
        {

            PasswordCharQuantityValueObject quantity = new PasswordCharQuantityValueObject();
            PasswordContainsDigitValueObject digit = new PasswordContainsDigitValueObject();
            PasswordContainsLowerValueObject lower = new PasswordContainsLowerValueObject();
            PasswordContainsUpperValueObject upper = new PasswordContainsUpperValueObject();
            PasswordContainsSpecialValueObject special = new PasswordContainsSpecialValueObject();
            PasswordContainsDistinctValueObject distinct = new PasswordContainsDistinctValueObject();
            PasswordContainsEmptyValueObject empty = new PasswordContainsEmptyValueObject();

            quantity.SetNext(digit);
            digit.SetNext(lower);
            lower.SetNext(upper);
            upper.SetNext(special);
            special.SetNext(distinct);
            distinct.SetNext(empty);

            quantity.Handle(this.Password);
        }
    }

}
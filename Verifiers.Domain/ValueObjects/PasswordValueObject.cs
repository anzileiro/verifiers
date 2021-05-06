using Verifiers.Domain.ContractObjects;

namespace Verifiers.Domain.ValueObjects
{

    public class PasswordValueObject : PasswordContractObject
    {
        private string _password = null;
        private readonly PasswordCharQuantityValueObject _quantityHandlerVerifier = null;
        private readonly PasswordContainsDigitValueObject _digitHandlerVerifier = null;
        private readonly PasswordContainsLowerValueObject _lowerHandlerVerifier = null;
        private readonly PasswordContainsUpperValueObject _upperHandlerVerifier = null;
        private readonly PasswordContainsSpecialValueObject _specialHandlerVerifier = null;
        private readonly PasswordContainsDistinctValueObject _distinctHandlerVerifier = null;
        private readonly PasswordContainsEmptyValueObject _emptyHandlerVerifier = null;
        public PasswordValueObject(string password)
        {
            this._password = password;
            this._quantityHandlerVerifier = new PasswordCharQuantityValueObject();
            this._digitHandlerVerifier = new PasswordContainsDigitValueObject();
            this._lowerHandlerVerifier = new PasswordContainsLowerValueObject();
            this._upperHandlerVerifier = new PasswordContainsUpperValueObject();
            this._specialHandlerVerifier = new PasswordContainsSpecialValueObject();
            this._distinctHandlerVerifier = new PasswordContainsDistinctValueObject();
            this._emptyHandlerVerifier = new PasswordContainsEmptyValueObject();
        }

        public void Validate()
        {
            this._quantityHandlerVerifier.SetNext(this._digitHandlerVerifier);
            this._digitHandlerVerifier.SetNext(this._lowerHandlerVerifier);
            this._lowerHandlerVerifier.SetNext(this._upperHandlerVerifier);
            this._upperHandlerVerifier.SetNext(this._specialHandlerVerifier);
            this._specialHandlerVerifier.SetNext(this._distinctHandlerVerifier);
            this._distinctHandlerVerifier.SetNext(this._emptyHandlerVerifier);

            this._quantityHandlerVerifier.Handle(this._password);
        }
    }

}
using System;
using Verifiers.Domain.ValueObjects;

namespace Verifiers.Domain
{
    public class Password
    {
        private string _value = null;
        public Password(string value)
        {
            this._value = value;
        }

        public void Validate()
        {
            new PasswordValueObject(this._value).Validate();
        }
    }
}

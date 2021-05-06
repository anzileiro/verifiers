using System;
using Verifiers.Domain.ValueObjects;

namespace Verifiers.Domain
{
    public class Password
    {

        public Password(string value)
        {
            Value = value;
        }

        public string Value { get; private set; }

        public void Validate()
        {
            new PasswordValueObject(this.Value).Validate();
        }
    }
}

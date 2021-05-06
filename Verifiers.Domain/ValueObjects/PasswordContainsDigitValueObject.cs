using System;
using System.Linq;
using Verifiers.Domain.AbstractObjects;


namespace Verifiers.Domain.ValueObjects
{
    public class PasswordContainsDigitValueObject : HandlerAbstractObject
    {

        public override void Handle(string value)
        {
            if (value.ToCharArray().Any(char.IsDigit) == false)
            {
                throw new Exception("The password must contains 1 digit or more.");
            }

            base.Handle(value);
        }

    }

}
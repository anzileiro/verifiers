using System;
using System.Linq;
using Verifiers.Domain.AbstractObjects;


namespace Verifiers.Domain.ValueObjects
{
    public class PasswordContainsLowerValueObject : HandlerAbstractObject
    {

        public override void Handle(string value)
        {
            if (value.ToCharArray().Any(char.IsLower) == false)
            {
                throw new Exception("The password must contains 1 or more lower characters");
            }

            base.Handle(value);
        }

    }

}
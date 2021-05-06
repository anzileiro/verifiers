using System;
using System.Linq;
using Verifiers.Domain.AbstractObjects;


namespace Verifiers.Domain.ValueObjects
{
    public class PasswordContainsUpperValueObject : HandlerAbstractObject
    {

        public override void Handle(string value)
        {
            if (value.ToCharArray().Any(char.IsUpper) == false)
            {
                throw new Exception("The password must contains 1 or more upper characters");
            }

            base.Handle(value);
        }

    }

}
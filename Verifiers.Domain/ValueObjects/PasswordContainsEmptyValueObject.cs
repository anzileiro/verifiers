using System;
using System.Linq;
using Verifiers.Domain.AbstractObjects;


namespace Verifiers.Domain.ValueObjects
{
    public class PasswordContainsEmptyValueObject : HandlerAbstractObject
    {

        public override void Handle(string value)
        {
            if (value.Contains(" "))
            {
                throw new Exception("The password must not contains white or empty spaces.");
            }

            base.Handle(value);
        }

    }

}
using System;
using Verifiers.Domain.AbstractObjects;

namespace Verifiers.Domain.ValueObjects
{
    public class PasswordCharQuantityValueObject : HandlerAbstractObject
    {

        private int ACCEPTABLE_CHAR_QUANTITY = 9;

        public override void Handle(string value)
        {
            if (value.Length < this.ACCEPTABLE_CHAR_QUANTITY)
            {
                throw new Exception("The password must contains 9 characters or more.");
            }

            base.Handle(value);
        }

    }

}
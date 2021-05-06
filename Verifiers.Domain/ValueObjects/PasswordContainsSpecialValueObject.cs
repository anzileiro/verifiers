using System;
using System.Linq;
using Verifiers.Domain.AbstractObjects;


namespace Verifiers.Domain.ValueObjects
{
    public class PasswordContainsSpecialValueObject : HandlerAbstractObject
    {
        private char[] SPECIAL_CHARACTERS = new char[] { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+' };

        public override void Handle(string value)
        {
            if (value.ToCharArray().Any(item => this.SPECIAL_CHARACTERS.Contains(item)) == false)
            {
                throw new Exception("The password must contains 1 special character or more.");
            }

            base.Handle(value);
        }

    }

}
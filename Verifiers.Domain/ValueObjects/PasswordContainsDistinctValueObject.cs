using System;
using System.Linq;
using Verifiers.Domain.AbstractObjects;


namespace Verifiers.Domain.ValueObjects
{
    public class PasswordContainsDistinctValueObject : HandlerAbstractObject
    {

        private bool IsDistinct(string value)
        {
            char[] characters = value.ToCharArray();

            bool repeated = false;

            for (int i = 0; i < characters.Length; i++)
            {
                for (int j = i + 1; j < characters.Length; j++)
                {
                    if (characters[i] == characters[j])
                    {
                        repeated = true;
                    }
                }
            }

            return repeated;
        }

        public override void Handle(string value)
        {
            if (this.IsDistinct(value))
            {
                throw new Exception("The password must not contains repeated characters.");
            }

            base.Handle(value);
        }

    }

}
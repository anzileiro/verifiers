using System;
using Verifiers.Application.ContractObjects;
using Verifiers.Domain;

namespace Verifiers.Application.UseCases
{

    public class PasswordVerifierUseCase : PasswordVerifierContractObject
    {
        public void execute(string value)
        {
            Console.WriteLine($"The password is {value}");
            new Password(value).Validate();
        }
    }

}
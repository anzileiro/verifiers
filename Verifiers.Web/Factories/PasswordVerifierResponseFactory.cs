using System;
using Verifiers.Web.Models;

namespace Verifiers.Web.Factories
{

    public class PasswordVerifierResponseFactory
    {
        public PasswordVerifierResponseModel ToOk()
        {
            return new PasswordVerifierResponseModel(true, "The password matches all verifiers and it is valid.");
        }

        public PasswordVerifierResponseModel ToBadRequest(Exception exception)
        {
            return new PasswordVerifierResponseModel(false, exception.Message);
        }
    }

}
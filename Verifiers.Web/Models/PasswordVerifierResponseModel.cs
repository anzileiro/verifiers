using System;

namespace Verifiers.Web.Models
{
    public class PasswordVerifierResponseModel
    {

        public PasswordVerifierResponseModel(bool valid, string message)
        {
            this.Id = Guid.NewGuid();
            this.Valid = valid;
            this.Message = message;
        }
        private Guid Id { get; set; }
        private bool Valid { get; set; }
        private string Message { get; set; }

        public object ToJson()
        {
            return new
            {
                id = this.Id,
                valid = this.Valid,
                message = this.Message
            };
        }
    }
}
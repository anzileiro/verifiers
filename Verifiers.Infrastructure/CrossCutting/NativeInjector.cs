using Microsoft.Extensions.DependencyInjection;
using Verifiers.Application.ContractObjects;
using Verifiers.Application.UseCases;

namespace Verifiers.Infrastructure.CrossCutting
{

    public static class NativeInjector
    {
        public static void Apply(IServiceCollection services)
        {
            services.AddScoped<PasswordVerifierContractObject, PasswordVerifierUseCase>();
        }
    }

}
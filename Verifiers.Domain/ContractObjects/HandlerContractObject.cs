namespace Verifiers.Domain.ContractObjects {

    public interface HandlerContractObject {

        HandlerContractObject SetNext(HandlerContractObject handler);

        void Handle(string value);

    }

}
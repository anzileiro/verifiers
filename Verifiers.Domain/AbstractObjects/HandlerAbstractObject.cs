using System;
using Verifiers.Domain.ContractObjects;

namespace Verifiers.Domain.AbstractObjects
{

    public abstract class HandlerAbstractObject : HandlerContractObject
    {

        public HandlerContractObject _nextHandler;

        public HandlerAbstractObject()
        {
            this._nextHandler = null;
        }

        public HandlerContractObject SetNext(HandlerContractObject handler)
        {
            this._nextHandler = handler;

            return this._nextHandler;
        }

        public virtual void Handle(string value)
        {
            if (this._nextHandler != null)
            {
                this._nextHandler.Handle(value);
            }
        }

    }

}
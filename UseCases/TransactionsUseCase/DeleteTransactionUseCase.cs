using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UseCases.DataStorePluginInterfaces;


namespace UseCases
{
    public class DeleteTransactionUseCase : IDeleteTransactionUseCase
    {
        private readonly ITransactionRepository transactionRepository;

        public DeleteTransactionUseCase(ITransactionRepository transactionRepository)
        {
            this.transactionRepository = transactionRepository;
        }
        public void Execute(int transactionId)
        {
            transactionRepository.Delete(transactionId);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases
{
    public interface IDeleteTransactionUseCase
    {
        void Execute(int transactionId);
    }
}

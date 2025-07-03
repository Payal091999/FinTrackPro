
namespace FinTrackPro.Application.Interfaces;

public interface ITransactionService
{
    Task<IEnumerable<Transaction>> GetTransactionsAsync();
}

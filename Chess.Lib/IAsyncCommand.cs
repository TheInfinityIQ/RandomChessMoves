using System.Threading.Tasks;
using System.Windows.Input;

namespace Chess.Lib
{
    public interface IAsyncCommand : ICommand
    {
        Task ExecuteAsync();
        bool CanExecute();
    }
}

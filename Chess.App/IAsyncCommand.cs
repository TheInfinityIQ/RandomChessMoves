using System.Threading.Tasks;
using System.Windows.Input;

namespace Chess.Game
{
    public interface IAsyncCommand : ICommand
    {
        Task ExecuteAsync();
        bool CanExecute();
    }
}

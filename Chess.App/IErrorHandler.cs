using System;

namespace Chess.Game
{
    public interface IErrorHandler
    {
        void HandleError(Exception ex);
    }
}

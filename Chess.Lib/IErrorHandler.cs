using System;

namespace Chess.Lib
{
    public interface IErrorHandler
    {
        void HandleError(Exception ex);
    }
}

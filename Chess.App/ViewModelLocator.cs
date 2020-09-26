using Chess.Lib.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Game
{
    public class ViewModelLocator
    {
        public MainWindowVM MainWindowVM { get => ViewModelLocator.mainWindowVM; }

        private static MainWindowVM mainWindowVM = new MainWindowVM();
    }
}

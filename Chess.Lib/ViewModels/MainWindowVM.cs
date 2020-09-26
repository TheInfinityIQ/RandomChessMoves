using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Web;
using System.Windows.Input;

namespace Chess.Lib.ViewModels
{
    public class MainWindowVM
    {

        public ICommand SendOneEmailCommand { get; }

        public MainWindowVM()
        {
            SendOneEmailCommand = new RelayCommand(SendOneEmail);
        }

        public void SendOneEmail()
        { 
            Process p = new Process();
            string lol = "I A full commitment's what I'm thinking of You wouldn't get this from any other guy I just wanna tell you how I'm feeling";

            lol = HttpUtility.UrlEncode(lol);

            p.StartInfo = new ProcessStartInfo("microsoftedge.exe",$"mailto:everettag@mymts.net?body={lol}");

            p.Start();
        }
    }
}

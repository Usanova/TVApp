using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TVApp.Views;

namespace TVApp.Commands
{
    public sealed class OkCommand : Command
    {
        readonly ViewBase _window;

        public OkCommand(ViewBase window)
        {
            _window = window;
        }

        public override void Execute()
        {
            var activeElementCommands =_window.GetActiveUIElementCommands();

            activeElementCommands?.EnterOk();
        }
    }
}

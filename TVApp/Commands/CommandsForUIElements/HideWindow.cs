using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TVApp.Commands.CommandsForUIElements
{
    public sealed class HideWindow : Command
    {
        ViewBase _window;

        public HideWindow(ViewBase window)
        {
            _window = window;
        }

        public override void Execute()
        {
            _window.Visibility = Visibility.Hidden;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVApp.Commands.CommandsForUIElements
{
    public sealed class OpenWindowCommand<T> : Command where T : ViewBase
    {
        ViewBase _previousWindow;

        public OpenWindowCommand(ViewBase previousWindow)
        {
            _previousWindow = previousWindow;
        }

        public override void Execute()
        {
            var window = (T)Activator.CreateInstance(typeof(T), new object[] { _previousWindow });

            window.ShowDialog();
        }
    }
}

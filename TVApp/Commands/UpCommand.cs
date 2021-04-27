using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVApp.Commands
{
    public sealed class UpCommand : Command                                                                                                                                                                                                                                                                                                                                                                                                        
    {
        readonly ViewBase _window;

        public UpCommand(ViewBase window)
        {
            _window = window;
        }

        public override void Execute()
        {
            _window.Up();
        }
    }
}

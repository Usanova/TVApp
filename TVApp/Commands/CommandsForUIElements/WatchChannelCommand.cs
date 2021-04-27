using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVApp.Domain;
using TVApp.Views;

namespace TVApp.Commands.CommandsForUIElements
{
    public sealed class WatchChannelCommand : Command
    {
        ChannelsWindow _window;
        Channel _channel;

        public WatchChannelCommand(ChannelsWindow window, Channel channel)
        {
            _window = window;
            _channel = channel;
        }

        public override void Execute()
        {
            var screenWindow = new ScreenWindow(_channel, _window);
            screenWindow.ShowDialog();
        }
    }
}

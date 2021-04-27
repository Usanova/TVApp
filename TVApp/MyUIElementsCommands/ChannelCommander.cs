using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVApp.Commands;
using TVApp.Commands.CommandsForUIElements;
using TVApp.Domain;
using TVApp.Views;

namespace TVApp.MyUIElementsCommands
{
    public sealed class ChannelCommander: UIElementCommanderBase
    {
        Channel _channel;

        public ChannelCommander(ChannelsWindow window,
            Channel channel)
        {
            _channel = channel;

            EnterOkCommand = new MacroCommand(new List<Command> { new HideWindow(window),
            new WatchChannelCommand(window, channel) });
        }

        public override void Focus() =>_channel.SetFocus();
    }
}

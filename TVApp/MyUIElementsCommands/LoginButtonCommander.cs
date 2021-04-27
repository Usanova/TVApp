using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TVApp.Commands;
using TVApp.Commands.CommandsForUIElements;
using TVApp.Views;

namespace TVApp.MyUIElementsCommands
{
    public sealed class LoginButtonCommander : UIElementCommanderBase
    {
        Button _button;

        public LoginButtonCommander(LoginView window,
            Button button,
            TextBox emailTextBox,
            TextBox passwordTextBox)
        {
            _button = button;

            EnterOkCommand = new CheckEmailAndPasswordCommand(emailTextBox, passwordTextBox)
            {
                SuccessfulCheck = new MacroCommand(new List<Command> { new HideWindow(window),
                    new OpenWindowCommand<ChannelsWindow>(window) }),
                UnsuccessfulCheck = new ShowErrorMessageCommand("Неверный Email или пароль")
            };
        }

        public override void Focus() => _button.Focus();
    }
}

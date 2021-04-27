using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TVApp.Commands;
using TVApp.MyUIElementsCommands;

namespace TVApp.Views
{
    /// <summary>
    /// Логика взаимодействия для LoginView.xaml
    /// </summary>
    public partial class LoginView : ViewBase
    {
        public LoginView()
        {
            InitializeComponent();
            this.DataContext = this;

            _rowUIElementCommands = new UIElementCommanderBase[] { 
                new TextBoxCommander(tbEmail), 
                new TextBoxCommander(tbPassword),
                new LoginButtonCommander(this, btLogin, tbEmail, tbPassword)};

            Command[] enterCommands = { new Enter0Command(this), new Enter1Command(this), new Enter2Command(this),
                new Enter3Command(this), new Enter4Command(this), new Enter5Command(this),
                new Enter6Command(this), new Enter7Command(this), new Enter8Command(this),
                new Enter9Command(this)};

            for (int key = 0, samsungCode = 23, lgCode = 65, sonyCode = 0; samsungCode <= 32; key++, 
                samsungCode++, lgCode++, sonyCode++)
            {
                SetOneCommandToSomeCommandName(
                    samsungCode: samsungCode, lgCode: lgCode, sonyCode: sonyCode, enterCommands[key]);
            }

            SetOneCommandToSomeCommandName(
                    samsungCode: 56, lgCode: 1, sonyCode: 10, new UpCommand(this));
            SetOneCommandToSomeCommandName(
                    samsungCode: 58, lgCode: 2, sonyCode: 11, new DownCommand(this));
            SetOneCommandToSomeCommandName(
                    samsungCode: 57, lgCode: 3, sonyCode: 12, new LeftCommand(this));
            SetOneCommandToSomeCommandName(
                    samsungCode: 55, lgCode: 4, sonyCode: 13, new NoCommand());
            SetOneCommandToSomeCommandName(
                    samsungCode: 123, lgCode: 55, sonyCode: 14, new OkCommand(this));

            _commander.RegisteredCommad($"samsung-321", new BackCommand(this));
            _commander.RegisteredCommad($"samsung-45", new BackCommand(this));

            _commander.RegisteredCommad($"lg-77", new BackCommand(this));
        }

        public void SetOneCommandToSomeCommandName(int samsungCode, int lgCode, int sonyCode, Command command)
        {
            _commander.RegisteredCommad(
                new string[]{ $"samsung-{samsungCode}", $"lg-{lgCode}", $"sony-{sonyCode}" }, command);
        }
    }
}

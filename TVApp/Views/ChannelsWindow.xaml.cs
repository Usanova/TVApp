using System;
using System.Collections.Generic;
using System.Linq;
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
using TVApp.Domain;
using TVApp.MyUIElementsCommands;

namespace TVApp.Views
{
    /// <summary>
    /// Логика взаимодействия для ChannelsWindow.xaml
    /// </summary>
    public partial class ChannelsWindow : ViewBase
    {
        public FocusElementCollection<Channel> Channels { get; set; } = new FocusElementCollection<Channel>
        {
            new Channel(1, "Первый канал", "Понять и простить"),
            new Channel(2, "Второй канал", "Любовная любовь"),
            new Channel(13, "СТС", "Воронины"),
            new Channel(24, "Paramaunt Comedy", "Теория большого взрыва"),
            new Channel(25, "National Geographic", "Династия Ким")
        };

        public ChannelsWindow(LoginView previousView) : base(previousView)
        {
            InitializeComponent();
            DataContext = this;

            _rowUIElementCommands = new UIElementCommanderBase[Channels.Count];

            for(int i = 0; i < _rowUIElementCommands.Length; i++)
                _rowUIElementCommands[i] = new ChannelCommander(this, Channels[i]);

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
                new string[] { $"samsung-{samsungCode}", $"lg-{lgCode}", $"sony-{sonyCode}" }, command);
        }
    }
}

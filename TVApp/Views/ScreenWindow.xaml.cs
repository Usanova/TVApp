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

namespace TVApp.Views
{
    /// <summary>
    /// Логика взаимодействия для ScreenWindow.xaml
    /// </summary>
    public partial class ScreenWindow : ViewBase
    {
        public Channel Channel { get; set; }
        public ScreenWindow(Channel channel, ChannelsWindow channelsWindow) : base(channelsWindow)
        {
            Channel = channel;
            this.DataContext = this;

            InitializeComponent();
            SetOneCommandToSomeCommandName(
            samsungCode: 123, lgCode: 55, sonyCode: 14, new BackCommand(this));

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

using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace TVApp.Domain
{
    public sealed class Channel : FocusElement
    {
        public Channel(uint number, string name, string currentProgram)
        {
            Number = number;
            Name = name;
            CurrentProgram = currentProgram;
        }

        public uint Number { get; set; }

        public string Name { get; set; }

        public string CurrentProgram { get; set; }
    }
}

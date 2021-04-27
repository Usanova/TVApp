using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVApp.Domain
{
    public abstract class FocusElement : ReactiveObject
    {
        [Reactive] public bool IsFocus { get; private set; }

        public delegate void FocusEvent();

        public event FocusEvent Focus;

        public void SetFocus()
        {
            IsFocus = true;
            Focus?.Invoke();
        }

        public void RemoveFocus()
        {
            IsFocus = false;
        }
    }
}

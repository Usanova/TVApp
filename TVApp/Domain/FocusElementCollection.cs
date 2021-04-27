using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVApp.Domain
{
    public sealed class FocusElementCollection<T> : List<T> where T : FocusElement
    {
        public void Add(T focusElement)
        {
            foreach(var oldChannel in this)
            {
                oldChannel.Focus += focusElement.RemoveFocus;
                focusElement.Focus += oldChannel.RemoveFocus;
            }

            base.Add(focusElement);
        }
    }
}

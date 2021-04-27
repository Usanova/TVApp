using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVApp.Commands;

namespace TVApp.MyUIElementsCommands
{
    public abstract class UIElementCommanderBase
    {
        protected Command Enter0Command { get; set; }

        protected Command Enter1Command { get; set; }

        protected Command Enter2Command { get; set; }

        protected Command Enter3Command { get; set; }

        protected Command Enter4Command { get; set; }

        protected Command Enter5Command { get; set; }

        protected Command Enter6Command { get; set; }

        protected Command Enter7Command { get; set; }

        protected Command Enter8Command { get; set; }

        protected Command Enter9Command { get; set; }

        protected Command EnterUpCommand { get; set; }

        protected Command EnterDownCommand { get; set; }

        protected Command EnterLeftCommand { get; set; }

        protected Command EnterRightCommand { get; set; }

        protected Command EnterOkCommand { get; set; }

        protected Command EnterBackCommand { get; set; }


        public void Enter0() => Enter0Command?.Execute();

        public void Enter1() => Enter1Command?.Execute();

        public void Enter2() => Enter2Command?.Execute();

        public void Enter3() => Enter3Command?.Execute();

        public void Enter4() => Enter4Command?.Execute();

        public void Enter5() => Enter5Command?.Execute();

        public void Enter6() => Enter6Command?.Execute();

        public void Enter7() => Enter7Command?.Execute();

        public void Enter8() => Enter8Command?.Execute();

        public void Enter9() => Enter9Command?.Execute();

        public void EnterUp() => EnterUpCommand?.Execute();

        public void EnterDown() => EnterDownCommand?.Execute();

        public void EnterLeft() => EnterLeftCommand?.Execute();

        public void EnterRight() => EnterRightCommand?.Execute();

        public void EnterOk() => EnterOkCommand?.Execute();

        public void EnterBack() => EnterBackCommand?.Execute();

        public abstract void Focus();
    }
}

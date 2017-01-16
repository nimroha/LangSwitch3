using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LangSwitch3
{
    class MessageHandler : Form
    {
        private static volatile MessageHandler wnd;
        private static volatile IntPtr hwnd;
        private static ManualResetEvent windowReadyEvent = new ManualResetEvent(false);

        private const int WM_HOTKEY_MSG_ID = 0x0312;

        public MessageHandler()
        {
            //wnd = this;
            //hwnd = this.Handle;
            //windowReadyEvent.Set();
            //Console.WriteLine("MessageHandler constructed");
        }

        protected override void SetVisibleCore(bool value)
        {
            // Ensure the window never becomes visible
            base.SetVisibleCore(false);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY_MSG_ID)
                //HandleHotkey(ref m);
            base.WndProc(ref m);
        }

        private void HandleHotkey(ref Message m)
        {
           
        }
    }
}

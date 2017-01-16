using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LangSwitch3
{
    public partial class Form1 : Form 
    {
        private const int WM_HOTKEY_MSG_ID = 0x0312;
        private IntPtr hWnd;

        private HotKeys hk;
        private Switcher switcher;


        public Form1()
        {
            InitializeComponent();
            hWnd = this.Handle;
            hk = new HotKeys(hWnd);
            switcher = new Switcher();
            if (hk.register((int)Keys.A)) { // register ctrl+shift+a
                Console.WriteLine("registered hotkey");
            }
            this.Visible = false;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY_MSG_ID) {
                Console.WriteLine("recieved hotkey msg");
                int key = m.LParam.ToInt32() >> 16;
                if ((int)Keys.A == key) {
                    HandleHotkeyPress();
                }
            }
            base.WndProc(ref m);
        }

        private void HandleHotkeyPress()
        {
            Console.WriteLine("Hotkey ctrl+shift+a pressed");
            
        }
    }
}

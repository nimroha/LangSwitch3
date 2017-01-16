using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LangSwitch3
{
    class HotKeys : IDisposable
    {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        [DllImport("user32")]
        public static extern bool GetMessage(ref Message lpMsg, IntPtr handle, uint mMsgFilterInMain, uint mMsgFilterMax); // probably unneede because of WndProc

        private const int ALT = 0x0001;
        private const int CTRL = 0x0002;
        private const int SHIFT = 0x0004;
        private const int WM_HOTKEY_MSG_ID = 0x0312;

        private int modifier;
        private int key;
        private int id;
        private IntPtr form1_hWnd;

        public HotKeys(IntPtr hWnd)
        {
            modifier = CTRL + SHIFT;
            form1_hWnd = hWnd;
        }

        public bool register(int key)
        {
            this.key = key;
            this.id = modifier ^ key ^ form1_hWnd.ToInt32();
            return RegisterHotKey(form1_hWnd,id,modifier,key);
        }

        public bool unregister()
        {
            return UnregisterHotKey(form1_hWnd, id);
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue) {
                if (disposing) {
                    // TODO: dispose managed state (managed objects).
                    unregister();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~HotKeys() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace CustomControl
{
    public partial class CustomButton : Control
    {
        #region Fields
        private Control control = null;
        private NativeWindow tipWindow = null;
        public readonly static string TOOLTIPS_CLASS = "tooltips_class32";
        private bool nativeCheck;
        private Bitmap icon;
        #endregion
        public CustomButton()
        {
            InitializeComponent();
            control = this;
            this.Click += CustomButton_Click;
        }

        private void CustomButton_Click(object? sender, EventArgs e)
        {
            if (nativeCheck)
            {
                ShowToolTip();
            }
        }

        #region Properties
        [Browsable(true)]
        public bool NativeCheck
        {
            get
            {
                return nativeCheck;
            }
            set
            {
                nativeCheck = value;
            }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Editor(typeof(ImageEditor), typeof(UITypeEditor))]
        public Bitmap Icon
        {
            get { return icon; }
            set
            {
                if (!Equals(icon, value))
                {
                    icon = value;
                    this.Invalidate();
                }
            }
        }

        #endregion
        private void ShowToolTip()
        {
            System.Windows.Forms.CreateParams cp;
            cp = new CreateParams();
            cp.Parent = this.control.Handle;
            cp.ClassName = TOOLTIPS_CLASS;
            cp.Style = 1;
            this.tipWindow = new NativeWindow();
            this.tipWindow.CreateHandle(cp);
            NativeMethods.SetWindowPos(this.tipWindow.Handle, (IntPtr)NativeMethods.HWND_NOTOPMOST, 0, 0, 0, 0, 19);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }

    internal class NativeMethods
    {
        internal const int HWND_NOTOPMOST = -2; // 0xfffe
        [DllImport("USER32.dll")]
        internal static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, int uFlags);

    }
}

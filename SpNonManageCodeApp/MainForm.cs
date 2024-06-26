using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace SpNonManageCodeApp
{
    public partial class MainForm : Form
    {
        const uint WM_SETTEXT = 0x0C;
        public MainForm()
        {
            InitializeComponent();

        }
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hwnd, uint Msg, int wParam, [MarshalAs(UnmanagedType.LPStr)] string lParam);

        private void button1_Click(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.LoadFrom("ChildProcessApp.dll");
            Process process = Process.Start(assembly.GetName().Name);
            //SendMessage(process.MainWindowHandle, WM_SETTEXT, 0, "Hello world");
        }
    }
}

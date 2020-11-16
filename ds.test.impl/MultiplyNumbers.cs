using System.Drawing;

namespace ds.test.impl
{
    class MultiplyNumbers : IPlugin
    {
        public Image Image { get => new Bitmap(64, 64); }

        public string Description { get => "Умножает числа."; }

        public string PluginName { get => "MultiplyNumbers"; }

        public string GetVersion()
        {
            return "1.0";
        }

        public int Run(int input1, int input2)
        {
            return input1 * input2;
        }
    }
}

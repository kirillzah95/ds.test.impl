using System.Drawing;

namespace ds.test.impl
{
    class AddNumbers : IPlugin
    {
        public Image Image { get => new Bitmap(64, 64); }

        public string Description { get => "Складывает числа."; }

        public string PluginName { get => "AddNumbers"; }

        public string GetVersion()
        {
            return "1.0";
        }

        public int Run(int input1, int input2)
        {
            return input1 + input2;
        }
    }
}

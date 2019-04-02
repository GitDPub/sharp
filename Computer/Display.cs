namespace Computer
{
    using System;

    public class Display : Hardware
    {
        private string resolution;
        private int dimention;

        public Display(string marca, string color, string mac, bool input, bool output, string resolution, int dimention) : base(marca, color, mac, input, output)
        {
            this.resolution = resolution;
            this.dimention = dimention;
        }

        public string Projectimage()
        {
            return string.Empty;
        }
    }
}

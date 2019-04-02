namespace Computer
{
    using System;

    public class CPU : Hardware
    {
        private string software;
        private string hardDisk;
        private string processor;
        private int ram;

        public CPU(string marca, string color, string mac, bool input, bool output, string software, string hardDisk, string processor, int ram) : base(marca, color, mac, input, output)
        {
            this.software = software;
            this.hardDisk = hardDisk;
            this.processor = processor;
            this.ram = ram;
        }

        public string DataProcessing(string stream)
        {
            return string.Empty;
        }

        public string Transmition(string stream)
        {
            return string.Empty;
        }

        public string Reception(string stream)
        {
            return string.Empty;
        }
    }
}

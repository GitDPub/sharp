namespace Computer
{
    using System;

    public class KeyBoard : Hardware
    {
        private string key;
        private string language;
        private bool numPad;

        public KeyBoard()
        {
        }

        public KeyBoard(string marca, string color, string mac, bool input, bool output, string key, string language, bool numPad) : base(marca, color, mac, input, output)
        {
            this.key = key;
            this.language = language;
            this.numPad = numPad;
        }

        public string Press(string keys)
        {
            return keys;
        }
    }
}

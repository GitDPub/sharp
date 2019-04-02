namespace Computer
{
    using System;

    public class Hardware
    {
        private string marca;
        private string color;
        private string mac;
        private bool input;
        private bool output;
        private bool on = false;

        public Hardware()
        {
        }

        public Hardware(string marca, string color, string mac, bool input, bool output)
        {
            this.marca = marca;
            this.color = color;
            this.mac = mac;
            this.input = input;
            this.output = output;
        }

        public void OnOff()
        {
            this.on = !this.on;
        }

        protected bool Plug()
        {
            return false;
        }

        protected bool StandBy()
        {
            return false;
        }
    }
}

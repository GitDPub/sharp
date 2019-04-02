namespace Computer
{
    using System;

    public class User
    {
        private string userName;
        private string password;
        private string profile;

        public User(string userName, string password, string profile)
        {
            this.userName = userName;
            this.password = password;
            this.profile = profile;
        }

        public static void Main()
        {
            Console.WriteLine("Starting all:");

            CPU objectCPU = new CPU("Dell", "negro", "12:E3:4D:5C:11:AA", true, true, "Windows10", "Sata_500GB", "i5", 16);
            KeyBoard objectKB = new KeyBoard("Genius", "negro", "12:E3:4D:5C:11:AB", false, true, string.Empty, "ES", true);
            Display objectDis = new Display("Samsung", "negro", "12:E3:4D:5C:11:AC", true, false, "1920x1080", 15);
            Mouse objectMouse = new Mouse("Genius", "negro", "12:E3:4D:5C:11:AD", false, true, 0, 0, string.Empty);
            WebCam objectWC = new WebCam("Genius", "negro", "12:E3:4D:5C:11:AE", false, true, "1k", string.Empty);
            User user = new User("admin", "12345", "admin");

            Console.WriteLine("on all: ");

            objectCPU.OnOff();
            objectKB.OnOff();
            objectDis.OnOff();
            objectMouse.OnOff();
            objectWC.OnOff();

            Console.WriteLine("typed text: " + objectKB.Press("Hola mundo"));

            objectMouse.X = 1;
            objectMouse.Y = 1;
            objectMouse.X = 2;
            objectMouse.Y = 1;
            objectMouse.X = 3;
            objectMouse.Y = 1;
            objectMouse.X = 4;
            objectMouse.Y = 1;
            objectMouse.X = 5;
            objectMouse.Y = 1;
            objectMouse.X = 6;
            objectMouse.Y = 2;
            objectMouse.X = 6;
            objectMouse.Y = 3;
            objectMouse.X = 6;
            objectMouse.Y = 4;
            objectMouse.X = 6;
            objectMouse.Y = 5;
            objectMouse.X = 6;
            objectMouse.Y = 6;
            objectMouse.X = 6;
            objectMouse.Y = 7;

            objectMouse.Key = "left";
            objectMouse.Key = "right";
            objectMouse.Key = "up";
            objectMouse.Key = "up";
            objectMouse.Key = "up";
            objectMouse.Key = "down";
            objectMouse.Key = "wheel";

            Console.WriteLine();

            Console.ReadKey();
        }

        public bool TurnOn()
        {
            return false;
        }

        public bool TurnOff()
        {
            return false;
        }

        public bool UsePC()
        {
            return false;
        }
    }
}

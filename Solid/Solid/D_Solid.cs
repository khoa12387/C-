using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public interface ISwitchable
    {
        void TurnOn();
        void TurnOff();
    }

    public class LightBulb : ISwitchable
    {
        public void TurnOn()
        {
            Console.WriteLine("LightBulb is turned on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("LightBulb is turned off.");
        }
    }

    public class Fan : ISwitchable
    {
        public void TurnOn()
        {
            Console.WriteLine("Fan is turned on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Fan is turned off.");
        }
    }

    public class Switch
    {
        private ISwitchable _device;

        public Switch(ISwitchable device)
        {
            _device = device;
        }

        public void Operate(bool on)
        {
            if (on)
                _device.TurnOn();
            else
                _device.TurnOff();
        }
    }
}

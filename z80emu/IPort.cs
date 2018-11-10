using System;

namespace z80emu
{
    interface IDevice
    {
      byte Read(byte highPart);
      void Write(byte highPart, byte value);
      event EventHandler Interrupt;
    }

    class Port
    {
      private IDevice[] map = new IDevice[256];

      public void Bind(byte port, IDevice device)
      {
        this.map[port] = device;
      }

      public IDevice Get(byte port)
      {
        return this.map[port];
      }
    }
}

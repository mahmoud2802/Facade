using System;
using Facade.Computer;



namespace Facade.Facades
{
    public class ComputerFacade
    {
        private readonly Bios _bios;
        private readonly Ram _ram;
        private readonly OperatingSystems _operatingSystem;

        public ComputerFacade()
        {
            Console.WriteLine("/////////////////////////////////");
            
         _bios=new Bios();
         _ram=new Ram();
         _operatingSystem=new OperatingSystems();
        }

        public void TurnOn()
        {
            _bios.Process();
            _ram.CopyData();
            _operatingSystem.Loading();
            Console.WriteLine("Computer Turned On");
        }

        public void TurnOff()
        {
            Console.WriteLine("Computer Turned Off");
        }
    }
}
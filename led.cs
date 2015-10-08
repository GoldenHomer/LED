using System;
using Microsoft.SPOT;
using System.Threading;
using Microsoft.SPOT.Hardware;
using GHIElectronics.NETMF.FEZ;

namespace MFConsoleApplication1
{
	public class Program
	{
		public static void Main()
		{
			OutputPort LED;
			InputPort Button;
			
			//Read the status of the button and pass state to LED. LED turns off when button is pressed.
			LED = new OutputPort((Cpu.Pin)FEZ_Pin.Digital.LED, true);
			Button = new InputPort((Cpu.Pin)FEZ_Pin.Digital.LDR, false, Port.ResistorMode.PullUp);
			
			while (true) 
			{
				LED.Write(true);
				Thread.Sleep(200);
				
				LED.Write(false);
				Thread.Sleep(200);
			}
		}
	}
}

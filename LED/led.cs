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
			LED = new OutputPort((Cpu.Pin)FEZ_Pin.Digital.LED, true);
			
			// led
			Thread.Sleep(Timeout.Infinite);
		}
	}
}

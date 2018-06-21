using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test658
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass658>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}

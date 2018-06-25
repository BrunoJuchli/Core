using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test852
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass852>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
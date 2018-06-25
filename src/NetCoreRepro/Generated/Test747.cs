using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test747
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass747>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
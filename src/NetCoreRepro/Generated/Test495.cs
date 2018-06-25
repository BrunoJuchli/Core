using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test495
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass495>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
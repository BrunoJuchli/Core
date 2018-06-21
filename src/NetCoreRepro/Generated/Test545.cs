using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test545
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass545>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}

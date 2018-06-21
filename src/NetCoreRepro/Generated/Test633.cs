using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test633
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass633>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}

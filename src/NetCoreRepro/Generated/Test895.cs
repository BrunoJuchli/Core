using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test895
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass895>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
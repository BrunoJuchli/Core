using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test919
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass919>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
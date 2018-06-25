using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test178
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass178>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
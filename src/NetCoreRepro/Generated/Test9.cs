using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test9
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass9>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
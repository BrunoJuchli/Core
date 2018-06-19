using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test291
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass291>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}

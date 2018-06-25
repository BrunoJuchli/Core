using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test744
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass744>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
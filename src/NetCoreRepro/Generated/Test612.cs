using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test612
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass612>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}

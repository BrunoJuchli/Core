using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test819
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass819>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
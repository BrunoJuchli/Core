using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test386
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass386>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
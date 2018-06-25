using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test272
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass272>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
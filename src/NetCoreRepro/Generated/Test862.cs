using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test862
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass862>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
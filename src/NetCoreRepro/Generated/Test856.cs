using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test856
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass856>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
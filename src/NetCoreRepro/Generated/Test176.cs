using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test176
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass176>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
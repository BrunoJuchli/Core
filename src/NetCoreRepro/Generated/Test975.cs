using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test975
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass975>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
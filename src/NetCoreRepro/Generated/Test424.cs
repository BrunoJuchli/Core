using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test424
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass424>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}

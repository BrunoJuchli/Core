using System;
using System.Diagnostics;

namespace NetCoreRepro.ToDuplicate
{
	public class Test983
	{
		public void DoSomething()
		{
			try
			{
				var aClass = ProxyFactory.CreateProxy<IClass983>();
				bool result = aClass.DoSomething();
			}
			catch (Exception)
			{
				Debugger.Launch();
			}
		}
	}
}
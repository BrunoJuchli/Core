using System;
using Castle.DynamicProxy;

namespace NetCoreRepro
{
	public static class ProxyFactory
	{
		private static readonly object locker = new object();
		private static readonly ProxyGenerator generator = new ProxyGenerator();
		private static readonly Interceptor interceptor = new Interceptor();

		public static T CreateProxy<T>() where T : class
		{
			lock (locker)
			{
				return generator.CreateInterfaceProxyWithoutTarget<T>(interceptor);
			}
		}

		private sealed class Interceptor : IInterceptor
		{
			public void Intercept(IInvocation invocation)
			{
				if (invocation.Method.ReturnType == typeof(void))
				{
				}
				else if (invocation.Method.ReturnType == typeof(bool))
				{
					invocation.ReturnValue = true;
				}
				else
				{
					invocation.ReturnValue = Activator.CreateInstance(invocation.Method.ReturnType);
				}
			}
		}
	}
}

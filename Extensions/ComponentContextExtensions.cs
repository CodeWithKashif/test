using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;

namespace Crimson.CMA.Utility.Extensions
{
	public static class ComponentContextExtensions
	{
		public static object SafeResolve ( this Autofac.IComponentContext context, Type serviceType )
		{
			object o;
			if ( context.TryResolve ( serviceType, out o ) )
				return o;
			else
				return null;
		}
	}
}

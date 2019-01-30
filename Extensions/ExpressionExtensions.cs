using System;

namespace PCHP.Utility.Extensions
{
	public static class ExpressionExtensions
	{
		public static string GetName<T> ( this System.Linq.Expressions.Expression<Func<T>> exp )
		{
			System.Linq.Expressions.MemberExpression memberExp = exp.Body as System.Linq.Expressions.MemberExpression;
			if ( memberExp == null )
				throw new Exception ( "Body of lambda must be a member access." );

			return memberExp.Member.Name;
		}

		public static string GetName<T, TR> ( this System.Linq.Expressions.Expression<Func<T, TR>> exp )
		{
			System.Linq.Expressions.MemberExpression memberExp = exp.Body as System.Linq.Expressions.MemberExpression;
			if ( memberExp == null )
				throw new Exception ( "Body of lambda must be a member access." );

			return memberExp.Member.Name;
		}
	}
}

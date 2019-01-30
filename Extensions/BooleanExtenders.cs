namespace PCHP.Utility.Extensions
{
	public static class BooleanExtenders
	{
		public static string IfTrue(this bool value, string returnIfTrue)
		{
			return IfTrue(value, returnIfTrue, string.Empty);
		}

		public static string IfTrue(this bool value, string returnIfTrue, string returnIfFalse)
		{
			return (value) ? returnIfTrue : returnIfFalse;
		}
	}
}

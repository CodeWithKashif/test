using System;
using System.Collections.Generic;

namespace PCHP.Utility.Extensions
{
	public static class RandomExtensions
	{
		public static bool NextBool ( this Random rand, float odds = .5f )
		{
			if ( odds < 0 || odds > 1 )
				throw new ArgumentException ( "odds must be between 0 and 1, inclusive" );

			return rand.NextDouble ( ) > .5f;
		}

		//NOTE: Enum.GetValues is slow enough that it needs to be cached before this code is highly used in production.  It is fine for test or simple applications.
		public static T NextEnum<T> ( this Random oRandom )
		{
			if ( !typeof ( T ).IsEnum )
				throw new Exception ( "Type of T must be an enum" );

			Array aValues = Enum.GetValues ( typeof ( T ) );

			return (T)aValues.GetValue ( oRandom.Next ( 0, aValues.Length ) );
		}

		public static T NextItem<T> ( this Random oRandom, IList<T> arr )
		{
			return arr[ oRandom.Next ( 0, arr.Count ) ];
		}
	}
}

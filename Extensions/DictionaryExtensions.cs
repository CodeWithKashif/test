using System;
using System.Collections.Generic;

namespace PCHP.Utility.Extensions
{
	public static class DictionaryExtensions
	{
		public static TValue SafeGet<TKey, TValue> ( this IDictionary<TKey, TValue> oDictionary, TKey sKey )
		{
			return oDictionary.SafeGet ( sKey, ( ) => default ( TValue ), false );
		}

		public static TValue SafeGet<TKey, TValue> ( this IDictionary<TKey, TValue> oDictionary, TKey sKey, Func<TValue> fnGetDefault, bool bAddDefault )
		{
			if ( oDictionary == null ) return fnGetDefault ( );

			TValue value;
			if ( oDictionary.TryGetValue ( sKey, out value ) )
				return value;
			else
			{
				TValue oDefault = fnGetDefault ( );

				if ( bAddDefault )
					oDictionary[ sKey ] = oDefault;

				return oDefault;
			}
		}
	}
}

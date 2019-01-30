using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace PCHP.Utility.Extensions
{
	public static class CollectionExtensions
	{
		public static TSource Second<TSource> ( this IEnumerable<TSource> source )
		{
			return source.ItemByNumber ( 1 );
		}

		public static TSource Third<TSource> ( this IEnumerable<TSource> source )
		{
			return source.ItemByNumber ( 2 );
		}

		public static TSource SecondToLast<TSource> ( this IEnumerable<TSource> source )
		{
			if ( source == null )
				return default ( TSource );

			return source.Reverse ( ).Skip ( 1 ).FirstOrDefault ( );
		}

        /// <summary>
        /// result.DistinctBy(x => x.Name)
        /// </summary>
	    public static IEnumerable<TSource> DistinctBy<TSource, TKey>
	        (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	    {
	        HashSet<TKey> seenKeys = new HashSet<TKey>();
	        foreach (TSource element in source)
	        {
	            if (seenKeys.Add(keySelector(element)))
	            {
	                yield return element;
	            }
	        }
	    }

	    public static DataTable Pivot(this DataTable tbl)
	    {
	        var tblPivot = new DataTable();
	        tblPivot.Columns.Add(tbl.Columns[0].ColumnName);
	        for (int i = 1; i < tbl.Rows.Count; i++)
	        {
	            tblPivot.Columns.Add(Convert.ToString(i));
	        }
	        for (int col = 0; col < tbl.Columns.Count; col++)
	        {
	            var r = tblPivot.NewRow();
	            r[0] = tbl.Columns[col].ToString();
	            for (int j = 1; j < tbl.Rows.Count; j++)
	                r[j] = tbl.Rows[j][col];

	            tblPivot.Rows.Add(r);
	        }
	        return tblPivot;
	    }

	    private static DataTable GenerateTransposedTable(this DataTable inputTable)
	    {
	        DataTable outputTable = new DataTable();

	        // Add columns by looping rows

	        // Header row's first column is same as in inputTable
	        outputTable.Columns.Add(inputTable.Columns[0].ColumnName.ToString());

	        // Header row's second column onwards, 'inputTable's first column taken
	        foreach (DataRow inRow in inputTable.Rows)
	        {
	            string newColName = inRow[0].ToString();
	            outputTable.Columns.Add(newColName);
	        }

	        // Add rows by looping columns        
	        for (int rCount = 1; rCount <= inputTable.Columns.Count - 1; rCount++)
	        {
	            DataRow newRow = outputTable.NewRow();

	            // First column is inputTable's Header row's second column
	            newRow[0] = inputTable.Columns[rCount].ColumnName.ToString();
	            for (int cCount = 0; cCount <= inputTable.Rows.Count - 1; cCount++)
	            {
	                string colValue = inputTable.Rows[cCount][rCount].ToString();
	                newRow[cCount + 1] = colValue;
	            }
	            outputTable.Rows.Add(newRow);
	        }

	        return outputTable;
	    }

        private static TSource ItemByNumber<TSource> ( this IEnumerable<TSource> source, uint n )
		{
			if ( source == null )
				return default ( TSource );

			IList<TSource> list = source as IList<TSource>;
			if ( list != null )
			{
				if ( list.Count > n )
					return list[ (int)n ];
			}
			else
			{
				int nCount = 0;
				using ( IEnumerator<TSource> enumerator = source.GetEnumerator ( ) )
				{
					bool bMoveNext;
					while ( ( bMoveNext = enumerator.MoveNext ( ) ) && nCount < n )
					{
						nCount++;
					}

					if ( bMoveNext )
						return enumerator.Current;
				}
			}

			throw new ArgumentException ( "source does not contain " + n + " or more elements.", "source" );
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace PtNet.Utils.Linq
{
	public static class EnumerableExtensions
	{
		public static IEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource,TKey> keySelector, SortingDirection direction)
		{
			switch (direction)
			{
                default:
				case SortingDirection.Ascending:
					return source.OrderBy(keySelector);
				case SortingDirection.Descending:
					return source.OrderByDescending(keySelector);
			}
		}
		
		public static IEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, params Func<TSource, TKey>[] keySelectors)
		{
			throw new NotImplementedException();
		}

	    public static IEnumerable<TSource> WhereNot<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> keySelector)
	    {
	        return source.Where(p => !keySelector(p));
	    }

        public static TSource FirstOrDefined<TSource>(this IEnumerable<TSource> source, TSource defaultResult)
        {
            var result = source.FirstOrDefault();

            if (result == null)
            {
                return defaultResult;
            }

            return result;
        }

        public static TSource FirstOrDefined<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> keySelector, TSource defaultResult)
        {
            throw new NotImplementedException();
        }

        public static TSource Second<TSource>(this IEnumerable<TSource> source)
        {
            return source.Skip(1).First();
        }

        public static TSource Second<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> keySelector)
        {
            return source.Where(keySelector).Skip(1).First();
        }

        public static TSource SecondOrDefault<TSource>(this IEnumerable<TSource> source)
        {
            return source.Skip(1).FirstOrDefault();
        }

        public static TSource SecondOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> keySelector)
        {
            return source.Where(keySelector).Skip(1).FirstOrDefault();
        }

        public static TSource SecondOrDefined<TSource>(this IEnumerable<TSource> source, TSource defaultResult)
        {
            throw new NotImplementedException();
        }

        public static TSource SecondOrDefined<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> keySelector, TSource defaultResult)
	    {
	        throw new NotImplementedException();
	    }

        public static TSource Random<TSource>(this IEnumerable<TSource> source)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<TSource> Shuffle<TSource>(this IEnumerable<TSource> source)
        {
            throw new NotImplementedException();
        }

        public static void ForEach<TSource>(this IEnumerable<TSource> source, Action<TSource> action)
        {
            throw new NotImplementedException();
        }
    }
}
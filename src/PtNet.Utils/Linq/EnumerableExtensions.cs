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

        public static IEnumerable<TSource> WhereNot<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> keySelector)
	    {
	        return source.Where(p => !keySelector(p));
	    }

        public static TSource FirstOrDefined<TSource>(this IEnumerable<TSource> source, TSource defaultResult)
        {
            var result = source.FirstOrDefault();

            if (EqualityComparer<TSource>.Default.Equals(result, default(TSource)))
            {
                return defaultResult;
            }

            return result;
        }

        public static TSource FirstOrDefined<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> keySelector, TSource defaultResult)
        {
            var result = source.FirstOrDefault(p => keySelector(p)) ;
            
            if (EqualityComparer<TSource>.Default.Equals(result, default(TSource)))
            {
                return defaultResult;
            }
            return result;
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
            return source.Skip(1).FirstOrDefined(defaultResult);    
        }

        public static TSource SecondOrDefined<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> keySelector, TSource defaultResult)
	    {
            return source.Where(keySelector).SecondOrDefined(defaultResult);  
        }

        public static TSource Random<TSource>(this IEnumerable<TSource> source)
        {
            var rand = new Random();
            
            return source.ElementAt(rand.Next(source.Count()));
        }

        public static IEnumerable<TSource> Shuffle<TSource>(this IEnumerable<TSource> source)
        {
            return source.OrderBy(elem => Guid.NewGuid());
        }

        public static void ForEach<TSource>(this IEnumerable<TSource> source, Action<TSource> action)
        {
            foreach(var item in source)
            {
                action(item);
            }
        }
    }
}
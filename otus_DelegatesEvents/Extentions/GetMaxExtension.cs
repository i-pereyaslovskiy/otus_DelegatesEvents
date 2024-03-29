﻿using otus_DelegatesEvents.Extentions;
using otus_DelegatesEvents.FileSearcher;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_DelegatesEvents.Tests
{
    public static class GetMaxExtension
    {
        public static T GetMax<T>(this IEnumerable<T> collection, Func<T, float> convertToNumber) where T : class
        {
            if (collection == null || !collection.Any())
                throw new ArgumentException("Collection is Null or Empty");

            T maxElement = collection.First();
            float maxValue = convertToNumber(maxElement);

            foreach (T item in collection)
            {
                float value = convertToNumber(item);
                if (value > maxValue)
                {
                    maxValue = value;
                    maxElement = item;
                }
            }
            return maxElement;
        }

       
    }
}

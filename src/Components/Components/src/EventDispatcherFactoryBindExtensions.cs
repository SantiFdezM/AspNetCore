// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Globalization;

namespace Microsoft.AspNetCore.Components
{
    /// <summary>
    /// Contains extension methods for two-way binding using <see cref="EventDispatcher"/>. For internal use only.
    /// </summary>
    public static class EventDispatcherFactoryBindExtensions
    {
        /// <summary>
        /// For internal use only.
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="receiver"></param>
        /// <param name="setter"></param>
        /// <param name="existingValue"></param>
        /// <returns></returns>
        public static EventDispatcher<UIChangeEventArgs> CreateBindingDispatcher(
            this EventDispatcherFactory factory,
            object receiver,
            Action<string> setter,
            string existingValue)
        {
            Func<object, string> converter = (obj) => (string)obj;
            return CreateBindingDispatcherCore<string>(factory, receiver, setter, converter);
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="receiver"></param>
        /// <param name="setter"></param>
        /// <param name="existingValue"></param>
        /// <returns></returns>
        public static EventDispatcher<UIChangeEventArgs> CreateBindingDispatcher(
            this EventDispatcherFactory factory,
            object receiver,
            Action<bool> setter,
            bool existingValue)
        {
            Func<object, bool> converter = (obj) => (bool)obj;
            return CreateBindingDispatcherCore<bool>(factory, receiver, setter, converter);
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="receiver"></param>
        /// <param name="setter"></param>
        /// <param name="existingValue"></param>
        /// <returns></returns>
        public static EventDispatcher<UIChangeEventArgs> CreateBindingDispatcher(
            this EventDispatcherFactory factory,
            object receiver,
            Action<bool?> setter,
            bool? existingValue)
        {
            Func<object, bool?> converter = (obj) => (bool?)obj;
            return CreateBindingDispatcherCore<bool?>(factory, receiver, setter, converter);
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="receiver"></param>
        /// <param name="setter"></param>
        /// <param name="existingValue"></param>
        /// <returns></returns>
        public static EventDispatcher<UIChangeEventArgs> CreateBindingDispatcher(
            this EventDispatcherFactory factory,
            object receiver,
            Action<int> setter,
            bool existingValue)
        {
            Func<object, int> converter = (obj) =>
            {
                return int.Parse((string)obj);
            };
            return CreateBindingDispatcherCore<int>(factory, receiver, setter, converter);
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="receiver"></param>
        /// <param name="setter"></param>
        /// <param name="existingValue"></param>
        /// <returns></returns>
        public static EventDispatcher<UIChangeEventArgs> CreateBindingDispatcher(
            this EventDispatcherFactory factory,
            object receiver,
            Action<int?> setter,
            int? existingValue)
        {
            Func<object, int?> converter = (obj) =>
            {
                if (int.TryParse((string)obj, out var value))
                {
                    return value;
                }

                return null;
            };
            return CreateBindingDispatcherCore<int?>(factory, receiver, setter, converter);
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="receiver"></param>
        /// <param name="setter"></param>
        /// <param name="existingValue"></param>
        /// <returns></returns>
        public static EventDispatcher<UIChangeEventArgs> CreateBindingDispatcher(
            this EventDispatcherFactory factory,
            object receiver,
            Action<long> setter,
            long existingValue)
        {
            Func<object, long> converter = (obj) =>
            {
                return long.Parse((string)obj);
            };
            return CreateBindingDispatcherCore<long>(factory, receiver, setter, converter);
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="receiver"></param>
        /// <param name="setter"></param>
        /// <param name="existingValue"></param>
        /// <returns></returns>
        public static EventDispatcher<UIChangeEventArgs> CreateBindingDispatcher(
            this EventDispatcherFactory factory,
            object receiver,
            Action<long?> setter,
            long? existingValue)
        {
            Func<object, long?> converter = (obj) =>
            {
                if (long.TryParse((string)obj, out var value))
                {
                    return value;
                }

                return null;
            };
            return CreateBindingDispatcherCore<long?>(factory, receiver, setter, converter);
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="receiver"></param>
        /// <param name="setter"></param>
        /// <param name="existingValue"></param>
        /// <returns></returns>
        public static EventDispatcher<UIChangeEventArgs> CreateBindingDispatcher(
            this EventDispatcherFactory factory,
            object receiver,
            Action<float> setter,
            float existingValue)
        {
            Func<object, float> converter = (obj) =>
            {
                return float.Parse((string)obj);
            };
            return CreateBindingDispatcherCore<float>(factory, receiver, setter, converter);
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="receiver"></param>
        /// <param name="setter"></param>
        /// <param name="existingValue"></param>
        /// <returns></returns>
        public static EventDispatcher<UIChangeEventArgs> CreateBindingDispatcher(
            this EventDispatcherFactory factory,
            object receiver,
            Action<float?> setter,
            float? existingValue)
        {
            Func<object, float?> converter = (obj) =>
            {
                if (float.TryParse((string)obj, out var value))
                {
                    return value;
                }

                return null;
            };
            return CreateBindingDispatcherCore<float?>(factory, receiver, setter, converter);
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="receiver"></param>
        /// <param name="setter"></param>
        /// <param name="existingValue"></param>
        /// <returns></returns>
        public static EventDispatcher<UIChangeEventArgs> CreateBindingDispatcher(
            this EventDispatcherFactory factory,
            object receiver,
            Action<double> setter,
            double existingValue)
        {
            Func<object, double> converter = (obj) =>
            {
                return double.Parse((string)obj);
            };
            return CreateBindingDispatcherCore<double>(factory, receiver, setter, converter);
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="receiver"></param>
        /// <param name="setter"></param>
        /// <param name="existingValue"></param>
        /// <returns></returns>
        public static EventDispatcher<UIChangeEventArgs> CreateBindingDispatcher(
            this EventDispatcherFactory factory,
            object receiver,
            Action<double?> setter,
            double? existingValue)
        {
            Func<object, double?> converter = (obj) =>
            {
                if (double.TryParse((string)obj, out var value))
                {
                    return value;
                }

                return null;
            };
            return CreateBindingDispatcherCore<double?>(factory, receiver, setter, converter);
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="receiver"></param>
        /// <param name="setter"></param>
        /// <param name="existingValue"></param>
        /// <returns></returns>
        public static EventDispatcher<UIChangeEventArgs> CreateBindingDispatcher(
            this EventDispatcherFactory factory,
            object receiver,
            Action<decimal> setter,
            decimal existingValue)
        {
            Func<object, decimal> converter = (obj) =>
            {
                return decimal.Parse((string)obj);
            };
            return CreateBindingDispatcherCore<decimal>(factory, receiver, setter, converter);
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="receiver"></param>
        /// <param name="setter"></param>
        /// <param name="existingValue"></param>
        /// <returns></returns>
        public static EventDispatcher<UIChangeEventArgs> CreateBindingDispatcher(
            this EventDispatcherFactory factory,
            object receiver,
            Action<decimal?> setter,
            decimal? existingValue)
        {
            Func<object, decimal?> converter = (obj) =>
            {
                if (decimal.TryParse((string)obj, out var value))
                {
                    return value;
                }

                return null;
            };
            return CreateBindingDispatcherCore<decimal?>(factory, receiver, setter, converter);
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="receiver"></param>
        /// <param name="setter"></param>
        /// <param name="existingValue"></param>
        /// <returns></returns>
        public static EventDispatcher<UIChangeEventArgs> CreateBindingDispatcher(
            this EventDispatcherFactory factory,
            object receiver,
            Action<DateTime> setter,
            DateTime existingValue)
        {
            // Avoiding CreateBindingDispatcherCore so we can avoid an extra allocating lambda
            // when a format is used.
            Action<UIChangeEventArgs> callback = (e) =>
            {
                setter(ConvertDateTime(e.Value, format: null));
            };
            return factory.CreateDispatcher<UIChangeEventArgs>(receiver, callback);
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="receiver"></param>
        /// <param name="setter"></param>
        /// <param name="existingValue"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static EventDispatcher<UIChangeEventArgs> CreateBindingDispatcher(
            this EventDispatcherFactory factory,
            object receiver,
            Action<DateTime> setter,
            DateTime existingValue,
            string format)
        {
            // Avoiding CreateBindingDispatcherCore so we can avoid an extra allocating lambda
            // when a format is used.
            Action<UIChangeEventArgs> callback = (e) =>
            {
                setter(ConvertDateTime(e.Value, format));
            };
            return factory.CreateDispatcher<UIChangeEventArgs>(receiver, callback);
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="factory"></param>
        /// <param name="receiver"></param>
        /// <param name="setter"></param>
        /// <param name="existingValue"></param>
        /// <returns></returns>
        public static EventDispatcher<UIChangeEventArgs> CreateBindingDispatcher<T>(
            this EventDispatcherFactory factory,
            object receiver,
            Action<T> setter,
            T existingValue) where T : Enum
        {
            Func<object, T> converter = (obj) =>
            {
                return (T)Enum.Parse(typeof(T), (string)obj); ;
            };
            return CreateBindingDispatcherCore<T>(factory, receiver, setter, converter);
        }

        private static DateTime ConvertDateTime(object obj, string format)
        {
            var text = (string)obj;
            if (string.IsNullOrEmpty(text))
            {
                return default;
            }
            else if (format != null && DateTime.TryParseExact(text, format, CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out var value))
            {
                return value;
            }
            else
            {
                return DateTime.Parse(text);
            }
        }

        private static EventDispatcher<UIChangeEventArgs> CreateBindingDispatcherCore<T>(
            this EventDispatcherFactory factory,
            object receiver,
            Action<T> setter,
            Func<object, T> converter)
        {
            Action<UIChangeEventArgs> callback = e =>
            {
                setter(converter(e.Value));
            };
            return factory.CreateDispatcher<UIChangeEventArgs>(receiver, callback);
        }
    }
}

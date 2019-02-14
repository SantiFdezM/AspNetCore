// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components
{
    /// <summary>
    /// A factory for creating <see cref="EventDispatcher"/> and <see cref="EventDispatcher{T}"/>
    /// instances.
    /// </summary>
    public sealed class EventDispatcherFactory
    {
        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public EventDispatcher CreateDispatcher(object receiver, Action callback)
        {
            if (receiver == null)
            {
                throw new ArgumentNullException(nameof(receiver));
            }

            if (callback == null)
            {
                throw new ArgumentNullException(nameof(callback));
            }

            return CreateDispatcherCore(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public EventDispatcher CreateDispatcher(object receiver, Action<object> callback)
        {
            if (receiver == null)
            {
                throw new ArgumentNullException(nameof(receiver));
            }

            if (callback == null)
            {
                throw new ArgumentNullException(nameof(callback));
            }

            return CreateDispatcherCore(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public EventDispatcher CreateDispatcher(object receiver, Func<Task> callback)
        {
            if (receiver == null)
            {
                throw new ArgumentNullException(nameof(receiver));
            }

            if (callback == null)
            {
                throw new ArgumentNullException(nameof(callback));
            }

            return CreateDispatcherCore(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public EventDispatcher CreateDispatcher(object receiver, Func<object, Task> callback)
        {
            if (receiver == null)
            {
                throw new ArgumentNullException(nameof(receiver));
            }

            if (callback == null)
            {
                throw new ArgumentNullException(nameof(callback));
            }

            return CreateDispatcherCore(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public EventDispatcher<T> CreateDispatcher<T>(object receiver, Action callback)
        {
            if (receiver == null)
            {
                throw new ArgumentNullException(nameof(receiver));
            }

            if (callback == null)
            {
                throw new ArgumentNullException(nameof(callback));
            }

            return CreateDispatcherCore<T>(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public EventDispatcher<T> CreateDispatcher<T>(object receiver, Action<T> callback)
        {
            if (receiver == null)
            {
                throw new ArgumentNullException(nameof(receiver));
            }

            if (callback == null)
            {
                throw new ArgumentNullException(nameof(callback));
            }

            return CreateDispatcherCore<T>(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public EventDispatcher<T> CreateDispatcher<T>(object receiver, Func<Task> callback)
        {
            if (receiver == null)
            {
                throw new ArgumentNullException(nameof(receiver));
            }

            if (callback == null)
            {
                throw new ArgumentNullException(nameof(callback));
            }

            return CreateDispatcherCore<T>(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public EventDispatcher<T> CreateDispatcher<T>(object receiver, Func<T, Task> callback)
        {
            if (receiver == null)
            {
                throw new ArgumentNullException(nameof(receiver));
            }

            if (callback == null)
            {
                throw new ArgumentNullException(nameof(callback));
            }

            return CreateDispatcherCore<T>(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        private EventDispatcher CreateDispatcherCore(object receiver, MulticastDelegate callback)
        {
            if (!object.ReferenceEquals(receiver, callback.Target) && receiver is IHandleAfterEvent handler)
            {
                return new EventDispatcher(handler, callback);
            }

            return new EventDispatcher(callback.Target as IHandleAfterEvent, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        private EventDispatcher<T> CreateDispatcherCore<T>(object receiver, MulticastDelegate callback)
        {
            if (!object.ReferenceEquals(receiver, callback.Target) && receiver is IHandleAfterEvent handler)
            {
                return new EventDispatcher<T>(handler, callback);
            }

            return new EventDispatcher<T>(callback.Target as IHandleAfterEvent, callback);
        }
    }
}

// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components
{
    /// <summary>
    /// Provides extension methods for <see cref="EventDispatcherFactory"/> and <see cref="UIEventArgs"/> types. For internal
    /// framework use.
    /// </summary>
    public static class EventDispatcherFactoryUIEventArgsExtensions
    {
        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="factory">The <see cref="EventDispatcherFactory"/>.</param>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public static EventDispatcher<UIEventArgs> CreateDispatcher(this EventDispatcherFactory factory, object receiver, Action<UIEventArgs> callback)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            return factory.CreateDispatcher<UIEventArgs>(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="factory">The <see cref="EventDispatcherFactory"/>.</param>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public static EventDispatcher<UIEventArgs> CreateDispatcher(this EventDispatcherFactory factory, object receiver, Func<UIEventArgs, Task> callback)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            return factory.CreateDispatcher<UIEventArgs>(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="factory">The <see cref="EventDispatcherFactory"/>.</param>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public static EventDispatcher<UIChangeEventArgs> CreateDispatcher(this EventDispatcherFactory factory, object receiver, Action<UIChangeEventArgs> callback)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            return factory.CreateDispatcher<UIChangeEventArgs>(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="factory">The <see cref="EventDispatcherFactory"/>.</param>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public static EventDispatcher<UIChangeEventArgs> CreateDispatcher(this EventDispatcherFactory factory, object receiver, Func<UIChangeEventArgs, Task> callback)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            return factory.CreateDispatcher<UIChangeEventArgs>(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="factory">The <see cref="EventDispatcherFactory"/>.</param>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public static EventDispatcher<UIClipboardEventArgs> CreateDispatcher(this EventDispatcherFactory factory, object receiver, Action<UIClipboardEventArgs> callback)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            return factory.CreateDispatcher<UIClipboardEventArgs>(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="factory">The <see cref="EventDispatcherFactory"/>.</param>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public static EventDispatcher<UIClipboardEventArgs> CreateDispatcher(this EventDispatcherFactory factory, object receiver, Func<UIClipboardEventArgs, Task> callback)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            return factory.CreateDispatcher<UIClipboardEventArgs>(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="factory">The <see cref="EventDispatcherFactory"/>.</param>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public static EventDispatcher<UIDragEventArgs> CreateDispatcher(this EventDispatcherFactory factory, object receiver, Action<UIDragEventArgs> callback)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            return factory.CreateDispatcher<UIDragEventArgs>(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="factory">The <see cref="EventDispatcherFactory"/>.</param>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public static EventDispatcher<UIDragEventArgs> CreateDispatcher(this EventDispatcherFactory factory, object receiver, Func<UIDragEventArgs, Task> callback)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            return factory.CreateDispatcher<UIDragEventArgs>(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="factory">The <see cref="EventDispatcherFactory"/>.</param>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public static EventDispatcher<UIErrorEventArgs> CreateDispatcher(this EventDispatcherFactory factory, object receiver, Action<UIErrorEventArgs> callback)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            return factory.CreateDispatcher<UIErrorEventArgs>(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="factory">The <see cref="EventDispatcherFactory"/>.</param>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public static EventDispatcher<UIErrorEventArgs> CreateDispatcher(this EventDispatcherFactory factory, object receiver, Func<UIErrorEventArgs, Task> callback)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            return factory.CreateDispatcher<UIErrorEventArgs>(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="factory">The <see cref="EventDispatcherFactory"/>.</param>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public static EventDispatcher<UIFocusEventArgs> CreateDispatcher(this EventDispatcherFactory factory, object receiver, Action<UIFocusEventArgs> callback)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            return factory.CreateDispatcher<UIFocusEventArgs>(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="factory">The <see cref="EventDispatcherFactory"/>.</param>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public static EventDispatcher<UIFocusEventArgs> CreateDispatcher(this EventDispatcherFactory factory, object receiver, Func<UIFocusEventArgs, Task> callback)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            return factory.CreateDispatcher<UIFocusEventArgs>(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="factory">The <see cref="EventDispatcherFactory"/>.</param>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public static EventDispatcher<UIKeyboardEventArgs> CreateDispatcher(this EventDispatcherFactory factory, object receiver, Action<UIKeyboardEventArgs> callback)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            return factory.CreateDispatcher<UIKeyboardEventArgs>(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="factory">The <see cref="EventDispatcherFactory"/>.</param>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public static EventDispatcher<UIKeyboardEventArgs> CreateDispatcher(this EventDispatcherFactory factory, object receiver, Func<UIKeyboardEventArgs, Task> callback)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            return factory.CreateDispatcher<UIKeyboardEventArgs>(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="factory">The <see cref="EventDispatcherFactory"/>.</param>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public static EventDispatcher<UIMouseEventArgs> CreateDispatcher(this EventDispatcherFactory factory, object receiver, Action<UIMouseEventArgs> callback)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            return factory.CreateDispatcher<UIMouseEventArgs>(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="factory">The <see cref="EventDispatcherFactory"/>.</param>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public static EventDispatcher<UIMouseEventArgs> CreateDispatcher(this EventDispatcherFactory factory, object receiver, Func<UIMouseEventArgs, Task> callback)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            return factory.CreateDispatcher<UIMouseEventArgs>(receiver, callback);
        }
        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="factory">The <see cref="EventDispatcherFactory"/>.</param>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public static EventDispatcher<UIPointerEventArgs> CreateDispatcher(this EventDispatcherFactory factory, object receiver, Action<UIPointerEventArgs> callback)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            return factory.CreateDispatcher<UIPointerEventArgs>(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="factory">The <see cref="EventDispatcherFactory"/>.</param>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public static EventDispatcher<UIPointerEventArgs> CreateDispatcher(this EventDispatcherFactory factory, object receiver, Func<UIPointerEventArgs, Task> callback)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            return factory.CreateDispatcher<UIPointerEventArgs>(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="factory">The <see cref="EventDispatcherFactory"/>.</param>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public static EventDispatcher<UIProgressEventArgs> CreateDispatcher(this EventDispatcherFactory factory, object receiver, Action<UIProgressEventArgs> callback)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            return factory.CreateDispatcher<UIProgressEventArgs>(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="factory">The <see cref="EventDispatcherFactory"/>.</param>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public static EventDispatcher<UIProgressEventArgs> CreateDispatcher(this EventDispatcherFactory factory, object receiver, Func<UIProgressEventArgs, Task> callback)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            return factory.CreateDispatcher<UIProgressEventArgs>(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="factory">The <see cref="EventDispatcherFactory"/>.</param>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public static EventDispatcher<UITouchEventArgs> CreateDispatcher(this EventDispatcherFactory factory, object receiver, Action<UITouchEventArgs> callback)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            return factory.CreateDispatcher<UITouchEventArgs>(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="factory">The <see cref="EventDispatcherFactory"/>.</param>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public static EventDispatcher<UITouchEventArgs> CreateDispatcher(this EventDispatcherFactory factory, object receiver, Func<UITouchEventArgs, Task> callback)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            return factory.CreateDispatcher<UITouchEventArgs>(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="factory">The <see cref="EventDispatcherFactory"/>.</param>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public static EventDispatcher<UIWheelEventArgs> CreateDispatcher(this EventDispatcherFactory factory, object receiver, Action<UIWheelEventArgs> callback)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            return factory.CreateDispatcher<UIWheelEventArgs>(receiver, callback);
        }

        /// <summary>
        /// Creates an <see cref="EventDispatcher"/> for the provided <paramref name="receiver"/> and
        /// <paramref name="callback"/>.
        /// </summary>
        /// <param name="factory">The <see cref="EventDispatcherFactory"/>.</param>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="callback">The event callback.</param>
        /// <returns>The <see cref="EventDispatcher"/>.</returns>
        public static EventDispatcher<UIWheelEventArgs> CreateDispatcher(this EventDispatcherFactory factory, object receiver, Func<UIWheelEventArgs, Task> callback)
        {
            if (factory == null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            return factory.CreateDispatcher<UIWheelEventArgs>(receiver, callback);
        }
    }
}

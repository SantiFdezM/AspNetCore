// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components
{
    /// <summary>
    /// A bound event handler delegate.
    /// </summary>
    public readonly struct EventDispatcher : IEventDispatcher
    {
        /// <summary>
        /// Gets a reference to the <see cref="EventDispatcherFactory"/>.
        /// </summary>
        public static readonly EventDispatcherFactory Factory = new EventDispatcherFactory();

        /// <summary>
        /// Gets an empty <see cref="EventDispatcher{T}"/>.
        /// </summary>
        public static readonly EventDispatcher Empty = new EventDispatcher(null, (Action)(() => { }));

        internal readonly MulticastDelegate Delegate;
        internal readonly IHandleAfterEvent Receiver;

        /// <summary>
        /// Creates the new <see cref="EventDispatcher{T}"/>.
        /// </summary>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="delegate">The delegate to bind.</param>
        public EventDispatcher(IHandleAfterEvent receiver, MulticastDelegate @delegate)
        {
            Receiver = receiver;
            Delegate = @delegate;
        }

        /// <summary>
        /// Gets a value that indicates whether the delegate associated with this event dispatcher is non-null.
        /// </summary>
        public bool HasDelegate => Delegate != null;

        // This is a hint to the runtime that Receiver is a different object than what
        // Delegate.Target points to. This allows us to avoid boxing the command object
        // when building the render tree. See logic where this is used.
        internal bool RequiresExplicitReceiver => Receiver != null && !object.ReferenceEquals(Receiver, Delegate.Target);

        /// <summary>
        /// Invokes the delegate associated with this binding.
        /// </summary>
        /// <param name="arg">The argument.</param>
        /// <returns></returns>
        public Task InvokeAsync(object arg)
        {
            if (Receiver == null)
            {
                return EventCallback.InvokeAsync<object>(Delegate, arg);
            }

            return Receiver.HandleEventAsync(new EventCallback(Delegate), arg);
        }
    }

    /// <summary>
    /// A bound event handler delegate.
    /// </summary>
    public readonly struct EventDispatcher<T> : IEventDispatcher
    {
        internal readonly MulticastDelegate Delegate;
        internal readonly IHandleAfterEvent Receiver;

        /// <summary>
        /// Creates the new <see cref="EventDispatcher{T}"/>.
        /// </summary>
        /// <param name="receiver">The event receiver.</param>
        /// <param name="delegate">The delegate to bind.</param>
        public EventDispatcher(IHandleAfterEvent receiver, MulticastDelegate @delegate)
        {
            Receiver = receiver;
            Delegate = @delegate;
        }

        /// <summary>
        /// Gets a value that indicates whether the delegate associated with this event dispatcher is non-null.
        /// </summary>
        public bool HasDelegate => Delegate != null;

        // This is a hint to the runtime that Reciever is a different object than what
        // Delegate.Target points to. This allows us to avoid boxing the command object
        // when building the render tree. See logic where this is used.
        internal bool RequiresExplicitReceiver => Receiver != null && !object.ReferenceEquals(Receiver, Delegate.Target);

        /// <summary>
        /// Invokes the delegate associated with this binding.
        /// </summary>
        /// <param name="arg">The <typeparamref name="T"/> argument.</param>
        /// <returns></returns>
        public Task InvokeAsync(T arg)
        {
            if (Receiver == null)
            {
                return EventCallback.InvokeAsync<T>(Delegate, arg);
            }

            return Receiver.HandleEventAsync(new EventCallback(Delegate), arg);
        }
    }

    // Marker interface for internal use. This is here so the renderer can identify an EventDispatcher<T>.
    internal interface IEventDispatcher
    {
    }
}

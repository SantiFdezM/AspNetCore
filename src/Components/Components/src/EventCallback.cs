// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components
{
    /// <summary>
    /// Wraps a callback delegate associated with an event.
    /// </summary>
    public struct EventCallback
    {
        /// <summary>
        /// An empty <see cref="EventCallback"/>.
        /// </summary>
        public static readonly EventCallback Empty = new EventCallback(null);

        private readonly MulticastDelegate _delegate;

        /// <summary>
        /// Creates a new <see cref="EventCallback"/> with the provided <paramref name="delegate"/>.
        /// </summary>
        /// <param name="delegate">The callback delegate.</param>
        public EventCallback(MulticastDelegate @delegate)
        {
            _delegate = @delegate;
        }

        /// <summary>
        /// Asynchronously invokes the delegate associated with this <see cref="EventCallback"/>.
        /// </summary>
        /// <param name="arg">The argument to provide to the delegate. May be <c>null</c>.</param>
        /// <returns>A <see cref="Task"/> then will complete asynchronously once the delegate has completed.</returns>
        public Task InvokeAsync(object arg)
        {
            return InvokeAsync<object>(_delegate, arg);
        }

        internal static Task InvokeAsync<T>(MulticastDelegate @delegate, T arg)
        {
            switch (@delegate)
            {
                case null:
                    return Task.CompletedTask;

                case Action action:
                    action.Invoke();
                    return Task.CompletedTask;

                case Action<T> actionEventArgs:
                    actionEventArgs.Invoke(arg);
                    return Task.CompletedTask;

                case Func<Task> func:
                    return func.Invoke();

                case Func<T, Task> funcEventArgs:
                    return funcEventArgs.Invoke(arg);

                default:
                    return @delegate.DynamicInvoke(arg) as Task ?? Task.CompletedTask;

            }
        }
    }
}

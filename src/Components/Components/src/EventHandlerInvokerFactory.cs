// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components
{
    public sealed class EventHandlerInvokerFactory
    {
        public Action CreateDelegate(object receiver, Action action)
        {
            if (receiver == null)
            {
                throw new ArgumentNullException(nameof(receiver));
            }

            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            // Determine whether the action is already a bound-delegate attached to handler.
            //
            // This is important for a case like the following:
            //
            //  @* in Outer.cshtml *@
            //  <Inner OnClick="@OnClick" />
            //  @functions {
            //      void OnClick() { ... }
            //  }
            //
            //  @* in Inner.cshtml *@
            //  <button onclick="@OnClick">Click Me!</button>
            //  @functions {
            //      [Parameter] Action OnClick { get; set; }
            //  }
            //
            // We want to make sure to call HandleEventAsync on the Outer component instead
            // of just the Inner component. We can't rely on action.Target to always point
            // to the outer component because in the case of a non-capturing lambda it won't.
            if (!object.ReferenceEquals(receiver, action.Target) && receiver is IHandleAfterEvent handler)
            {
                return (Action)(() =>
                {
                    _ = ComponentBase.DispatchEventAsync(handler, new EventHandlerInvoker(action), UIEventArgs.Empty);
                });
            }

            return action;
        }

        public Action<TEventArgs> CreateDelegate<TEventArgs>(object receiver, Action action) where TEventArgs : UIEventArgs
        {
            if (receiver == null)
            {
                throw new ArgumentNullException(nameof(receiver));
            }

            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            if (!object.ReferenceEquals(receiver, action.Target) && receiver is IHandleAfterEvent handler)
            {
                return (Action<TEventArgs>)((TEventArgs eventArgs) =>
                {
                    _ = ComponentBase.DispatchEventAsync(handler, new EventHandlerInvoker(action), eventArgs);
                });
            }

            return (args) => action();
        }

        public Action<TEventArgs> CreateDelegate<TEventArgs>(object receiver, Action<TEventArgs> action) where TEventArgs : UIEventArgs
        {
            if (receiver == null)
            {
                throw new ArgumentNullException(nameof(receiver));
            }

            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            if (!object.ReferenceEquals(receiver, action.Target) && receiver is IHandleAfterEvent handler)
            {
                return (Action<TEventArgs>)((TEventArgs eventArgs) =>
                {
                    _ = ComponentBase.DispatchEventAsync(handler, new EventHandlerInvoker(action), eventArgs);
                });
            }

            return action;
        }

        public Func<Task> CreateAsyncDelegate(object receiver, Action action)
        {
            if (receiver == null)
            {
                throw new ArgumentNullException(nameof(receiver));
            }

            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            if (!object.ReferenceEquals(receiver, action.Target) && receiver is IHandleAfterEvent handler)
            {
                return (Func<Task>)(() =>
                {
                    return ComponentBase.DispatchEventAsync(handler, new EventHandlerInvoker(action), UIEventArgs.Empty);
                });
            }

            return () =>
            {
                action();
                return Task.CompletedTask;
            };
        }

        public Func<Task> CreateAsyncDelegate(object receiver, Func<Task> action)
        {
            if (receiver == null)
            {
                throw new ArgumentNullException(nameof(receiver));
            }

            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            if (!object.ReferenceEquals(receiver, action.Target) && receiver is IHandleAfterEvent handler)
            {
                return (Func<Task>)(() =>
                {
                    return ComponentBase.DispatchEventAsync(handler, new EventHandlerInvoker(action), UIEventArgs.Empty);
                });
            }

            return action;
        }

        public Func<TEventArgs, Task> CreateAsyncDelegate<TEventArgs>(object receiver, Action action) where TEventArgs : UIEventArgs
        {
            if (receiver == null)
            {
                throw new ArgumentNullException(nameof(receiver));
            }

            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            if (!object.ReferenceEquals(receiver, action.Target) && receiver is IHandleAfterEvent handler)
            {
                return (Func<TEventArgs, Task>)((TEventArgs eventArgs) =>
                {
                    return ComponentBase.DispatchEventAsync(handler, new EventHandlerInvoker(action), eventArgs);
                });
            }

            return (Func<TEventArgs, Task>)((eventArgs) =>
            {
                action();
                return Task.CompletedTask;
            });
        }

        public Func<TEventArgs, Task> CreateAsyncDelegate<TEventArgs>(object receiver, Func<Task> action) where TEventArgs : UIEventArgs
        {
            if (receiver == null)
            {
                throw new ArgumentNullException(nameof(receiver));
            }

            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            if (!object.ReferenceEquals(receiver, action.Target) && receiver is IHandleAfterEvent handler)
            {
                return (Func<TEventArgs, Task>)((TEventArgs eventArgs) =>
                {
                    return ComponentBase.DispatchEventAsync(handler, new EventHandlerInvoker(action), eventArgs);
                });
            }

            return (Func<TEventArgs, Task>)((eventArgs) =>
            {
                return action();
            });
        }

        public Func<TEventArgs, Task> CreateAsyncDelegate<TEventArgs>(object receiver, Action<TEventArgs> action) where TEventArgs : UIEventArgs
        {
            if (receiver == null)
            {
                throw new ArgumentNullException(nameof(receiver));
            }

            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            if (!object.ReferenceEquals(receiver, action.Target) && receiver is IHandleAfterEvent handler)
            {
                return (Func<TEventArgs, Task>)((TEventArgs eventArgs) =>
                {
                    return ComponentBase.DispatchEventAsync(handler, new EventHandlerInvoker(action), eventArgs);
                });
            }

            return (Func<TEventArgs, Task>)((eventArgs) =>
            {
                action(eventArgs);
                return Task.CompletedTask;
            });
        }

        public Func<TEventArgs, Task> CreateAsyncDelegate<TEventArgs>(object receiver, Func<TEventArgs, Task> action) where TEventArgs : UIEventArgs
        {
            if (receiver == null)
            {
                throw new ArgumentNullException(nameof(receiver));
            }

            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            if (!object.ReferenceEquals(receiver, action.Target) && receiver is IHandleAfterEvent handler)
            {
                return (Func<TEventArgs, Task>)((TEventArgs eventArgs) =>
                {
                    return ComponentBase.DispatchEventAsync(handler, new EventHandlerInvoker(action), eventArgs);
                });
            }

            return action;
        }
    }
}

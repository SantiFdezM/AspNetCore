// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components
{
    /// <summary>
    /// Interface implemented by components that receive notification of state changes.
    /// </summary>
    public interface IHandleAfterEvent
    {
        /// <summary>
        /// Notifies the a state change has been triggered.
        /// </summary>
        /// <param name="invoker">The <see cref="EventHandlerInvoker"/> associated with this event.</param>
        /// <param name="eventArgs">The <see cref="UIEventArgs"/> associated with this event.</param>
        /// <returns>
        /// A <see cref="Task"/> that completes once the component has processed the state change.
        /// </returns>
        Task HandleEventAsync(EventHandlerInvoker invoker, UIEventArgs eventArgs);
    }
}

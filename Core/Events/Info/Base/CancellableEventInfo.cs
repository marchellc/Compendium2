﻿namespace Compendium.Events.Base
{
    public class CancellableEventInfo<TValue> : EventInfo
    {
        public TValue Cancellation { get; set; } = default;

        public override bool IsCancellable => true;
    }
}
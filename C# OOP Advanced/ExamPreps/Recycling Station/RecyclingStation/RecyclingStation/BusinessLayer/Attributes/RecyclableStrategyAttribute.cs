﻿namespace RecyclingStation.BusinessLayer.Attributes
{
    using System;
    using RecyclingStation.WasteDisposal.Attributes;

    public class RecyclableStrategyAttribute : DisposableAttribute
    {
        public RecyclableStrategyAttribute(Type correspondingStratygyType) 
            : base(correspondingStratygyType)
        {
        }
    }
}

﻿using Newtonsoft.Json.Linq;
using ReactNative.UIManager.Events;
using System;

namespace RNWebviewBridge.Events
{
    class MessageEvent : Event
    {
        private readonly string _data;

        public MessageEvent(int viewTag, string data)
            : base(viewTag, TimeSpan.FromTicks(Environment.TickCount))
        {
            _data = data;
        }

        public override string EventName
        {
            get
            {
                return "topMessage";
            }
        }

        public override bool CanCoalesce
        {
            get
            {
                return false;
            }
        }

        public override void Dispatch(RCTEventEmitter eventEmitter)
        {
            eventEmitter.receiveEvent(ViewTag, EventName, new JObject
            {
                { "data", _data },
            });
        }
    }
}

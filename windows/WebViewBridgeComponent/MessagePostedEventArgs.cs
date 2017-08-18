﻿namespace WebViewBridgeComponent
{
    /// <summary>
    /// Arguments for <see cref="WebViewBridge.MessagePosted"/> event.
    /// </summary>
    public class MessagePostedEventArgs
    {
        internal MessagePostedEventArgs(int tag, string message)
        {
            Tag = tag;
            Message = message;
        }

        /// <summary>
        /// The tag of the React WebView instance.
        /// </summary>
        public int Tag { get; }

        /// <summary>
        /// The message.
        /// </summary>
        public string Message { get; }
    }
}

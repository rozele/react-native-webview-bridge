using System;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace WebViewBridgeComponent
{
    /// <summary>
    /// Bridge for Status callbacks.
    /// </summary>
    [AllowForWeb]
    public sealed class StatusBridge
    {
        private readonly WebView _webView;

        /// <summary>
        /// Instantiates the <see cref="StatusBridge"/>.
        /// </summary>
        /// <param name="webView">The view instance.</param>
        public StatusBridge(WebView webView)
        {
            _webView = webView;
        }

        /// <summary>
        /// Send an asynchronous RPC request with Status.
        /// </summary>
        /// <param name="host">The host address.</param>
        /// <param name="callbackId">The callback id.</param>
        /// <param name="json">The RPC request data.</param>
        /// <remarks>
        /// Once the RPC completes, invokes `httpCallback` with the <paramref name="callbackId"/>
        /// and response data.
        /// </remarks>
        public async void SendRequest(string host, string callbackId, string json)
        {
            await Task.Run(async () =>
            {
                // TODO: call Statusgo RPC
                var response = default(string);
                await _webView.InvokeScriptAsync("eval", new[] { $"httpCallback({callbackId},{response})" }).AsTask().ConfigureAwait(false);
            });
        }

        /// <summary>
        /// Sends a synchronous RPC request with Status.
        /// </summary>
        /// <param name="host">The host address.</param>
        /// <param name="json">The request data.</param>
        /// <returns>The response data.</returns>
        public string SendRequestSync(string host, string json)
        {
            // TODO: call Statusgo RPC
            return null;
        }
    }
}

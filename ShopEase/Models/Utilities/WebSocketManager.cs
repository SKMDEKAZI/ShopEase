// ShopEase/Utilities/WebSocketManager.cs
using System.Collections.Concurrent;
using System.Net.WebSockets;

namespace ShopEase.Utilities
{
    public class WebSocketManager
    {
        private readonly ConcurrentDictionary<string, WebSocket> _sockets = new();

        public void AddSocket(WebSocket socket)
        {
            _sockets.TryAdd(Guid.NewGuid().ToString(), socket);
        }

        public void RemoveSocket(WebSocket socket)
        {
            var entry = _sockets.FirstOrDefault(x => x.Value == socket);
            if (!entry.Equals(default(KeyValuePair<string, WebSocket>)))
            {
                _sockets.TryRemove(entry.Key, out _);
            }
        }

        public async Task BroadcastAsync(byte[] message)
        {
            foreach (var socket in _sockets.Values.Where(s => s.State == WebSocketState.Open))
            {
                try
                {
                    await socket.SendAsync(
                        new ArraySegment<byte>(message),
                        WebSocketMessageType.Text,
                        true,
                        CancellationToken.None);
                }
                catch
                {
                    RemoveSocket(socket);
                }
            }
        }
    }
}
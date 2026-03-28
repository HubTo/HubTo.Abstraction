namespace HubTo.Abstraction.Models
{
    public sealed class PluginContext
    {
        public string PluginName { get; }
        public string TraceId { get; }

        public PluginContext(string pluginName, string traceId)
        {
            PluginName = pluginName;
            TraceId = traceId;
        }
    }
}

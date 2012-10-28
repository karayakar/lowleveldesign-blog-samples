using System.Diagnostics;
using System.Globalization;
using System.Text;
using NLog;
using NLog.LayoutRenderers;
using NLog.Config;
using NLog.Internal;

namespace LowLevelDesign.NLog.LayoutRenderers
{
    /// <summary>
    /// The trace correlation activity id.
    /// </summary>
    [LayoutRenderer("activityid")]
    [ThreadAgnostic]
    public class TraceActivityIdLayoutRenderer : LayoutRenderer
    {
        /// <summary>
        /// Renders the current trace activity ID.
        /// </summary>
        /// <param name="builder">The <see cref="StringBuilder"/> to append the rendered data to.</param>
        /// <param name="logEvent">Logging event.</param>
        protected override void Append(StringBuilder builder, LogEventInfo logEvent)
        {
            builder.Append(Trace.CorrelationManager.ActivityId.ToString("D", CultureInfo.InvariantCulture));
        }
    }
}

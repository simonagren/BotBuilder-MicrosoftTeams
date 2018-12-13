// <auto-generated /> Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector.Teams.Models
{
    using System.Linq;

    /// <summary>
    /// Base class for Task Module responses
    /// </summary>
    public partial class TaskModuleResponseBase
    {
        /// <summary>
        /// Initializes a new instance of the TaskModuleResponseBase class.
        /// </summary>
        public TaskModuleResponseBase() { }

        /// <summary>
        /// Initializes a new instance of the TaskModuleResponseBase class.
        /// </summary>
        /// <param name="type">Choice of action options when responding to the
        /// task/submit message. Possible values include: 'message',
        /// 'continue'</param>
        public TaskModuleResponseBase(string type = default(string))
        {
            Type = type;
        }

        /// <summary>
        /// Gets or sets choice of action options when responding to the
        /// task/submit message. Possible values include: 'message',
        /// 'continue'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Recommendations.Client
{
    using Entities;

    /// <summary>
    /// The Recommendations API identifies consumption patterns from your
    /// transaction information in order to provide recommendations. These
    /// recommendations can help your customers more easily discover items
    /// that they may be interested in.&lt;br&gt; By showing your customers
    /// products that they are more likely to be interested in, you will, in
    /// turn, increase your sales.
    /// </summary>
    public partial interface IRecommendationsAPI : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        Newtonsoft.Json.JsonSerializerSettings DeserializationSettings { get; }


        /// <summary>
        /// Gets the IModels.
        /// </summary>
        IModels Models { get; }

    }
}
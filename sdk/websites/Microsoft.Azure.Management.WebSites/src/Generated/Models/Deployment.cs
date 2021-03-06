// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// User credentials used for publishing activity.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Deployment : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the Deployment class.
        /// </summary>
        public Deployment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Deployment class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="status">Deployment status.</param>
        /// <param name="message">Details about deployment status.</param>
        /// <param name="author">Who authored the deployment.</param>
        /// <param name="deployer">Who performed the deployment.</param>
        /// <param name="authorEmail">Author email.</param>
        /// <param name="startTime">Start time.</param>
        /// <param name="endTime">End time.</param>
        /// <param name="active">True if deployment is currently active, false
        /// if completed and null if not started.</param>
        /// <param name="details">Details on deployment.</param>
        public Deployment(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), int? status = default(int?), string message = default(string), string author = default(string), string deployer = default(string), string authorEmail = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), bool? active = default(bool?), string details = default(string))
            : base(id, name, kind, type)
        {
            Status = status;
            Message = message;
            Author = author;
            Deployer = deployer;
            AuthorEmail = authorEmail;
            StartTime = startTime;
            EndTime = endTime;
            Active = active;
            Details = details;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets deployment status.
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public int? Status { get; set; }

        /// <summary>
        /// Gets or sets details about deployment status.
        /// </summary>
        [JsonProperty(PropertyName = "properties.message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets who authored the deployment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.author")]
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets who performed the deployment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deployer")]
        public string Deployer { get; set; }

        /// <summary>
        /// Gets or sets author email.
        /// </summary>
        [JsonProperty(PropertyName = "properties.author_email")]
        public string AuthorEmail { get; set; }

        /// <summary>
        /// Gets or sets start time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.start_time")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets end time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.end_time")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets true if deployment is currently active, false if
        /// completed and null if not started.
        /// </summary>
        [JsonProperty(PropertyName = "properties.active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or sets details on deployment.
        /// </summary>
        [JsonProperty(PropertyName = "properties.details")]
        public string Details { get; set; }

    }
}

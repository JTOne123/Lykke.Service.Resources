// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Service.Resources.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GroupItem
    {
        /// <summary>
        /// Initializes a new instance of the GroupItem class.
        /// </summary>
        public GroupItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GroupItem class.
        /// </summary>
        public GroupItem(string id = default(string), string value = default(string))
        {
            Id = id;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public string Value { get; set; }

    }
}

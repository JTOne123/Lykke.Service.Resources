// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Service.Resources.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class GroupResourcesModel
    {
        /// <summary>
        /// Initializes a new instance of the GroupResourcesModel class.
        /// </summary>
        public GroupResourcesModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GroupResourcesModel class.
        /// </summary>
        public GroupResourcesModel(string name = default(string), IList<GroupItem> values = default(IList<GroupItem>))
        {
            Name = name;
            Values = values;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Values")]
        public IList<GroupItem> Values { get; set; }

    }
}

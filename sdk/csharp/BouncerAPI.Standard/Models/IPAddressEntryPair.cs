/*
 * BouncerAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using BouncerAPI.Standard;
using BouncerAPI.Standard.Utilities;


namespace BouncerAPI.Standard.Models
{
    public class IPAddressEntryPair : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string entryID;
        private string iPv4;

        /// <summary>
        /// a unique identifier for the newly created Geo Location; opaque but likely a GUID
        /// </summary>
        [JsonProperty("EntryID")]
        public string EntryID 
        { 
            get 
            {
                return this.entryID; 
            } 
            set 
            {
                this.entryID = value;
                onPropertyChanged("EntryID");
            }
        }

        /// <summary>
        /// IP Address v4 in CIDR Format. Either IPv4 or IPv6 MUST be present.
        /// </summary>
        [JsonProperty("IPv4")]
        public string IPv4 
        { 
            get 
            {
                return this.iPv4; 
            } 
            set 
            {
                this.iPv4 = value;
                onPropertyChanged("IPv4");
            }
        }
    }
} 
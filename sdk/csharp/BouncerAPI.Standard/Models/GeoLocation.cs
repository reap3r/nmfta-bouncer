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
    public class GeoLocation : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string countryCode;
        private string startDate;
        private string endDate;
        private string comments;
        private bool active;

        /// <summary>
        /// ISO Country Code
        /// </summary>
        [JsonProperty("Country Code")]
        public string CountryCode 
        { 
            get 
            {
                return this.countryCode; 
            } 
            set 
            {
                this.countryCode = value;
                onPropertyChanged("CountryCode");
            }
        }

        /// <summary>
        /// Starting UTC Date and time for entry
        /// </summary>
        [JsonProperty("Start_Date")]
        public string StartDate 
        { 
            get 
            {
                return this.startDate; 
            } 
            set 
            {
                this.startDate = value;
                onPropertyChanged("StartDate");
            }
        }

        /// <summary>
        /// Ending UTC Date and time for entry
        /// </summary>
        [JsonProperty("End_Date")]
        public string EndDate 
        { 
            get 
            {
                return this.endDate; 
            } 
            set 
            {
                this.endDate = value;
                onPropertyChanged("EndDate");
            }
        }

        /// <summary>
        /// Any notes or description for the entry, maximum length of 3000 characters
        /// </summary>
        [JsonProperty("Comments")]
        public string Comments 
        { 
            get 
            {
                return this.comments; 
            } 
            set 
            {
                this.comments = value;
                onPropertyChanged("Comments");
            }
        }

        /// <summary>
        /// Identifies if the entry is active
        /// </summary>
        [JsonProperty("Active")]
        public bool Active 
        { 
            get 
            {
                return this.active; 
            } 
            set 
            {
                this.active = value;
                onPropertyChanged("Active");
            }
        }
    }
} 
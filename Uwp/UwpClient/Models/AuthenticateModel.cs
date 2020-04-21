﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Uwp.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class AuthenticateModel
    {
        /// <summary>
        /// Initializes a new instance of the AuthenticateModel class.
        /// </summary>
        public AuthenticateModel() { }

        /// <summary>
        /// Initializes a new instance of the AuthenticateModel class.
        /// </summary>
        public AuthenticateModel(string username, string password)
        {
            Username = username;
            Password = password;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Username == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Username");
            }
            if (Password == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Password");
            }
        }
    }
}
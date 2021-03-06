﻿using System;
using System.Collections.Generic;
using Abp.Json;

namespace Abp.Notifications
{
    /// <summary>
    /// Used to store data for a notification.
    /// </summary>
    [Serializable]
    public class NotificationData
    {
        /// <summary>
        /// Shortcut to set/get <see cref="Properties"/>.
        /// </summary>
        /// <param name="key"></param>
        public object this[string key]
        {
            get { return Properties[key]; }
            set { Properties[key] = value; }
        }

        /// <summary>
        /// Can be used to add custom properties to this notification.
        /// </summary>
        public Dictionary<string, object> Properties
        {
            get { return _properties; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                _properties = value;
            }
        }
        private Dictionary<string, object> _properties;

        /// <summary>
        /// Createa a new NotificationData object.
        /// </summary>
        public NotificationData()
        {
            Properties = new Dictionary<string, object>();
        }

        public override string ToString()
        {
            return this.ToJsonString();
        }
    }
}
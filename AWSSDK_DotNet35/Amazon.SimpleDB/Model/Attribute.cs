/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.SimpleDB.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Attribute
    {
        
        private string name;
        private string alternateNameEncoding;
        private string value;
        private string alternateValueEncoding;

        /// <summary>
        /// The name of the attribute.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// 
        ///  
        /// </summary>
        public string AlternateNameEncoding
        {
            get { return this.alternateNameEncoding; }
            set { this.alternateNameEncoding = value; }
        }

        // Check to see if AlternateNameEncoding property is set
        internal bool IsSetAlternateNameEncoding()
        {
            return this.alternateNameEncoding != null;
        }

        /// <summary>
        /// The value of the attribute.
        ///  
        /// </summary>
        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this.value != null;
        }

        /// <summary>
        /// 
        ///  
        /// </summary>
        public string AlternateValueEncoding
        {
            get { return this.alternateValueEncoding; }
            set { this.alternateValueEncoding = value; }
        }

        // Check to see if AlternateValueEncoding property is set
        internal bool IsSetAlternateValueEncoding()
        {
            return this.alternateValueEncoding != null;
        }
    }
}

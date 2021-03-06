/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

using Amazon.Route53.Model;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// List Health Checks Request Marshaller
    /// </summary>       
    public class ListHealthChecksRequestMarshaller : IMarshaller<IRequest, ListHealthChecksRequest>
    {
        
    
        public IRequest Marshall(ListHealthChecksRequest listHealthChecksRequest)
        {
            IRequest request = new DefaultRequest(listHealthChecksRequest, "AmazonRoute53");



            request.HttpMethod = "GET";
            string uriResourcePath = "/2013-04-01/healthcheck?marker={Marker}&maxitems={MaxItems}"; 
            uriResourcePath = uriResourcePath.Replace("{Marker}", listHealthChecksRequest.IsSetMarker() ? listHealthChecksRequest.Marker.ToString() : "" ); 
            uriResourcePath = uriResourcePath.Replace("{MaxItems}", listHealthChecksRequest.IsSetMaxItems() ? listHealthChecksRequest.MaxItems.ToString() : "" ); 

            if (uriResourcePath.Contains("?")) 
            {
                int queryIndex = uriResourcePath.IndexOf("?", StringComparison.OrdinalIgnoreCase);
                string queryString = uriResourcePath.Substring(queryIndex + 1);
                
                uriResourcePath    = uriResourcePath.Substring(0, queryIndex);
                
        
                foreach (string s in queryString.Split('&', ';')) 
                {
                    string[] nameValuePair = s.Split('=');
                    if (nameValuePair.Length == 2 && nameValuePair[1].Length > 0) 
                    {
                        request.Parameters.Add(nameValuePair[0], nameValuePair[1]);
                    }
                    else
                    {
                        request.Parameters.Add(nameValuePair[0], null);
                    }
                
                }
            }
            
            request.ResourcePath = uriResourcePath;
            
        
            request.UseQueryString = true;
            
            
            return request;
        }
    }
}
    

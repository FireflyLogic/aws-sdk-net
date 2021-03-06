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

using Amazon.CloudSearch_2011_02_01.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.CloudSearch_2011_02_01.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe Rank Expressions Request Marshaller
    /// </summary>       
    public class DescribeRankExpressionsRequestMarshaller : IMarshaller<IRequest, DescribeRankExpressionsRequest>
    {
        public IRequest Marshall(DescribeRankExpressionsRequest describeRankExpressionsRequest)
        {
            IRequest request = new DefaultRequest(describeRankExpressionsRequest, "AmazonCloudSearch");
            request.Parameters.Add("Action", "DescribeRankExpressions");
            request.Parameters.Add("Version", "2011-02-01");
            if (describeRankExpressionsRequest != null && describeRankExpressionsRequest.IsSetDomainName())
            {
                request.Parameters.Add("DomainName", StringUtils.FromString(describeRankExpressionsRequest.DomainName));
            }
            if (describeRankExpressionsRequest != null)
            {
                List<string> rankNamesList = describeRankExpressionsRequest.RankNames;

                int rankNamesListIndex = 1;
                foreach (string rankNamesListValue in rankNamesList)
                { 
                    request.Parameters.Add("RankNames.member." + rankNamesListIndex, StringUtils.FromString(rankNamesListValue));
                    rankNamesListIndex++;
                }
            }

            return request;
        }
    }
}

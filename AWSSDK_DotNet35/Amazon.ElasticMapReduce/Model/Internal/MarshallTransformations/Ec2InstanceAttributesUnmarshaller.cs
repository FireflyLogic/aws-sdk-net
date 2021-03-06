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
    using System.IO;
    using ThirdParty.Json.LitJson;
    using Amazon.ElasticMapReduce.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// Ec2InstanceAttributesUnmarshaller
      /// </summary>
      internal class Ec2InstanceAttributesUnmarshaller : IUnmarshaller<Ec2InstanceAttributes, XmlUnmarshallerContext>, IUnmarshaller<Ec2InstanceAttributes, JsonUnmarshallerContext>
      {
        Ec2InstanceAttributes IUnmarshaller<Ec2InstanceAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public Ec2InstanceAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            Ec2InstanceAttributes ec2InstanceAttributes = new Ec2InstanceAttributes();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("Ec2KeyName", targetDepth))
              {
                ec2InstanceAttributes.Ec2KeyName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Ec2SubnetId", targetDepth))
              {
                ec2InstanceAttributes.Ec2SubnetId = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("Ec2AvailabilityZone", targetDepth))
              {
                ec2InstanceAttributes.Ec2AvailabilityZone = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("IamInstanceProfile", targetDepth))
              {
                ec2InstanceAttributes.IamInstanceProfile = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return ec2InstanceAttributes;
        }

        private static Ec2InstanceAttributesUnmarshaller instance;
        public static Ec2InstanceAttributesUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new Ec2InstanceAttributesUnmarshaller();
            return instance;
        }
    }
}
  

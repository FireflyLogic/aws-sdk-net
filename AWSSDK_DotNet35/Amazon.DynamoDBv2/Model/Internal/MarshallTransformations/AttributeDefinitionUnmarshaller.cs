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
    using Amazon.DynamoDBv2.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// AttributeDefinitionUnmarshaller
      /// </summary>
      internal class AttributeDefinitionUnmarshaller : IUnmarshaller<AttributeDefinition, XmlUnmarshallerContext>, IUnmarshaller<AttributeDefinition, JsonUnmarshallerContext>
      {
        AttributeDefinition IUnmarshaller<AttributeDefinition, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public AttributeDefinition Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            AttributeDefinition attributeDefinition = new AttributeDefinition();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("AttributeName", targetDepth))
              {
                attributeDefinition.AttributeName = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("AttributeType", targetDepth))
              {
                attributeDefinition.AttributeType = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return attributeDefinition;
        }

        private static AttributeDefinitionUnmarshaller instance;
        public static AttributeDefinitionUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new AttributeDefinitionUnmarshaller();
            return instance;
        }
    }
}
  

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
    using Amazon.SimpleWorkflow.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// WorkflowExecutionConfigurationUnmarshaller
      /// </summary>
      internal class WorkflowExecutionConfigurationUnmarshaller : IUnmarshaller<WorkflowExecutionConfiguration, XmlUnmarshallerContext>, IUnmarshaller<WorkflowExecutionConfiguration, JsonUnmarshallerContext>
      {
        WorkflowExecutionConfiguration IUnmarshaller<WorkflowExecutionConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public WorkflowExecutionConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) return null;
            WorkflowExecutionConfiguration workflowExecutionConfiguration = new WorkflowExecutionConfiguration();
        
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
              
              if (context.TestExpression("taskStartToCloseTimeout", targetDepth))
              {
                workflowExecutionConfiguration.TaskStartToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("executionStartToCloseTimeout", targetDepth))
              {
                workflowExecutionConfiguration.ExecutionStartToCloseTimeout = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("taskList", targetDepth))
              {
                workflowExecutionConfiguration.TaskList = TaskListUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("childPolicy", targetDepth))
              {
                workflowExecutionConfiguration.ChildPolicy = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
            }
          
            return workflowExecutionConfiguration;
        }

        private static WorkflowExecutionConfigurationUnmarshaller instance;
        public static WorkflowExecutionConfigurationUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new WorkflowExecutionConfigurationUnmarshaller();
            return instance;
        }
    }
}
  

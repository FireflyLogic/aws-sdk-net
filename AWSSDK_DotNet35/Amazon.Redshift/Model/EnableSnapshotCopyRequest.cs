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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the EnableSnapshotCopy operation.
    /// <para>Enables the automatic copy of snapshots from one region to another region for a specified cluster.</para>
    /// </summary>
    public partial class EnableSnapshotCopyRequest : AmazonRedshiftRequest
    {
        private string clusterIdentifier;
        private string destinationRegion;
        private int? retentionPeriod;


        /// <summary>
        /// The unique identifier of the source cluster to copy snapshots from. Constraints: Must be the valid name of an existing cluster that does not
        /// already have cross-region snapshot copy enabled.
        ///  
        /// </summary>
        public string ClusterIdentifier
        {
            get { return this.clusterIdentifier; }
            set { this.clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this.clusterIdentifier != null;
        }

        /// <summary>
        /// The destination region that you want to copy snapshots to. Constraints: Must be the name of a valid region. For more information, see <a
        /// href="http://docs.aws.amazon.com/general/latest/gr/rande.html#redshift_region">Regions and Endpoints</a> in the Amazon Web Services General
        /// Reference.
        ///  
        /// </summary>
        public string DestinationRegion
        {
            get { return this.destinationRegion; }
            set { this.destinationRegion = value; }
        }

        // Check to see if DestinationRegion property is set
        internal bool IsSetDestinationRegion()
        {
            return this.destinationRegion != null;
        }

        /// <summary>
        /// The number of days to retain automated snapshots in the destination region after they are copied from the source region. Default: 7.
        /// Constraints: Must be at least 1 and no more than 35.
        ///  
        /// </summary>
        public int RetentionPeriod
        {
            get { return this.retentionPeriod ?? default(int); }
            set { this.retentionPeriod = value; }
        }

        // Check to see if RetentionPeriod property is set
        internal bool IsSetRetentionPeriod()
        {
            return this.retentionPeriod.HasValue;
        }

    }
}
    

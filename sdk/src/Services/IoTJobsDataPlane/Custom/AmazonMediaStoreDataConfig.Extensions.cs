/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime;


namespace Amazon.IoTJobsDataPlane
{
    /// <summary>
    /// Configuration for accessing Amazon IoTJobsDataPlane service
    /// </summary>
    public partial class AmazonIoTJobsDataPlaneConfig : ClientConfig
    {
        /// <summary>
        /// Validate that the config object is properly configured.
        /// </summary>
        public override void Validate()
        {
            if (RegionEndpoint != null)
                throw new AmazonClientException("The RegionEndpoint property is not applicable for AmazonIoTJobsDataPlaneClient and should not be set.");

            if (string.IsNullOrEmpty(this.ServiceURL))
                throw new AmazonClientException("A ServiceURL is not set for the AmazonIoTJobsDataPlaneClient. A ServiceURL needs to be provided to use this client.");
        }
    }
}
// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.SiteRecovery.Models;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// Hyper V Replica Provider specific entity details.
    /// </summary>
    public partial class HyperVReplica2012ReplicationDetails : ReplicationProviderSpecificSettings
    {
        private InitialReplicationDetails _initialReplicationDetails;
        
        /// <summary>
        /// Optional. Gets or sets initial replication details.
        /// </summary>
        public InitialReplicationDetails InitialReplicationDetails
        {
            get { return this._initialReplicationDetails; }
            set { this._initialReplicationDetails = value; }
        }
        
        private string _lastReplicatedTime;
        
        /// <summary>
        /// Optional. Gets or sets the Last replication time.
        /// </summary>
        public string LastReplicatedTime
        {
            get { return this._lastReplicatedTime; }
            set { this._lastReplicatedTime = value; }
        }
        
        private IList<DiskDetails> _vMDiskDetails;
        
        /// <summary>
        /// Optional. Gets or sets VM disk details.
        /// </summary>
        public IList<DiskDetails> VMDiskDetails
        {
            get { return this._vMDiskDetails; }
            set { this._vMDiskDetails = value; }
        }
        
        private IList<VMNicDetails> _vmNics;
        
        /// <summary>
        /// Optional. Gets or sets the network details.
        /// </summary>
        public IList<VMNicDetails> VmNics
        {
            get { return this._vmNics; }
            set { this._vmNics = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// HyperVReplica2012ReplicationDetails class.
        /// </summary>
        public HyperVReplica2012ReplicationDetails()
        {
            this.VMDiskDetails = new LazyList<DiskDetails>();
            this.VmNics = new LazyList<VMNicDetails>();
        }
    }
}

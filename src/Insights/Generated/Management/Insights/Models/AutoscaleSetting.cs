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
using Microsoft.Azure.Management.Insights.Models;

namespace Microsoft.Azure.Management.Insights.Models
{
    /// <summary>
    /// A setting that contains all of the configuration for the automatic
    /// scaling of a resource.
    /// </summary>
    public partial class AutoscaleSetting
    {
        private bool _enabled;
        
        /// <summary>
        /// Optional. Specifies whether automatic scaling is enabled for the
        /// resource.
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. The name of the autoscale setting.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private IList<AutoscaleProfile> _profiles;
        
        /// <summary>
        /// Optional. Contains a collection of automatic scaling profiles that
        /// specify different scaling parameters for different time periods. A
        /// maximum of 20 profiles can be specified.
        /// </summary>
        public IList<AutoscaleProfile> Profiles
        {
            get { return this._profiles; }
            set { this._profiles = value; }
        }
        
        private string _targetResourceUri;
        
        /// <summary>
        /// Optional. The resource identifier of the resource that the
        /// autoscale setting should be added to.
        /// </summary>
        public string TargetResourceUri
        {
            get { return this._targetResourceUri; }
            set { this._targetResourceUri = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AutoscaleSetting class.
        /// </summary>
        public AutoscaleSetting()
        {
            this.Profiles = new List<AutoscaleProfile>();
        }
    }
}

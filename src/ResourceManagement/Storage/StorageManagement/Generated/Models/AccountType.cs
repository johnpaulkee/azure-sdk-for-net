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
using System.Linq;

namespace Microsoft.Azure.Management.Storage.Models
{
    /// <summary>
    /// The account type of the storage account.
    /// </summary>
    public enum AccountType
    {
        /// <summary>
        /// Locally-redundant storage.
        /// </summary>
        StandardLRS = 0,
        
        /// <summary>
        /// Zone-redundant storage.
        /// </summary>
        StandardZRS = 1,
        
        /// <summary>
        /// Geo-redundant storage.
        /// </summary>
        StandardGRS = 2,
        
        /// <summary>
        /// Read access geo-redundant storage.
        /// </summary>
        StandardRAGRS = 3,
        
        /// <summary>
        /// Premium locally-redundant storage.
        /// </summary>
        PremiumLRS = 4,
    }
}
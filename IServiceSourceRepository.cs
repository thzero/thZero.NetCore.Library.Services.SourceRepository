/* ------------------------------------------------------------------------- *
thZero.NetCore.Library.Services.CircuitBreaker.Steeltoe
Copyright (C) 2016-2021 thZero.com

<development [at] thzero [dot] com>

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

	http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
 * ------------------------------------------------------------------------- */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace thZero.Services
{
    public interface IServiceSourceRepository : IService
    {
        Task<SourceRepositoryProfile> GetProfile();
    }

    public class SourceRepositoryProfile
    {
        public SourceRepositoryProfile()
        {
            Repos = new List<SourceRepositoryProfileRepo>();
        }

        #region Public Properties
        public string Name { get; set; }
        public string Url { get; set; }
        public ICollection<SourceRepositoryProfileRepo> Repos { get; set; }
        #endregion
    }

    public class SourceRepositoryProfileRepo
    {
        #region Public Properties
        public string Description { get; set; }
        public string Forked { get; set; }
        public string FullName { get; set; }
        public string Language { get; set; }
        public string Name { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public string Url { get; set; }
        #endregion
    }
}

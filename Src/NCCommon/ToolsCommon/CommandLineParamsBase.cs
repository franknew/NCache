﻿// Copyright (c) 2018 Alachisoft
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//    http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.


namespace Alachisoft.NCache.Tools.Common
{
    public class CommandLineParamsBase
    {
        static private string _userId = string.Empty;
        static private string _userPwd = string.Empty;
        static private bool _printLogo = true;
        static private bool _hotApply = false;
        static private bool _overwrite = false;
        static private bool _usage = false;

        [ArgumentAttribute(@"/h", @"/hotapply", false)]
        public bool IsHotApply
        {
            get { return _hotApply; }
            set { _hotApply = value; }
        }

        [ArgumentAttribute(@"/o", @"/overwrite", false)]
        public bool IsOverWrite
        {
            get { return _overwrite; }
            set { _overwrite = value; }
        }

        [ArgumentAttribute(@"/?", @"/help", false)]
        public bool IsUsage
        {
            get { return _usage; }
            set { _usage = value; }
        }


        [ArgumentAttribute(@"/U", @"/user-id")]
        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        [ArgumentAttribute(@"/P", @"/password")]
        public string Password
        {
            get { return _userPwd; }
            set { _userPwd = value; }
        }

        [ArgumentAttribute(@"/nologo", @"/G", true)]
        public bool IsLogo
        {
            get { return _printLogo; }
            set { _printLogo = value; }
        }



    }
}

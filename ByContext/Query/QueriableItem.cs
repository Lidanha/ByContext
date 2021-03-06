﻿// Copyright 2011 Avi Levi

// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at

//  http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using ByContext.FilterConditions;
using ByContext.ValueProviders;

namespace ByContext.Query
{
    public class QueriableItem
    {
        public static QueriableItem Create(IValueProvider valueProvider, IFilterCondition[] conditions)
        {
            return new QueriableItem
                {
                    Conditions = conditions,
                    ValueProvider = valueProvider
                };
        }

        public IValueProvider ValueProvider { get; private set; }
        public IFilterCondition[] Conditions { get; private set; }
    }
}
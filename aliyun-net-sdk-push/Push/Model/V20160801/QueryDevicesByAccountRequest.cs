/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Push;
using Aliyun.Acs.Push.Transform;
using Aliyun.Acs.Push.Transform.V20160801;

namespace Aliyun.Acs.Push.Model.V20160801
{
    public class QueryDevicesByAccountRequest : RpcAcsRequest<QueryDevicesByAccountResponse>
    {
        public QueryDevicesByAccountRequest()
            : base("Push", "2016-08-01", "QueryDevicesByAccount")
        {
        }

		private long? appKey;

		private string account;

		public long? AppKey
		{
			get
			{
				return appKey;
			}
			set	
			{
				appKey = value;
				DictionaryUtil.Add(QueryParameters, "AppKey", value.ToString());
			}
		}

		public string Account
		{
			get
			{
				return account;
			}
			set	
			{
				account = value;
				DictionaryUtil.Add(QueryParameters, "Account", value);
			}
		}

        public override QueryDevicesByAccountResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryDevicesByAccountResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}

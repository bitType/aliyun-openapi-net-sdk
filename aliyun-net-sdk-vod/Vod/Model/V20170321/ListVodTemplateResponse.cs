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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class ListVodTemplateResponse : AcsResponse
	{

		private string requestId;

		private List<ListVodTemplate_VodTemplateInfo> vodTemplateInfoList;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public List<ListVodTemplate_VodTemplateInfo> VodTemplateInfoList
		{
			get
			{
				return vodTemplateInfoList;
			}
			set	
			{
				vodTemplateInfoList = value;
			}
		}

		public class ListVodTemplate_VodTemplateInfo
		{

			private string name;

			private string vodTemplateId;

			private string templateType;

			private string subTemplateType;

			private string source;

			private string isDefault;

			private string templateConfig;

			private string creationTime;

			private string modifyTime;

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string VodTemplateId
			{
				get
				{
					return vodTemplateId;
				}
				set	
				{
					vodTemplateId = value;
				}
			}

			public string TemplateType
			{
				get
				{
					return templateType;
				}
				set	
				{
					templateType = value;
				}
			}

			public string SubTemplateType
			{
				get
				{
					return subTemplateType;
				}
				set	
				{
					subTemplateType = value;
				}
			}

			public string Source
			{
				get
				{
					return source;
				}
				set	
				{
					source = value;
				}
			}

			public string IsDefault
			{
				get
				{
					return isDefault;
				}
				set	
				{
					isDefault = value;
				}
			}

			public string TemplateConfig
			{
				get
				{
					return templateConfig;
				}
				set	
				{
					templateConfig = value;
				}
			}

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
				}
			}
		}
	}
}

// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//	   Copyright (c) 2018 Citrix ShareFile. All rights reserved.
// </auto-generated>
// ------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Net;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShareFile.Api.Client.Extensions;
using ShareFile.Api.Client.Exceptions;

namespace ShareFile.Api.Client.Models 
{
	public class AccountUser : User 
	{
		public bool? IsAdministrator { get; set; }
		public bool? CanCreateFolders { get; set; }
		public bool? CanUseFileBox { get; set; }
		public bool? CanManageUsers { get; set; }
		public bool? IsVirtualClient { get; set; }
		public int? DiskSpace { get; set; }
		public int? Bandwidth { get; set; }
		public int? BandwidthUsageMB { get; set; }
		public int? StorageQuotaLimitGB { get; set; }
		public int? StorageQuotaPercent { get; set; }
		public bool? EnableHardLimit { get; set; }
		public IEnumerable<UserPolicy> Policies { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as AccountUser;
			if(typedSource != null)
			{
				IsAdministrator = typedSource.IsAdministrator;
				CanCreateFolders = typedSource.CanCreateFolders;
				CanUseFileBox = typedSource.CanUseFileBox;
				CanManageUsers = typedSource.CanManageUsers;
				IsVirtualClient = typedSource.IsVirtualClient;
				DiskSpace = typedSource.DiskSpace;
				Bandwidth = typedSource.Bandwidth;
				BandwidthUsageMB = typedSource.BandwidthUsageMB;
				StorageQuotaLimitGB = typedSource.StorageQuotaLimitGB;
				StorageQuotaPercent = typedSource.StorageQuotaPercent;
				EnableHardLimit = typedSource.EnableHardLimit;
				Policies = typedSource.Policies;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("IsAdministrator", out token) && token.Type != JTokenType.Null)
				{
					IsAdministrator = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("CanCreateFolders", out token) && token.Type != JTokenType.Null)
				{
					CanCreateFolders = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("CanUseFileBox", out token) && token.Type != JTokenType.Null)
				{
					CanUseFileBox = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("CanManageUsers", out token) && token.Type != JTokenType.Null)
				{
					CanManageUsers = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("IsVirtualClient", out token) && token.Type != JTokenType.Null)
				{
					IsVirtualClient = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("DiskSpace", out token) && token.Type != JTokenType.Null)
				{
					DiskSpace = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("Bandwidth", out token) && token.Type != JTokenType.Null)
				{
					Bandwidth = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("BandwidthUsageMB", out token) && token.Type != JTokenType.Null)
				{
					BandwidthUsageMB = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("StorageQuotaLimitGB", out token) && token.Type != JTokenType.Null)
				{
					StorageQuotaLimitGB = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("StorageQuotaPercent", out token) && token.Type != JTokenType.Null)
				{
					StorageQuotaPercent = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("EnableHardLimit", out token) && token.Type != JTokenType.Null)
				{
					EnableHardLimit = (bool?)serializer.Deserialize(token.CreateReader(), typeof(bool?));
				}
				if(source.TryGetProperty("Policies", out token) && token.Type != JTokenType.Null)
				{
					Policies = (IEnumerable<UserPolicy>)serializer.Deserialize(token.CreateReader(), typeof(IEnumerable<UserPolicy>));
				}
			}
		}
	}
}
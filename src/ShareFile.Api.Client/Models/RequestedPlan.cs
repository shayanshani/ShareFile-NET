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
	/// <summary>
	/// Requested Plan
	/// </summary>
	public class RequestedPlan : ODataObject 
	{
		/// <summary>
		/// Billing Rate estimate in US Dollars
		/// </summary>
		public decimal? BaseBillingRate { get; set; }
		/// <summary>
		/// Number of User licenses for the account
		/// </summary>
		public int? BaseUsers { get; set; }
		/// <summary>
		/// Base amount of Cloud Storage to provision
		/// </summary>
		public int? BaseDiskSpaceInGB { get; set; }

		public override void Copy(ODataObject source, JsonSerializer serializer)
		{
			if(source == null || serializer == null) return;
			base.Copy(source, serializer);

			var typedSource = source as RequestedPlan;
			if(typedSource != null)
			{
				BaseBillingRate = typedSource.BaseBillingRate;
				BaseUsers = typedSource.BaseUsers;
				BaseDiskSpaceInGB = typedSource.BaseDiskSpaceInGB;
			}
			else
			{
				JToken token;
				if(source.TryGetProperty("BaseBillingRate", out token) && token.Type != JTokenType.Null)
				{
					BaseBillingRate = (decimal?)serializer.Deserialize(token.CreateReader(), typeof(decimal?));
				}
				if(source.TryGetProperty("BaseUsers", out token) && token.Type != JTokenType.Null)
				{
					BaseUsers = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
				if(source.TryGetProperty("BaseDiskSpaceInGB", out token) && token.Type != JTokenType.Null)
				{
					BaseDiskSpaceInGB = (int?)serializer.Deserialize(token.CreateReader(), typeof(int?));
				}
			}
		}
	}
}
﻿/*
	AsterNET ARI Framework
	Automatically generated file @ 6/1/2015 7:04:56 PM
*/
using System;
using System.Collections.Generic;
using AsterNET.ARI.Actions;

namespace AsterNET.ARI.Models
{
	/// <summary>
	/// Info about Asterisk status
	/// </summary>
	public class StatusInfo 
	{

		/// <summary>
		///
		/// </summary>
		// public AsteriskActions Asteris { get; set; }


		/// <summary>
		/// Time when Asterisk was started.
		/// </summary>
		public DateTime Startup_time { get; set; }

		/// <summary>
		/// Time when Asterisk was last reloaded.
		/// </summary>
		public DateTime Last_reload_time { get; set; }

	}
}

/*
	AsterNET ARI Framework
	Automatically generated file @ 6/1/2015 7:04:56 PM
*/
using System;
using System.Collections.Generic;
using AsterNET.ARI.Actions;

namespace AsterNET.ARI.Models
{
	/// <summary>
	/// Notification that another WebSocket has taken over for an application.  An application may only be subscribed to by a single WebSocket at a time. If multiple WebSockets attempt to subscribe to the same application, the newer WebSocket wins, and the older one receives this event.
	/// </summary>
	public class ApplicationReplacedEvent  : Event
	{

		/// <summary>
		///
		/// </summary>
		// public EventsActions Event { get; set; }


	}
}

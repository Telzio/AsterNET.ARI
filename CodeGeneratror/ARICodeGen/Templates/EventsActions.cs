﻿/*
	AsterNET ARI Framework
	Automatically generated file @ 6/1/2015 7:04:56 PM
*/
using System.Collections.Generic;
using System.Linq;
using AsterNET.ARI.Middleware;
using AsterNET.ARI.Models;
using Newtonsoft.Json;

namespace AsterNET.ARI.Actions
{
	
	public class EventsActions : ARIBaseAction, IEventsActions
	{

		public EventsActions(IActionConsumer consumer)
			: base(consumer)
		{}

		/// <summary>
		/// WebSocket connection for events.. 
		/// </summary>
		/// <param name="app">Applications to subscribe to.</param>
		public Message EventWebsocket(string app)
		{
			string path = "/events";
			var request = GetNewRequest(path, HttpMethod.GET);
			if(app != null)
				request.AddParameter("app", app, ParameterType.QueryString);

			var response = Execute<Message>(request);

			if((int)response.StatusCode >= 200 && (int)response.StatusCode < 300)
				return response.Data;

			switch((int)response.StatusCode)
            {
				default:
					// Unknown server response
					throw new AriException(string.Format("Unknown response code {0} from ARI.", response.StatusCode.ToString()));
            }
		}
		/// <summary>
		/// Generate a user event.. 
		/// </summary>
		/// <param name="eventName">Event name</param>
		/// <param name="application">The name of the application that will receive this event</param>
		/// <param name="source">URI for event source (channel:{channelId}, bridge:{bridgeId}, endpoint:{tech}/{resource}, deviceState:{deviceName}</param>
		/// <param name="variables">The "variables" key in the body object holds custom key/value pairs to add to the user event. Ex. { "variables": { "key": "value" } }</param>
		public void UserEvent(string eventName, string application, string source = null, List<KeyValuePair<string, string>> variables = null)
		{
			string path = "/events/user/{eventName}";
			var request = GetNewRequest(path, HttpMethod.POST);
			if(eventName != null)
				request.AddUrlSegment("eventName", eventName);
			if(application != null)
				request.AddParameter("application", application, ParameterType.QueryString);
			if(source != null)
				request.AddParameter("source", source, ParameterType.QueryString);
			if(variables != null)
			{
				var dictionary = variables.ToDictionary((keyItem) => keyItem.Key, (valueItem) => valueItem.Value);
				var variablesValue = JsonConvert.SerializeObject(new { variables = dictionary });
				request.AddParameter("application/json", variablesValue, ParameterType.RequestBody);
			}
			var response = Execute(request);
		}
	}
}


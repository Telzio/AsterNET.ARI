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
	/// Event showing failure of a recording operation.
	/// </summary>
	public class RecordingFailedEvent  : Event
	{

		/// <summary>
		///
		/// </summary>
		// public EventsActions Event { get; set; }


		/// <summary>
		/// Recording control object
		/// </summary>
		public LiveRecording Recording { get; set; }

	}
}

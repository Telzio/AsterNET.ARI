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
	/// Event showing the completion of a media playback operation.
	/// </summary>
	public class PlaybackFinishedEvent  : Event
	{

		/// <summary>
		///
		/// </summary>
		// public EventsActions Event { get; set; }


		/// <summary>
		/// Playback control object
		/// </summary>
		public Playback Playback { get; set; }

	}
}

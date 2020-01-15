using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using System;

namespace quick_music_player
{
	public static class ShellManager
	{
		public static TimeSpan GetDuration(string filePath)
		{
			using (var shell = ShellObject.FromParsingName(filePath))
			{
				IShellProperty prop = shell.Properties.System.Media.Duration;
				var t = (ulong)prop.ValueAsObject;
				return TimeSpan.FromTicks((long)t);
			}
		}

		public static string[] GetAllInfo(string filePath)
		{
			using (var shell = ShellObject.FromParsingName(filePath))
			{
				// title
				IShellProperty titleProp = shell.Properties.System.Title;
				var title = (string) titleProp.ValueAsObject;

				// artist
				IShellProperty artistProp = shell.Properties.System.Music.DisplayArtist;
				var artist = (string) artistProp.ValueAsObject;

				// album
				IShellProperty albumProp = shell.Properties.System.Music.AlbumTitle;
				var album = (string) albumProp.ValueAsObject;

				// duration
				IShellProperty durationProp = shell.Properties.System.Media.Duration;
				var duration = (ulong) durationProp.ValueAsObject;

				return new string[]
				{
					title,
					artist,
					album,
					TimeSpan.FromTicks((long) duration).ToString(@"mm\:ss")
				};
			}
		}

		public static string[] GetDetails(string filePath)
		{
			using (var shell = ShellObject.FromParsingName(filePath))
			{
				// compression
				IShellProperty compressionProp = shell.Properties.System.Audio.Compression;
				var compression = (string) compressionProp.ValueAsObject;

				// bitrate
				IShellProperty bitrateProp = shell.Properties.System.Audio.EncodingBitrate;
				var bitrate = (uint) bitrateProp.ValueAsObject;

				// bpm
				IShellProperty bpmProp = shell.Properties.System.Music.BeatsPerMinute;
				var bpm = (string) bpmProp.ValueAsObject;

				// released
				IShellProperty releasedProp = shell.Properties.System.Media.DateReleased;
				var released = (string) releasedProp.ValueAsObject;

				// duration
				IShellProperty durationProp = shell.Properties.System.Media.Duration;
				var duration = (ulong) durationProp.ValueAsObject;

				return new string[]
				{
					compression,
					(bitrate / 1000).ToString(),
					bpm,
					released,
					TimeSpan.FromTicks((long) duration).ToString(@"mm\:ss")
				};
			}
		}
	}
}

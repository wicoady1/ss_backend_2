using System;

namespace ss_backend_assess
{
	public class MyTreeNode : Gtk.TreeNode
	{
		

		string song_title;

		public MyTreeNode (string artist, string song_title)
		{
			Artist = artist;
			this.song_title = song_title;
		}

		[Gtk.TreeNodeValue (Column=0)]
		public string Artist;

		[Gtk.TreeNodeValue (Column=1)]
		public string SongTitle { get { return song_title; } }
	}
}


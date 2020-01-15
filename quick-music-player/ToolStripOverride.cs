using System.Windows.Forms;

namespace quick_music_player
{
	public class ToolStripOverride : ToolStripSystemRenderer
	{
		public ToolStripOverride() { }

		protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e) { }
	}
}

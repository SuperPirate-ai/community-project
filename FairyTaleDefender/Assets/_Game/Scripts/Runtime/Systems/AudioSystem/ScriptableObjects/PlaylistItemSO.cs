using BoundfoxStudios.FairyTaleDefender.Common;
using UnityEngine;

namespace BoundfoxStudios.FairyTaleDefender.Systems.AudioSystem.ScriptableObjects
{
	/// <summary>
	/// <see cref="ScriptableObject"/> for holding a reference to an <see cref="AudioClip"/> and some Information about it.
	/// </summary>
	[CreateAssetMenu(menuName = Constants.MenuNames.Audio + "/Playlist Item")]
	public class PlaylistItemSO : ScriptableObject
	{
		[field: SerializeField]
		public AudioClip AudioClip { get; private set; } = default!;

		[field: SerializeField]
		public string Title { get; private set; } = string.Empty;

		[field: SerializeField]
		public string Interpreter { get; private set; } = string.Empty;

		[field: SerializeField]
		public string Url { get; private set; } = string.Empty;
	}
}

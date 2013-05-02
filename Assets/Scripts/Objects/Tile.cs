using UnityEngine;
using System.Collections;

/// <summary>
/// Represents a tile on a tile-based map.
/// </summary>
public class Tile : BaseObject {
	
	#region Members
	Vector2 position;
	Vector2 size;
	Texture2D texture;
	#endregion
	
	/// <summary>
	/// Initializes a new instance of the <see cref="Tile"/> class.
	/// </summary>
	/// <param name='position'>
	/// The position of the tile in x,y coordinates.
	/// </param>
	/// <param name='size'>
	/// The size of the tile, as Unity's units.
	/// </param>/
	public Tile(Vector2 position, Vector2 size) 
		: base(position, Vector2.zero, Vector2.zero, Vector2.zero, Vector2.zero,
			Vector2.zero, size, Resources.Load("tile") as Texture2D) {

	}
	
	// Use this for initialization
	void Start() {
	}
	
	// Update is called once per frame
	public void Update () {
	
	}
}

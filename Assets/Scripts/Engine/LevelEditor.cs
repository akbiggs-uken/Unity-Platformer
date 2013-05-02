using UnityEngine;
using System.Collections;

public class LevelEditor : MonoBehaviour {
	
	#region CONSTANTS
	static bool DEBUG = true;
	
	const int MOUSE_LEFT = 0;
	const int TILESIZE = 32;
	const int MAPSIZE = 32;
	#endregion
	
	#region Members
	Tile[,] tiles;
	#endregion
	
	// Use this for initialization
	void Start () {
		tiles = new Tile[MAPSIZE, MAPSIZE];
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(MOUSE_LEFT)) {
			//Vector2 clickPos = new Vector2(Input.mousePosition.x / Screen.width,
			//	Input.mousePosition.y / Screen.height)
			Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
			AddTileAtPixel(clickPos);
		}
	}
	
	void AddTileAtPixel(Vector2 pixel) {
		
		if (DEBUG)
			Debug.Log(string.Format("Adding tile at {0}, {1}", pixel.x, pixel.y));
		
		int tileIndexX = (int)(pixel.x / MAPSIZE);
		int tileIndexY = (int)Mathf.Ceil(pixel.y / MAPSIZE);
		
		if (DEBUG)
			Debug.Log(string.Format("Tile indices are [{0}, {1}]", tileIndexX, tileIndexY));
		
		Vector2 tilePos = new Vector2(tileIndexX * TILESIZE, Screen.height - tileIndexY * TILESIZE);
		tiles[tileIndexX, tileIndexY] = new Tile(tilePos, new Vector2(TILESIZE, TILESIZE));
	}
	
	void OnGUI() {
		for (int i=0; i < MAPSIZE; i++)
			for (int j = 0; j < MAPSIZE; j++) {
				Tile tile = tiles[i,j];
				if (tile != null)
					tile.Render();
			}
	}
}

using UnityEngine;
using System.Collections;

/// <summary>
/// A template for other objects in the platformer to derive.
/// </summary>
public class BaseObject {
	
	#region Members
	Vector2 position;
	
	Vector2 velocity;
	Vector2 maxVelocity;
	
	Vector2 acceleration;
	Vector2 deceleration;
	Vector2 maxAcceleration;
	
	Vector2 size;
	
	Texture2D texture;
	#endregion
	
	#region Initialization
	public BaseObject(Vector2 position,
			Vector2 velocity, Vector2 maxVelocity,
			Vector2 acceleration, Vector2 deceleration, Vector2 maxAcceleration,
			Vector2 size, Texture2D texture) {
		this.position = position;
		this.velocity = velocity;
		this.maxVelocity = maxVelocity;
		this.acceleration = acceleration;
		this.deceleration = deceleration;
		this.maxAcceleration = maxAcceleration;
		this.size = size;
		this.texture = texture;
	}
	#endregion
	
	#region Updating
	void Update () {
	
	}
	#endregion
	
	#region Drawing
	
	/// <summary>
	/// Render this instance.
	/// Should only be invoked from the context of an OnGUI.
	/// </summary>
	public virtual void Render() {
		GUI.DrawTexture(new Rect(position.x, position.y, size.x, size.y), texture);
	}
	#endregion
}

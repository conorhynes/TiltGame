using UnityEngine;
using System.Collections;

public class Corridor {
	public Corridor(Vector3 pos)
	{
		GameObject ground = GameObject.CreatePrimitive(PrimitiveType.Plane);
		Rigidbody gameObjectsRigidBody = ground.AddComponent<Rigidbody>();
		gameObjectsRigidBody.mass = 1;
		gameObjectsRigidBody.useGravity = false;
	}
}

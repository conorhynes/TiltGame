using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {
	enum types{
		entry = 0,
		exit = 1,
		corridor = 2,
		leftTurn = 3,
		rightTurn = 4,
		teeJunc = 5,
		crossRoad = 6,
		wall = 7
	}

	// Use this for initialization
	void Start () {
		generateNew ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void generateNew()
	{
		int[][] gridList = new int[][] {new int[]{(int)types.entry,(int)types.corridor,(int)types.corridor,(int)types.leftTurn,(int)types.wall,(int)types.wall},
						new int[]{(int)types.wall,(int)types.wall,(int)types.rightTurn,(int)types.corridor,(int)types.corridor,(int)types.exit}};

		//Insert grid generation code here

		for(int i = 0 ; i < gridList.Length ; i++)
		{
			for(int j = 0 ; j < gridList[i].Length ; j++)
			{
				switch(gridList[i][j])
				{
				case (int)types.entry:
					//Generate Type entry
					break;
				case (int)types.exit:
					//Generate Type exit
					break;
				case (int)types.corridor:
					GameObject corridor = (GameObject)Resources.Load ("CorridorObject");
					Vector3 pos = new Vector3(0, 0, 0);
					Rigidbody gameObjectsRigidBody = corridor.AddComponent<Rigidbody>();
					gameObjectsRigidBody.mass = 1;
					gameObjectsRigidBody.useGravity = false;
					corridor.rigidbody.position = pos;
					corridor.layer = 1;
					//Generate Type corridor
					break;
				case (int)types.crossRoad:
					//Generate Type crossroad
					break;
				case (int)types.leftTurn:
					//Generate Type leftTurn
					break;
				case (int)types.rightTurn:
					//Generate Type Right Turn
					break;
				case (int)types.teeJunc:
					//Generate Type Tee Junc
					break;
				case (int)types.wall:
					//Generate Type Wall
					break;
				default:
					//Generate Type default(1)
					break;
				}
			}
		}
	}
}

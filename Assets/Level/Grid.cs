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
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void generateNew()
	{
		int[][] gridList = {{types.entry,types.corridor,types.corridor,types.leftTurn,types.wall,types.wall},
							{types.wall,types.wall,types.rightTurn,types.corridor,types.corridor,types.exit}};

		//Insert grid generation code here

		for(int i = 0 ; i < gridList.GetLength ; i++)
		{
			for(int j = 0 ; j < gridList[i].GetLength ; j++)
			{
				switch(gridList[i][j])
				{
				case types.entry:
					//Generate Type entry
					break;
				case types.exit:
					//Generate Type exit
					break;
				case types.corridor:
					//Generate Type corridor
					break;
				case types.crossRoad:
					//Generate Type crossroad
					break;
				case types.leftTurn:
					//Generate Type leftTurn
					break;
				case types.rightTurn:
					//Generate Type Right Turn
					break;
				case types.teeJunc:
					//Generate Type Tee Junc
					break;
				case types.wall:
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

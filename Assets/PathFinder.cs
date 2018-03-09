using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinder : MonoBehaviour {
    [SerializeField] WayPoint startWayPoint, endWaypoint;
    Dictionary<Vector2, WayPoint> grid = new Dictionary<Vector2, WayPoint>();
    Vector2[] directions =
    {
        new Vector2(0,1), // up
        new Vector2(1,0),
        new Vector2(-1,0),
        new Vector2(0,-1)
    };
	// Use this for initialization
	void Start () {
        LoadBlocks();
        ColorStartAndEnd();
        ExploreNeighbors();
    }

    private void ExploreNeighbors()
    {
        foreach(Vector2 direction in directions)
        {
            Vector2 explorationCoordates = startWayPoint.GetGridPos() + direction;
            grid[explorationCoordates].SetTopColor(Color.blue);
            if (grid.ContainsKey(explorationCoordates))
            {
                print("ya");
            }
        }

    }

    void ColorStartAndEnd()
    {
        startWayPoint.SetTopColor(Color.green);
        endWaypoint.SetTopColor(Color.red);
    }

    // Update is called once per frame
    void Update () {
		
	}
    void LoadBlocks()
    {
        var waypoints = FindObjectsOfType<WayPoint>();
        foreach(WayPoint waypoint in waypoints)
        {
            //overlap?
            // add to dict\
            bool isOverlapping = grid.ContainsKey(waypoint.GetGridPos());
            if (isOverlapping)
            {
                Debug.Log("overlapping block " + waypoint);
            }
            else
            {
                grid.Add(waypoint.GetGridPos(), waypoint);

            }
           
        }
    }
}

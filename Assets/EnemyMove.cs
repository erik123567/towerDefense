using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
    [SerializeField] List<WayPoint> path;
	// Use this for initialization
	void Start () {
        StartCoroutine(PrintAllWayPoints());
        Debug.Log("back at at start");
    }
	
	// Update is called once per frame
	void Update () {
        
	}
    IEnumerator PrintAllWayPoints()
    {
        Debug.Log("Starting patrol");
        foreach (WayPoint b in path)
        {

            transform.position = b.transform.position;
            Debug.Log("Visitng block: " + b.name);
            yield return new WaitForSeconds(1f);
        }
        Debug.Log("ending patrol");
    }
}

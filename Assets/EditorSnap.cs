using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode]
public class EditorSnap : MonoBehaviour {
    [SerializeField] [Range(1f,20f)] float gridSize = 10f;

    private void Awake()
    {
        Debug.Log("here");
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 snapPos;
        snapPos.x = Mathf.RoundToInt(transform.position.x / gridSize) * gridSize;
        snapPos.z = Mathf.RoundToInt(transform.position.z / gridSize) * gridSize;
        snapPos.y = 0f;
        transform.position = snapPos;
    }
}
//dude

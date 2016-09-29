using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public enum ColorStates {
	Closed,
	Open,
	Gazed
}


public class Hexagon : MonoBehaviour {
    private List<GameObject> insideCubes = new List<GameObject>();
    // Use this for initialization

    void Start () {

        //Subscribe to the gaze delegate
        GazeResponder gr = gameObject.GetComponent<GazeResponder>();
        gr.gazeChanged += Gr_gazeChanged;

		//First, get children
        foreach (Transform child in transform)
        {
            if (child.CompareTag("InsideHex"))
            {
                insideCubes.Add(child.gameObject);
            }
                
        }
	}

    private void Gr_gazeChanged(bool status)
    {
        
        foreach(GameObject inside in insideCubes)
        {
            inside.GetComponent<Renderer>().material.color = status ? Color.green : Color.blue;
        }
        
    }

    // Update is called once per frame
    void Update () {
	}	


}

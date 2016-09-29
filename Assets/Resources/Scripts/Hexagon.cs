using UnityEngine;
using System.Collections;
using System.Linq;


public enum ColorStates {
	Closed,
	Open,
	Gazed
}


public class Hexagon : MonoBehaviour {
	private GameObject[] insideCubes;
	// Use this for initialization
	void Start () {
		//First, get children
		Transform[] huh = gameObject.GetComponentsInChildren<Transform>();
		Debug.Log(huh.Length);
		//insideCubes = insideCubes.Where(child => child.tag == "InsideHex").ToArray;
	}
	
	// Update is called once per frame
	void Update () {
	}	

}

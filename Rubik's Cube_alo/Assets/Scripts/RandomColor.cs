 using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomColor : MonoBehaviour {

	public GameObject EmptyQuadPrefab, spawn1, spawn2, spawn3;
	public List<Color> cores;
	GameObject[] SpawnsList;
	List<GameObject> PaintQuadsList;

	// Use this for initialization
	void Start () {
		PaintQuadsList = new List<GameObject>();
		SpawnsList [0] = spawn1;
		SpawnsList [1] = spawn2;
		SpawnsList [2] = spawn3;
		print (SpawnsList);
	}
	
	// Update is called once per frame
	void Update () {
		GameObject[] achar = GameObject.FindGameObjectsWithTag ("Empty Paint");
		if(achar.Length == 0)
		{
			print ("zirow");
			SpawnQuads ();
		}
	}

	void SpawnQuads()
	{
		print ("ALOO");
		for (int i = 0; i > 3; i++) {
			print ("Ints" + 1);
			GameObject g = (GameObject)Instantiate (EmptyQuadPrefab, SpawnsList[i].transform.position, Quaternion.identity);
			PaintQuadsList.Add (g);
		}
		foreach(GameObject paint in PaintQuadsList){
			int j = Random.Range(0, cores.Count);
			paint.GetComponent<SpriteRenderer> ().color = cores[j];
		}
	}
}

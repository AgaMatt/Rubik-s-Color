using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class WinCondition : MonoBehaviour {



	GameObject[] rightSons, leftSons, upSons, downSons, frontSons, backSons ;
	Color[] rightColor, leftColor, upColor, downColor, frontColor, backColor;
	int blueCount, yellowCount, redCount, whiteColor, orangeColor, greenCount;
	Color cBlue, cYellow, cRed, cWhite, cOrange, cGreen;
	List<GameObject> frontList, backList, upList, downList, leftList, rightList;

	void Start()
	{
		/*	frontList = new List<GameObject> ();
		backList = new List<GameObject> ();
		upList = new List<GameObject> ();
		downList = new List<GameObject> ();
		leftList = new List<GameObject> ();
		rightList = new List<GameObject> ();*/

		rightColor = new Color[8];
		leftColor = new Color[8];
		upColor = new Color[8];
		downColor = new Color[8];
		frontColor = new Color[8];
		backColor = new Color[8];

		cBlue = new Color (0, 0.208f, 1.000f, 1.000f);
		cYellow = new Color (1f,0.110f, 0.125f, 1f);
		cRed = new Color (1.000f,0.110f,0.125f,1.000f);
		cWhite = new Color (1f,1f,1f,1f);
		cOrange = new Color (1,0.522f,0.004f, 1f);
		cGreen = new Color (0.180f,0.773f,0.004f,1f);

	}

	void Update()
	{
		RunAllFathers ();
	}


	void RunAllFathers()
	{
		FatherUp ();
		FatherRight ();
		FatherLeft ();
		FatherFront ();
		FatherDown ();
		FatherBack ();
	}

	void FatherRight()
	{
		rightSons = GameObject.FindGameObjectsWithTag ("Right Side");
		for(int i =0; i<8; i++)
		{
			//rightSons [i] = rightList [i];
			rightColor [i] = rightSons [i].GetComponent<MeshRenderer> ().material.color;
		}

	}

	void FatherLeft()
	{
		leftSons = 	GameObject.FindGameObjectsWithTag ("Left Side");
		for(int i =0; i<8; i++)
		{
			//leftSons [i] = leftList [i];
			leftColor [i] = leftSons [i].GetComponent<MeshRenderer> ().material.color;
		}
	}

	void FatherUp()
	{
		upSons = GameObject.FindGameObjectsWithTag ("Up Side");
		for (int i = 0; i < 8; i++) {
			//upSons[i] = upList[i];
			upColor [i] = upSons [i].GetComponent<MeshRenderer> ().material.color;
			//print (upColor[i]);
			/*	if(upColor[i] == cRed)
			{
				print ("REEEEEEED");
			}else if(upColor[i] ==cWhite)
				print ("Braco");
			else if(upColor[i] ==cOrange)
				print ("orangee");
			else if(upColor[i] == cBlue)
				print ("blues");
			else if(upColor[i] ==cYellow)
				print ("marelo");
			else if(upColor[i] ==cGreen)
				print ("verdi");*/
		}
	}


	void FatherDown()
	{
		downSons = GameObject.FindGameObjectsWithTag ("Down Side");
		for(int i =0; i < 8; i++)
		{
			//downSons [i] = downList [i];
			downColor [i] = downSons [i].GetComponent<MeshRenderer> ().material.color;
		}
	}

	void FatherFront()
	{
		frontSons = GameObject.FindGameObjectsWithTag ("Front Side");
		for(int i =0; i<8; i++)
		{
			//frontSons [i] = frontList [i];
			frontColor [i] = frontSons [i].GetComponent<MeshRenderer> ().material.color;
		}
	}

	void FatherBack ()
	{
		backSons = GameObject.FindGameObjectsWithTag ("Back Side");
		for(int i =0; i<8; i++)
		{
			//backSons [i] = backList [i];
			backColor [i] = backSons [i].GetComponent<MeshRenderer> ().material.color;
		}
	}

}


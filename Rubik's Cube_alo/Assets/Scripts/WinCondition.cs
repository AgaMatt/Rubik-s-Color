using UnityEngine;
using System.Collections;

public class WinCondition : MonoBehaviour {

	GameObject[] rightSons, leftSons, upSons, downSons, frontSons, backSons ;
	Color[] rightColor, leftColor, upColor, downColor, frontColor, backColor;
	int blueCount, yellowCount, redCount, whiteColor, orangeColor, greenCount;
	Color cBlue, cYellow, cRed, cWhite, cOrange, cGreen;

	void Start()
	{
		rightColor = new Color[8];
		leftColor = new Color[8];
		upColor = new Color[8];
		downColor = new Color[8];
		frontColor = new Color[8];
		backColor = new Color[8];

		cBlue = new Color (0, 0.208f, 1.000f, 1.000f);
		
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
			rightColor [i] = rightSons [i].GetComponent<MeshRenderer> ().material.color;

		}

	}

	void FatherLeft()
	{
		leftSons = 	GameObject.FindGameObjectsWithTag ("Left Side");
		for(int i =0; i<8; i++)
		{
			leftColor [i] = leftSons [i].GetComponent<MeshRenderer> ().material.color;
		}
	}

	void FatherUp()
	{
		upSons = GameObject.FindGameObjectsWithTag ("Up Side");
		for (int i = 0; i < 8; i++) {
			upColor [i] = upSons [i].GetComponent<MeshRenderer> ().material.color;
			//print (upColor[i]);
		}
	}


	void FatherDown()
	{
		downSons = GameObject.FindGameObjectsWithTag ("Down Side");
		for(int i =0; i < 8; i++)
		{
			downColor [i] = downSons [i].GetComponent<MeshRenderer> ().material.color;
		}
	}

	void FatherFront()
	{
		frontSons = GameObject.FindGameObjectsWithTag ("Front Side");
		for(int i =0; i<8; i++)
		{
			frontColor [i] = frontSons [i].GetComponent<MeshRenderer> ().material.color;
		}
	}

	void FatherBack ()
	{
		backSons = GameObject.FindGameObjectsWithTag ("Back Side");
		for(int i =0; i<8; i++)
		{
			backColor [i] = backSons [i].GetComponent<MeshRenderer> ().material.color;
		}
	}

}


using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class WinCondition : MonoBehaviour {



	public GameObject[] rightSons, leftSons, upSons, downSons, frontSons, backSons ;
	public Color[] rightColor, leftColor, upColor, downColor, frontColor, backColor;
	public int rightCount, leftCount, upCount, downCount, frontCount, backCount;
	Color cBlue, cYellow, cRed, cWhite, cOrange, cGreen, colorZ, colorX, colorC, colorV, colorB, colorN;
	List<GameObject> frontList, backList, upList, downList, leftList, rightList;
	WinScreen winScreen;

	void Start()
	{
		/*	frontList = new List<GameObject> ();
		backList = new List<GameObject> ();
		upList = new List<GameObject> ();
		downList = new List<GameObject> ();
		leftList = new List<GameObject> ();
		rightList = new List<GameObject> ();*/
		winScreen = GameObject.FindObjectOfType<WinScreen> ();
		rightColor = new Color[9];
		leftColor = new Color[9];
		upColor = new Color[9];
		downColor = new Color[9];
		frontColor = new Color[9];
		backColor = new Color[9];

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
		CheckForWin ();
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
		for(int i =0; i<9; i++)
		{
			//rightSons [i] = rightList [i];
			rightColor [i] = rightSons [i].GetComponent<MeshRenderer> ().material.color;
			//print (rightColor[i]);
		}

	}

	void FatherLeft()
	{
		leftSons = 	GameObject.FindGameObjectsWithTag ("Left Side");
		for(int i =0; i<9; i++)
		{
			//leftSons [i] = leftList [i];
			leftColor [i] = leftSons [i].GetComponent<MeshRenderer> ().material.color;
		}
	}

	void FatherUp()
	{
		upSons = GameObject.FindGameObjectsWithTag ("Up Side");
		for (int i = 0; i < 9; i++) {
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
		for(int i =0; i < 9; i++)
		{
			//downSons [i] = downList [i];
			downColor [i] = downSons [i].GetComponent<MeshRenderer> ().material.color;
		}
	}

	void FatherFront()
	{
		frontSons = GameObject.FindGameObjectsWithTag ("Front Side");
		for(int i =0; i<9; i++)
		{
			//frontSons [i] = frontList [i];
			frontColor [i] = frontSons [i].GetComponent<MeshRenderer> ().material.color;
		}
	}

	void FatherBack ()
	{
		backSons = GameObject.FindGameObjectsWithTag ("Back Side");
		for(int i =0; i<9; i++)
		{
			//backSons [i] = backList [i];
			backColor [i] = backSons [i].GetComponent<MeshRenderer> ().material.color;
		}
	}
	void CheckForWin()
	{
		colorZ = rightColor [0];
		colorX = leftColor [0];
		colorC = upColor [0];
		colorV = downColor [0];
		colorB = frontColor [0];
		colorN = backColor [0];
		if (colorZ != colorX && colorZ != colorC && colorZ != colorV && colorZ != colorB && colorZ != colorN) {
			for (int i = 0; i < 9; i++) {
				if (rightColor [i] == colorZ) {
					rightCount ++;
					//print ("tudo certo Right");
				} else
					rightCount = 0;
			}
		}

			if(colorX != colorZ && colorX != colorC && colorX != colorV && colorX != colorB && colorX != colorN){
				for(int i =0; i < 9; i++){
				if (leftColor [i] == colorX) {
					leftCount ++;
					//print ("tudo certo Left");
				} else
					leftCount = 0;
				}

			}

		if(colorC != colorX && colorC != colorZ && colorC != colorV && colorC != colorB && colorC != colorN){
			for(int i =0; i < 9; i++){
				if (upColor [i] == colorC) {
					upCount ++;
					//print ("tudo certo Up");
				} else
					upCount = 0;
			}
		}

		if(colorV != colorX && colorV != colorC && colorV != colorZ && colorV != colorB && colorV != colorN){
			for(int i =0; i < 9; i++){
				if(downColor[i] == colorV)
				{
					downCount ++;
				//	print ("tudo certo Down");
				}else
					downCount = 0;
			}
		}

		if(colorB != colorX && colorB != colorC && colorB != colorV && colorB != colorZ && colorB != colorN){
			for(int i =0; i < 9; i++){
				if (frontColor [i] == colorB) {
					frontCount ++;
					//print ("tudo certo Front");
				} else
					frontCount = 0;
			}
		}

		if(colorN != colorX && colorN != colorC && colorN != colorV && colorN != colorB && colorN != colorZ){
			for(int i =0; i < 9; i++){
				if (backColor [i] == colorN) {
					backCount ++;
					//print ("tudo certo Back");
				} else
					backCount = 0;
			}
		}

		if(rightCount > 10 && leftCount > 10 && upCount > 10 && downCount > 10 && frontCount > 10 && backCount > 10){
			winScreen.WinTheGame ();
		}
		
	}

}


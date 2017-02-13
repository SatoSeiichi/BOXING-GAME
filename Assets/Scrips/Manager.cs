using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class Manager : MonoBehaviour {
	public Animator[] anim = new Animator[2];
	
	public Vector3 zigAccel;
	
	bool[] actionFlag = new bool[4];
	
	
	public GameObject planeMesh;
	public Color planColor;
	
	// Use this for initialization
	void Start () {
		GetComponent<ZigReciever> ().SetUp (OnReciveZigData);
		
		for(int i = 0 ; i < actionFlag.Length; i++)
		{
			actionFlag[i] = false;
		}
		
		MeshFilter mf = planeMesh.GetComponent<MeshFilter>();
		mf.mesh.SetIndices(mf.mesh.GetIndices(0),MeshTopology.LineStrip,0);
		
		MeshRenderer mr = planeMesh.GetComponent<MeshRenderer>();
		mr.material.color = planColor;
	}
	
	// Update is called once per frame
	void Update () {      
		//if (Input.GetKeyDown (KeyCode.Space)) {
		//	anim[0].SetInteger("punching",Random.Range(1,3));
		//}
		if(actionFlag[0])
		{
			anim[0].SetInteger("punching",2);
			actionFlag[0] = false;
		}
		
		if(actionFlag[1])
		{
			anim[0].SetInteger("punching",1);
			actionFlag[1] = false;
		}
		
		if(actionFlag[2])
		{
			anim[1].SetInteger("punching",2);
			actionFlag[2] = false;
		}
		
		if(actionFlag[3])
		{
			anim[1].SetInteger("punching",1);
			actionFlag[3] = false;
		}
	}  
	
	void OnReciveZigData(string data){
		JSONNode zigData = JSONNode.Parse(data);
		//print((string)zigData["device"]["uuid"]);
		
		string uuid = (string)zigData["device"]["uuid"];
		
		float x = zigData["sensordata"]["accel"]["x"].AsFloat;
		if(x > 1)
		{
			switch(uuid)
			{
			case "P1-L":
				actionFlag[0] = true;
				break;
			case "P1-R":
				actionFlag[1] = true;
				break;
			case "P2-L":
				actionFlag[2] = true;
				break;
			case "P2-R":
				actionFlag[3] = true;
				break;
			}
		}
	}
}

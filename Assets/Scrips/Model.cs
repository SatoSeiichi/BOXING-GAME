using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour {
	public Manager manager;
	public Color color;
	public SkinnedMeshRenderer smr;
	// Use this for initialization
	void Start () {
		smr.sharedMesh.SetIndices(smr.sharedMesh.GetIndices(0), MeshTopology.LineStrip, 0);
		
		smr.material.color = color;
	}
	// Return to default
	void OnApplicationQuit(){
		smr.sharedMesh.SetIndices(smr.sharedMesh.GetIndices(0), MeshTopology.Triangles, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void Impact()
	{
		//print("impact");
		if(gameObject.name == "Y_Bot_1")
		{
			manager.anim[1].SetInteger("punching",10);
		}
		else
		{
			manager.anim[0].SetInteger("punching",10);
		}
	}
}

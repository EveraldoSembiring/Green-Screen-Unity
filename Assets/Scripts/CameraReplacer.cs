using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraReplacer : MonoBehaviour {
    public Material GreenReplacerMaterial;
	// Use this for initialization
	void Start () {
        RenderTexture rt = new RenderTexture(Screen.width, Screen.height, 24);
        GetComponent<Camera>().targetTexture = rt;
        GreenReplacerMaterial.SetTexture("_TexReplacer", rt);	
	}
}

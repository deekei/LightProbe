using UnityEngine;
using System.Collections;

public class lightProbeScript : MonoBehaviour {


	public LightProbes lightProbeScene;

	public float [] coefficientList;
	// Use this for initialization
	void Start () {

		coefficientList = new float[27];


		//lightProbeScene.GetInterpolatedLightProbe (this.transform.position, renderer, coefficientList);
	}
	
	// Update is called once per frame
	void Update () {
		LightmapSettings.lightProbes.GetInterpolatedLightProbe(this.transform.position, renderer, coefficientList);
	}
}

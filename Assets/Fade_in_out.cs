using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade_in_out : MonoBehaviour {

	private Light luz;
	public float maxRange;
	public float minRange;
	public float step;
	private bool fading_in;

	void Start () {
		luz = gameObject.GetComponent<Light> ();
	}
	

	void Update () {
		if (!fading_in){
			luz.range -= step * Time.deltaTime * Random.value;
			if (luz.range <= minRange)
				fading_in = true;
		}else{
			luz.range += step * Time.deltaTime * Random.value;
			if (luz.range >= maxRange)
				fading_in = false;
		}

	}
}

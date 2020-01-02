using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour {

    public float speed = -2f;
    public float loverYValue = -20f;
    public float upperYValue = 40;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0f, speed * Time.deltaTime, 0f);
        if (transform.position.y <= loverYValue)
        {
            transform.Translate(0f, upperYValue, 0f);
        }
	}
}

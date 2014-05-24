using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float _speed = 1f;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(Vector3.up * Time.deltaTime * _speed, Space.World);  
        }
	}
}

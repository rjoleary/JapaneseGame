using UnityEngine;
using System.Collections;

public class TrackTarget : MonoBehaviour {

	public float _distance = 5f;
    public GameObject _target;
	
	void Update () {
        Vector3 targetPos = _target.transform.position;
        transform.position = new Vector3(targetPos.x, targetPos.y + 1, targetPos.z + _distance);
	}
}

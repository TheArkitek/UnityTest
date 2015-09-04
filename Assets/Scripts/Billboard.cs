using UnityEngine;
using System.Collections;

public class Billboard : MonoBehaviour
{
    public GameObject target;

	// Use this for initialization
	void Start ()
    {
        if (target == null)
            target = Camera.main.gameObject;
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.LookAt(transform.position + target.transform.rotation * Vector3.back, target.transform.rotation * Vector3.up);
    }
}

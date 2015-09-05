using UnityEngine;
using System.Collections;

public class BasicSeeker : MonoBehaviour
{
    public float speed;

	// Use this for initialization
	void Start ()
    {
	
	}
    
	// Update is called once per frame
	void Update ()
    {
        transform.GetComponent<Rigidbody>().velocity = new Vector3(speed, 0, 0);
        foreach (Transform t in transform)
            t.position = new Vector3(transform.position.x, 0.1f, transform.position.z);
	}
}

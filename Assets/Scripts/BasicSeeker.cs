using UnityEngine;
using System.Collections;

public class BasicSeeker : MonoBehaviour
{
    public float speed;
    public Camera targetCamera;

	// Use this for initialization
	void Start ()
    {
	
	}

    void Awake()
    {
        targetCamera = Camera.main;
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.GetComponent<Rigidbody>().velocity = new Vector3(speed, 0, 0);
        transform.LookAt(transform.position + targetCamera.transform.rotation * Vector3.back, targetCamera.transform.rotation * Vector3.up);
	}
}

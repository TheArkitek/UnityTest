using UnityEngine;
using System.Collections;

public class EnemyGoal : MonoBehaviour
{
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<BasicSeeker>() != null)
            Destroy(other.gameObject);
    }
}

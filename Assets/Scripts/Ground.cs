using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour
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
        if (other.GetComponent<BasicProjectile>() != null)
            Destroy(other.gameObject);
    }
}

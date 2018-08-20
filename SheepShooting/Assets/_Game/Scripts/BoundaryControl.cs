using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryControl : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        //Debug.Log(other.gameObject.name);
        Destroy(other.gameObject);
    }
}

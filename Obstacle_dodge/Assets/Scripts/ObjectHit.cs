using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {

        GetComponent<MeshRenderer>().material.color = Color.skyBlue;
        // Debug.Log("Something hit me!");
    }
}

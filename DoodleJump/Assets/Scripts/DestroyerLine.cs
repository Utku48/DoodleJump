using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerLine : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Platform")
        {
            float RandomRespawnX = Random.Range(-4.2f, 4.2f);
            float RandomRespawnY = 15f;
            other.transform.position = new Vector3(RandomRespawnX, other.transform.position.y + RandomRespawnY, other.transform.position.z);
        }
    }
}

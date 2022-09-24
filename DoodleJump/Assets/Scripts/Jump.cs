using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Jump : MonoBehaviour
{
    public float jumpPower;
    private Rigidbody2D rb;
    private Vector2 SpeedCh;



    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.relativeVelocity.y <= 0)//Temas edilen objenin y hızı 0 ise
        {
            rb = other.collider.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                SpeedCh = rb.velocity;//Rigidbody içindeki hız KarakterHızına Atıldı
                SpeedCh.y = jumpPower;//Rigidbody'den gelen velocity hızının y'si zıplama gücü oldu
                rb.velocity = SpeedCh;

            }



        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCreater : MonoBehaviour
{

    public GameObject platform;
    public int platformSayisi;
    public float minX, maxX, minY, maxY;//Platfırmların koordinatlarını belirlemek için

    void Start()
    {
        Vector3 clonePos = new Vector3();//Objenin klonlanacağı pozisyonu belirtecek
        for (int i = 0; i <= platformSayisi; i++)
        {
            clonePos.x = Random.Range(minX, maxX);
            clonePos.y = Random.Range(minY, maxY);
            Instantiate(platform, clonePos, Quaternion.identity);//Instantiate(GameObject,Position,Rotation)
        }


    }
}

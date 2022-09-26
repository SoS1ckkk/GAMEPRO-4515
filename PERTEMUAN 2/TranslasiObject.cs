using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslasiObject : MonoBehaviour
{
    Vector3 kanan;
    Vector3 kiri ;
    Vector3 atas ;
    Vector3 bawah ;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        kanan = new Vector3(1,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (kanan * speed * Time.deltaTime);
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    Vector3 kanan;
    Vector3 kiri ;
    Vector3 atas ;
    Vector3 bawah ;
    public int speed;
    Vector3 maju ;
    Vector3 mundur;
    public int aksi;
    

    // Start is called before the first frame update
    void Start()
    {
        kanan = new Vector3(1,0,0);
        kiri = new Vector3(-1,0,0);
        atas = new Vector3(0,1,0);
        bawah = new Vector3(0,-1,0);
        maju = new Vector3(0,0,1);
        mundur = new Vector3(0,0,-1);
    }

    // Update is called once per frame
    void Update()
    {
        switch (aksi) {
            case 0: 
                transform.position = transform.position + (kanan * speed * Time.deltaTime);
                break;
            case 1: 
                transform.position = transform.position + (kiri * speed * Time.deltaTime);
                break;
            case 2: 
                transform.position = transform.position + (atas * speed * Time.deltaTime);
                break;
            case 3: 
                transform.position = transform.position + (bawah * speed * Time.deltaTime);
                break;
            case 4: 
                transform.rotation = transform.rotation * Quaternion.Euler(maju * speed * Time.deltaTime);
                break;
            case 5: 
                transform.rotation = transform.rotation * Quaternion.Euler(mundur * speed * Time.deltaTime);
                break;
            
        }
    }
}

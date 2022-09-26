using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotasiObject : MonoBehaviour
{
    Vector3 maju ;
    public int speedRotasi;
    // Start is called before the first frame update
    void Start()
    {
        maju = new Vector3(0,0,1);

        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = transform.rotation * Quaternion.Euler(maju * speedRotasi * Time.deltaTime);
    }
}

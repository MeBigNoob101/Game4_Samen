using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float bulletVelocity = 30;
    public float bulletprefablifetime = 3f;



    // Update is called once per frame
    void Update()
    {// left mouse

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

        }
    }
}

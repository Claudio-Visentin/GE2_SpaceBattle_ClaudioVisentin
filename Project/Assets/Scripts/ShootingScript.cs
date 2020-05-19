using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public float wait;
    public GameObject laser;
    public Vector3 direction;
    public Transform laserstarter;
    public float waitbeforedestroying;
    public bool repeat;

    void Awake()
    {
        StartCoroutine("Shoot");
    }

    IEnumerator Shoot ()
    {
        yield return new WaitForSeconds(wait);
        GameObject instlaser = Instantiate(laser, laserstarter.transform);
        instlaser.transform.parent = laserstarter;
        instlaser.GetComponent<Rigidbody>().AddRelativeForce(direction);
        yield return new WaitForSeconds(waitbeforedestroying);
        Destroy(instlaser);
        if (repeat == true)
        {
            StartCoroutine("Shoot");
        }
    }
    
}

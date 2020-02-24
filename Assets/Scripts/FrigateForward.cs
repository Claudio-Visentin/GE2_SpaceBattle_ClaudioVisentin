using UnityEngine;

public class FrigateForward : MonoBehaviour
{
    Rigidbody rigid;
    void Start()
    {
       rigid = GetComponent <Rigidbody> (); 
       rigid.AddForce (100f, 0f, 0f);
    }
}

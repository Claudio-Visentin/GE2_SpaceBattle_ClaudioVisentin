using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    Rigidbody rigid;
    public float speedx;
    public float speedy;
    public float speedz;
    void Start()
    {
       rigid = GetComponent <Rigidbody> (); 
       rigid.AddForce (speedx, speedy, speedz);
    }
}

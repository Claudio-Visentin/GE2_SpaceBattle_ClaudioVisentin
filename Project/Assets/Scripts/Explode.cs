using System.Collections;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public float timer;
    public GameObject explosion;
    public GameObject spaceship;
    void Awake()
    {
        StartCoroutine("Exploder");
    }

    // Update is called once per frame
    IEnumerator Exploder ()
    {
        yield return new WaitForSeconds(timer);
        GameObject explosioninst = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(spaceship);
    }
}

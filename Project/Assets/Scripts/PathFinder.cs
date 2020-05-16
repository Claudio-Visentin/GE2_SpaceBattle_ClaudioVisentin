using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinder : MonoBehaviour
{
    public List <Transform> Waypoints = new List <Transform> ();
    public int index = 0;
    Rigidbody rigid;
    public float speed;
    public float rotationspeed;
    public bool loop;
    public bool movesideways;
    
    void Awake () {
        rigid = GetComponent <Rigidbody> ();
        
    }
    void Update () {
        if (movesideways == false)
        {
            Quaternion targetrotation = Quaternion.LookRotation(Waypoints[index].position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetrotation, rotationspeed * Time.deltaTime);
        }
        transform.position = Vector3.MoveTowards (transform.position, Waypoints [index].position, speed);
         if (Vector3.Distance (Waypoints [index].position, transform.position) < 1) {
             NewPoint();
        }
    }

    void NewPoint () {
        if (index < Waypoints.Count) {
            index += 1;
        }
        if (index >= Waypoints.Count && loop == true) {
            index = 0;
        }
    }
}

﻿using UnityEngine;

public class FriendAI : MonoBehaviour
{
    public PathFinder mainship;
    public Vector3 offset;
    public float speed;
    public float rotationspeed;
    void FixedUpdate()
    {
        Vector3 randomfactor = new Vector3 (Random.Range(0, 0.1f), 0f, Random.Range(0, 0.1f));
        Vector3 nextmove = mainship.Waypoints [mainship.index].position + offset + randomfactor;
        transform.position = Vector3.MoveTowards(transform.position, nextmove, speed);
        transform.rotation = mainship.gameObject.transform.rotation;
    }
}

using UnityEngine;

public class FriendAI : MonoBehaviour
{
    public PathFinder mainship;
    public Vector3 offset;
    public float speed;
    public float rotationspeed;
    void Update()
    {
        Vector3 randomfactor = new Vector3 (Random.Range(0, 0.1f), 0f, Random.Range(0, 0.1f));
        Vector3 nextmove = mainship.Waypoints [mainship.index].position + offset + randomfactor;
        transform.position = Vector3.MoveTowards(transform.position, nextmove, speed);
        Quaternion targetrotation = Quaternion.LookRotation(mainship.Waypoints[mainship.index].position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetrotation, rotationspeed * Time.deltaTime);
    }
}

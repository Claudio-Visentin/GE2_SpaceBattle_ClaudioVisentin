using UnityEngine;

public class FriendAI : MonoBehaviour
{
    public Transform mainship;
    public Vector3 offset;
    public float speed;
    void Update()
    {
        Vector3 randomfactor = new Vector3 (Random.Range(0, 2), 0f, Random.Range(0, 2));
        Vector3 nextmove = mainship.position + offset;
        transform.position = Vector3.MoveTowards(transform.position, nextmove, speed);
        transform.rotation = mainship.rotation;
    }
}

using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public SceneDirector scene;
    public Transform spaceship;
    public float speed;
    void Update()
    {
        if (scene.Scene == "Scene1")
        {
            transform.LookAt(spaceship.position);
            transform.position = Vector3.MoveTowards(transform.position, new Vector3 (0f, 0f, 0f), speed);
        }
        if (scene.Scene == "Scene2")
        {
            //Clip plays
        }
        if (scene.Scene == "Scene3")
        {

        }
        if (scene.Scene == "Scene4")
        {

        }
        if (scene.Scene == "Scene5")
        {
            //Clip plays
        }
        if (scene.Scene == "Scene6")
        {

        }
    }
}

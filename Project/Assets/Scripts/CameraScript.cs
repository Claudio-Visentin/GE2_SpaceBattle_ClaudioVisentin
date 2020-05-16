using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour
{
    public SceneDirector scene;
    public Transform spaceship;
    public float speed;

    bool scene1part1check = false;
    bool scene1part1 = false;
    void Update()
    {
        if (scene.Scene == "Scene1")
        {
            if (scene1part1check == false)
            {
                StartCoroutine("Scene1");
                scene1part1check = true;
            }
            if (scene1part1 == false)
            {
                transform.LookAt(spaceship.position);
                transform.parent = spaceship.transform;
            }
            else
            {
                transform.parent = null;
                transform.LookAt(spaceship.position);
                transform.position = Vector3.MoveTowards(transform.position, spaceship.position, speed);
            }
            
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
    public IEnumerator Scene1()
    {
        yield return new WaitForSeconds(3f);
        scene1part1 = true;
    }
}

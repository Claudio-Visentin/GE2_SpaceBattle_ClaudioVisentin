using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour
{
    public SceneDirector scene;
    public Transform spaceship;
    public float speed;

    bool scene1part1check = false;
    bool scene1part1 = false;

    bool scene3start = false;

    bool scene4start = false;
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
            if (scene3start == false)
            {
                spaceship = GameObject.FindGameObjectWithTag("MainShip").transform;
                transform.position = new Vector3(-126.8f, 11.5f, 228.5f);
                transform.parent = spaceship.transform;
                StartCoroutine("Scene3");
                scene3start = true;
            }
            transform.LookAt(spaceship.position);
        }
        if (scene.Scene == "Scene4")
        {
            if (scene4start == false)
            {
                transform.position = new Vector3(-227f, 138.1f, 191.7f);
                StartCoroutine("Scene4");
                scene4start = true;
            }
            transform.LookAt(spaceship.position);
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
        spaceship = GameObject.FindGameObjectWithTag("MainShip").transform;
        yield return new WaitForSeconds(3f);
        scene1part1 = true;
    }
    public IEnumerator Scene3()
    {
        spaceship = GameObject.FindGameObjectWithTag("MainShip").transform;
        yield return new WaitForSeconds(4.8f);
        transform.parent = null;
    }
    public IEnumerator Scene4()
    {
        spaceship = GameObject.FindGameObjectWithTag("MainShip").transform;
        yield return new WaitForSeconds(8.9f);
        transform.parent = null;
    }
}

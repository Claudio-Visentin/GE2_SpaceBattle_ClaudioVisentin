using System.Collections;
using UnityEngine.Video;
using UnityEngine;

public class SceneDirector : MonoBehaviour
{
    public VideoPlayer video;
    public VideoClip scene2;
    public VideoClip scene5;
    public string Scene;

    public GameObject scene1;
    public GameObject scene3;
    public GameObject scene4;
    public GameObject scene6part1;
    public GameObject scene6part2;

    void Start()
    {
        video.renderMode = VideoRenderMode.CameraNearPlane;
        StartCoroutine("SceneTimer"); 
    }

   IEnumerator SceneTimer ()
    {
        Scene = "Scene1";
        yield return new WaitForSeconds(8f);
        video.clip = scene2;
       // video.Play();
        Scene = "Scene2";
        yield return new WaitForSeconds(1f);
        scene1.SetActive(false);
       // yield return new WaitForSeconds(19f);
      //  video.Stop();
        Scene = "Scene3";
        scene3.SetActive(true);
        yield return new WaitForSeconds(5f);
        Scene = "Scene4";
        scene3.SetActive(false);
        scene4.SetActive(true);
        yield return new WaitForSeconds(9f);
        Scene = "Scene5";
        video.clip = scene5;
      //  video.Play();
        scene4.SetActive(false);
      //  yield return new WaitForSeconds(9f);
        Scene = "Scene6";
        scene6part1.SetActive(true);
       // video.Stop();
        yield return new WaitForSeconds(3.8f);
        scene6part1.SetActive(false);
        scene6part2.SetActive(true);       
    }
}

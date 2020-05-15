using System.Collections;
using UnityEngine.Video;
using UnityEngine;

public class SceneDirector : MonoBehaviour
{
    public VideoPlayer video;
    public VideoClip scene2;
    public VideoClip scene5;
    public string Scene;

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
        video.Play();
        Scene = "Scene2";
        yield return new WaitForSeconds(20f);
        video.Stop();
        Scene = "Scene3";
        yield return new WaitForSeconds(5f);
        Scene = "Scene4";
        yield return new WaitForSeconds(9f);
        Scene = "Scene5";
        video.clip = scene5;
        video.Play();
        yield return new WaitForSeconds(8f);
        Scene = "Scene6";
        video.Stop();
    }
}

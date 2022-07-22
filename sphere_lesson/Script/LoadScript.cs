using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScript : MonoBehaviour
{
    private string bundelURL = "https://www.schoolvr.ru/ban.unity3d";
    private int version = 7;
    [SerializeField] AudioSource sourse;
    [SerializeField] SpriteRenderer sRender;

    public void OnClickDownload()
    {
        Debug.Log("Rnopka najalas");
        StartCoroutine(DownLoadAndCashe());

    }
    public IEnumerator DownLoadAndCashe()
    {
        while (!Caching.ready)
            yield return null;

        var www = WWW.LoadFromCacheOrDownload(bundelURL, version);
        yield return www;
        Debug.Log("1 itap prohel");

        if (!string.IsNullOrEmpty(www.error))
        {
            Debug.Log(www.error);
            yield break;
        }
            Debug.Log("Bandl na meste!");
            var assetBundle = www.assetBundle;
            string musicName = "lol1.mp3";
            string spriteName = "pip1.jpg";

            var musicRequest = assetBundle.LoadAssetAsync(musicName, typeof(AudioClip));
            yield return musicRequest;
            Debug.Log("музыкальный файл распокован");
            var spriteRequest = assetBundle.LoadAssetAsync(spriteName, typeof(Sprite));
            yield return spriteRequest;
            Debug.Log("Изображение распоковано!");

            sourse.clip = musicRequest.asset as AudioClip;
            sourse.Play();
            sRender.sprite = spriteRequest.asset as Sprite;
            Debug.Log("norma");
    }
}

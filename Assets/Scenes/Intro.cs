using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    public CanvasGroup image1,image2, image3, image4;
    public float fadeTime = 3f;
    public float accumTime = 0f;
    public bool intro1, intro2, intro3, intro4;
    private Coroutine fadeCor;
    void Awake()
    {
        StartFadeIn();
        intro1 = false;
        intro2 = false;
        intro3 = false;
        intro4 = false;

        image1.alpha = 0;
        image2.alpha = 0;
        image3.alpha = 0;
        image4.alpha = 0;
    }
    void StartFadeIn()
    {
        if (fadeCor != null)
        {
            StopAllCoroutines();
            fadeCor = null;
        }
        fadeCor = StartCoroutine(FadeIn());
    }
    private IEnumerator FadeIn()
    {
        yield return new WaitForSeconds(0.2f);
        accumTime = 0f;

        while(true)
        {
            if (intro1 == false)//image1 페이드 인
            {
                image1.alpha = Mathf.Lerp(0f, 1f, accumTime / fadeTime);
                yield return 0;
                accumTime += Time.deltaTime;
                if (accumTime >= fadeTime)
                {
                    accumTime = 0f;
                    intro1 = true;
                    continue;
                }
            }
            else if (intro2 == false)
            {
                image2.alpha = Mathf.Lerp(0f, 1f, accumTime / fadeTime);
                yield return 0;
                accumTime += Time.deltaTime;
                if (accumTime >= fadeTime)
                {
                    accumTime = 0f;
                    intro2 = true;
                    continue;
                }
            }
            else if (intro3 == false)
            {
                image3.alpha = Mathf.Lerp(0f, 1f, accumTime / fadeTime);
                yield return 0;
                accumTime += Time.deltaTime;
                if (accumTime >= fadeTime)
                {
                    accumTime = 0f;
                    intro3 = true;
                    continue;
                }
            }
            else if (intro4 == false)
            {
                image4.alpha = Mathf.Lerp(0f, 1f, accumTime / fadeTime);
                yield return 0;
                accumTime += Time.deltaTime;
                if (accumTime >= fadeTime)
                {
                    accumTime = 0f;
                    intro4 = true;
                    continue;
                }
            }
            else
            {
                SceneManager.LoadScene("StartScene");
                break;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

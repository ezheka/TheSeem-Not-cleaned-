using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGameBlack : MonoBehaviour
{
    public MenuButtons ButtonManager;
    public Image img; 
    public AnimationCurve curve;
    public GameObject panelFinish, panelStart;
    public static bool finishBool = false;
    float t;

    private void Awake()
    {
        StartCoroutine(FadeIn());
        img.gameObject.SetActive(true);
    }

    private void Start()
    {
        if (finishBool == false)
        {
            panelStart.SetActive(true);
            panelFinish.SetActive(false);
        }
        else
        {
            panelStart.SetActive(false);
            panelFinish.SetActive(true);
        }
    }

    IEnumerator FadeIn()
    {
        float t = 1f;

        while (t > 0f)
        {
            t -= 0.005f * 1.5f;
            float a = curve.Evaluate(t);
            img.color = new Color(0, 0, 0, a);
            yield return 0;
        }
        if (t <= 0)
        {
            img.gameObject.SetActive(false);
            img.color = new Color(0, 0, 0, 100);
        }
    }

    IEnumerator FadeOut()
    {
        float t = 0f;
        img.color = new Color(0, 0, 0, 0);
        while (t < 1f)
        {
            t += 0.005f * 1.5f;
            float a = curve.Evaluate(t);
            img.color = new Color(0, 0, 0, a);
            yield return 0;
        }
        if (t >= 0.5)
        {
            SceneManager.LoadScene(4);
        }
    }

    public void ActiveBlackPanel()
    {
        img.gameObject.SetActive(true);
        StartCoroutine(FadeOut());
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Вышел");
    }

    public void openURL(string strURL)
    {
        Application.OpenURL(strURL);
    }

    public void closePanelFinish()
    {
        panelFinish.SetActive(false);
        panelStart.SetActive(true);
        finishBool = false;
    }
}

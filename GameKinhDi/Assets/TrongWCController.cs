using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrongWCController : MonoBehaviour
{
    [SerializeField] GameObject ban_chan;
    [SerializeField] float time_delay;
    [SerializeField] float time_delay2;
    [SerializeField] int n;
    [SerializeField] GameObject menu;
    void Start()
    {
        ban_chan.SetActive(false);
        menu.SetActive(false);
        if (SettingController.item[1] == -1)
            SettingController.item[1] = 0;

    }
    private void Update()
    {
        if(time_delay > 0)
        {
            time_delay -= Time.deltaTime;
            if(time_delay <= 0)
                ban_chan.SetActive(true);
        }
        else
        {
            if(time_delay2 > 0) { 
                time_delay2 -= Time.deltaTime;
                if(time_delay2 <= 0)
                    ban_chan.SetActive(false);
            }

        }
    }
    public IEnumerator ClickCoroutine()
    {
        if (n > 0)
        {
            n--;
            ban_chan.SetActive(!ban_chan.activeSelf);
            yield return new WaitForSeconds(1f);
            Click();
        }
        else
        {
            menu.SetActive(true);
        }
    }

    public void Click()
    {
        StartCoroutine(ClickCoroutine());
    }
    public void RaNgoai()
    {
        SceneManager.LoadScene(SettingController.SCENE_VAO_PHONGWC[SettingController.lv]);
    }
}

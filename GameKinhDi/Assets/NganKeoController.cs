using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NganKeoController : MonoBehaviour
{
    public GameObject panel;
    public Sprite []items;
    public GameObject[] lItems;
    private void Start()
    {
        panel.SetActive(false);
        if(SettingController.lv == 2)
        {
            lItems[2].gameObject.SetActive(false);
            lItems[3].gameObject.SetActive(false);
        }
        else
        {
            lItems[0].gameObject.SetActive(false);
            lItems[1].gameObject.SetActive(false);
        }
    }
    public void RaNgoai()
    {
        Invoke("RaNgoai2", 1f);
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
            panel.SetActive(false);
    }
    void RaNgoai2()
    {
        SceneManager.LoadScene(SettingController.SCENE_TRONG_GV[1]);
    }
    public void NhatItem(int i)
    {
        SettingController.item[i + 2] = 1;
        panel.SetActive(true);
        panel.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = items[i];
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TrongTuController : MonoBehaviour
{
    [SerializeField] GameObject phan_dien;
    [SerializeField] GameObject menuGame;
    [SerializeField] GameObject[] camera;
    [SerializeField] float time;
    // Start is called before the first frame update
    void Start()
    {
        menuGame.SetActive(false);
        camera[PlayerPrefs.GetInt(SettingController.KEY_CAMERA_2, 0)].SetActive(true);
        camera[(PlayerPrefs.GetInt(SettingController.KEY_CAMERA_2, 0) + 1)%2].SetActive(false);
        if (SettingController.INDEX_BOSS == 1)
        {
            phan_dien.SetActive(true);
        }
        else
            phan_dien.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (phan_dien.activeSelf)
        {
            time -= Time.deltaTime;
            if(time < 0)
            {
                if(SettingController.INDEX_BOSS == -(SettingController.lv + 1))
                {
                    SettingController.INDEX_BOSS = (SettingController.lv + 1);
                    phan_dien.SetActive(false);
                }
            }
        }
    }
    public void RaNgoai()
    {
        AdioController.instance.Play(2);
        SceneManager.LoadScene(SettingController.SCENE_TRONG_LOP[SettingController.lv]);
    }
}

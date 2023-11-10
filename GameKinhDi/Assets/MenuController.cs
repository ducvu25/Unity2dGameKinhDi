using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public static void ChoiLai()
    {
        SettingController.Reset();
        SceneManager.LoadScene(SettingController.SCENE_HANH_LANG[SettingController.lv]);
    }
    public static void ThoatGame()
    {
        Application.Quit();
    }
    public static void Thoat()
    {
        SceneManager.LoadScene(SettingController.SCENE_MENU);
    }
}

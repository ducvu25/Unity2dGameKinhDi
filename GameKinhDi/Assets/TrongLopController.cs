using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrongLopController : MonoBehaviour
{
    GameObject player;
    [SerializeField] GameObject den_pin;
    [SerializeField] GameObject huong_dan;
    [SerializeField] GameObject boss;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag(SettingController.TAG_PLAYER);
    }
    // Start is called before the first frame update
    void Start()
    {
        boss.SetActive(false);
        SettingController.INDEX_BOSS = 0;
        if (((SettingController.lv == 0 && SettingController.item[0] == 1) || SettingController.lv >= 1) && (int)Random.Range(0, 2) == 1)
        {
            boss.SetActive(true);
            SettingController.INDEX_BOSS = 1;
        }
        huong_dan.SetActive(false);
        player.transform.position = SettingController.GetIndex(1); //new Vector3(SettingController.INDEX_PLAYER_2.x, SettingController.INDEX_PLAYER_2.y, SettingController.INDEX_PLAYER_2.z);
    }
    public void RaNgoai()
    {
        if (SettingController.INDEX_BOSS == (SettingController.lv + 1) && (int)Random.Range(0, 1) == 0)
            SettingController.INDEX_BOSS = -(SettingController.lv + 1);
        AdioController.instance.Play(2);
        StartCoroutine(LoadSceneAfterDelay(0.2f));
    }
    private IEnumerator LoadSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SettingController.SCENE_HANH_LANG[SettingController.lv]);
    }
    public void VaoTu(int type)
    {
        AdioController.instance.Play(2);
        PlayerPrefs.SetInt(SettingController.KEY_CAMERA_2, type);
        SettingController.SetIndexPlayer(1, new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z));
        SceneManager.LoadScene(SettingController.SCENE_TRONG_TU);
    }
    public void NhatDen()
    {
        SettingController.item[0] = 1;
        Destroy(den_pin);
        huong_dan.SetActive(true);
        Destroy(huong_dan, 2f);
        SettingController.INDEX_BOSS = -(SettingController.lv + 1);
        boss.SetActive(true);
    }
    public void MoNganKeo()
    {
        SettingController.SetIndexPlayer(1, new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z));
        SceneManager.LoadScene(SettingController.SCENE_TRONG_GV[0]);
    }
}

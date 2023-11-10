using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HanhLangController : MonoBehaviour
{
    GameObject player;
    [SerializeField] GameObject boss;
    [SerializeField] GameObject menuGame;
    [SerializeField] GameObject cua_khoa;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag(SettingController.TAG_PLAYER);
    }
    // Start is called before the first frame update
    void Start()
    {
        boss.SetActive(false);
        if (((SettingController.lv == 0 && SettingController.item[0] == 1) || SettingController.lv >= 1) && (int)Random.Range(0, 2) == 1)
        {
             boss.SetActive(true);
        }
            
        menuGame.SetActive(false);
        player.transform.position = SettingController.GetIndex(0);// new Vector3(SettingController.INDEX_PLAYER_1.x, SettingController.INDEX_PLAYER_1.y, SettingController.INDEX_PLAYER_1.z);
    }
    public void VaoLop()
    {
        AdioController.instance.Play(2);
        SettingController.SetIndexPlayer(0, new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z));
        StartCoroutine(LoadSceneAfterDelay(0.2f, 0));
    }

    private IEnumerator LoadSceneAfterDelay(float delay, int type)
    {
        yield return new WaitForSeconds(delay);
        switch (type)
        {
            case 0:
                SceneManager.LoadScene(SettingController.SCENE_TRONG_LOP[SettingController.lv]);
                break;
            case 1:
                SceneManager.LoadScene(SettingController.SCENE_TRONG_GV[SettingController.lv]);
                break;
            case 2:
                SceneManager.LoadScene(SettingController.SCENE_VAO_PHONGWC[SettingController.lv]);
                break;
        }
    }
    public void VaoPhongGV()
    {
        if (boss.activeSelf && (int)Random.Range(0, 2) == 1)
            SettingController.INDEX_BOSS = -SettingController.INDEX_BOSS;
        AdioController.instance.Play(2);
        SettingController.SetIndexPlayer(0, new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z));
        StartCoroutine(LoadSceneAfterDelay(0.2f, 1));
    }
    public void VaoNhaWC()
    {
        AdioController.instance.Play(2);
        SettingController.SetIndexPlayer(0, new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z));
        StartCoroutine(LoadSceneAfterDelay(0.2f, 2));
    }
    public void CamKhoa()
    {
        if (SettingController.item[1] == 1)
        {
            cua_khoa.GetComponent<Animator>().SetTrigger("On");
            Invoke("NextMap", 0.5f);
        }
    }
    void NextMap()
    {
        SettingController.INDEX_BOSS = Mathf.Abs((SettingController.lv + 2));
        SettingController.lv++;
        if(SettingController.lv == 3 && SettingController.item[2] == 1 && SettingController.item[3] == 1)
        {
            menuGame.SetActive(true);
            Invoke("Pause", 0.2f);
        }
        SettingController.item[1] = 0;
        SceneManager.LoadScene(SettingController.SCENE_HANH_LANG[SettingController.lv]);
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }
}

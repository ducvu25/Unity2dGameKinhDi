using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NhaVeSinhController : MonoBehaviour
{
    GameObject player;
    [SerializeField] GameObject chia_khoa;
    [SerializeField] GameObject huong_dan;
    [SerializeField] GameObject menuGame;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag(SettingController.TAG_PLAYER);
    }
    // Start is called before the first frame update
    void Start()
    {
        menuGame.SetActive(false);
        huong_dan.SetActive(false);
        if(SettingController.item[1] != 0)
            Destroy(chia_khoa);
        player.transform.position = SettingController.GetIndex(3);//new Vector3(SettingController.INDEX_PLAYER_3.x, SettingController.INDEX_PLAYER_3.y, SettingController.INDEX_PLAYER_3.z);
    }
    public void RaNgoai()
    {
        StartCoroutine(LoadSceneAfterDelay(0.2f));
    }
    private IEnumerator LoadSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SettingController.SCENE_HANH_LANG[SettingController.lv]);
    }
    public void VaoPhongWC()
    {
        SettingController.SetIndexPlayer(3, new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z));
        SceneManager.LoadScene(SettingController.SCENE_TRONG_WC[SettingController.lv]);
    }
    public void NhatChiaKhoa()
    {
        SettingController.item[1] = 1;
        Destroy(chia_khoa);
        huong_dan.SetActive(true);
        Destroy(huong_dan, 2f);
    }
}

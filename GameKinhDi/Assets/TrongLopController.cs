using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrongLopController : MonoBehaviour
{
    GameObject player;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag(SettingController.TAG_PLAYER);
    }
    // Start is called before the first frame update
    void Start()
    {
        player.transform.position = new Vector3(SettingController.INDEX_PLAYER_2.x, SettingController.INDEX_PLAYER_2.y, SettingController.INDEX_PLAYER_2.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RaNgoai()
    {
        SceneManager.LoadScene(SettingController.SCENE_HANH_LANG);
    }
    public void VaoTu()
    {
        SettingController.SetIndexPlayer(1, new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z));
        SceneManager.LoadScene(SettingController.SCENE_TRONG_TU);
    }
}

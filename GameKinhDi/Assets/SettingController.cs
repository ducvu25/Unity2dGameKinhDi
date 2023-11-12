using UnityEngine;
public static class SettingController 
{
    // Lv 1
    public static string[] SCENE_HANH_LANG = {"Hanh_Lang_1", "Hanh_Lang_2", "Hanh_Lang_3" };
    public static string []SCENE_TRONG_LOP = { "Trong_Lop_1", "Trong_Lop_2", "Trong_Lop_3" };
    public static string SCENE_TRONG_TU = "Trong_Tu";
    public static string []SCENE_TRONG_WC = { "Trong_WC_1", "Trong_WC_2", "Trong_WC_3" };
    public static string []SCENE_VAO_PHONGWC = { "Nha_WC_1", "Nha_WC_2", "Nha_WC_3" };
    public static string []SCENE_TRONG_GV = { "Ngan_Keo", "Phong GV_2", "Phong GV_3" };
    public static string SCENE_MENU = "Menu";
    public static string SCENE_END = "End";
    public static string TAG_PLAYER = "Player";
    public static string KEY_PHANDIEN_2 = "TANG_2";
    public static string KEY_CAMERA_2 = "CAMERA_2";
    public static int INDEX_BOSS = -2;
    public static Vector3[] INDEX_PLAYER_HANH_LANG = { new Vector3(-75.23f, 4.58f, 0), new Vector3(-75.23f, 4.58f, 0) , new Vector3(-75.23f, 4.58f, 0) };
    public static Vector3[] INDEX_PLAYER_TRONG_LOP = { new Vector3(-79.7871f, -7.768655f, 0), new Vector3(-79.7871f, -7.768655f, 0), new Vector3(-75.4f, -7.768655f, 0) };
    public static Vector3[] INDEX_PLAYER_TRONG_GV = { new Vector3(-79.7871f, -7.14f, 0), new Vector3(-79.7871f, -7.14f, 0), new Vector3(-79.7871f, -7.14f, 0) };
    public static Vector3[] INDEX_PLAYER_TRONG_WC = { new Vector3(-114.2f, -6.9f, 0), new Vector3(-114.2f, -6.9f, 0), new Vector3(-114.2f, -6.9f, 0) };
    public static int[] item = { 0, -1, 0, 0, 0, 0};
    public static int lv = 0;
    public static void SetIndexPlayer(int index, Vector3 player)
    {
        switch (index)
        {
            case 0:
                INDEX_PLAYER_HANH_LANG[lv] = player;
                break;
            case 1:
                INDEX_PLAYER_TRONG_LOP[lv] = player;
                break;
            case 2:
                INDEX_PLAYER_TRONG_GV[lv] = player;
                break;
            case 3:
                INDEX_PLAYER_TRONG_WC[lv] = player;
                break;
        }
    }
    public static void Reset()
    {
        INDEX_BOSS = 0;
        INDEX_PLAYER_HANH_LANG[0] = new Vector3(-75.23f, 4.58f, 0);
        INDEX_PLAYER_HANH_LANG[1] = new Vector3(-75.23f, 4.58f, 0);
        INDEX_PLAYER_HANH_LANG[2] = new Vector3(-75.23f, 4.58f, 0);
        INDEX_PLAYER_TRONG_LOP[0] = new Vector3(-79.7871f, -7.768655f, 0);
        INDEX_PLAYER_TRONG_LOP[1] = new Vector3(-79.7871f, -7.768655f, 0);
        INDEX_PLAYER_TRONG_LOP[2] = new Vector3(-79.7871f, -7.768655f, 0);
        INDEX_PLAYER_TRONG_GV[0] = new Vector3(-79.7871f, -7.14f, 0);
        INDEX_PLAYER_TRONG_GV[1] = new Vector3(-79.7871f, -7.14f, 0);
        INDEX_PLAYER_TRONG_GV[2] = new Vector3(-79.7871f, -7.14f, 0);
        item[0] = 0;
        item[1] = 0;
        item[2] = 0;
        item[3] = 0;
        item[4] = 0;
        item[5] = 0;    
        Time.timeScale = 1;
        lv = 0;
    }
    public static Vector3 GetIndex(int type)
    {
        switch (type)
        {
            case 0:
                {
                    return INDEX_PLAYER_HANH_LANG[lv];
                }
            case 1:
                {
                    return INDEX_PLAYER_TRONG_LOP[lv];
                }
            case 2:
                {
                    return INDEX_PLAYER_TRONG_GV[lv];
                }
            case 3:
                {
                    return INDEX_PLAYER_TRONG_WC[lv];
                }
        }
        return Vector3.one;
    }
}

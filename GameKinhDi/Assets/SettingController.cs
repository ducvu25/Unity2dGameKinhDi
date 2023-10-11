using UnityEngine;
public static class SettingController 
{
    public static string SCENE_HANH_LANG = "Hanh_Lang";
    public static string SCENE_TRONG_LOP = "Trong_Lop";
    public static string SCENE_TRONG_TU = "Trong_Tu";
    public static string TAG_PLAYER = "Player";
    public static Vector3 INDEX_PLAYER_1 = new Vector3(-75.6605f, 3.452f, 0);
    public static Vector3 INDEX_PLAYER_2 = new Vector3(-77.7146f, -7.8289f, 0);

    public static void SetIndexPlayer(int index, Vector3 player)
    {
        switch (index)
        {
            case 0:
                INDEX_PLAYER_1 = player;
                break;
            case 1:
                INDEX_PLAYER_2 = player;
                break;
        }
    }
}

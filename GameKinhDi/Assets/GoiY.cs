using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoiY : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == SettingController.TAG_PLAYER)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == SettingController.TAG_PLAYER)
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}

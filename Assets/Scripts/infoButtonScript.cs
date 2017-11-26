using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class infoButtonScript : MonoBehaviour {


    public Text accidentsInfo;
    public GameObject PanelManager;
    public void OnClick()
    {
        PanelManager.gameObject.SetActive(false);
        accidentsInfo.text = "";
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using jsonclass;
using LitJson;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public int bagnumber;
    private SystemData SysDataList = null;
    private RoleData RoleDataList = null;
    public List<List<int>> array1 = new List<List<int>>();
    public List<int> type0, type21,  type70= new List<int>();

    public void ReloadJsonData()
    {
        string sysJsontxt = ((TextAsset)Resources.Load("systemData")).text;
        string roleJsontxt = ((TextAsset)Resources.Load("roleData")).text;
        SysDataList = JsonMapper.ToObject<SystemData>(sysJsontxt);
        RoleDataList = JsonMapper.ToObject<RoleData>(roleJsontxt);
    }

    void Typeuncode()
    {
        foreach (var item in SysDataList.itemList)
        {
            type0.Add(item.type);
        }

        for (int i = 0; i <= type0.Count - 1; i++)
        {
            if (type0[i] == 21)
                type21.Add(i);
            if(type0[i] == 70)
                type70.Add(i);
        }
    }

    private void LoadiConandText()
    {
        this.GetComponentInChildren<Text>().text = string.Format("{0}", RoleDataList.ItemList[bagnumber - 1].count);
        string spriteaddress = string.Format("icons/{0}", SysDataList.itemList[bagnumber - 1].resid);
        this.GetComponent<Image>().sprite = Resources.Load<Sprite>(spriteaddress.Replace(".jpg", ""));
    }

    public void WhenBottonhit()
    {
        GameObject.FindWithTag("intro").GetComponentInChildren<Text>().text = SysDataList.itemList[bagnumber - 1].intro;
        GameObject.FindWithTag("nametxt").GetComponent<Text>().text = SysDataList.itemList[bagnumber - 1].name;
    }
    // Use this for initialization

    void Start ()
    {
        ReloadJsonData();
        Typeuncode();
        LoadiConandText();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

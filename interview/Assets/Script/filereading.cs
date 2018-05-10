using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using jsonclass;
using LitJson;
using System.Text;
using System.IO;


public class filereading : MonoBehaviour
{
    public SystemData SysDataList = null;
    public RoleData RoleDataList = null;

    private void ReloadJsonData()
    {
        string sysJsontxt = ((TextAsset)Resources.Load("systemData")).text;
        string roleJsontxt = ((TextAsset)Resources.Load("roleData")).text;
        SysDataList = JsonMapper.ToObject<SystemData>(sysJsontxt);
        RoleDataList = JsonMapper.ToObject<RoleData>(roleJsontxt);
    }

    private void DisplaySystemData(SystemData systemData)
    {
        if (systemData == null) return;

        foreach (var systemItem in systemData.itemList)  {
            Debug.Log("Id" + systemItem.id +"\n"
               + "name" + systemItem.name);
        }
    }

    private void DisplayRoleData(RoleData roleData)
    {
        if (roleData == null) return;

        foreach (var roleItem in roleData.ItemList)
        {
            Debug.Log("Id" + roleItem.itemsn + "\n"
                      + "count" + roleItem.count);
        }
    }
    void Start()
    {
        ReloadJsonData();
        //DisplaySystemData(SysDataList);
        //DisplayRoleData(RoleDataList);

    }
}

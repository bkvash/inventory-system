using System;
using System.Collections.Generic;

namespace jsonclass {

    //玩家数据
    [Serializable]
    public class RoleData {
        //玩家的所有道具
        public List<RoleItem> ItemList;

    }


    //玩家的一个道具
    [Serializable]
    public class RoleItem {
        //道具的系统id 对应 SystemItem 的id属性
        public int itemsn;

        //道具的数量
        public int count;

    }


}
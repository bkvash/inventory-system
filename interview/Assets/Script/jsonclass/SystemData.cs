using System;
using System.Collections.Generic;

namespace jsonclass {

    //所有的策划数据
    [Serializable]
    public class SystemData {
        //游戏所有道具
        public List<SystemItem> itemList;

    }


    [Serializable]
    public class SystemItem {

        //唯一标识 
        public int id = default(int);

        //道具名称
        public string name = "";

        //道具的图标资源 对应Resources.icons目录里的图片
        public string resid = "";

        public int quality = default(int);

        //道具的类型
        public int type = default(int);

        //说明
        public string intro = "";

    }


}

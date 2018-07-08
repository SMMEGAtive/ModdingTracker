using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModdingTracker
{
    //Defining the Object Type of Modding Data
    class ModData
    {
        string _Title; //Title of the map, obv
        string _Artist; //Artist of the map
        DateTime _Date; //Date the mod are done
        string _Link; //The link to the post
        int _Type; //Type of the mod    1-Regular Mod   2-Bubble Mod    3-Qualify Mod   4-Popped
    }
}

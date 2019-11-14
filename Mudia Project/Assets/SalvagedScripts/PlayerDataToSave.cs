using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PlayerDataToSave
{
    //Data....Get from Game
    
    public int level;
   
    public float maxHealth;
    public float curHealth;
    public float posx, posy, posz;
    public float rotx, roty, rotz, rotw;

    public static int saveSlot;

    public PlayerDataToSave(PlayerHandler player)
    {

        level = 0;


        posx = player.transform.position.x;
        posy = player.transform.position.y;
        posz = player.transform.position.z;

        rotx = player.transform.rotation.x;
        roty = player.transform.rotation.y;
        rotz = player.transform.rotation.z;
        rotw = player.transform.rotation.w;
    }   

}
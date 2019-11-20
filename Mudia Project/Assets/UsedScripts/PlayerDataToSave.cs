using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PlayerDataToSave
{
    //Data....Get from Game
    public string playerName;
    public int level;
    public string checkPoint;
    public float maxHealth, maxMana, maxStamina;
    public float curHealth, curMana, curStamina;
    public float posx, posy, posz;
    public float rotx, roty, rotz, rotw;

    public static int saveSlot;
    public int[] stats = new int[6];
    public int classIndex;
    public int raceIndex;
    public int skinIndex, eyesIndex, mouthIndex, hairIndex, clothesIndex, armourIndex;
    public PlayerDataToSave(PlayerHandler player)
    {
        
        level = 0;
        if (player.curCheckPoint != null)
        {
            checkPoint = player.curCheckPoint.name;
            posx = player.transform.position.x;
            posy = player.transform.position.y;
            posz = player.transform.position.z;

            rotx = player.transform.rotation.x;
            roty = player.transform.rotation.y;
            rotz = player.transform.rotation.z;
            rotw = player.transform.rotation.w;
        }
        else
        {
            
            posx = 0;
            posy = 0;
            posz = 0;
        }
        maxHealth = player.maxHealth;
       

        curHealth = player.curHealth;
        

        
    }

}

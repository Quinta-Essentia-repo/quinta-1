using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
	This component is derived from CharacterStats. It adds two things:
		- Gaining modifiers when equipping items
		- Restarting the game when dying
*/

public class PlayerStats : CharacterStats
{
    public PlayerHandler handler;
    // Use this for initialization
    public override void Start()
    {

        base.Start();
        EquipmentManager.instance.onEquipmentChanged += OnEquipmentChanged;
        maxHealth = handler.maxHealth;
    }

    void OnEquipmentChanged(Equipment newItem, Equipment oldItem)
    {
        if (newItem != null)
        {
            armor += newItem.armorModifier;
            damage += newItem.damageModifier;
        }

        if (oldItem != null)
        {
            armor -= oldItem.armorModifier;
            damage -= oldItem.armorModifier;
        }

    }



}
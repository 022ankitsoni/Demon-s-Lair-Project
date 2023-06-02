using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int Health;
    public string Weapon;
    public float Ammo;
    public int Score;

    public PlayerData ()
    {
        Health = SaveScript.HealthAmt;
        Weapon = SaveScript.WeaponName;
        Ammo = SaveScript.AmmoAmt;
        Score = SaveScript.Score;
    }
}

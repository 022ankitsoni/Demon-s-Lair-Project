using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossRoom : MonoBehaviour
{
    [SerializeField] GameObject Boss;     //for storing boss to activate the boss when player enters the room
    [SerializeField] GameObject BossHB;   //for activating the healthbar
   // [SerializeField] GameObject FinalMinions;   //for final minion wave

    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.CompareTag("Player"))
        {
            Boss.gameObject.SetActive(true);     //to activate the boss
            BossHB.gameObject.SetActive(true);   //to activate the healthBar
        //    FinalMinions.gameObject.SetActive(true);    //to activate the final wave of minion or to stop the new wave of minions
        }

    }

    private void Update()
    {
        if (SaveScript.PlayerDead == true)
        {
            BossHB.gameObject.SetActive(false);   //to deactivate the healthBar
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : Repeater
{
    [SerializeField] private Goblin King;
    [SerializeField] private Mercenary Enemy;
    private void Start()
    {
        Strike();
        Damage_system(King.Attack);
        Strike();
        Damage_system(Enemy.Attack);
    }

    /*private void Start()
    {
        Strike();
        Damage_system(Enemy.Attack);
    }*/

    protected override void Strike()
    {
        Debug.Log("Hit!");
    }

    public void Damage_system(int dmg)
    {
        Debug.Log("Player2 Current HP: " + Health);
        Health -= dmg;
        Debug.Log("Player2 HP: " + Health);
        Debug.Log(" ");
        Debug.Log(" ");
    }
}

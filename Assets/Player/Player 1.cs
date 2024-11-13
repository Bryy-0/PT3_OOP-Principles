using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : Repeater, Damage_System
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
        Debug.Log("Player1 Current HP: " + Health);
        Health -= dmg;
        Debug.Log("Player1 HP: " + Health);
        Debug.Log("");
    }
}

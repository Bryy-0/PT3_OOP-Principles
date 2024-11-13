using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Repeater2, Damage_System
{
    [SerializeField] private Player1 Sword;
    [SerializeField] private Player2 Archer;
    private void Start()
    {
        Strike();
        Damage_system(Sword.Attack);
        Damage_system(Archer.Attack);

    }

    protected override void Strike()
    {
        Debug.Log("Hit!");
    }

    public void Damage_system(int dmg)
    {
        Debug.Log("Goblin Current HP: " + Health);
        Health -= dmg;
        Debug.Log("Goblin HP: " + Health);
        Debug.Log(" ");
        Debug.Log(" ");
    }
}

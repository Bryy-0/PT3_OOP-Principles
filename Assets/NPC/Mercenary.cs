using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercenary : Repeater2
{
    [SerializeField] private Player1 Sword;
    [SerializeField] private Player2 Archer;
    private void Start()
    {
        Strike();
        Damage_system(Sword.Attack);
        Strike();
        Damage_system(Archer.Attack);

    }

    protected override void Strike()
    {
        Debug.Log("Hit!");
    }

    public void Damage_system(int dmg)
    {
        Debug.Log("Mercenary Current HP: " + Health);
        Health -= dmg;
        Debug.Log("Mercenary HP: " + Health);
        Debug.Log(" ");
        Debug.Log(" ");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Repeater2 : MonoBehaviour
{
    protected int Health = 100;
    [SerializeField] protected int Mana;
    [SerializeField] protected int Defence;
    [SerializeField] protected int Speed;
    public int Attack;

    protected abstract void Strike();
}

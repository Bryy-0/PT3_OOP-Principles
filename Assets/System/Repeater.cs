using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Repeater : MonoBehaviour
{
    public int Health = 150;
    [SerializeField] protected int Mana;
    [SerializeField] protected int Defence;
    [SerializeField] protected int Speed;
    [SerializeField] protected int Luck;
    public int Attack;

    protected abstract void Strike();
}

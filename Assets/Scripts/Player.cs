using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    public void Healing(int health)
    {
        _health += health;
    }
}

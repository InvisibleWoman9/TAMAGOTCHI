using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{

    public Tamagotchi Pompote = new Tamagotchi(30, 10, 10, 10);
    
    void Start()
    {
        
    }

    //[ContextMenu("Damage")]
    //public void Damage();
    
    void Update()
    {
        if(Pompote.IsDead)
        {
            Debug.Log("The Character is Dead !");
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            Eat();
        }
    }


    void Eat()
    {
        Pompote.Hunger --;
        Debug.Log("Hunger =   " + Pompote.Hunger);
    }


}


public class Tamagotchi
{
    public bool IsDead { get; private set; }
    private int _health;

    private int _hunger;
    private int _sleep;
    private int _joy;

    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
            if(_health <= 0)
            {
                IsDead = true;
                _health = 0;
            }
        }

    }

    public int Hunger
    {
        get
        {
            return _hunger;
        }
        set
        {
            _hunger = value;
            if(_hunger <= 0)
            {
                IsDead = true;
                _health = 0;
            }

            
        }
    }

    public int Sleep
    {
        get
        {
            return _sleep;
        }
        set
        {
            _sleep = value;
            if(_sleep <= 0)
            {
                IsDead = true;
                _health = 0;
            }

            
            
        }
    }

    public int Joy
    {
        get
        {
            return _joy;
        }
        set
        {
            _joy = value;
            if(_joy <= 0)
            {
                IsDead = true;
                _health = 0;
            }

            
        }
    }

    public Tamagotchi(int health, int hunger, int sleep, int joy) 
    {
        _health = health;
        _hunger = hunger;
        _sleep = sleep;
        _joy = joy;
    }

    





}

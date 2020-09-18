using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{

    public Tamagotchi Pompote = new Tamagotchi(30, 10, 10, 10);
    
    void Start()
    {
        
    }

    
    
    void Update()
    {
        if(Pompote.IsDead)
        {
            Debug.Log("The Character is Dead !");
        }

        //Quand j'appuies sur A, la valeur de Hunger diminue de 1
        if(Input.GetKeyDown(KeyCode.A))
        {
            OneDamageTest();
        }
        //Quand j'appuies sur B, la valeur de Sleep diminue de 1
        if(Input.GetKeyDown(KeyCode.B))
        {
            TwoDamageTest();
        }
        //Quand j'appuies sur C, la valeur de Joy diminue de 1
        if(Input.GetKeyDown(KeyCode.C))
        {
            ThreeDamageTest();
        }
        //Quand j'appuies sur Q, la valeur de Hunger se met à 10
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Eat();
        }
        //Quand j'appuies sur Z, la valeur de Sleep se met à 10
        if(Input.GetKeyDown(KeyCode.Z))
        {
            Sleep();
        }
        //Quand j'appuies sur D, la valeur de Joy se met à 10
        if(Input.GetKeyDown(KeyCode.D))
        {
            Joy();
        }
        
    }

    //TEST de damage
    void OneDamageTest()
    {        
        Pompote.Hunger --;
        Debug.Log("Hunger =   " + Pompote.Hunger);
    }

    void TwoDamageTest()
    {        
        Pompote.Sleep --;
        Debug.Log("Sleep =   " + Pompote.Sleep);
    }

    void ThreeDamageTest()
    {        
        Pompote.Joy --;
        Debug.Log("Joy =   " + Pompote.Joy);
    }
    //TESTS de damage

    //Fonction Manger
    void Eat()
    {
        //Remettre la valeur initiale, reset hunger (je ne sais pas encore comment faire);
        Pompote.Hunger = 10 ;
        Debug.Log("Hunger =   " + Pompote.Hunger);
    }

    //Fonction Dormir
    void Sleep()
    {
        //Remettre la valeur initiale, reset sleep (je ne sais pas encore comment faire);
        Pompote.Sleep = 10;
        Debug.Log("Sleep =   " + Pompote.Sleep);
    }

    //Fonction de Joie
    void Joy()
    {
        //Remettre la valeur initiale, reset joy (je ne sais pas encore comment faire);
        Pompote.Joy = 10;
        Debug.Log("Joy =   " + Pompote.Joy);
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

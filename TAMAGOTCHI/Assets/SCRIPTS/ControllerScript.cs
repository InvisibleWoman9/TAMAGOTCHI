using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{

    public Tamagotchi Smoggles = new Tamagotchi(30, 10, 10, 10);
    float Timer;
    
    void Start()
    {
        
    }

    void TourDejeu()
    {

    }
    
    void Update()
    {
        if(Smoggles.IsDead)
        {
            Debug.Log("The Character is Dead !");
        }
        else
        {
            Smoggles.Hunger -= Time.deltaTime/60f;
            Smoggles.Sleep -= Time.deltaTime/120f;
            Smoggles.Joy -= Time.deltaTime/180f;

            
        }
        

        


        
        //Quand j'appuies sur Q, la valeur de Hunger se met à 10
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Eat();
        }
        //Quand j'appuies sur Z, la valeur de Sleep se met à 10
        if(Input.GetKeyDown(KeyCode.D))
        {
            Sleep();
        }
        //Quand j'appuies sur D, la valeur de Joy se met à 10
        if(Input.GetKeyDown(KeyCode.Z))
        {
            Joy();
        }

        
    }//FIN UPDATE

    

    //Il faut que j'affiche quand il mange le sprite de quand il mange aussi 

    //Fonction Manger
    void Eat()
    {
        
        Smoggles.Hunger = 10 ;
        Smoggles.Joy ++;
        Smoggles.Sleep ++;
        Debug.Log("Hunger =   " + Smoggles.Hunger);
    }

    //Fonction Dormir
    void Sleep()
    {
        
        Smoggles.Sleep = 10;
        Smoggles.Joy ++;
        Smoggles.Hunger -= 2f;
        Debug.Log("Sleep =   " + Smoggles.Sleep);
    }

    //Fonction de Joie
    void Joy()
    {
        
        Smoggles.Joy = 10;
        Smoggles.Sleep ++;
        Debug.Log("Joy =   " + Smoggles.Joy);
    }


}



public class Tamagotchi
{
    public bool IsDead { get; private set; }
    private float _health;

    private float _hunger;
    private float _sleep;
    private float _joy;

    public float Health
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

    public float Hunger
    {
        get
        {
            return _hunger;
        }
        set
        {
            _hunger = value;
            _hunger = Mathf.Clamp(value,0,10f);  
            if(_hunger <= 0)
            {
                IsDead = true;
                _health = 0;
            }
            
            
        }
    }

    public float Sleep
    {
        get
        {
            return _sleep;
        }
        set
        {
            _sleep = value;
            _sleep = Mathf.Clamp(value,0,10f);
            if(_sleep <= 0)
            {
                IsDead = true;
                _health = 0;
            }

            
            
        }
    }

    public float Joy
    {
        get
        {
            return _joy;
        }
        set
        {
            _joy = value;
            _joy = Mathf.Clamp(value,0,10f);
            if(_joy <= 0)
            {
                IsDead = true;
                _health = 0;
            }

            
        }
    }

    public Tamagotchi(float health, float hunger, float sleep, float joy) 
    {
        _health = health;
        _hunger = hunger;
        _sleep = sleep;
        _joy = joy;
    }
    
    





}

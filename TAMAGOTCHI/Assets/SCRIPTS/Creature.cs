using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    [Range(0,100f)][SerializeField]private float _hunger, _health, _weight, _sleep;
    [SerializeField]private bool awake;
    
    public float Hunger
    {
        get
        {
            return _hunger;
        }

        set
        {
            
            _hunger = value;
            _hunger = Mathf.Clamp(value,0,100f);
        }
    }

    public float Health
    {
        get
        {
            return _health;
        }

        set
        {
            
            _health = value;
            _health = Mathf.Clamp(value,0,100f);
        }
    }

    public float Weight
    {
        get
        {
            return _weight;
        }

        set
        {
            
            _weight = value;
            _weight = Mathf.Clamp(value,0,100f);
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
            _sleep = Mathf.Clamp(value,0,100f);
        }
    }

    [Range(0,10f)]public float gameSpeed = 1;


    void Start()
    {
        Load();
    }


    void Update()
    {
        GetInputs();

        if (awake)
        {
            Sleep -= gameSpeed * 0.5f * Time.deltaTime;
        }
        else
        {
            Sleep += gameSpeed * 2f * Time.deltaTime;
            if (Hunger<50f) Clean();
        }

        Hunger += gameSpeed * Time.deltaTime;

        if (Hunger > 90f)
        {
            Health -= gameSpeed * 0.5f * Time.deltaTime;
        }

    }


    void GetInputs()
    {
        if (Input.GetKeyDown(KeyCode.S)) GoSleep();
        if (Input.GetKeyDown(KeyCode.F)) Feed();
        if (Input.GetKeyDown(KeyCode.C)) Clean();
        if (Input.GetKeyDown(KeyCode.W)) WakeUp();  
    }


    void WakeUp()
    {
        if (awake) return;
        Debug.Log("Waking Up");
        awake = true;
    }

    void GoSleep()
    {
        if (awake==false) return;
        Debug.Log("Going to Sleep");
        awake = false;
    }


    void Feed()
    {
        if (awake==false) return;
        Debug.Log("Feeding");
        Hunger -= 30f;
    }


    void Clean()
    {
        if (awake==false) return;
        Debug.Log("Cleaning");
        Health += 10f;
    }





    void Save()
    {
        PlayerPrefs.SetFloat("hunger",Hunger);
        PlayerPrefs.SetFloat("health",Health);
        PlayerPrefs.SetFloat("weight",Weight);
        PlayerPrefs.SetFloat("sleep",Sleep);
    }


    void Load()
    {
        if (PlayerPrefs.HasKey("hunger"))
        {
            Hunger = PlayerPrefs.GetFloat("hunger");
            Health = PlayerPrefs.GetFloat("health");
            Weight = PlayerPrefs.GetFloat("weight");
            Sleep = PlayerPrefs.GetFloat("sleep");
        }
        else Birth();
    }


    void Birth()
    {
        Debug.Log("Your Creature is born!");
        Hunger = 10f;
        Health = 100f;
        Weight = 1f;
        Sleep = 100f;
        Save();
    }




}



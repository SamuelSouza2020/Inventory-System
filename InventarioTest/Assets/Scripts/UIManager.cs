using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    //py = player
    public int pyLife, pyMoney, pyPower, pyShild;

    public static UIManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        //SceneManager.sceneLoaded += Carrega;
    }
    void Start()
    {
        pyLife = 10;
        pyMoney = 10;
        pyPower = 10;
        pyShild = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

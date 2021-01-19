using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class healthboss : MonoBehaviour
{
    public int enemyMaxHealth;
    public int enemycurrenthealth;


    void Start()
    {
        enemycurrenthealth = enemyMaxHealth;
    }


    void Update()
    {
        if (enemycurrenthealth <= 0)
        {
            SceneManager.LoadScene(11);
        }
    }

    public void hurtenemy(int damagetogive1)
    {
        enemycurrenthealth -= damagetogive1;
    }

    public void setmaxhealth()
    {
        enemycurrenthealth = enemyMaxHealth;
    }


}

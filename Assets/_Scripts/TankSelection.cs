using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    public TankSpawner tankSpawner;

    public void BlueTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.Blue);
        this.gameObject.SetActive(false);
    }

    public void GreenTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.Green);
        this.gameObject.SetActive(false);
    }

    public void RedTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.Red);
        this.gameObject.SetActive(false);
    }
}
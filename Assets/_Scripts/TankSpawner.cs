using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;
        public TankTypes tankType;
        public Material color;
    }

    public List<Tank> tankList;

    [SerializeField] private TankView tankView;


    public void CreateTank(TankTypes tankType)
    {
        if (tankType == TankTypes.Green)
        {
            TankModel tankModel = new TankModel(tankList[0].movementSpeed, tankList[0].rotationSpeed, tankList[0].tankType, tankList[0].color);
            TankController tankController = new TankController(tankView, tankModel);
        }
        else if (tankType == TankTypes.Blue)
        {
            TankModel tankModel = new TankModel(tankList[1].movementSpeed, tankList[1].rotationSpeed, tankList[1].tankType, tankList[1].color);
            TankController tankController = new TankController(tankView, tankModel);
        }
        else if (tankType == TankTypes.Red)
        {
            TankModel tankModel = new TankModel(tankList[2].movementSpeed, tankList[2].rotationSpeed, tankList[2].tankType, tankList[2].color);
            TankController tankController = new TankController(tankView, tankModel);
        }
    }
}
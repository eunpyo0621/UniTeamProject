using Engin;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Conveyor : MonoBehaviour
{
    const short MAX_ARR_SIZE = 5;
    [SerializeField] Vector3[] conveyorPos = new Vector3[5];
    [SerializeField] Soul[] soulConveyor = new Soul[5];
    [SerializeField] Soul[] soulStack = new Soul[10];

    private void Awake()
    {
        for(int i = 0;i<MAX_ARR_SIZE*2;i++)
        {
            soulStack[i] = new Soul(Random.Range(1, 10));
        }
    }
    void Update()
    {
        
    }
    void Check(Soul[] soulArr)
    {
        for(int i = 0;i<MAX_ARR_SIZE;i++)
        {

        }
    }
    void Plus(Soul[] soulArr)
    {
        for (int i = 0; i < MAX_ARR_SIZE * 2; i++)
        {

        }
    }
}

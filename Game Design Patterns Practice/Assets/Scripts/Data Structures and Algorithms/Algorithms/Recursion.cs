using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recursion : MonoBehaviour
{
   private void Start()
   {
      //CalculateIterative(4);
      //CalculateRecursive(4);
      //CalculateHeadRecursion(4);
      CalculateTreeRecursion(3);
   }

   public void CalculateIterative(int n)
   {
      while(n > 0 )
      {
         int k = n * n;
         Debug.Log(k);
         n = n - 1;
      }
   }
   public void CalculateTailRecursive(int n)
   {
      if(n > 0 )
      {
         int k = n * n;
         Debug.Log(k);
         CalculateTailRecursive(n - 1);
      }
   }
   
   public void CalculateHeadRecursion(int n)
   {
      if(n > 0 )
      {
         CalculateHeadRecursion(n - 1); //same as normal recursion, just recursed before the calculation
         int k = n * n;
         Debug.Log(k);
      }
   }
   
   public void CalculateTreeRecursion(int n)
   {
      if(n > 0 )
      {
         CalculateTreeRecursion(n - 1);
         int k = n * n;
         Debug.Log(k);
         CalculateTreeRecursion(n - 1);
      }
   }
}

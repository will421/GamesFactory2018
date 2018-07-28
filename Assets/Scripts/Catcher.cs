using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catcher : MonoBehaviour
{

  public int goalCount = 7;
  private int count = 0;

  public delegate void AllCatched();
  public static event AllCatched OnAllCatched;

  void OnTriggerEnter2D(Collider2D col)
  {
    if (col.tag == "collectable")
    {
      Destroy(col.gameObject);
      //todo sound
      count++;
      if (count == goalCount)
      {
        OnAllCatched();
      }
    }
  }

}

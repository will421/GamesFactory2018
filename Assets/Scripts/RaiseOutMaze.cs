using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseOutMaze : MonoBehaviour {

		public delegate void OutMaze();
    public static event OutMaze OnOutMaze;

  void OnTriggerEnter2D(Collider2D col)
  {
		OnOutMaze();
  }

  public static void emit(){
    OnOutMaze();
  }
}

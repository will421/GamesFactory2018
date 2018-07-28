using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{

  public GameObject nextLevel;
  void Start()
  {
    RaiseOutMaze.OnOutMaze += GoToNextLevel;
    Catcher.OnAllCatched += GoToNextLevel;
  }

  void OnDisable()
  {
    RaiseOutMaze.OnOutMaze -= GoToNextLevel;
    Catcher.OnAllCatched -= GoToNextLevel;
  }

  public void GoToNextLevel(){
    gameObject.GetComponent<LevelController>().Leave();
    GameObject newLevel = Instantiate(nextLevel, Vector3.zero, Quaternion.identity);
    newLevel.GetComponent<LevelController>().Spawn();
  }

}

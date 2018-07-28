using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{

  public float leaveScalePerSec = 1;

  public float startScalePerSec = 5;
  public float leaveScale = 0.01f;
  public float startScale = 10f;

  bool startAnimationInProgress = false;
  bool leaveAnimationInProgress = false;
  float currentScale;

  void Update()
  {
    if (leaveAnimationInProgress)
    {
      currentScale -= leaveScalePerSec * Time.deltaTime;
      currentScale = Mathf.Max(currentScale, leaveScale);
      if (currentScale == leaveScale)
      {
        leaveAnimationInProgress = false;
      }
      UpdateScale();
    }
    else if (startAnimationInProgress)
    {
      currentScale -= startScalePerSec * Time.deltaTime;
      currentScale = Mathf.Max(currentScale, 1);
      if (currentScale == 1)
      {
        startAnimationInProgress = false;
				transform.Find("player").gameObject.SetActive(true);
      }
      UpdateScale();
    }
  }

  public void Leave()
  {
		transform.Find("player").gameObject.SetActive(false);
    leaveAnimationInProgress = true;
    currentScale = 1f;
  }

  public void Spawn()
  {
		transform.Find("player").gameObject.SetActive(false);
    startAnimationInProgress = true;
    currentScale = startScale;
    UpdateScale();
  }

  void UpdateScale()
  {
    transform.localScale = Vector3.one * currentScale;
  }
}

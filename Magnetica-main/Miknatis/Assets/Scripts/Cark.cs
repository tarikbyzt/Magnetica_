using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Cark : MonoBehaviour
{
    public bool right=true,finish=false;
    public float slideSpeed;
    public float multipleX;
    public GameObject nextButton;
    bool deger;
    public RectTransform rect;

    private void Start()
    {
        deger = true;
        rect = GetComponent<RectTransform>();
        
    }
    private void Update()
    {
        
        if (finish)
        {
            Debug.Log("MultipleX= " + multipleX);
        }
        if (LevelController.Current.finishMenu.activeSelf)
        {
            StartCoroutine(FinishTouch());
        }
        if (right)
        {
            Vector3 newPosition = new Vector3(rect.localPosition.x+slideSpeed*Time.deltaTime, rect.localPosition.y, rect.localPosition.z);
            rect.localPosition = newPosition;
        }
        if (rect.localPosition.x >= 340)
        {
            right = false;
        }
        if (rect.localPosition.x <= -371f)
        {
            right = true;
        }
        if (!right)
        {
            Vector3 newPosition = new Vector3(rect.localPosition.x - slideSpeed * Time.deltaTime, rect.localPosition.y, rect.localPosition.z);
            rect.localPosition = newPosition;
        }

        if (slideSpeed==0&&deger)
        {
            
            LevelController.Current.ChangeMultiplicationScore(multipleX);
            deger = false;
        }


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("triggering");
        if (other.gameObject.CompareTag("X2"))
        {
            float sanalScore = LevelController.Current.score;
            multipleX = 2;
            sanalScore *= multipleX;
            LevelController.Current.finishScoreText.text=sanalScore.ToString();
        }
        if (other.gameObject.CompareTag("X3"))
        {
            float sanalScore = LevelController.Current.score;
            multipleX = 3;
            sanalScore *= multipleX;
            LevelController.Current.finishScoreText.text = sanalScore.ToString();
        }
        if (other.gameObject.CompareTag("X4"))
        {
            float sanalScore = LevelController.Current.score;
            multipleX = 4;
            sanalScore *= multipleX;
            LevelController.Current.finishScoreText.text = sanalScore.ToString();
        }
    }
    IEnumerator FinishTouch()
    {
        yield return new WaitForSeconds(1f);
        if (Input.touchCount == 1)
        {
            
            finish = true;
            slideSpeed = 0;
            nextButton.SetActive(true);
        }
    }

}

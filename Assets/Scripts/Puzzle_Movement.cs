using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_Movement : MonoBehaviour
{
    public bool moving;

    private float startPosX;
    private float startPosY;

    public GameObject correctForm;
    private Vector3 resetPosition;

    private bool finish;

    public AudioSource PuzzleSound;
    public AudioSource ClickSound;


    // Initialize puzzle
    void Start()
    {
        resetPosition = this.transform.localPosition;
        finish = false;
    }

    // Move pieces while they aren't at their final position
    void Update()
    {
        if(!finish)
        {
             if(moving)
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);
                this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
            }
        }

    }

    // Move peices with mouse
    private void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            moving = true; 

            ClickSound.Play();

        }
    }

    // Reset pieces on mouse up 
    private void OnMouseUp()
    {
        moving = false;

            if(Mathf.Abs(this.transform.localPosition.x - correctForm.transform.localPosition.x)<= 1f &&
            Mathf.Abs(this.transform.localPosition.y - correctForm.transform.localPosition.y)<= 1f)
        {
            this.transform.position = new Vector3(correctForm.transform.position.x, correctForm.transform.position.y, correctForm.transform.position.z);
            finish = true;
            PuzzleSound.Play();

            GameObject.Find("PointsHandler").GetComponent<Win_Script>().AddPoint();
        }
        else
        {
            this.transform.localPosition = new Vector3 (resetPosition.x, resetPosition.y, resetPosition.z);
        }

    }


}

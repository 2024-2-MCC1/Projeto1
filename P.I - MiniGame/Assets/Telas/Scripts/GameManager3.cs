using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager3 : MonoBehaviour
{
    [SerializeField] private Sprite bgImage;

   public List<Button> btns = new List<Button>();
    // Start is called before the first frame update
    void Start()
    {
        GetButtons();
    }

    // Update is called once per frame
    void GetButtons()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("puzzleBtn");
        for (int i = 0; i < objects.Length; i++)
        {
            btns.Add(objects[i].GetComponent<Button>());
            btns[i].image.sprite = bgImage;
        }
        void AssListeners()
        {
            foreach (Button btn in btns) {
                btn.onClick.AddListener(() => PickPuzzle());
            }

        }
    }
    public void PickPuzzle() {
        print("Hey");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class QuizManager : MonoBehaviour
{
    public GameObject Nilai0, Nilai1, Nilai2, Nilai3, Nilai4, Nilai5, Nilai6, Nilai7, Nilai8;
    public RectTransform MenuPetunjuk, MenuSoal1, MenuSoal2, MenuSoal3, MenuSoal4, MenuSoal5, MenuSoal6, MenuSoal7, MenuSoal8, MenuHasil;
    private int benarnya;
    // Start is called before the first frame update
    void Start()
    {
        MenuPetunjuk.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuSoal1.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal7.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal8.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuHasil.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    void Update()
    {
        if (benarnya == 0)
        {
            Nilai0.SetActive(true);
            Nilai1.SetActive(false);
            Nilai2.SetActive(false);
            Nilai3.SetActive(false);
            Nilai4.SetActive(false);
            Nilai5.SetActive(false);
            Nilai6.SetActive(false);
            Nilai7.SetActive(false);
            Nilai8.SetActive(false);
        }
        else if (benarnya == 1)
        {
            Nilai1.SetActive(true);
            Nilai0.SetActive(false);
            Nilai2.SetActive(false);
            Nilai3.SetActive(false);
            Nilai4.SetActive(false);
            Nilai5.SetActive(false);
            Nilai6.SetActive(false);
            Nilai7.SetActive(false);
            Nilai8.SetActive(false);
        }
        else if (benarnya == 2)
        {
            Nilai2.SetActive(true);
            Nilai1.SetActive(false);
            Nilai0.SetActive(false);
            Nilai3.SetActive(false);
            Nilai4.SetActive(false);
            Nilai5.SetActive(false);
            Nilai6.SetActive(false);
            Nilai7.SetActive(false);
            Nilai8.SetActive(false);
        }
        else if (benarnya == 3)
        {
            Nilai3.SetActive(true);
            Nilai1.SetActive(false);
            Nilai2.SetActive(false);
            Nilai0.SetActive(false);
            Nilai4.SetActive(false);
            Nilai5.SetActive(false);
            Nilai6.SetActive(false);
            Nilai7.SetActive(false);
            Nilai8.SetActive(false);
        }
        else if (benarnya == 4)
        {
            Nilai4.SetActive(true);
            Nilai1.SetActive(false);
            Nilai2.SetActive(false);
            Nilai3.SetActive(false);
            Nilai0.SetActive(false);
            Nilai5.SetActive(false);
            Nilai6.SetActive(false);
            Nilai7.SetActive(false);
            Nilai8.SetActive(false);
        }
        else if (benarnya == 5)
        {
            Nilai5.SetActive(true);
            Nilai1.SetActive(false);
            Nilai2.SetActive(false);
            Nilai3.SetActive(false);
            Nilai4.SetActive(false);
            Nilai0.SetActive(false);
            Nilai6.SetActive(false);
            Nilai7.SetActive(false);
            Nilai8.SetActive(false);
        }
        else if (benarnya == 6)
        {
            Nilai6.SetActive(true);
            Nilai1.SetActive(false);
            Nilai2.SetActive(false);
            Nilai3.SetActive(false);
            Nilai4.SetActive(false);
            Nilai5.SetActive(false);
            Nilai0.SetActive(false);
            Nilai7.SetActive(false);
            Nilai8.SetActive(false);
        }
        else if (benarnya == 7)
        {
            Nilai7.SetActive(true);
            Nilai1.SetActive(false);
            Nilai2.SetActive(false);
            Nilai3.SetActive(false);
            Nilai4.SetActive(false);
            Nilai5.SetActive(false);
            Nilai6.SetActive(false);
            Nilai0.SetActive(false);
            Nilai8.SetActive(false);
        }
        else
        {
            Nilai8.SetActive(true);
            Nilai1.SetActive(false);
            Nilai2.SetActive(false);
            Nilai3.SetActive(false);
            Nilai4.SetActive(false);
            Nilai5.SetActive(false);
            Nilai6.SetActive(false);
            Nilai7.SetActive(false);
            Nilai0.SetActive(false);
        }
    }
    public void ButtonSoal1()
    {
        MenuPetunjuk.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuSoal2.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal7.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal8.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuHasil.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void ButtonSoal2()
    {
        MenuPetunjuk.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuSoal3.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal7.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal8.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuHasil.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void ButtonSoal3()
    {
        MenuPetunjuk.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal2.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal3.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuSoal4.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal7.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal8.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuHasil.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void ButtonSoal4()
    {
        MenuPetunjuk.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal2.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal3.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal4.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuSoal5.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal7.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal8.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuHasil.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void ButtonSoal5()
    {
        MenuPetunjuk.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal2.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal3.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal4.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal5.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuSoal6.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal7.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal8.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuHasil.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void ButtonSoal6()
    {
        MenuPetunjuk.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal2.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal3.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal4.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal5.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal6.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuSoal7.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuSoal8.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuHasil.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void ButtonSoal7()
    {
        MenuPetunjuk.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal2.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal3.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal4.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal5.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal6.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal7.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuSoal8.DOAnchorPos(new Vector2(1500, 0), 1.0f);
        MenuHasil.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void ButtonSoal8()
    {
        MenuPetunjuk.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal2.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal3.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal4.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal5.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal6.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal7.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal8.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuHasil.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void ButtonHasil()
    {
        MenuPetunjuk.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal1.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal2.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal3.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal4.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal5.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal6.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal7.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuSoal8.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuHasil.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
    public void Benar()
    {
        benarnya = benarnya + 1;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public GameObject Background1, Background2;
    public RectTransform MenuButton, MenuOrangBawah, MenuKembali, MenuPetunjuk, MenuInformasi;
    // Start is called before the first frame update
    void Start()
    {
        Background1.SetActive(true);
        Background2.SetActive(false);
        MenuButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuOrangBawah.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, 1500), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(0, 1500), 1.0f);
        MenuKembali.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void MenuKembaliButton()
    {
        Background1.SetActive(true);
        Background2.SetActive(false);
        MenuButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuOrangBawah.DOAnchorPos(new Vector2(-1500, 0), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, 1500), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(0, 1500), 1.0f);
        MenuKembali.DOAnchorPos(new Vector2(1500, 0), 1.0f);
    }
    public void MenuPetunjukButton()
    {
        Background1.SetActive(false);
        Background2.SetActive(true);
        MenuButton.DOAnchorPos(new Vector2(0, -1500), 1.0f);
        MenuOrangBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(0, 1500), 1.0f);
        MenuKembali.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
    public void MenuInformasiButton()
    {
        Background1.SetActive(false);
        Background2.SetActive(true);
        MenuButton.DOAnchorPos(new Vector2(0, -1500), 1.0f);
        MenuOrangBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuPetunjuk.DOAnchorPos(new Vector2(0, 1500), 1.0f);
        MenuInformasi.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuKembali.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
}

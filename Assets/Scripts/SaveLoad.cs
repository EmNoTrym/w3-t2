using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class SaveLoad : MonoBehaviour
{
    public Slider soundSlider;
    public Slider musicSlider;
    public TMP_Dropdown graphicsDropdown;
    public TMP_Dropdown languageDropdown;

    public TMP_Text settingText;
    public TMP_Text soundText;
    public TMP_Text musicText;
    public TMP_Text graphicsText;
    public TMP_Text languageText;


    private void Start()
    {
        graphicsDropdown.value = PlayerPrefs.GetInt("graphicValue", 0);
        languageDropdown.value = PlayerPrefs.GetInt("languageValue", 0);

        soundSlider.value = PlayerPrefs.GetFloat("soundValue",50f);
        musicSlider.value = PlayerPrefs.GetFloat("musicValue",50f);

    }

    public void OnChangeValueSound()
    {
        PlayerPrefs.SetFloat("soundValue", soundSlider.value);
    }
    public void OnChangeValueMusic()
    {
        PlayerPrefs.SetFloat("musicValue", musicSlider.value);
    }
    public void OnChangeValueGraphic()
    {
        PlayerPrefs.SetInt("graphicValue", graphicsDropdown.value);
    }
    public void OnChangeValueLanguage()
    {
        PlayerPrefs.SetInt("languageValue", languageDropdown.value);
        Loadlanguage();
    }

    void Loadlanguage()
    {
        if(languageDropdown.value == 0)
        {
            settingText.text = "Settings";
            soundText.text = "Sound";
            musicText.text = "Music";
            graphicsText.text = "Graphics";
            languageText.text = "Language";
        }else if(languageDropdown.value == 1)
        {
            settingText.text = "Cài Đặt";
            soundText.text = "Âm Thanh";
            musicText.text = "Nhạc";
            graphicsText.text = "Đồ Họa";
            languageText.text = "Ngôn Ngữ";
        }
    }
    
}

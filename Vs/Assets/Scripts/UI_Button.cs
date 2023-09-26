using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections.Generic;

public class UI_Button : MonoBehaviour
{
	[SerializeField] Button rePlayBtn;

	
    public void RePlay()
	{
		Debug.Log("재시작");
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void Enabled()
	{
		Image[] imgs = GetComponentsInChildren<Image>();
		Button[] btns = GetComponentsInChildren<Button>();
		TextMeshProUGUI[] tmps = GetComponentsInChildren<TextMeshProUGUI>();

		foreach(Image img in imgs)
		{
			img.enabled = true;
		}

		foreach (Button btn in btns)
		{
			btn.enabled = true;
		}

		foreach (TextMeshProUGUI tmp in tmps)
		{
			tmp.enabled = true;
		}
	}

	public void UnEnabled()
	{
		Image[] imgs = GetComponentsInChildren<Image>();
		Button[] btns = GetComponentsInChildren<Button>();
		TextMeshProUGUI[] tmps = GetComponentsInChildren<TextMeshProUGUI>();

		foreach (Image img in imgs)
		{
			img.enabled = false;
		}

		foreach (Button btn in btns)
		{
			btn.enabled = false;
		}

		foreach (TextMeshProUGUI tmp in tmps)
		{
			tmp.enabled = false;
		}
	}

}

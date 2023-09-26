using UnityEngine;
using UnityEngine.UI;

public class UI_Player : MonoBehaviour
{
	[SerializeField] Slider hpSlider;


	public void ChangeHp(int value, int max)
	{
		hpSlider.value = (float)value/max;
	}
}

﻿
using UnityEngine;
using UnityEngine.UI;
namespace ET
{
	[ObjectSystem]
	public class DlgLoginViewComponentAwakeSystem : AwakeSystem<DlgLoginViewComponent> 
	{
		public override void Awake(DlgLoginViewComponent self)
		{
			self.uiTransform = self.GetParent<UIBaseWindow>().uiTransform;
		}
	}


	[ObjectSystem]
	public class DlgLoginViewComponentDestroySystem : DestroySystem<DlgLoginViewComponent> 
	{
		public override void Destroy(DlgLoginViewComponent self)
		{
			self.m_EButton_LoginBtnImage = null;
			self.m_EButton_LoginBtn = null;
			self.m_EInput_Account = null;
			self.m_EInput_Password = null;
			self.uiTransform = null;
		}
	}
}
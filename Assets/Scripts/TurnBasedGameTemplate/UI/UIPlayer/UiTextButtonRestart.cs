﻿using TurnBasedGameTemplate.Localization;
using TurnBasedGameTemplate.UI;

namespace TurnBasedGameTemplate.UI
{
    public class UiTextButtonRestart : UiText
    {
        protected override void Awake()
        {
            base.Awake();
            var restartText = Localization.Localization.Instance.Get(LocalizationIds.Restart);
            SetText($"{restartText}");
        }
    }
}
﻿using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.ADT.MiningShop;

[GenerateTypedNameReferences]
public sealed partial class MiningShopWindow : DefaultWindow
{
    public MiningShopWindow()
    {
        RobustXamlLoader.Load(this);
    }
}


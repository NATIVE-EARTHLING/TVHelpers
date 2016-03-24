//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************
using MediaAppSample.Core.ViewModels;

namespace MediaAppSample.UI.Controls
{
    public abstract class BusyPanelBase : ViewControlBase<ViewModelBase>
    {
    }

    public sealed partial class BusyPanel : BusyPanelBase
    {
        public BusyPanel()
        {
            this.InitializeComponent();
        }
    }
}

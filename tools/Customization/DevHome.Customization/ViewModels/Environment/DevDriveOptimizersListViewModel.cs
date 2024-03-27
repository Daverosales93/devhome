﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.WinUI.Collections;
using DevHome.Customization.ViewModels.Environments;

namespace DevHome.Customization.Models.Environments;

/// <summary>
/// The view model for the list of dev drives retrieved from a single dev drive provider.
/// </summary>
public partial class DevDriveOptimizersListViewModel : ObservableObject
{
    public ObservableCollection<DevDriveOptimizerCardViewModel> DevDriveOptimizerCardCollection { get; private set; } = new();

    public AdvancedCollectionView DevDriveOptimizerCardAdvancedCollectionView { get; private set; }

    public DevDriveOptimizersListViewModel()
    {
        // Create a new AdvancedCollectionView for the DevDriveCards collection.
        DevDriveOptimizerCardAdvancedCollectionView = new(DevDriveOptimizerCardCollection);
    }
}
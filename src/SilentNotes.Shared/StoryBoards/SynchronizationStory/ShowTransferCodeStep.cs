﻿// Copyright © 2018 Martin Stoeckli.
// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using SilentNotes.Controllers;
using SilentNotes.Services;

namespace SilentNotes.StoryBoards.SynchronizationStory
{
    /// <summary>
    /// This step belongs to the <see cref="SynchronizationStoryBoard"/>. It shows the dialog to
    /// enter the transfer code.
    /// </summary>
    public class ShowTransferCodeStep : StoryBoardStepBase
    {
        private readonly INavigationService _navigationService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShowTransferCodeStep"/> class.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1611:ElementParametersMustBeDocumented", Justification = "Dependency injection")]
        public ShowTransferCodeStep(int stepId, IStoryBoard storyBoard, INavigationService navigationService)
            : base(stepId, storyBoard)
        {
            _navigationService = navigationService;
        }

        /// <inheritdoc/>
        public override Task Run()
        {
            _navigationService.Navigate(ControllerNames.TransferCode);
            return GetCompletedDummyTask();
        }
    }
}
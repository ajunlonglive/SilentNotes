﻿// Copyright © 2018 Martin Stoeckli.
// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using System.Windows.Input;
using SilentNotes.Services;
using SilentNotes.StoryBoards.SynchronizationStory;
using SilentNotes.Workers;

namespace SilentNotes.ViewModels
{
    /// <summary>
    /// View model to ask the user for a new transfer code.
    /// </summary>
    public class TransferCodeViewModel : ViewModelBase
    {
        private readonly IStoryBoardService _storyBoardService;
        private readonly IFeedbackService _feedbackService;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferCodeViewModel"/> class.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1611:ElementParametersMustBeDocumented", Justification = "Dependency injection")]
        public TransferCodeViewModel(
            INavigationService navigationService,
            ILanguageService languageService,
            ISvgIconService svgIconService,
            IBaseUrlService webviewBaseUrl,
            IStoryBoardService storyBoardService,
            IFeedbackService feedbackService)
            : base(navigationService, languageService, svgIconService, webviewBaseUrl)
        {
            _storyBoardService = storyBoardService;
            _feedbackService = feedbackService;

            // Initialize commands
            OkCommand = new RelayCommand(Ok);
            GoBackCommand = new RelayCommand(GoBack);
            CancelCommand = new RelayCommand(Cancel);
        }

        /// <summary>
        /// Gets or sets the transfer code.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets the command to go back to the note overview.
        /// </summary>
        public ICommand OkCommand { get; private set; }

        private async void Ok()
        {
            bool codeIsValid = TransferCode.TrySanitizeUserInput(Code, out string sanitizedCode);
            if (codeIsValid)
            {
                _storyBoardService.ActiveStory?.StoreToSession(SynchronizationStorySessionKey.UserEnteredTransferCode.ToInt(), sanitizedCode);
                await (_storyBoardService.ActiveStory?.ContinueWith(SynchronizationStoryStepId.DecryptCloudRepository)
                    ?? Task.CompletedTask);
            }
            else
            {
                _feedbackService.ShowToast(Language["sync_error_transfercode"]);
            }
        }

        /// <summary>
        /// Gets the command to go back to the note overview.
        /// </summary>
        public ICommand GoBackCommand { get; private set; }

        private void GoBack()
        {
            Cancel();
        }

        /// <inheritdoc/>
        public override void OnGoBackPressed(out bool handled)
        {
            handled = true;
            GoBack();
        }

        /// <summary>
        /// Gets the command to go back to the note overview.
        /// </summary>
        public ICommand CancelCommand { get; private set; }

        private void Cancel()
        {
            _storyBoardService.ActiveStory?.ContinueWith(SynchronizationStoryStepId.StopAndShowRepository);
        }
    }
}

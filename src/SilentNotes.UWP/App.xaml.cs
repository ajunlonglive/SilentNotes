﻿// Copyright © 2018 Martin Stoeckli.
// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using System;
using SilentNotes.Services;
using SilentNotes.Services.CloudStorageServices;
using SilentNotes.StoryBoards.SynchronizationStory;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace SilentNotes.UWP
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public sealed partial class App : Application
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// This is the first line of authored code executed, and as such is the logical equivalent
        /// of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    // Load state from previously suspended application
                }

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }

            if (e.PrelaunchActivated == false)
            {
                if (rootFrame.Content == null)
                {
                    // When the navigation stack isn't restored navigate to the first page,
                    // configuring the new page by passing required information as a navigation
                    // parameter
                    rootFrame.Navigate(typeof(MainPage), e.Arguments);
                }

                // Ensure the current window is active
                Window.Current.Activate();
            }
        }

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        private void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();

            // Save application state and stop any background activity
            INavigationService navigationService = Ioc.GetOrCreate<INavigationService>();
            navigationService.CurrentController?.StoreUnsavedData();

            deferral.Complete();
        }

        /// <inheritdoc/>
        protected override void OnActivated(IActivatedEventArgs args)
        {
            TryHandleOauthRedirect(args);
        }

        /// <summary>
        /// OpenAuth2 requires the usage of an external browser, where the user can login to his
        /// service. Then the website will redirect to a given url, which can be intercepted by the
        /// application. Here we handle this intercepted url.
        /// </summary>
        /// <param name="args">The event arguments of <see cref="OnActivated(IActivatedEventArgs)"/>.</param>
        /// <returns>Returns true if the url is a redirect and has been handled, otherwise false.</returns>
        private bool TryHandleOauthRedirect(IActivatedEventArgs args)
        {
            if (args.Kind != ActivationKind.Protocol)
                return false;

            Uri redirectUri = (args as ProtocolActivatedEventArgs)?.Uri;
            string url = redirectUri?.AbsoluteUri;
            if (string.IsNullOrEmpty(url) || (!url.Contains("ch.martinstoeckli.silentnotes://oauth2redirect/")))
                return false;

            // Bring application back to front
            Window.Current.Activate();

            // Call the storage service
            IStoryBoardService storyBoardService = Ioc.GetOrCreate<IStoryBoardService>();
            IOauth2CloudStorageService oauthStorageService = storyBoardService.ActiveStory?.LoadFromSession<IOauth2CloudStorageService>(
                SynchronizationStorySessionKey.OauthCloudStorageService.ToInt());
            oauthStorageService?.HandleOauth2Redirect(redirectUri);

            return true;
        }
    }
}
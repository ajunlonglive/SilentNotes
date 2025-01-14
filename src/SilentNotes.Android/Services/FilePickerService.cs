﻿// Copyright © 2021 Martin Stoeckli.
// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using System;
using System.IO;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using AndroidX.DocumentFile.Provider;
using SilentNotes.Services;
using Uri = Android.Net.Uri;

namespace SilentNotes.Android.Services
{
    /// <summary>
    /// Implementation of the <see cref="IFilePickerService"/> interface for the Android platform.
    /// </summary>
    public class FilePickerService : IFilePickerService
    {
        private readonly Context _context;
        private readonly ActivityResultAwaiter _activityResultAwaiter;
        private Uri _pickedUri;

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderPickerService"/> class.
        /// </summary>
        /// <param name="activityResultAwaiter">Can start activities and get their result.</param>
        public FilePickerService(Context context, ActivityResultAwaiter activityResultAwaiter)
        {
            _context = context;
            _activityResultAwaiter = activityResultAwaiter;
        }

        /// <inheritdoc/>
        public async Task<bool> PickFile()
        {
            Intent filePickerIntent = new Intent(Intent.ActionOpenDocument);
            filePickerIntent.AddFlags(ActivityFlags.GrantReadUriPermission);
            filePickerIntent.AddCategory(Intent.CategoryOpenable);
            filePickerIntent.SetType("application/*");

            var activityResult = await _activityResultAwaiter.StartActivityAndWaitForResult(filePickerIntent);
            if (activityResult.ResultCode == Result.Ok)
            {
                _pickedUri = activityResult.Data?.Data;
                return true;
            }
            return false;
        }

        /// <inheritdoc/>
        public async Task<byte[]> ReadPickedFile()
        {
            if (_pickedUri == null)
                throw new Exception("Pick a file first before it can be read.");

            DocumentFile file = DocumentFile.FromSingleUri(_context, _pickedUri);
            using (Stream stream = _context.ContentResolver.OpenInputStream(file.Uri))
            {
                byte[] result = new byte[stream.Length];
                await stream.ReadAsync(result, 0, (int)stream.Length);
                return result;
            }
        }
    }
}
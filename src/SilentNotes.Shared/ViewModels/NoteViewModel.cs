﻿// Copyright © 2018 Martin Stoeckli.
// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Input;
using SilentNotes.Controllers;
using SilentNotes.Models;
using SilentNotes.Services;
using SilentNotes.Workers;

namespace SilentNotes.ViewModels
{
    /// <summary>
    /// View model to present a single note.
    /// </summary>
    public class NoteViewModel : ViewModelBase
    {
        private readonly IRepositoryStorageService _repositoryService;
        private SearchableHtmlConverter _searchableTextConverter;
        private string _searchableContent;

        /// <summary>
        /// Initializes a new instance of the <see cref="NoteViewModel"/> class.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1611:ElementParametersMustBeDocumented", Justification = "Dependency injection")]
        public NoteViewModel(
            INavigationService navigationService,
            ILanguageService languageService,
            ISvgIconService svgIconService,
            IBaseUrlService webviewBaseUrl,
            SearchableHtmlConverter searchableTextConverter,
            IRepositoryStorageService repositoryService,
            NoteModel noteFromRepository)
            : base(navigationService, languageService, svgIconService, webviewBaseUrl)
        {
            _repositoryService = repositoryService;
            _searchableTextConverter = searchableTextConverter;
            MarkSearchableContentAsDirty();
            BackgroundColor = "#c09e79";
            BackgroundTexture = "cork.jpg";
            GoBackCommand = new RelayCommand(GoBack);
            BackgroundColorsHex = new List<string> { "#fbf4c1", "#fdd8bb", "#facbc6", "#fcd5ef", "#d9d9fc", "#cee7fb", "#d0f8f9", "#d9f8c8" };

            Model = noteFromRepository;
        }

        /// <summary>
        /// Gets the unique id of the note.
        /// </summary>
        public Guid Id
        {
            get { return Model.Id; }
        }

        /// <summary>
        /// Gets a searchable representation of the <see cref="HtmlContent"/>. This searchable
        /// text is generated on demand only, to mark it as dirty use <see cref="MarkSearchableContentAsDirty"/>.
        /// </summary>
        public string SearchableContent
        {
            get
            {
                bool searchableContentIsDirty = _searchableContent == null;
                if (searchableContentIsDirty)
                {
                    SearchableHtmlConverter converter = LazyCreator.GetOrCreate(ref _searchableTextConverter);
                    converter.TryConvertHtml(HtmlContent, out _searchableContent);
                }
                return _searchableContent;
            }
        }

        /// <summary>
        /// Marks the <see cref="SearchableContent"/> as dirty, so it can be recreated the next
        /// time it is used.
        /// </summary>
        private void MarkSearchableContentAsDirty()
        {
            _searchableContent = null;
        }

        /// <summary>
        /// Gets or sets the Html content of the note.
        /// </summary>
        public string HtmlContent
        {
            get { return Model.HtmlContent; }

            set
            {
                if (value == null)
                    value = string.Empty;
                if (ChangePropertyIndirect(() => Model.HtmlContent, (string v) => Model.HtmlContent = v, value, true))
                {
                    MarkSearchableContentAsDirty();
                    Model.RefreshModifiedAt();
                }
            }
        }

        /// <summary>
        /// Gets or sets the background color as hex string, e.g. #ff0000
        /// </summary>
        public string BackgroundColorHex
        {
            get { return Model.BackgroundColorHex; }

            set
            {
                if (ChangePropertyIndirect(() => Model.BackgroundColorHex, (string v) => Model.BackgroundColorHex = v, value, true))
                    Model.RefreshModifiedAt();
            }
        }

        /// <summary>
        /// Gets a list of available background colors.
        /// </summary>
        public List<string> BackgroundColorsHex { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating whether the note is deleted and is part of the
        /// recycling bin.
        /// </summary>
        public bool InRecyclingBin
        {
            get { return Model.InRecyclingBin; }

            set
            {
                if (ChangePropertyIndirect(() => Model.InRecyclingBin, (bool v) => Model.InRecyclingBin = v, value, true))
                    Model.RefreshModifiedAt();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the note is a selected item.
        /// This can be used to implement multi selection lists.
        /// </summary>
        public bool IsSelected { get; set; }

        /// <inheritdoc />
        public override void OnStoringUnsavedData()
        {
            if (Modified)
            {
                Model.HtmlContent = XmlUtils.SanitizeXmlString(Model.HtmlContent);

                _repositoryService.LoadRepositoryOrDefault(out NoteRepositoryModel noteRepository);
                _repositoryService.TrySaveRepository(noteRepository);
                Modified = false;
            }
        }

        /// <summary>
        /// Gets the command to go back to the note overview.
        /// </summary>
        public ICommand GoBackCommand { get; private set; }

        /// <inheritdoc/>
        private void GoBack()
        {
            _navigationService.Navigate(ControllerNames.NoteRepository);
        }

        /// <inheritdoc/>
        public override void OnGoBackPressed(out bool handled)
        {
            handled = true;
            GoBack();
        }

        /// <summary>
        /// Gets the wrapped model.
        /// </summary>
        internal NoteModel Model { get; private set; }
    }
}
﻿/*
    Copyright (C) 2014-2016 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System.ComponentModel;
using System.Windows;
using dnSpy.Contracts.Text.Editor;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Adornments;
using Microsoft.VisualStudio.Text.Editor;

namespace dnSpy.Contracts.Language.Intellisense {
	/// <summary>
	/// An <see cref="IIntellisensePresenter"/> shown in a popup
	/// </summary>
	interface IPopupIntellisensePresenter : IIntellisensePresenter, INotifyPropertyChanged {
		/// <summary>
		/// Gets the popup element. Raise <see cref="INotifyPropertyChanged.PropertyChanged"/> when this
		/// property changes.
		/// </summary>
		UIElement SurfaceElement { get; }

		/// <summary>
		/// Gets the span. Raise <see cref="INotifyPropertyChanged.PropertyChanged"/> when this
		/// property changes.
		/// </summary>
		ITrackingSpan PresentationSpan { get; }

		/// <summary>
		/// Gets the popup styles. Raise <see cref="INotifyPropertyChanged.PropertyChanged"/> when this
		/// property changes.
		/// </summary>
		PopupStyles PopupStyles { get; }

		/// <summary>
		/// Gets the name of the <see cref="ISpaceReservationManager"/>, eg. <see cref="PredefinedSpaceReservationManagerNames.Completion"/>
		/// </summary>
		string SpaceReservationManagerName { get; }

		/// <summary>
		/// Gets/sets the opacity
		/// </summary>
		double Opacity { get; set; }
	}
}

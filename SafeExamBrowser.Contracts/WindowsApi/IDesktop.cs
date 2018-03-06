﻿/*
 * Copyright (c) 2018 ETH Zürich, Educational Development and Technology (LET)
 *
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

namespace SafeExamBrowser.Contracts.WindowsApi
{
	/// <summary>
	/// Defines the API to retrieve information about desktops and perform desktop-related operations.
	/// </summary>
	public interface IDesktop
	{
		/// <summary>
		/// Retrieves the name of the currently active desktop.
		/// </summary>
		string CurrentName { get; }
	}
}
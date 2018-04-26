﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.WindowsAzure.Build.Tasks.Utilities
{
    /// <summary>
    /// Constants used within the Build.Tasks library
    /// </summary>
    static class Constants
    {

        /// <summary>
        /// Constants, defaults used for Nuget Publish task
        /// </summary>
        public static class NugetDefaults
        {
            public const string NUGET_PATH = "nuget.exe";
            public const string NUGET_PUBLISH_URL = "https://www.nuget.org/api/v2/package/";
            public const string NUGET_SYMBOL_PUBLISH_URL = "https://nuget.smbsrc.net";
            public const int NUGET_TIMEOUT = 60; //Seconds
            public const string DEFAULT_API_KEY = "1234";
            public const string SDK_NUGET_APIKEY_ENV = "NetSdkNugetApiKey";
        }

        /// <summary>
        /// Constants used for various build stage tasks
        /// </summary>
        internal static class BuildStageConstant
        {
            public const string API_TAG_PROPERTYNAME = "AzureApiTag";
            public const string PROPS_FILE_NAME = "AzSdk.RP.props";
            public const string TYPENAMETOSEACH = "SdkInfo";
            public const string PROPERTYNAMEPREFIX = "ApiInfo_";
        }

        internal static class FrameworkMonikerConstant
        {
            // Switch to Attributes on enums for description
            public static string Net452 = "net452";
            public static string NetStd14 = "netstandard1.4";
        }
    }
}
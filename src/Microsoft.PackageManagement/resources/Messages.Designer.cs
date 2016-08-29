﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.PackageManagement.Internal.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.PackageManagement.Internal.Resources.Messages", typeof(Messages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Version {0} of the Package Provider {1} is already loaded. Since this is an assembly-based provider, we cannot load another version..
        /// </summary>
        public static string AssemblyPackageProviderAlreadyLoaded {
            get {
                return ResourceManager.GetString("AssemblyPackageProviderAlreadyLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to create specified folder &apos;{0}&apos;..
        /// </summary>
        public static string CreatefolderFailed {
            get {
                return ResourceManager.GetString("CreatefolderFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dependent Package &apos;{0}&apos; failed to install..
        /// </summary>
        public static string DependentPackageFailedInstall_dependency {
            get {
                return ResourceManager.GetString("DependentPackageFailedInstall_dependency", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Destination Path not set..
        /// </summary>
        public static string DestinationPathNotSet {
            get {
                return ResourceManager.GetString("DestinationPathNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provider &apos;{0}&apos; is ignored because the other provider with the same name has already been imported from path &apos;{1}&apos;..
        /// </summary>
        public static string DuplicatedProviderName {
            get {
                return ResourceManager.GetString("DuplicatedProviderName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PowerShell meta provider initialization failed..
        /// </summary>
        public static string FailedPowerShellMetaProvider {
            get {
                return ResourceManager.GetString("FailedPowerShellMetaProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to bootstrap provider &apos;{0}&apos;..
        /// </summary>
        public static string FailedProviderBootstrap {
            get {
                return ResourceManager.GetString("FailedProviderBootstrap", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to re-import the provider &apos;{0}&apos;..
        /// </summary>
        public static string FailToReImportProvider {
            get {
                return ResourceManager.GetString("FailToReImportProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File from &apos;{0}&apos; failed signature validation..
        /// </summary>
        public static string FileFailedVerification {
            get {
                return ResourceManager.GetString("FileFailedVerification", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified file &apos;{0}&apos; is not found..
        /// </summary>
        public static string FileNotFound {
            get {
                return ResourceManager.GetString("FileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The expected hash &apos;{0}&apos; is not equal to the computed hash &apos;{1}&apos; from the file to be installed..
        /// </summary>
        public static string HashNotEqual {
            get {
                return ResourceManager.GetString("HashNotEqual", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Importing package provider &apos;{0}&apos;..
        /// </summary>
        public static string ImportPackageProvider {
            get {
                return ResourceManager.GetString("ImportPackageProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Administrator rights are required to install packages in &apos;{0}&apos;. Log on to the computer with an account that has Administrator rights, and then try again, or install &apos;{1}&apos; by adding &quot;-Scope CurrentUser&quot; to your command. You can also try running the Windows PowerShell session with elevated rights (Run as Administrator)..
        /// </summary>
        public static string InstallRequiresCurrentUserScopeParameterForNonAdminUser {
            get {
                return ResourceManager.GetString("InstallRequiresCurrentUserScopeParameterForNonAdminUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The filename specified is not valid..
        /// </summary>
        public static string InvalidFilename {
            get {
                return ResourceManager.GetString("InvalidFilename", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified provider &apos;{0}&apos; was not loaded because no valid type was found. The supported file types are &apos;{1}&apos;..
        /// </summary>
        public static string InvalidFileType {
            get {
                return ResourceManager.GetString("InvalidFileType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The format of the specified hash &apos;{0}&apos; is invalid..
        /// </summary>
        public static string InvalidHashFormat {
            get {
                return ResourceManager.GetString("InvalidHashFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wildcards in the &apos;{0}&apos; is not supported. Please specify a full provider name..
        /// </summary>
        public static string InvalidParameter {
            get {
                return ResourceManager.GetString("InvalidParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to import the specified provider &apos;{0}&apos;. Please check if it is a valid PackageManagement provider..
        /// </summary>
        public static string InvalidProvider {
            get {
                return ResourceManager.GetString("InvalidProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified version range is invalid. Minimum Version:{0} MaximumVersion:{1}..
        /// </summary>
        public static string InvalidVersionRange {
            get {
                return ResourceManager.GetString("InvalidVersionRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loading an assembly &apos;{0}&apos;..
        /// </summary>
        public static string LoadingAssembly {
            get {
                return ResourceManager.GetString("LoadingAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loading a PowerShell module &apos;{0}&apos;..
        /// </summary>
        public static string LoadingPowerShellModule {
            get {
                return ResourceManager.GetString("LoadingPowerShellModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing File xml tag..
        /// </summary>
        public static string MissingFileTag {
            get {
                return ResourceManager.GetString("MissingFileTag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing the hash attribute within the File xml tag..
        /// </summary>
        public static string MissingHashAttribute {
            get {
                return ResourceManager.GetString("MissingHashAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of the hash xml attribute is empty..
        /// </summary>
        public static string MissingHashContent {
            get {
                return ResourceManager.GetString("MissingHashContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter &apos;{0}&apos; is required for this operation..
        /// </summary>
        public static string MissingRequiredParameter {
            get {
                return ResourceManager.GetString("MissingRequiredParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find package provider: {0}..
        /// </summary>
        public static string ModuleWithVersionNotFound {
            get {
                return ResourceManager.GetString("ModuleWithVersionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No match was found for the specified search criteria and provider name &apos;{0}&apos;. Try &apos;Get-PackageProvider -ListAvailable&apos; to see if the provider exists on the system..
        /// </summary>
        public static string NoMatchFoundForCriteria {
            get {
                return ResourceManager.GetString("NoMatchFoundForCriteria", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package &apos;{0}&apos; failed to install. Please look at &apos;{1}&apos; file for details..
        /// </summary>
        public static string PackageFailedInstallErrorLog {
            get {
                return ResourceManager.GetString("PackageFailedInstallErrorLog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package source &apos;{0}&apos; already exists with that provider..
        /// </summary>
        public static string PackageSourceExists {
            get {
                return ResourceManager.GetString("PackageSourceExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A protocol handler for scheme &apos;{0}&apos; is not available..
        /// </summary>
        public static string ProtocolNotSupported {
            get {
                return ResourceManager.GetString("ProtocolNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provider &apos;{0}&apos; has already been imported..
        /// </summary>
        public static string ProviderImportedAlready {
            get {
                return ResourceManager.GetString("ProviderImportedAlready", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified assembly &apos;{0}&apos; in \ProviderAssemblies, should be installed in ProviderAssemblies\ProviderName\Version. Either delete the provider assembly from \ProviderAssemblies, or create \ProviderAssemblies\ProvidernName\Version, and then move the assembly there..
        /// </summary>
        public static string ProviderNameAndVersionNotAvailableFromFilePath {
            get {
                return ResourceManager.GetString("ProviderNameAndVersionNotAvailableFromFilePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provider &apos;{0}&apos; is not respecting the responsiveness threshold in a timely fashion; Canceling request..
        /// </summary>
        public static string ProviderNotResponsive {
            get {
                return ResourceManager.GetString("ProviderNotResponsive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provider &apos;{0}&apos; failed to load..
        /// </summary>
        public static string ProviderPluginLoadFailure {
            get {
                return ResourceManager.GetString("ProviderPluginLoadFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provider {0} is successfully loaded..
        /// </summary>
        public static string ProviderSuccessfullyLoaded {
            get {
                return ResourceManager.GetString("ProviderSuccessfullyLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provider is loaded from path: &apos;{0}&apos;..
        /// </summary>
        public static string ProviderSuccessfullyLoadedFromLocation {
            get {
                return ResourceManager.GetString("ProviderSuccessfullyLoadedFromLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to download the list of available providers. Check your internet connection..
        /// </summary>
        public static string ProviderSwidtagUnavailable {
            get {
                return ResourceManager.GetString("ProviderSwidtagUnavailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;Provider &apos;{0}&apos; is not completing the request in the time allowed; Canceling request..
        /// </summary>
        public static string ProviderTimeoutExceeded {
            get {
                return ResourceManager.GetString("ProviderTimeoutExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provider &apos;{0}&apos; has already been imported. Trying to import it again..
        /// </summary>
        public static string ReImportProvider {
            get {
                return ResourceManager.GetString("ReImportProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removal of the environment variable &apos;{0}&apos; requires elevation..
        /// </summary>
        public static string RemoveEnvironmentVariableRequiresElevation {
            get {
                return ResourceManager.GetString("RemoveEnvironmentVariableRequiresElevation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A protocol handler for scheme &apos;{0}&apos; is not available..
        /// </summary>
        public static string SchemeNotSupported {
            get {
                return ResourceManager.GetString("SchemeNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple assemblies are found under path &apos;{0}&apos;. Please install a single provider assembly under each version folder..
        /// </summary>
        public static string SingleAssemblyAllowed {
            get {
                return ResourceManager.GetString("SingleAssemblyAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Skipping previously processed assembly: {0}..
        /// </summary>
        public static string SkippingProcessedAssembly {
            get {
                return ResourceManager.GetString("SkippingProcessedAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Skipping previously processed provider &apos;{0}&apos;..
        /// </summary>
        public static string SkipPreviousProcessedProvider {
            get {
                return ResourceManager.GetString("SkipPreviousProcessedProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source location &apos;{0}&apos; is not valid for this provider..
        /// </summary>
        public static string SourceLocationNotValid_Location {
            get {
                return ResourceManager.GetString("SourceLocationNotValid_Location", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Xml &apos;{0}&apos; is not a valid SoftwareIdentity swidtag. It needs to use &apos;{1}&apos; namespace..
        /// </summary>
        public static string SwidTagXmlInvalidNameSpace {
            get {
                return ResourceManager.GetString("SwidTagXmlInvalidNameSpace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The swidtag xml returned by the provider is not valid..
        /// </summary>
        public static string SwidTagXmlNotValid {
            get {
                return ResourceManager.GetString("SwidTagXmlNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to copy file to destination &apos;{0}&apos;..
        /// </summary>
        public static string UnableToCopyFileTo {
            get {
                return ResourceManager.GetString("UnableToCopyFileTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to create shortcut for file &apos;{0}&apos; because it does not exist..
        /// </summary>
        public static string UnableToCreateShortcutTargetDoesNotExist {
            get {
                return ResourceManager.GetString("UnableToCreateShortcutTargetDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to download from URI &apos;{0}&apos; to &apos;{1}&apos;..
        /// </summary>
        public static string UnableToDownload {
            get {
                return ResourceManager.GetString("UnableToDownload", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to import provider &apos;{0}&apos; under the current file path. The known provider search paths are &apos;{1}.&apos;.
        /// </summary>
        public static string UnableToImportProvider {
            get {
                return ResourceManager.GetString("UnableToImportProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package &apos;{0}&apos; failed to install..
        /// </summary>
        public static string UnableToInstallPackage_package_reason {
            get {
                return ResourceManager.GetString("UnableToInstallPackage_package_reason", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to overwrite existing file &apos;{0}&apos;..
        /// </summary>
        public static string UnableToOverwriteExistingFile {
            get {
                return ResourceManager.GetString("UnableToOverwriteExistingFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to remove existing file &apos;{0}&apos;..
        /// </summary>
        public static string UnableToRemoveFile {
            get {
                return ResourceManager.GetString("UnableToRemoveFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to resolve package dependency -- package &apos;{0}&apos; not found..
        /// </summary>
        public static string UnableToResolveDependency_dependencyPackage {
            get {
                return ResourceManager.GetString("UnableToResolveDependency_dependencyPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to resolve package reference &apos;{0}&apos;..
        /// </summary>
        public static string UnableToResolvePackage {
            get {
                return ResourceManager.GetString("UnableToResolvePackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to resolve package source &apos;{0}&apos;..
        /// </summary>
        public static string UnableToResolveSource_NameOrLocation {
            get {
                return ResourceManager.GetString("UnableToResolveSource_NameOrLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to uninstall package..
        /// </summary>
        public static string UnableToUninstallPackage {
            get {
                return ResourceManager.GetString("UnableToUninstallPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown Folder Id &apos;{0}&apos;..
        /// </summary>
        public static string UnknownFolderId {
            get {
                return ResourceManager.GetString("UnknownFolderId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find package provider &apos;{0}&apos;..
        /// </summary>
        public static string UnknownProvider {
            get {
                return ResourceManager.GetString("UnknownProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The archive file type is not supported..
        /// </summary>
        public static string UnsupportedArchive {
            get {
                return ResourceManager.GetString("UnsupportedArchive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified hash algorithm &apos;{0}&apos; is not supported. Please try using &apos;{1}&apos; instead..
        /// </summary>
        public static string UnsupportedHashAlgorithm {
            get {
                return ResourceManager.GetString("UnsupportedHashAlgorithm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provider type is not supported..
        /// </summary>
        public static string UnsupportedProviderType {
            get {
                return ResourceManager.GetString("UnsupportedProviderType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uri Scheme &apos;{0}&apos; is not supported..
        /// </summary>
        public static string UriSchemeNotSupported_Scheme {
            get {
                return ResourceManager.GetString("UriSchemeNotSupported_Scheme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User declined to install untrusted package &apos;{0}&apos;..
        /// </summary>
        public static string UserDeclinedUntrustedPackageInstall {
            get {
                return ResourceManager.GetString("UserDeclinedUntrustedPackageInstall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requiredVersion, minimumVersion or maximumVersion property applies to PowerShell modules. For the assembly providers, it is ignored..
        /// </summary>
        public static string VersionPropertyWillbeIgnored {
            get {
                return ResourceManager.GetString("VersionPropertyWillbeIgnored", resourceCulture);
            }
        }
    }
}
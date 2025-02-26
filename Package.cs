using System;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;

namespace Ony.SyntaxLume;

[PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
[Guid(PACKAGE_GUID_STRING)]
public sealed class Package : AsyncPackage
{
	public const string PACKAGE_GUID_STRING = "ECDF8BE8-168C-4BB8-AC21-A490326C6066";

	protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
	{
		await JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);
	}
}
#nullable enable
using Couchbase.Management.Analytics;
using Couchbase.Management.Collections;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Couchbase.KeyValue;
using Xunit.Abstractions;

namespace Couchbase.Test.Common.Utils
{
    /// <summary>
    /// Attempts to cleanup a resource at the end of a test, ignoring failures without failing the test.
    /// </summary>
    public class DisposeCleaner : IDisposable
    {
        private readonly Action _onDispose;
        private readonly ITestOutputHelper? _outputHelper;

        public DisposeCleaner(Action onDispose, ITestOutputHelper? outputHelper = null)
        {
            this._onDispose = onDispose ?? throw new ArgumentNullException(nameof(onDispose));
            this._outputHelper = outputHelper;
        }

        public void Dispose()
        {
            try
            {
                this._onDispose();
            }
            catch (Exception e)
            {
                this._outputHelper?.WriteLine(nameof(DisposeCleaner) + ": failure during cleanup: " + e.ToString());
            }
        }

        public static IAsyncDisposable DropScopeOnDispose(ICouchbaseCollectionManager collectionManager, string scopeName, ITestOutputHelper? outputHelper = null)
        {
            return new DisposeCleanerAsync(() => collectionManager.DropScopeAsync(scopeName), outputHelper);
        }

        public static IAsyncDisposable DropDataverseOnDispose(IAnalyticsIndexManager analyticsIndexManager, string dataverseName, ITestOutputHelper? outputHelper = null)
        {
            return new DisposeCleanerAsync(() => analyticsIndexManager.DropDataverseAsync(dataverseName), outputHelper);
        }

        public static IAsyncDisposable RemoveDocument(ICouchbaseCollection collection, string docId,
            ITestOutputHelper outputHelper)
        {
            return new DisposeCleanerAsync(() => collection.RemoveAsync(docId), outputHelper);
        }
    }

    /// <summary>
    /// Attempts to cleanup a resource at the end of a test, ignoring failures without failing the test.
    /// </summary>
    public class DisposeCleanerAsync : IAsyncDisposable
    {
        private readonly Func<Task> onDispose;
        private readonly ITestOutputHelper? outputHelper;

        public DisposeCleanerAsync(Func<Task> onDispose, ITestOutputHelper? outputHelper = null)
        {
            this.onDispose = onDispose ?? throw new ArgumentNullException(nameof(onDispose));
            this.outputHelper = outputHelper;
        }

        public async ValueTask DisposeAsync()
        {
            try
            {
                await onDispose();
            }
            catch (Exception e)
            {
                this.outputHelper?.WriteLine(nameof(DisposeCleanerAsync) + ": failure during cleanup: " + e.ToString());
            }
        }
    }
}
